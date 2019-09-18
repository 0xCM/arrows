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

    public static class Divisors
    {
        /// <summary>
        /// Constructs a divisor list
        /// </summary>
        /// <param name="dividend">The dividend</param>
        /// <param name="divisors">The values that divide the dividend</param>
        /// <typeparam name="T">The numeric type</typeparam>
        public static DivisorList<T> DefineList<T>(T dividend, T[] divisors)
            where T : struct
                => new DivisorList<T>(dividend, divisors);

        public static DivisorList<T> DefineList<T>(T dividend, IReadOnlyList<T> divisors)
            where T : struct
                => new DivisorList<T>(dividend, divisors);


        [MethodImpl(Inline)]
        public static DivisorIndex<T> DefineIndex<T>(Interval<T> range, IReadOnlyList<DivisorList<T>> lists)
            where T : struct
                => new DivisorIndex<T>(range, lists);

        [MethodImpl(Inline)]
        public static T[] Compute<T>(T src)
            where T : struct
                => Divisors<T>.Inhabitant.divisors(src);

        [MethodImpl(Inline)]
        public static DivisorIndex<T> Compute<T>(Interval<T> interval)
            where T : struct
                => Divisors<T>.Inhabitant.Compute(interval);

        [MethodImpl(Inline)]
        public static IEnumerable<DivisorIndex<T>> Compute<T>(Interval<T> interval, T step)        
            where T : struct
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



}