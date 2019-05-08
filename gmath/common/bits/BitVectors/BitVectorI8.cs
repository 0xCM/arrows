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

    public struct BitVectorI8 : IEquatable<BitVectorI8>
    {
        [MethodImpl(Inline)]
        public static implicit operator BitVectorI8(sbyte src)
            => new BitVectorI8(src);

        [MethodImpl(Inline)]
        public static implicit operator sbyte(BitVectorI8 src)
            => new BitVectorI8(src);

        [MethodImpl(Inline)]
        public BitVectorI8(sbyte data)
            => this.data = data;
        
        sbyte data;

        [MethodImpl(Inline)]
        public static BitVectorI8 Define(sbyte src)
            => new BitVectorI8(src);

        [MethodImpl(Inline)]
        public static BitVectorI8 Define(Bit b0, Bit b1, Bit b2, Bit b3, Bit b4, Bit b5, Bit b6, Sign sign)
            => Bits.bitpack(b0,b1,b2,b3,b4,b5,b6,sign);

        [MethodImpl(Inline)]
        public static bool operator ==(BitVectorI8 lhs, BitVectorI8 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitVectorI8 lhs, BitVectorI8 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static BitVectorI8 operator |(BitVectorI8 lhs, BitVectorI8 rhs)
            => lhs.data.Or(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorI8 operator &(BitVectorI8 lhs, BitVectorI8 rhs)
            => lhs.data.And(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorI8 operator ^(BitVectorI8 lhs, BitVectorI8 rhs)
            => lhs.data.XOr(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorI8 operator ~(BitVectorI8 src)
            => src.data.Flip();

        public Bit this[int index]
        {
            [MethodImpl(Inline)]
            get => Bits.test(data, index);
            
            [MethodImpl(Inline)]
            set => data = value ? Bits.set(data,index) : Bits.unset(data,index);
        }

        [MethodImpl(Inline)]
        public bool IsSet(int index)
            => Bits.test(data,index);

        [MethodImpl(Inline)]
        public string BitString()
            => Bits.bitstring(data);

        [MethodImpl(Inline)]
        public Bit[] BitData()
            => Bits.bits(data);

        [MethodImpl(Inline)]
        public int PopCount()
            => (int)Bits.popcount((uint)data) + (data < 0 ? 1 : 0);

        [MethodImpl(Inline)]
        public bool Equals(BitVectorI8 rhs)
            => data == rhs.data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override string ToString()
            => BitString();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }


}