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

    public class Histogram
    {
        public static Histogram<T> define<T>(Interval<T> domain, T grain)            
            where T : struct, IEquatable<T>
                => new Histogram<T>(domain,grain);

        public static Func<Interval<T>,T, Histogram<T>> factory<T>()
            where T : struct, IEquatable<T> => define;        

    }


    public class Histogram<T>
        where T : struct, IEquatable<T>
    {
        public Histogram(Interval<T> Domain, T Grain)
        {
            this.Domain =Domain;
            this.Grain = Grain;
            this.Partitions = Domain.canonical().Discretize(Grain);
            this.Counts = alloc<int>(Partitions.Count);
        }

        public Interval<T> Domain {get;}
        
        public T Grain {get;}

        public Index<T> Partitions {get;}

        int[] Counts {get;}

        int BucketSize(int ix)
            => Counts[ix-1];
        
        Interval<T> PartitionDomain(int ix)
            => ix == Partitions.Length - 1 
             ? Interval.closed(Partitions[ix-1], Partitions[ix]).canonical() 
             : Interval.leftclosed(Partitions[ix-1], Partitions[ix]).canonical();
                    
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
                    Counts[i-1] = primops.inc(Counts[i-1]);
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
            return -1;
        }

        /// <summary>
        /// Distribute an index of values to the histogram
        /// </summary>
        /// <param name="value">The source value</param>
        public void Deposit(IEnumerable<T> src)
        {
            var indices = src.AsParallel().Select(FindBucketIndex).GroupBy(x => x).ToList();            
            foreach(var i in indices)
                Counts[i.Key - 1] = Counts[i.Key - 1] + i.Count();
        }
        
        /// <summary>
        /// Describes the current state of the histogram
        /// </summary>
        /// 
        public Index<SampleCount<T>> Buckets()            
        {
            var buckets = alloc<SampleCount<T>>(Partitions.Length - 1);
            for(var i = 1; i< Partitions.Length; i++)
                buckets[i-1] = SampleCount.define(PartitionDomain(i), BucketSize(i));
            return buckets;
        }
        

    }

}