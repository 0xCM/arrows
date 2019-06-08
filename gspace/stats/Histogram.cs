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

    using static zfunc;

    public class Histogram
    {
        public static Histogram<T> define<T>(Interval<T> domain, T? grain = null)            
            where T : struct
        {
            var width = gmath.sub(domain.Right, domain.Left);
            var histo = new Histogram<T>(domain, 
                grain ?? gmath.div(width, convert<T>(100)));
            return histo;
        }
    }

    public class Histogram<T>
        where T : struct
    {
        public Histogram(Interval<T> Domain, T BinWidth)
        {
            this.Domain = Domain;
            this.BinWidth = BinWidth;
            this.Partitions = Domain.Discretize(BinWidth).ToArray();
            this.Counts = alloc<ulong>(Partitions.Length);
        }

        public Interval<T> Domain {get;}
        
        public T BinWidth {get;}

        public T[] Partitions {get;}

        ulong[] Counts {get;}

        ulong BucketSize(int ix)
            => Counts[ix-1];
        
        Interval<T> PartitionDomain(int ix)
            => ix == Partitions.Length - 1 
             ? closed(Partitions[ix-1], Partitions[ix]) 
             : leftclosed(Partitions[ix-1], Partitions[ix]);

        /// <summary>
        /// Distribute a single value to the histogram
        /// </summary>
        /// <param name="value">The source value</param>
        public void Deposit(T value)
        {
            var deposited = false;
            for(int i = 1; i< Partitions.Length; i++)                    
            {
                
                if(PartitionDomain(i).Contains(value))
                {
                    Counts[i-1] = gmath.inc(Counts[i-1]);
                    deposited = true;
                    break;
                }                
            }
            
            if(!deposited)
                throw new Exception($"No bucket found for the value {value} since the histogram domain is {Domain}");
        }

        int FindBucketIndex(T value)
        {
            for(int i = 1; i< Partitions.Length; i++)                    
                if(PartitionDomain(i).Contains(value))
                    return i;
            throw new Exception($"No bucket found for the value {value} since the histogram domain is {Domain}");
        }

        /// <summary>
        /// Distribute an index of values to the histogram
        /// </summary>
        /// <param name="value">The source value</param>
        public void Deposit(IEnumerable<T> src, bool pll = true)
        {
            var indices = pll 
                ? src.AsParallel().Select(FindBucketIndex).GroupBy(x => x).Freeze() 
                : src.Select(FindBucketIndex).GroupBy(x => x).Freeze(); 

            foreach(var i in indices)
                Counts[i.Key - 1] = Counts[i.Key - 1] + (ulong)i.Count();
        }
        
        /// <summary>
        /// Describes the current state of the histogram
        /// </summary>
        /// 
        public Span<SampleCount<T>> Buckets()            
        {
            var buckets = alloc<SampleCount<T>>(Partitions.Length - 1);
            for(var i = 1; i< Partitions.Length; i++)
                buckets[i-1] = SampleCount.define(PartitionDomain(i), BucketSize(i));
            return buckets;
        }    

            
    }
}