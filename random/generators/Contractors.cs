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
            => src.UMulHi(max); 

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

        /// <summary>
        /// Yields the next random value from the source that conforms to a specified upper bound
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="max">The exclusive upper bound</param>
        [MethodImpl(Inline)]
        public static byte Next(this IRandomSource<byte> src, byte max)
            => src.Next().Contract(max);

        /// <summary>
        /// Yields the next random value from the source that conforms to a specified upper bound
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="max">The exclusive upper bound</param>
        [MethodImpl(Inline)]
        public static ushort Next(this IRandomSource<ushort> src, ushort max)
            => src.Next().Contract(max);

        /// <summary>
        /// Yields the next random value from the source that conforms to a specified upper bound
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="max">The exclusive upper bound</param>
        [MethodImpl(Inline)]
        public static uint Next(this IRandomSource<uint> src, uint max)
            => src.Next().Contract(max);

        /// <summary>
        /// Yields the next random value from the source that conforms to a specified upper bound
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="max">The exclusive upper bound</param>
        [MethodImpl(Inline)]
        public static ulong Next(this IRandomSource<ulong> src, ulong max) 
            => src.Next().Contract(max);

        /// <summary>
        /// Yields the next random value from the source that conforms to a specified upper bound
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="max">The exclusive upper bound</param>
        [MethodImpl(Inline)]
        static ulong NextLegacy(this IRandomSource<ulong> src, ulong max) 
        {
            var m = src.Next().UMul128(max);
            var l = m.lo;
            if (l < max) 
            {
                var t = math.negate(max) % max;
                while (l < t) 
                {
                    m = src.Next().UMul128(max);
                    l = m.lo;                    
                }
            }
            return m.ShiftRW(8).lo;                 
        }
        
        /// <summary>
        /// Effects a component-wise contraction on the source vector on a source vector of unsigned primal type, 
        /// dst[i] = src[i].Contract(max[i])
        /// </summary>
        /// <param name="src">The vector to contract</param>
        /// <param name="max">The upper bound</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The unsigned primal type</typeparam>
         public static Vector<N,T> Contract<N,T>(this Vector<N,T> src, Vector<N,T> max)
            where N : ITypeNat, new()
            where T : struct
        {
            var dst = NatSpan.alloc<N,T>();
            for(var i=0; i<dst.Length; i++)
                dst[i] = Contract(src[i],max[i]);
            return dst;
        }

         public static Span<N,T> Contract<N,T>(this Span<N,T> src, Span<N,T> max)
            where N : ITypeNat, new()
            where T : struct
        {
            var dst = NatSpan.alloc<N,T>();
            for(var i=0; i<dst.Length; i++)
                dst[i] = Contract(src[i],max[i]);
            return dst;
        }


        /// <summary>
        /// Effects a component-wise contraction on the source vector on a source vector of unsigned primal type, 
        /// dst[i] = src[i].Contract(max[i])
        /// </summary>
        /// <param name="src">The vector to contract</param>
        /// <param name="max">The upper bound</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The unsigned primal type</typeparam>
         public static Vector<T> Contract<T>(this Vector<T> src, Vector<T> max)
            where T : struct
        {
            var len = src.Length;
            require(len == max.Length);
            var dst = Vector.Alloc<T>(len);
            for(var i=0; i<dst.Length; i++)
                dst[i] = Contract(src[i],max[i]);
            return dst;
        }

        /// <summary>
        /// Derives an int8 random source from a uint8 random source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="target">The range of the target generator</param>
        [MethodImpl(Inline)]
        public static IBoundRandomSource<sbyte> DeriveSource(this IRandomSource<byte> src, Interval<sbyte>? target = null) 
            => new PolyRandI8(src,target);

        /// <summary>
        /// Derives an uint8 random source from a uint64 random source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="target">The range of the target generator</param>
        [MethodImpl(Inline)]
        public static IBoundRandomSource<byte> DeriveSource(this IRandomSource<ulong> src, Interval<byte>? target = null) 
            => new PolyRandU8(src,target);

        /// <summary>
        /// Queries a non-specified source for a point-source
        /// </summary>
        /// <param name="src">The source to query</param>
        /// <typeparam name="T">The point type</typeparam>
        [MethodImpl(Inline)]
        public static Option<IRandomSource<T>> PointSource<T>(this IRandomSource src)
            where T : struct
                => src is IRandomSource<T> x ? some(x) : null;

        /// <summary>
        /// Generates a psedorandom int in the interval [0, max) if max >= 0
        /// </summary>
        /// <param name="random">The stateful source on which the generation is predicated</param>
        /// <param name="max">The exclusive maximum</param>
        [MethodImpl(Inline)]
        internal static int NextInt32(this IRandomSource<ulong> random, int max)
            => max >= 0 ? (int)random.Next((ulong)max) 
                : - (int)random.Next((ulong) (Int32.MaxValue + max));        
    }
}