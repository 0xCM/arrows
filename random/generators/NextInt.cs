//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Text;

    using static zfunc;
    using static As;

    static class NextIntX
    {
        /// <summary>
        /// Implements Leimire's algorithm for sampling a uniformly distribute random number
        /// in an interval [0,..,max)
        /// </summary>
        /// <param name="rng">A random source</param>
        /// <param name="max">The upper bound for the sample</param>
        /// <remarks>Reference: Fast Random Integer Generation in an Interval, Daniel Lemire 2018</remarks>
        public static ulong NextU64(this IRandomSource rng, ulong max) 
        {
            var x = rng.NextInt();
            dinx.umul128(x, max, out UInt128 m);
            ulong l = m.lo;
            if (l < max) 
            {
                ulong t = ~max % max;
                while (l < t) 
                {
                    x = rng.NextInt();
                    m = dinx.umul128(x, max, out UInt128 z);
                    l = m.lo;                    
                }
            }
        
            var vec = dinx.shiftrw(m.ToVec128(), 8);
            return vec.ToUInt128().lo;
        }


        /// <summary>
        /// Generates a psedorandom int in the interval [0, max) if max >= 0
        /// </summary>
        /// <param name="rng">The stateful source on which the generation is predicated</param>
        /// <param name="max">The exclusive maximum</param>
        [MethodImpl(Inline)]
        public static int NextI32(this IRandomSource rng, int max)
            => max >= 0 
            ? (int)rng.NextInt((ulong)max)  
            : - (int)rng.NextInt((ulong) (Int32.MaxValue + max));        


    }
}