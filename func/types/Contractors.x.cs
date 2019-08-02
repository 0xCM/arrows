//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using static As;

    using static zfunc;

    

    /// <summary>
    /// Implements Leimire's algorithm for sampling a uniformly distribute random number
    /// in an interval [0,..,max)
    /// </summary>
    /// <param name="random">A random source</param>
    /// <param name="max">The upper bound for the sample</param>
    /// <remarks>Reference: Fast Random Integer Generation in an Interval, Daniel Lemire 2018</remarks>
    /// <remarks>Reference: https://github.com/lemire/fastrange</reference>
    public static class Contractors
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
            => src.MulHi(max); 

        [MethodImpl(Inline)]
        public static T Contract<T>(T src, T max)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(uint8(src).Contract(uint8(max)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(uint16(src).Contract(uint16(max)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src).Contract(uint32(max)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src).Contract(uint64(max)));
            else
                throw unsupported<T>();
        }

    }
}