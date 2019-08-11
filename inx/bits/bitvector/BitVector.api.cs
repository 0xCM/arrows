//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    

    public static class BitVector
    {   
        /// <summary>
        /// Creates a generic bitvector of natural length
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Natural<N,T>(N len = default, in T src = default)        
            where N : ITypeNat, new()
            where T : struct
                => new BitVector<N,T>(src);

        /// <summary>
        /// Constructs a bitvector of natural length from a source span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Natural<N,T>(Span<T> src, N n = default)
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
        public static BitVector<N,T> Natural<N,T>(ReadOnlySpan<T> src, N n = default)
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
        public static BitVector<T> Generic<T>(Span<T> src, uint? dim = null)
            where T : struct
                => new BitVector<T>(src,dim);

        /// <summary>
        /// Constructs a bitvector where the length is determined by the capacity
        /// of the source span if unspecified
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> Generic<T>(ReadOnlySpan<T> src, uint? dim = null)
            where T : struct
                => new BitVector<T>(src,dim);

        /// <summary>
        /// Creates a generic bitvector over an arbitrary number of elements
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> Generic<T>(params T[] src)
            where T : struct
                => BitVector<T>.Define(src);


        [MethodImpl(Inline)]
        public static BitVector8 Scalar8<T>(BitVector<T> src)        
            where T : struct
                => src.Bytes().First();

        [MethodImpl(Inline)]
        public static BitVector16 Scalar16<T>(BitVector<T> src)        
            where T : struct
                => BitConverter.ToUInt16(src.Bytes().Extend(BitVector16.ByteSize));

        [MethodImpl(Inline)]
        public static BitVector32 Scalar32<T>(BitVector<T> src)        
            where T : struct
                => BitConverter.ToUInt32(src.Bytes().Extend(BitVector32.ByteSize));

        [MethodImpl(Inline)]
        public static BitVector64 Scalar64<T>(BitVector<T> src)        
            where T : struct
                => BitConverter.ToUInt64(src.Bytes().Extend(BitVector64.ByteSize));

        /// <summary>
        /// Constructs an 8-bit bitvector from a bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector8 Scalar8(Span<Bit> src)
            => BitVector8.Define(src);

        /// <summary>
        /// Constructs an 8-bit bitvector from a bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector8 Scalar8(ReadOnlySpan<Bit> src)
            => BitVector8.Define(src);


        /// <summary>
        /// Constructs a 16-bit bitvector from a bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector16 Scalar16(Span<Bit> src)
            => BitVector16.Define(src);

        /// <summary>
        /// Constructs a 16-bit bitvector from a bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector16 Scalar16(ReadOnlySpan<Bit> src)
            => BitVector16.Define(src);

        /// <summary>
        /// Constructs a 32-bit bitvector from a bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector32 Scalar32(Span<Bit> src)
            => BitVector32.Define(src);

        /// <summary>
        /// Constructs a 32-bit bitvector from a bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector32 Scalar32(ReadOnlySpan<Bit> src)
            => BitVector32.Define(src);

        /// <summary>
        /// Constructs a 64-bit bitvector from a bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector64 Scalar64(Span<Bit> src)
            => BitVector64.Define(src);

        /// <summary>
        /// Constructs a 64-bit bitvector from a bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector64 Scalar64(ReadOnlySpan<Bit> src)
            => BitVector64.Define(src);

        /// <summary>
        /// Defines a scalar bitvector over the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 Scalar(sbyte src)
            => (byte)src;

        /// <summary>
        /// Defines a scalar bitvector over the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 Scalar(byte src)
            => src;

        /// <summary>
        /// Defines a scalar bitvector over the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 Scalar(short src)
            => (ushort)src;

        /// <summary>
        /// Defines a scalar bitvector over the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 Scalar(ushort src)
            => src;

        /// <summary>
        /// Defines a scalar bitvector over the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 Scalar(int src)
            => (uint)src;

        /// <summary>
        /// Defines a scalar bitvector over the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 Scalar(uint src)
            => src;

        /// <summary>
        /// Defines a scalar bitvector over the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 Scalar(long src)
            => (ulong)src;

        /// <summary>
        /// Defines a scalar bitvector over the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 Scalar(ulong src)
            => src;

        /// <summary>
        /// Defines a scalar bitvector over the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 Scalar(float src)
            => (uint)BitConverter.SingleToInt32Bits(src);

        /// <summary>
        /// Defines a scalar bitvector over the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 Scalar(double src)
            => (ulong)BitConverter.DoubleToInt64Bits(src);


        [MethodImpl(Inline)]
        public static BitVector<T> Counted<T>(BitSize bitcount, params T[] src)
            where T : struct
                => BitVector<T>.Define(bitcount, src);

    }


}