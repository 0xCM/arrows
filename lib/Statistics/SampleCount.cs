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

    public static class SampleCount
    {
        public static SampleCount<T> define<T>(Interval<T> domain, int count)
            where T : struct, IEquatable<T>
            => new SampleCount<T>(domain,count);

        public static Func<Interval<T>,int, SampleCount<T>> factory<T>()
            where T : struct, IEquatable<T> => define;        
    }


    /// <summary>
    /// Represents an occurrence of a value with an interval
    /// </summary>
    /// <typeparam name="T">The value domain</typeparam>
    public class SampleCount<T>
        where T : struct, IEquatable<T>
    {
        public SampleCount(Interval<T> Domain, int Count)
        {
            this.Domain = Domain;
            this.Count = Count;
        }

        public Interval<T> Domain {get;}

        public int Count {get;}

        public override string ToString()
            => $"{Domain}: {Count}";
    }


    public static class SampleCountX
    {
        public static ulong TotalCount<T>(this IEnumerable<SampleCount<T>> counts)
            where T : struct, IEquatable<T>
        {
            var sum = 0ul;
            iter(counts, c => sum += (ulong)c.Count);
            return sum;
        }
    }


}