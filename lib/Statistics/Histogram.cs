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
        public static Histogram<T> define<T>(T min, T max, T binwidth)
            where T : struct, IEquatable<T>
             => new Histogram<T>(min,max,binwidth);
    }
    
    public class Histogram<T> : Formattable
        where T : struct, IEquatable<T>
    {
        
        public Histogram(floatg<T> min, floatg<T> max, floatg<T> bincount)
        {
            this.range = Interval.leftclosed(min,max);
            this.binwidth = bincount;
            this.points =  new SortedSet<floatg<T>>(Interval.partition(range, bincount));
            this.bins = map(points, point => (point, floatg<T>.Zero)).ToDictionary();
        }


        Dictionary<floatg<T>,floatg<T>> bins {get;}
        
        SortedSet<floatg<T>> points {get;}

        public Interval<floatg<T>> range;

        public T binwidth {get;}

        public void distribute(IEnumerable<floatg<T>> values)
        {
            var lower = range.left;
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

        public IEnumerable<(Interval<floatg<T>> bin, floatg<T> ratio)> ratios()
        {
            var count = Z0.floatg<T>.Zero;
            foreach(var bin in bins)
                count += bin.Value;

            foreach(var bin in bins)
            {
                var interval = Interval.leftclosed(bin.Key.sub(binwidth), bin.Key).canonical();
                var ratio = bin.Value / count;
                yield return (interval,ratio);                
            }                
        }

        public string format()
            => eol(map(tuples(bins), t => t.Format()));

        public override string ToString()
            => format();                       
    }
}