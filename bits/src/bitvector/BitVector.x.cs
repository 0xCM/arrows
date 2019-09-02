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
        /// Constructs a 64-bit bitvector from a 64-bit primal value
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
                => BitVector.FromCells(src,n);

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
                => BitVector.FromCells(src,n);

        /// <summary>
        /// Constructs a bitvector from a primal span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="len">The bitvector length, if specified</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> ToBitVector<T>(this Span<T> src, BitSize? len = null)
            where T : struct
                => BitVector.FromCells(src,len);

        /// <summary>
        /// Loads a bitvector from a primal segment
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="len">The bitvector length, if specified</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> ToBitVector<T>(this Memory<T> src, BitSize? len = null)
            where T : struct
                => BitVector.FromCells(src,len);

        /// <summary>
        /// Loads a bitvector from a primal span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> ToBitVector<T>(this ReadOnlySpan<T> src, BitSize? len = null)
            where T : struct
                => BitVector.FromCells(src,len);

        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector8<T>(this BitVector<T> src)        
            where T : struct
                => src.Bytes().First();

        [MethodImpl(Inline)]
        public static BitVector8 TakeBitVector8<T>(this BitVector<T> src, int offset = 0)        
            where T : struct
                => src.Bytes()[offset];

        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector16<T>(this BitVector<T> src)        
            where T : struct
                => BitConverter.ToUInt16(src.Bytes().Extend(2));

        [MethodImpl(Inline)]
        public static BitVector16 TakeBitVector16<T>(this BitVector<T> src, int offset = 0)        
            where T : struct
                => BitConverter.ToUInt16(src.Bytes().Slice(offset, 2));

        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32<T>(this BitVector<T> src)        
            where T : struct
                => BitConverter.ToUInt32(src.Bytes().Extend(4));

        [MethodImpl(Inline)]
        public static BitVector32 TakeBitVector32<T>(this BitVector<T> src, int offset = 0)        
            where T : struct
                => BitConverter.ToUInt32(src.Bytes().Slice(offset, 4));

        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64<T>(this BitVector<T> src)        
            where T : struct
                => BitConverter.ToUInt64(src.Bytes().Extend(8));

        [MethodImpl(Inline)]
        public static BitVector64 TakeBitVector64<T>(this BitVector<T> src, int offset = 0)        
            where T : struct
                => BitConverter.ToUInt64(src.Bytes().Slice(offset, 8));

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
        /// Defines a 32-bit bitvector with content determined by its corresponding integral type 
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32(this uint src)        
            => src;

        /// <summary>
        /// Defines a 32-bit bitvector with content determined by a 32-bit usigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32(this int src)        
            => (uint)src;

        /// <summary>
        /// Defines a 64-bit bitvector where the lower 16 bits are determined by 
        /// an 8-bit usigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64(this byte src)        
            => src;

        /// <summary>
        /// Constructs a 64-bit bitvector where the lower 8 bits are 
        /// determined by an 8-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64(this sbyte src)        
            => (byte)src;

        /// <summary>
        /// Defines a 64-bit bitvector where the lower 16 bits are determined by a 16-bit usigned integer 
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64(this ushort src)        
            => src;


        /// <summary>
        /// Defines a 64-bit bitvector where the lower 16 bits are determined by a 16-bit signed integer 
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64(this short src)        
            => (ushort)src;

        /// <summary>
        /// Defines a 64-bit bitvector where the lower 32 bits are determined by a 32-bit unsigned integer 
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
        /// Creates a 128-bit bitvector from a 8-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector128(this sbyte src)        
            => (byte)src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 8-bit unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector128(this byte src)        
            => src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 16-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector128(this short src)        
            => (ushort)src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 16-bit unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector128(this ushort src)        
            => src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 32-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector128(this int src)        
            => (uint)src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 32-bit unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector128(this uint src)        
            => src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 64-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector128(this long src)        
            => (ulong)src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 64-bit unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector128(this ulong src)        
            => src;

        /// <summary>
        /// Converts the source bitvector it the equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<N8,byte> ToGeneric(this BitVector8 src)
            => src;
    
        /// <summary>
        /// Converts the source bitvector it the equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<N16,ushort> ToGeneric(this BitVector16 src)
            => src;

        /// <summary>
        /// Converts the source bitvector it the equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<N32,uint> ToGeneric(this BitVector32 src)
            => src;

        /// <summary>
        /// Converts the source bitvector it the equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<N64,ulong> ToGeneric(this BitVector64 src)
            => src;

        /// <summary>
        /// Constructs a 128-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector128(this BitString src)
            => BitVector128.FromBitString(src);

        /// <summary>
        /// Constructs a 64-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64(this BitString src)
            => BitVector64.FromBitString(src);

        /// <summary>
        /// Constructs a 32-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32(this BitString src)
            => BitVector32.FromBitString(src);

        /// <summary>
        /// Constructs a 16-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector16(this BitString src)
            => BitVector16.FromBitString(src);

        /// <summary>
        /// Constructs a 8-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector8(this BitString src)
            => BitVector8.FromBitString(src);

        /// <summary>
        /// Constructs a 4-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 ToBitVector4(this BitString src)
            => BitVector4.FromBitString(src);

        /// <summary>
        /// Extracts a 128-bit cpu vector from a bitsring of length 128 or greater
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">The primal component type of the target vector</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> ToCpuVec128<T>(this BitString src)
            where T : struct        
                => src.Pack().As<byte,T>().ToSpan128().ToCpuVec128();

        /// <summary>
        /// Extracts a 256-bit cpu vector from a bitsring of length 128 or greater
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">The primal component type of the target vector</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> ToCpuVec256<T>(this BitString src)
            where T : struct        
                => src.Pack().As<byte,T>().ToSpan256().ToCpuVec256();                
    }
}
