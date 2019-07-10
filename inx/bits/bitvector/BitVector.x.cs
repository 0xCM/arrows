//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class BitVectorX
    {
        /// <summary>
        /// Constructs a canonical 8-bit bitvector from an 8-bit primal value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector(this byte src)
            => src;

        /// <summary>
        /// Constructs a canonical 18-bit bitvector from a 16-bit primal value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this ushort src)
            => src;

        /// <summary>
        /// Constructs a canonical 32-bit bitvector from a 32-bit primal value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this uint src)
            => src;

        /// <summary>
        /// Constructs a canonical 64-bit bitvector from a 64-bit primal value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this ulong src)
            => src;
        
        /// <summary>
        /// Constructs a bitvector of natural length from a source span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> ToBitVector<N,T>(this Span<T> src, N n = default)
            where N : ITypeNat, new()
            where T : struct
                => new BitVector<N, T>(src);

        /// <summary>
        /// Constructs a bitvector of natural length from a source span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> ToBitVector<N,T>(this ReadOnlySpan<T> src, N n = default)
            where N : ITypeNat, new()
            where T : struct
                => new BitVector<N, T>(src);
    }
}
