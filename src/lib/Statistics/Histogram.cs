//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    using static zcore;

    public static class Histogram
    {
        public static Histogram<T> define<T>(T min, T max, T? binwidth = null)
            where T : struct
             => new Histogram<T>(min,max,binwidth);
    }
    
    public class Histogram<T> : Traits.Formattable
    {
        
        public Histogram(real<T> min, real<T> max, real<T>? binwidth = null)
        {
            this.range = Interval.leftclosed(min,max);
            this.binwidth = binwidth ?? (max - min)/real(convert<T>(20));
            this.points =  new SortedSet<real<T>>(Interval.partition(range, this.binwidth));
            this.bins = map(points, point => (point, real<T>.Zero)).ToDictionary();
        }


        Dictionary<real<T>,real<T>> bins {get;}
        
        SortedSet<real<T>> points {get;}

        public Interval<real<T>> range;

        public T binwidth {get;}

        public void distribute(IEnumerable<real<T>> values)
        {
            var lower = range.left;
            var last = points.Last();
            foreach(var value in values)
            {
                foreach(var point in points)                
                {
                    if(value >= lower && value < point)
                    {
                        bins[point] = ++bins[point];
                        break;
                    }
                    lower = point;
                }
            }
        }

        public IEnumerable<(Interval<T> bin, real<double> ratio)> ratios()
        {
            var count = real(points.Count);
            var current = points.First();            
            foreach(var next in points.Skip(1))
            {                
                var ratio = next.convert<double>()/real<double>(count);
                var interval = Interval.leftclosed<T>(current, next).canonical(); 
                yield return (interval, ratio);

                current = next;
            }
        }

        public string format()
            => eol(map(tuples(bins), t => t.Format()));

        public override string ToString()
            => format();                       

    }

}