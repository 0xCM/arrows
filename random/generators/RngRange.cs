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

    /// <summary>
    /// Implements Leimire's algorithm for sampling a uniformly distribute random number
    /// in an interval [0,..,max)
    /// </summary>
    /// <param name="random">A random source</param>
    /// <param name="max">The upper bound for the sample</param>
    /// <remarks>Reference: Fast Random Integer Generation in an Interval, Daniel Lemire 2018</remarks>
    /// <remarks>Reference: https://github.com/lemire/fastrange</reference>
    public static class RngRange
    {
        /// <summary>
        /// Evenly projects points from the interval [0,2^8 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        public static byte Contract(this byte src, byte max)
            => (byte)(((ushort)src * (ushort)max) >> 8);

        /// <summary>
        /// Evenly projects points from the interval [0,2^15 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        public static ushort Contract(this ushort src, ushort max)
            => (ushort)(((uint)src * (uint)max) >> 16);

        /// <summary>
        /// Evenly projects points from the interval [0,2^31 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        public static uint Contract(this uint src, uint max)
            => (uint)(((ulong)src * (ulong)max) >> 32);

        /// <summary>
        /// Evenly projects points from the interval [0,2^63 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        public static ulong Contract(this ulong src, ulong max)
            => src.UMulHi(max); 
        
        /// <summary>
        /// Implements Leimire's algorithm for sampling a uniformly distribute random number
        /// in an interval [0,..,max)
        /// </summary>
        /// <param name="random">A random source</param>
        /// <param name="max">The upper bound for the sample</param>
        /// <remarks>Reference: Fast Random Integer Generation in an Interval, Daniel Lemire 2018</remarks>
        [MethodImpl(Inline)]
        internal static ulong NextUInt64(this IRandomSource<ulong> random, ulong max) 
        {
            return random.Next().Contract(max);
            // var m = random.Next().UMul128(max);
            // var l = m.lo;
            // if (l < max) 
            // {
            //     var t = math.negate(max) % max;
            //     while (l < t) 
            //     {
            //         m = random.Next().UMul128(max);
            //         l = m.lo;                    
            //     }
            // }
            // return m.ShiftRW(8).lo;        
        }

        /// <summary>
        /// Effects a component-wise contraction on the source vector, dst[i] = src[i].Contract(max[i])
        /// </summary>
        /// <param name="src">The vector to contract</param>
        /// <param name="max">The upper bound</param>
        /// <typeparam name="N"></typeparam>
         public static Vector<N,ulong> Contract<N>(this Vector<N,ulong> src, Vector<N,ulong> max)
            where N : ITypeNat, new()
        {
            var dst = NatSpan.alloc<N,ulong>();
            for(var i=0; i<dst.Length; i++)
                dst[i] = src[i].Contract(max[i]);
            return dst;
        }
       
        /// <summary>
        /// Generates a psedorandom int in the interval [0, max) if max >= 0
        /// </summary>
        /// <param name="random">The stateful source on which the generation is predicated</param>
        /// <param name="max">The exclusive maximum</param>
        [MethodImpl(Inline)]
        internal static int NextInt32(this IRandomSource<ulong> random, int max)
            => max >= 0 ? (int)random.NextUInt64((ulong)max) 
                : - (int)random.NextUInt64((ulong) (Int32.MaxValue + max));        

    }
}