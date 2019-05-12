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

    using static zfunc;
    using static mfunc;
    
    public static class Divisors
    {
        [MethodImpl(Inline)]
        public static T[] Compute<T>(T src)
            where T : struct, IEquatable<T>
                => Divisors<T>.Inhabitant.divisors(src);

        [MethodImpl(Inline)]
        public static DivisorIndex<T> Compute<T>(Interval<T> interval)
            where T : struct, IEquatable<T>
                => Divisors<T>.Inhabitant.Compute(interval);

        [MethodImpl(Inline)]
        public static IEnumerable<DivisorIndex<T>> Compute<T>(Interval<T> interval, T step)        
            where T : struct, IEquatable<T>
                => Divisors<T>.Inhabitant.Compute(interval,step);

        public static ulong[] Compute(ulong src)
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
            return result.ToArray();
        }

        public static uint[] Compute(uint src)
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
            return result.ToArray();
        }
    }

    public readonly struct Divisors<T> 
        where T : struct, IEquatable<T>
    {
        public static readonly Divisors<T> Inhabitant = default;
            
        static readonly T Zero = gmath.zero<T>();

        static readonly T One = gmath.one<T>();

        [MethodImpl(Inline)]
        public T[] divisors(T src)
            => Divisors.Compute(src);
    
        /// <summary>
        /// Computes the divisors for each number in a specified interval
        /// </summary>
        /// <param name="min">The minimum dividend</param>
        /// <param name="max">The maximum dividend</param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        public DivisorIndex<T> Compute(Interval<T> interval)
        {
            var results = from n in Range(interval).AsParallel()
                        let d = Divisors.Compute(n)
                        select DivisorList.Define(n, d);

            return DivisorIndex.define(interval, results.ToList());
        }

        /// <summary>
        /// Computes a divisor index stream
        /// </summary>
        /// <param name="step"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <typeparam name="T"></typeparam>
        public IEnumerable<DivisorIndex<T>> Compute(Interval<T> interval, T step)
        {
            var min = interval.leftclosed ? interval.left : gmath.inc(interval.left);
            var max = interval.rightclosed ? interval.right : gmath.dec(interval.right);
            for(var i=min; gmath.lt(i,max); i = gmath.add(i, step))
            {
                var divMin = gmath.add(i, One);
                var divMax = gmath.add(i, step);
                var next = Interval.closed(divMin, divMax);
                yield return Compute(next);
            }
        }

        [MethodImpl(Inline)]
        public IEnumerable<T> Range(Interval<T> src)
        {
            var first = src.leftclosed ? src.left : gmath.inc(src.left);
            var last = src.rightclosed ? src.right : gmath.dec(src.right);
            return Range(first,last);
        }

        [MethodImpl(Inline)]
        public IEnumerable<T> Range(T first, T last)
        {
            var current = first;
            if(gmath.lt(first, last))
            {
                while(gmath.lteq(current, last))
                {
                    yield return current;
                    current = gmath.inc(current);
                }                
            }
            else
            {
                while(gmath.gteq(current, last))
                {
                    yield return current;
                    current = gmath.dec(current);
                    
                }
            }
        }        
    } 
}