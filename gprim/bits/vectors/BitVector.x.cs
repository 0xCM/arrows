//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static Bits;

    public static partial class BitVectorX
    {        
        public static BitVector<N,T> ToNatBits<N,T>(this N bits, ref T head)
            where N : INatPow2, new()
            where T : struct
                => BitVector.Load<N,T>(ref head);

        [MethodImpl(Inline)]
        public static BitVectorU8 ToBits(this byte src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorI8 ToBits(this sbyte src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorU16 ToBits(this ushort src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorI32 ToBits(this int src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorU32 ToBits(this uint src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorU64 ToBits(this ulong src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorI64 ToBits(this long src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorU128 ToBits(this u128 src)
            => src;

        [MethodImpl(Inline)]        
        public static BitVector<N8,sbyte> ToNatBits(this ref sbyte src)
            => NatBits.Load(ref src);

        [MethodImpl(Inline)]        
        public static BitVector<N8,byte> ToNatBits(this ref byte src)
            => NatBits.Load(ref src);

        [MethodImpl(Inline)]        
        public static BitVector<N16,short> ToNatBits(this ref short src)
            => NatBits.Load(ref src);

        [MethodImpl(Inline)]        
        public static BitVector<N16,ushort> ToNatBits(this ref ushort src)
            => NatBits.Load(ref src);

        [MethodImpl(Inline)]        
        public static BitVector<N32,int> ToNatBits(this ref int src)
            => NatBits.Load(ref src);

        [MethodImpl(Inline)]        
        public static BitVector<N32,uint> ToNatBits(this ref uint src)
            => NatBits.Load(ref src);

        [MethodImpl(Inline)]        
        public static BitVector<N64,long> ToNatBits(this ref long src)
            => NatBits.Load(ref src);

        [MethodImpl(Inline)]        
        public static BitVector<N64,ulong> ToNatBits(this ref ulong src)
            => NatBits.Load(ref src);


        [MethodImpl(Inline)]        
        public static BitVector<sbyte> ToGeneric(this BitVectorI8 src)
            => src;

        [MethodImpl(Inline)]        
        public static BitVector<short> ToGeneric(this BitVectorI16 src)
            => src;

        [MethodImpl(Inline)]        
        public static BitVector<int> ToGeneric(this BitVectorI32 src)
            => src;

        [MethodImpl(Inline)]        
        public static BitVector<long> ToGeneric(this BitVectorI64 src)
            => src;

        [MethodImpl(Inline)]        
        public static BitVector<byte> ToGeneric(this BitVectorU8 src)
            => src;

        [MethodImpl(Inline)]        
        public static BitVector<ushort> ToGeneric(this BitVectorU16 src)
            => src;

        [MethodImpl(Inline)]        
        public static BitVector<uint> ToGeneric(this BitVectorU32 src)
            => src;

        [MethodImpl(Inline)]        
        public static BitVector<ulong> ToGeneric(this BitVectorU64 src)
            => src;

        [MethodImpl(Inline)]        
        public static BitVector<N8, sbyte> ToNatBits(this BitVectorI8 src)
            => src;

        [MethodImpl(Inline)]        
        public static BitVector<N8, byte> ToNatBits(this BitVectorU8 src)
            => src;

        [MethodImpl(Inline)]        
        public static BitVector<N16, short> ToNatBits(this BitVectorI16 src)
            => src;

        [MethodImpl(Inline)]        
        public static BitVector<N16, ushort> ToNatBits(this BitVectorU16 src)
            => src;

        [MethodImpl(Inline)]        
        public static BitVector<N32, int> ToNatBits(this BitVectorI32 src)
            => src;

        [MethodImpl(Inline)]        
        public static BitVector<N32, uint> ToNatBits(this BitVectorU32 src)
            => src;

        [MethodImpl(Inline)]        
        public static BitVector<N64, long> ToNatBits(this BitVectorI64 src)
            => src;

        [MethodImpl(Inline)]        
        public static BitVector<N64, ulong> ToNatBits(this BitVectorU64 src)
            => src;

    }

}
