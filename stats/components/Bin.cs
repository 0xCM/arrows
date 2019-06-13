//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Threading;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    
    using static zfunc;

    public static class Bin
    {
        public static Bin<T> Define<T>(Interval<T> domain, int count)
            where T : struct
            => new Bin<T>(domain,count);
    }

    /// <summary>
    /// Represents an occurrence of a value with an interval
    /// </summary>
    /// <typeparam name="T">The value domain</typeparam>
    public class Bin<T>
        where T : struct
    {
        public static Bin<T> operator ++(Bin<T> src)
            => src;

        public Bin(in Interval<T> Domain, int Count = 0)
        {
            this.Domain = Domain;
            this.Counter = (int)Count;
        }

        int Counter;

        public Interval<T> Domain {get;}

        public int Count 
        {
            get => Counter;
        }

        public string Format()
            => $"{Domain}: {Count}";

        public void Increment()
            => Interlocked.Increment(ref Counter);

        public override string ToString()
            => Format();
    }

    public static class BinX
    {
        public static ulong TotalCount<T>(this ReadOnlySpan<Bin<T>> bins)
            where T : struct
        {
            var sum = 0ul;
            for(var i=0; i<bins.Length; i++)
                sum += (uint)bins[i].Count;
            return sum;
        }
    }
}