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

        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector8<T>(this BitVector<T> src)        
            where T : unmanaged
                => src.Bytes.First();

        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector16<T>(this BitVector<T> src)        
            where T : unmanaged
                => BitConverter.ToUInt16(src.Bytes.Extend(2));

        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32<T>(this BitVector<T> src)        
            where T : unmanaged
                => BitConverter.ToUInt32(src.Bytes.Extend(4));

        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64<T>(this BitVector<T> src)        
            where T : unmanaged
                => BitConverter.ToUInt64(src.Bytes.Extend(8));

        /// <summary>
        /// Constructs a 4-bit bitvector from the lower 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 ToBitVector4(this byte src)
            => src;

        /// <summary>
        /// Constructs a 4-bit bitvector from the lower 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 ToBitVector4(this ushort src)
            => (UInt4)src;


        /// <summary>
        /// Creates an an 8-bit bitvector from the source value interpreted as a byte
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector8(this sbyte src)        
            => (byte)src;

        /// <summary>
        /// Creates an an 8-bit bitvector via the obvious canonical bijection
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector8(this byte src)        
            => src;

        /// <summary>
        /// Creates a 16-bit bitvector with the lower 8 bits populated by the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector16(this byte src)        
            => src;

        /// <summary>
        /// Creates a 16-bit bitvector by interpreting the source value as an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector16(this short src)        
            => (ushort)src;

        /// <summary>
        /// Creates a 16-bit bitvector via canonical bijection with the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector16(this ushort src)        
            => src;

        /// <summary>
        /// Creates an an 8-bit bitvector from the lower 8 bits of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector8(this ushort src)        
            => (byte)src;

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
            where T : unmanaged        
                => src.Pack().As<byte,T>().ToSpan128().ToCpuVec128();

        /// <summary>
        /// Extracts a 256-bit cpu vector from a bitsring of length 128 or greater
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">The primal component type of the target vector</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> ToCpuVec256<T>(this BitString src)
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
