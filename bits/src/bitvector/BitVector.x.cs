﻿//-----------------------------------------------------------------------------
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
            where T : unmanaged
                => BitVector.Load(src,n);

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
            where T : unmanaged
                => BitVector.Load(src,n);

        /// <summary>
        /// Constructs a bitvector from a primal array
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="len">The bitvector length, if specified</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> ToBitVector<T>(this T[] src, BitSize? len = null)
            where T : unmanaged
                => BitVector.Load(src,len);

        /// <summary>
        /// Constructs a bitvector from a primal span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="len">The bitvector length, if specified</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> ToBitVector<T>(this Span<T> src, BitSize? len = null)
            where T : unmanaged
                => BitVector.Load(src,len);

        /// <summary>
        /// Converts the leading elements of generic bitvector to an 8-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector8<T>(this BitVector<T> src)        
            where T : unmanaged
                => src.Nonempty ? src.Bytes.First() : (byte)0;

        /// <summary>
        /// Converts the leading elements of generic bitvector to a 16-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector16<T>(this BitVector<T> src)        
            where T : unmanaged
                => src.Data.TakeUInt16();

        /// <summary>
        /// Converts the leading elements of generic bitvector to a 16-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector16<N,T>(this BitVector<N,T> src)        
            where T : unmanaged
            where N : ITypeNat, new()
                => src.Data.TakeUInt16();

        /// <summary>
        /// Converts the leading elements of generic bitvector to a 32-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32<T>(this BitVector<T> src)        
            where T : unmanaged
                => src.Data.TakeUInt32();

        /// <summary>
        /// Converts the leading elements of generic bitvector to a 32-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector<N,T>(this BitVector<N,T> src, N32 n)        
            where T : unmanaged
            where N : ITypeNat, new()
                => src.Data.TakeUInt32();

        /// <summary>
        /// Converts the leading elements of generic bitvector to a 64-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector<T>(this BitVector<T> src, N64 n)
            where T : unmanaged
                => src.Data.TakeUInt64();

        /// <summary>
        /// Converts the leading elements of generic bitvector to a 64-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector<N,T>(this BitVector<N,T> src, N64 n)        
            where T : unmanaged
            where N : ITypeNat, new()
                => src.Data.TakeUInt64();

        /// <summary>
        /// Constructs a 4-bit bitvector from the lower 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 ToBitVector(this byte src, N4 n)
            => src;

        /// <summary>
        /// Constructs a 4-bit bitvector from the lower 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 ToBitVector(this ushort src, N4 n)
            => (UInt4)src;

        /// <summary>
        /// Creates an an 8-bit bitvector from the source value interpreted as a byte
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector(this sbyte src, N8 n)        
            => (byte)src;

        /// <summary>
        /// Creates an an 8-bit bitvector via the obvious canonical bijection
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector(this byte src, N8 n)        
            => src;

        /// <summary>
        /// Creates a 16-bit bitvector with the lower 8 bits populated by the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this byte src, N16 n)        
            => src;

        /// <summary>
        /// Creates a 16-bit bitvector by interpreting the source value as an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this short src, N16 n)        
            => (ushort)src;

        /// <summary>
        /// Creates an an 8-bit bitvector from the lower 8 bits of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector(this ushort src, N8 n)        
            => (byte)src;

        /// <summary>
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this sbyte src, N32 n)        
            => (byte)src;

        /// <summary>
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this byte src, N32 n)        
            => src;

        /// <summary>
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this ushort src, N32 n)        
            => src;

        /// <summary>
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32(this short src, N32 n)        
            => (ushort)src;

        /// <summary>
        /// Defines a 32-bit bitvector with content determined by its corresponding integral type 
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this uint src, N32 n)        
            => src;

        /// <summary>
        /// Defines a 32-bit bitvector with content determined by a 32-bit usigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this int src, N32 n)        
            => (uint)src;

        /// <summary>
        /// Defines a 64-bit bitvector where the lower 16 bits are determined by 
        /// an 8-bit usigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this byte src, N64 n)        
            => src;

        /// <summary>
        /// Constructs a 64-bit bitvector where the lower 8 bits are 
        /// determined by an 8-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this sbyte src, N64 n)        
            => (byte)src;

        /// <summary>
        /// Defines a 64-bit bitvector where the lower 16 bits are determined by a 16-bit usigned integer 
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this ushort src, N64 n)        
            => src;
            
        /// <summary>
        /// Defines a 64-bit bitvector where the lower 16 bits are determined by a 16-bit signed integer 
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this short src, N64 n)        
            => (ushort)src;

        /// <summary>
        /// Defines a 64-bit bitvector where the lower 32 bits are determined by a 32-bit unsigned integer 
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this uint src, N64 n)        
            => src;

        /// <summary>
        /// Constructs a 64-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this int src, N64 n)        
            => (uint)src;

        /// <summary>
        /// Constructs a 64-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this long src, N64 n)        
            => (ulong)src;


        /// <summary>
        /// Constructs a 64-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this ulong src, N64 n)        
            => src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 8-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this sbyte src, N128 n)        
            => (byte)src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 8-bit unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this byte src, N128 n)        
            => src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 16-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this short src, N128 n)        
            => (ushort)src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 16-bit unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this ushort src, N128 n)        
            => src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 32-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this int src, N128 n)        
            => (uint)src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 32-bit unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this uint src, N128 n)        
            => src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 64-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this long src, N128 n)        
            => (ulong)src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 64-bit unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this ulong src, N128 n)        
            => src;

        /// <summary>
        /// Converts the source bitvector to an equivalent generic bitvector of natural length
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<N8,byte> ToGeneric(this BitVector8 src)
            => src;
    
        /// <summary>
        /// Converts the source bitvector to an equivalent generic bitvector of natural length
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<N16,ushort> ToGeneric(this BitVector16 src)
            => src;

        /// <summary>
        /// Converts the source bitvector to an equivalent generic bitvector of natural length
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
        /// Constructs a 4-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 ToBitVector(this BitString src, N4 n)
            => BitVector4.FromBitString(src);

        /// <summary>
        /// Constructs a 8-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector(this BitString src, N8 n)
            => BitVector8.FromBitString(src);

        /// <summary>
        /// Constructs a 16-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this BitString src, N16 n)
            => BitVector16.FromBitString(src);

        /// <summary>
        /// Constructs a 32-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this BitString src, N32 n)
            => BitVector32.FromBitString(src);

        /// <summary>
        /// Constructs a 64-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this BitString src, N64 n)
            => BitVector64.FromBitString(src);

        /// <summary>
        /// Constructs a 128-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this BitString src, N128 n)
            => BitVector128.FromBitString(src);

        /// <summary>
        /// Extracts a 128-bit cpu vector from a bitsring of length 128 or greater
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">The primal component type of the target vector</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> ToCpuVec<T>(this BitString src, N128 n)
            where T : unmanaged        
                => src.Pack().As<byte,T>().ToSpan128().ToCpuVec128();

        /// <summary>
        /// Extracts a 256-bit cpu vector from a bitsring of length 128 or greater
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">The primal component type of the target vector</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> ToCpuVec<T>(this BitString src, N256 n)
            where T : unmanaged        
                => src.Pack().As<byte,T>().ToSpan256().ToCpuVec256();                

        /// <summary>
        /// Converts an 8-bit bitmask to an 8-bit bitvector
        /// </summary>
        /// <param name="src">The source mask</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector(this BitMask8 src)
            => ((byte)src).ToBitVector();

        /// <summary>
        /// Converts a 16-bit bitmask to a 16-bit bitvector
        /// </summary>
        /// <param name="src">The source mask</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this BitMask16 src)
            => ((ushort)src).ToBitVector();

        /// <summary>
        /// Converts a 32-bit bitmask to a 32-bit bitvector
        /// </summary>
        /// <param name="src">The source mask</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this BitMask32 src)
            => ((uint)src).ToBitVector();

        /// <summary>
        /// Converts a 64-bit bitmask to a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source mask</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this BitMask64 src)
            => ((ulong)src).ToBitVector();

        /// <summary>
        /// Converts a scalar value to a type-parametric fixed-bits bitvector
        /// </summary>
        /// <param name="src">The source scalar</param>
        [MethodImpl(Inline)]
        public static FixedBits<BitVector8,byte> ToFixedBits(this byte src)
            => FixedBits.FromScalar(src);

        /// <summary>
        /// Converts a scalar value to a type-parametric fixed-bits bitvector
        /// </summary>
        /// <param name="src">The source scalar</param>
        [MethodImpl(Inline)]
        public static FixedBits<BitVector16,ushort> ToFixedBits(this ushort src)
            => FixedBits.FromScalar(src);

        /// <summary>
        /// Converts a scalar value to a type-parametric fixed-bits bitvector
        /// </summary>
        /// <param name="src">The source scalar</param>
        [MethodImpl(Inline)]
        public static FixedBits<BitVector32,uint> ToFixedBits(this uint src)
            => FixedBits.FromScalar(src);

        /// <summary>
        /// Converts a scalar value to a type-parametric fixed-bits bitvector
        /// </summary>
        /// <param name="src">The source scalar</param>
        [MethodImpl(Inline)]
        public static FixedBits<BitVector64,ulong> ToFixedBits(this ulong src)
            => FixedBits.FromScalar(src);

        /// <summary>
        /// Converts a primal bitvector to the corresponding type-parametric fixed-bits bitvector
        /// </summary>
        /// <param name="src">The source scalar</param>
        [MethodImpl(Inline)]
        public static FixedBits<BitVector8,byte> ToFixedBits(this BitVector8 src)
            => src;

        /// <summary>
        /// Converts a primal bitvector to the corresponding type-parametric fixed-bits bitvector
        /// </summary>
        /// <param name="src">The source scalar</param>
        [MethodImpl(Inline)]
        public static FixedBits<BitVector16,ushort> ToFixedBits(this BitVector16 src)
            => src;

        /// <summary>
        /// Converts a primal bitvector to the corresponding type-parametric fixed-bits bitvector
        /// </summary>
        /// <param name="src">The source scalar</param>
        [MethodImpl(Inline)]
        public static FixedBits<BitVector32,uint> ToFixedBits(this BitVector32 src)
            => src;

        /// <summary>
        /// Converts a primal bitvector to the corresponding type-parametric fixed-bits bitvector
        /// </summary>
        /// <param name="src">The source scalar</param>
        [MethodImpl(Inline)]
        public static FixedBits<BitVector64,ulong> ToFixedBits(this BitVector64 src)
            => src;

        /// <summary>
        /// Converts a parametric fixed bitvector to a primal bitvector
        /// </summary>
        /// <param name="v">The source vector</param>
        [MethodImpl(Inline)]
        public static V ToPrimalBits<V,S>(this FixedBits<V,S> v)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
                => v;


    }
}
