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
        

    public readonly struct Divisors<T> 
        where T : struct
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
                        select Divisors.DefineList(n, d);

            return Divisors.DefineIndex(interval, results.ToList());
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
            var min = interval.LeftClosed ? interval.Left : gmath.inc(interval.Left);
            var max = interval.RightClosed ? interval.Right : gmath.dec(interval.Right);
            for(var i=min; gmath.lt(i,max); i = gmath.add(i, step))
            {
                var divMin = gmath.add(i, One);
                var divMax = gmath.add(i, step);
                var next = closed(divMin, divMax);
                yield return Compute(next);
            }
        }

        [MethodImpl(Inline)]
        public IEnumerable<T> Range(Interval<T> src)
        {
            var first = src.LeftClosed ? src.Left : gmath.inc(src.Left);
            var last = src.RightClosed ? src.Right : gmath.dec(src.Right);
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