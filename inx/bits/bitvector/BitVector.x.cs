//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

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
        /// <typeparam name="T">The primal segment type</typeparam>
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

        /// <summary>
        /// Constructs a bitvector where the length is determined by the capacity
        /// of the source span if unspecified
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> ToBitVector<T>(this Span<T> src, uint? dim = null)
            where T : struct
                => new BitVector<T>(src,dim);

        /// <summary>
        /// Constructs a bitvector where the length is determined by the capacity
        /// of the source span if unspecified
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> ToBitVector<T>(this ReadOnlySpan<T> src, uint? dim = null)
            where T : struct
                => new BitVector<T>(src,dim);

        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector8<T>(this BitVector<T> src)        
            where T : struct
                => src.Bytes().First();

        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector16<T>(this BitVector<T> src)        
            where T : struct
                => BitConverter.ToUInt16(src.Bytes().Extend(BitVector16.ByteSize));

        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32<T>(this BitVector<T> src)        
            where T : struct
                => BitConverter.ToUInt32(src.Bytes().Extend(BitVector32.ByteSize));

        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64<T>(this BitVector<T> src)        
            where T : struct
                => BitConverter.ToUInt64(src.Bytes().Extend(BitVector64.ByteSize));


        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector8(this sbyte src)        
            => (byte)src;

        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector8(this byte src)        
            => src;

        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector16(this byte src)        
            => src;

        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector16(this short src)        
            => (ushort)src;

        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector16(this ushort src)        
            => src;

        /// <summary>
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32(this sbyte src)        
            => (byte)src;

        /// <summary>
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32(this byte src)        
            => src;

        /// <summary>
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32(this ushort src)        
            => src;

        /// <summary>
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32(this short src)        
            => (ushort)src;

        /// <summary>
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32(this uint src)        
            => src;

        /// <summary>
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32(this int src)        
            => (uint)src;

        /// <summary>
        /// Constructs a 64-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64(this byte src)        
            => src;

        /// <summary>
        /// Constructs a 64-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64(this sbyte src)        
            => (byte)src;

        /// <summary>
        /// Constructs a 64-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64(this ushort src)        
            => src;

        /// <summary>
        /// Constructs a 64-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64(this short src)        
            => (ushort)src;

        /// <summary>
        /// Constructs a 64-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64(this uint src)        
            => src;

        /// <summary>
        /// Constructs a 64-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64(this int src)        
            => (uint)src;

        /// <summary>
        /// Constructs a 64-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64(this long src)        
            => (ulong)src;

        /// <summary>
        /// Constructs a 64-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64(this ulong src)        
            => src;

        /// <summary>
        /// Constructs an 8-bit bitvector from a bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector8(this Span<Bit> src)
            => BitVector8.Define(src);

        /// <summary>
        /// Constructs an 8-bit bitvector from a bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector8(this ReadOnlySpan<Bit> src)
            => BitVector8.Define(src);

        /// <summary>
        /// Constructs a 16-bit bitvector from a bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector16(this Span<Bit> src)
            => BitVector16.Define(src);

        /// <summary>
        /// Constructs a 16-bit bitvector from a bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector16(this ReadOnlySpan<Bit> src)
            => BitVector16.Define(src);

        /// <summary>
        /// Constructs a 32-bit bitvector from a bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32(this Span<Bit> src)
            => BitVector32.Define(src);

        /// <summary>
        /// Constructs a 32-bit bitvector from a bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32(this ReadOnlySpan<Bit> src)
            => BitVector32.Define(src);

        /// <summary>
        /// Constructs a 64-bit bitvector from a bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64(this Span<Bit> src)
            => BitVector64.Define(src);

        /// <summary>
        /// Constructs a 64-bit bitvector from a bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64(this ReadOnlySpan<Bit> src)
            => BitVector64.Define(src);

    }
}
