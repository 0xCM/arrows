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

    using static zfunc;    
    using static Bits;
    using static Bytes;

    public ref struct BitVector4
    {
        UInt4 data;

        [MethodImpl(Inline)]
        public BitVector4(in byte data)
        {
            require(data <= 0xF);
            this.data = (UInt4)data;
        }

        [MethodImpl(Inline)]
        public BitVector4(UInt4 data)
        {
            this.data = data;
        }

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N4,byte>(in BitVector4 src)
            => new BitVector<N4,byte>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector4(in byte src)
            => new BitVector4(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(in BitVector4 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector4(UInt4 src)
            => new BitVector4(src);

        [MethodImpl(Inline)]
        public static BitVector4 Define(Bit? x0 = null, Bit? x1 = null, Bit? x2 = null, Bit? x3 = null)
            => UInt4.FromBits(x0,x1,x2,x3);

        [MethodImpl(Inline)]
        public static BitVector4 Define(in byte src)
            => new BitVector4(src);
            

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector4 lhs, in BitVector4 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector4 lhs, in BitVector4 rhs)
            => !lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static BitVector4 operator +(in BitVector4 lhs, in BitVector4 rhs)
            => Define((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline)]
        public static BitVector4 operator *(in BitVector4 lhs, in BitVector4 rhs)
            => Define((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline)]
        public static BitVector4 operator -(in BitVector4 src)
            => Define((byte) ~ src.data);

        [MethodImpl(Inline)]
        public static BitVector4 operator |(in BitVector4 lhs, in BitVector4 rhs)
            => Define((byte)(lhs.data | rhs.data));


        [MethodImpl(Inline)]
        public void EnableBit(in int pos)
            => data[pos] = Bit.On;

        [MethodImpl(Inline)]
        public void DisableBit(in int pos)
            => data[pos] = Bit.Off;

        [MethodImpl(Inline)]
        public bool TestBit(byte pos)
            => data[pos];

        public Bit this[in int pos]
        {
            [MethodImpl(Inline)]
            get => data[pos];
            
            [MethodImpl(Inline)]
            set => data[pos] = value;
        }

        [MethodImpl(Inline)]
        public BitString ToBitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => new byte[]{data};

        [MethodImpl(Inline)]
        public ulong PopCount()
            => pop(data);

        [MethodImpl(Inline)]
        public ulong Nlz()
            => nlz((byte)(data << 4));

        [MethodImpl(Inline)]
        public ulong Ntz()
            => ntz(data);

        [MethodImpl(Inline)]
        public bool Eq(in BitVector4 rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public bool NEq(in BitVector4 rhs)
            => data != rhs.data;

        [MethodImpl(Inline)]
        public bool AllOnes()
            => (0xF & data) == 0xF;
 
        [MethodImpl(Inline)]
        public bool AllZeros()
            => data == 0;

        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false)
            => ToBitString().Format(tlz, specifier);

        public override bool Equals(object obj)
            => throw new NotSupportedException();
       
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}