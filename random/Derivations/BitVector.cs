//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;

    using BV = Z0.BitVector;

    partial class RngX
    {
        /// <summary>
        /// Produces a random r-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector4 BitVector4(this IRandomSource random)
            => BV.FromScalar(random.NextUInt4());

        /// <summary>
        /// Produces a random 8-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector8 BitVector8(this IRandomSource random)
            => random.NextUInt8();

        /// <summary>
        /// Produces a random 16-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector16 BitVector16(this IRandomSource random)
            => random.NextUInt16();

        /// <summary>
        /// Produces a random 32-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector32 BitVector32(this IRandomSource random)
            => random.NextUInt32();

        /// <summary>
        /// Produces a random 64-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector64 BitVector64(this IRandomSource random)
            => random.NextUInt64();

        /// <summary>
        /// Produces a random generic bitvector of specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitvector length</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> BitVector<T>(this IRandomSource random, BitSize len)
            where T : struct
                => BV.Load<T>(random.Stream<T>().TakeSpan(BV.CellCount<T>(len)));

        /// <summary>
        /// Produces a random bitvector of natural length and generic type
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitvector length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> BitVector<N,T>(this IRandomSource random, N len = default)
            where T : struct
            where N : ITypeNat, new()
                => BV.Load<N,T>(random.Stream<T>().TakeSpan(BV.CellCount<T>(nati<N>())));

    }

}