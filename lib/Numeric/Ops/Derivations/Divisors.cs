//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using static zcore;
    using static primops;
    using static Operative;

    partial class Operative
    {
        public interface Divisors<T>
            where T : struct, IEquatable<T>
        {
            Index<T> divisors(T src);
        }
    }

    public static partial class algorithms
    {
        [MethodImpl(Inline)]
        public static Index<T> divisors<T>(T src)
            where T : struct, IEquatable<T>
                => DivisorOps<T>.Inhabitant.divisors(src);
        
        [MethodImpl(Inline)]
        public static IEnumerable<T> range<T>(Interval<T> src)        
            where T : struct, IEquatable<T>
                => DivisorOps<T>.Inhabitant.range(src);

        [MethodImpl(Inline)]
        public static IEnumerable<T> range<T>(T first, T last)
            where T : struct, IEquatable<T>
                => DivisorOps<T>.Inhabitant.range(first,last);

        [MethodImpl(Inline)]
        public static DivisorIndex<T> divisors<T>(Interval<T> interval)
            where T : struct, IEquatable<T>
                => DivisorOps<T>.Inhabitant.divisors(interval);

        [MethodImpl(Inline)]
        public static IEnumerable<DivisorIndex<T>> divisors<T>(Interval<T> interval, T step)        
            where T : struct, IEquatable<T>
                => DivisorOps<T>.Inhabitant.divisors(interval,step);
    }

    public readonly struct DivisorOps<T> : Operative.Divisors<T>
        where T : struct, IEquatable<T>
    {
        public static readonly DivisorOps<T> Inhabitant = default;

        static readonly Operative.Divisors<T> AlgOps = Reify.Divisors.Operator<T>();
        
        static readonly Operative.PrimOps<T> PrimOps = primops.typeops<T>();
        
        static readonly T Zero = PrimOps.zero;

        static readonly T One = PrimOps.one;


        [MethodImpl(Inline)]
        public Index<T> divisors(T src)
            => AlgOps.divisors(src);
    
        /// <summary>
        /// Computes the divisors for each number in a specified interval
        /// </summary>
        /// <param name="min">The minimum dividend</param>
        /// <param name="max">The maximum dividend</param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        public DivisorIndex<T> divisors(Interval<T> interval)
        {
            var results = from n in range(interval).AsParallel()
                        let d = AlgOps.divisors(n)
                        select DivisorList.define(n, d);

            return DivisorIndex.define(interval, results.ToList());
        }

        /// <summary>
        /// Computes a divisor index stream
        /// </summary>
        /// <param name="step"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <typeparam name="T"></typeparam>
        public IEnumerable<DivisorIndex<T>> divisors(Interval<T> interval, T step)
        {
            var min = interval.leftclosed ? interval.left : PrimOps.inc(interval.left);
            var max = interval.rightclosed ? interval.right : PrimOps.dec(interval.right);
            for(var i=min; PrimOps.lt(i,max); i = PrimOps.add(i, step))
            {
                var divMin = PrimOps.add(i, One);
                var divMax = PrimOps.add(i, step);
                var next = Interval.closed(divMin, divMax);
                yield return divisors(next);
            }
        }

        [MethodImpl(Inline)]
        public IEnumerable<T> range(Interval<T> src)
        {
            var first = src.leftclosed ? src.left : PrimOps.inc(src.left);
            var last = src.rightclosed ? src.right : PrimOps.dec(src.right);
            return range(first,last);
        }

        [MethodImpl(Inline)]
        public IEnumerable<T> range(T first, T last)
        {
            var current = first;
            if(PrimOps.lt(first, last))
            {
                while(PrimOps.lteq(current, last))
                {
                    yield return current;
                    current = PrimOps.inc(current);
                }                
            }
            else
            {
                while(gteq(current, last))
                {
                    yield return current;
                    current = PrimOps.dec(current);
                    
                }
            }
        }        
    }

    partial class Reify
    {
        public class Divisors : 
            Divisors<ulong>,
            Divisors<uint>
        {
            static readonly Divisors Inhabitant = new Divisors();

            [MethodImpl(Inline)]
            public static Divisors<T> Operator<T>() 
                where T : struct, IEquatable<T>
                    => cast<Divisors<T>>(Inhabitant);


            public Index<ulong> divisors(ulong src)
            {
                var result = new List<ulong>();
                
                if(src != 0UL &&  src != 1UL)
                {
                    var upper = src/2UL + 1UL;
                    var current = 2UL;

                    while(current < upper)
                    {
                        if(src % current == 0UL)
                            result.Add(current);

                        current = ++current;
                    }
                }    
                return result;
            }

            public Index<uint> divisors(uint src)
            {
                var result = new List<uint>();
                
                if(src != 0u &&  src != 1u)
                {
                    var upper = src/2u + 1u;
                    var current = 2u;

                    while(current < upper)
                    {
                        if(src % current == 0u)
                            result.Add(current);

                        current = ++current;
                    }
                }    
                return result;
            }
        }
    }
}