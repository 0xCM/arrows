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

    public static class SampleCount
    {
        public static SampleCount<T> define<T>(Interval<T> domain, ulong count)
            where T : struct
            => new SampleCount<T>(domain,count);

        public static Func<Interval<T>, ulong, SampleCount<T>> factory<T>()
            where T : struct => define;        
    }

    /// <summary>
    /// Represents an occurrence of a value with an interval
    /// </summary>
    /// <typeparam name="T">The value domain</typeparam>
    public class SampleCount<T>
        where T : struct
    {
        public SampleCount(Interval<T> Domain, ulong Count)
        {
            this.Domain = Domain;
            this.Count = Count;
        }

        public Interval<T> Domain {get;}

        public ulong Count {get;}

        public override string ToString()
            => $"{Domain}: {Count}";
    }

    public static class SampleCountX
    {
        public static ulong TotalCount<T>(this ReadOnlySpan<SampleCount<T>> counts)
            where T : struct
        {
            var sum = 0ul;
            for(var i=0; i<counts.Length; i++)
                sum += counts[i].Count;
            return sum;
        }
    }
}