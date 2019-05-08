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

    public struct BitVector8 : IEquatable<BitVector8>
    {
        [MethodImpl(Inline)]
        public static BitVector8 Define(byte src)
            => new BitVector8(src);

        [MethodImpl(Inline)]
        public static BitVector8 Define(Bit b0, Bit b1, Bit b2, Bit b3, Bit b4, Bit b5, Bit b6, Bit b7)
            => Bits.pack(b0,b1,b2,b3,b4,b5,b6,b7);

        [MethodImpl(Inline)]
        public static bool operator ==(BitVector8 lhs, BitVector8 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitVector8 lhs, BitVector8 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static BitVector8 operator |(BitVector8 lhs, BitVector8 rhs)
            => BitVector8.Define((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline)]
        public static BitVector8 operator &(BitVector8 lhs, BitVector8 rhs)
            => BitVector8.Define((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline)]
        public static BitVector8 operator ^(BitVector8 lhs, BitVector8 rhs)
            => BitVector8.Define((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline)]
        public static BitVector8 operator ~(BitVector8 src)
            => BitVector8.Define((byte)(~src.data));

        [MethodImpl(Inline)]
        public static implicit operator BitVector8(byte src)
            => new BitVector8(src);

        [MethodImpl(Inline)]
        public BitVector8(byte data)
            => this.data = data;
        
        byte data;

        public Bit this[int index]
        {
            [MethodImpl(Inline)]
            get => Bits.testbit(data, index);
            
            [MethodImpl(Inline)]
            set => data = value ? Bits.setbit(data,index) : Bits.unset(data,index);
        }

        [MethodImpl(Inline)]
        public bool IsSet(int index)
            => Bits.testbit(data,index);

        [MethodImpl(Inline)]
        public string Format()
            => Bits.bitchars(data);


        [MethodImpl(Inline)]
        public bool Equals(BitVector8 rhs)
            => data == rhs.data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}