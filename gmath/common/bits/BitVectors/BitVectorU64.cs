//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;

    using static mfunc;

    public struct BitVectorU64 : IEquatable<BitVectorU64>
    {
        public static readonly BitVectorU64 Zero = Define(0);
        
        [MethodImpl(Inline)]
        public static BitVectorU64 Define(ulong src)
            => new BitVectorU64(src);    

        [MethodImpl(Inline)]
        public static bool operator ==(BitVectorU64 lhs, BitVectorU64 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitVectorU64 lhs, BitVectorU64 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static BitVectorU64 operator |(BitVectorU64 lhs, BitVectorU64 rhs)
            => lhs.data.Or(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorU64 operator &(BitVectorU64 lhs, BitVectorU64 rhs)
            => lhs.data.And(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorU64 operator ^(BitVectorU64 lhs, BitVectorU64 rhs)
            => lhs.data.XOr(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorU64 operator ~(BitVectorU64 src)
            => src.data.Flip();

        [MethodImpl(Inline)]
        public static implicit operator BitVectorU64(ulong src)
            => new BitVectorU64(src);

        [MethodImpl(Inline)]
        public static implicit operator ulong(BitVectorU64 src)
            => src.data;

        [MethodImpl(Inline)]
        public BitVectorU64(ulong data)
            => this.data = data;
        
        ulong data;

        public Bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => Bits.test(data, pos);
            
            [MethodImpl(Inline)]
            set
            {
                if(value)
                    Bits.set(ref data, pos);
                else
                     Bits.unset(data,pos);                    
            }
            
        }

        [MethodImpl(Inline)]
        public bool IsSet(int index)
            => Bits.test(data,index);

        [MethodImpl(Inline)]
        public string BitString()
            => Bits.bitstring(data);

        [MethodImpl(Inline)]
        public byte[] Bytes()
            => Bits.bytes(data);

        [MethodImpl(Inline)]
        public Bit[] BitData()
            => Bits.bits(data);

        [MethodImpl(Inline)]
        public int PopCount()
            => (int)Bits.popcount(data);

        [MethodImpl(Inline)]
        public (BitVectorU32 x0, BitVectorU32 x1) Split()
            => Bits.split(data);


        [MethodImpl(Inline)]
        public bool Equals(BitVectorU64 rhs)
            => data == rhs.data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override string ToString()
            => BitString();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }


}