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
        byte data;

        [MethodImpl(Inline)]
        public BitVector4(in byte data)
        {
            require(data <= 0xF);
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
        public static BitVector4 Define(byte? x0 = null, byte? x1 = null, byte? x2 = null, byte? x3 = null)
        {
            var x = default(byte);
            if(x0 == 1) x |= (1 << 0);
            if(x1 == 1) x |= (1 << 1);
            if(x2 == 1) x |= (1 << 2);
            if(x3 == 1) x |= (1 << 3);
            return x;
        }

        [MethodImpl(Inline)]
        public static BitVector4 Define(in byte src)
            => new BitVector4(src);

        [MethodImpl(Inline)]
        public static BitVector4 Define(in ReadOnlySpan<Bit> src)
        {
            require(src.Length == 4);
            var x = default(byte);
            if(src[0]) x |= (1 << 0);
            if(src[1]) x |= (1 << 1);
            if(src[2]) x |= (1 << 2);
            if(src[3]) x |= (1 << 3);
            return x;
        }
            

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector4 lhs, in BitVector4 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector4 lhs, in BitVector4 rhs)
            => !lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static BitVector4 operator |(in BitVector4 lhs, in BitVector4 rhs)
            => Define((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline)]
        public static BitVector4 operator &(in BitVector4 lhs, in BitVector4 rhs)
            => Define((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline)]
        public static BitVector4 operator ^(in BitVector4 lhs, in BitVector4 rhs)
            => Define((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline)]
        public static BitVector4 operator ~(in BitVector4 src)
            => Define((byte) ~ src.data);

        public Bit this[in int pos]
        {
            [MethodImpl(Inline)]
            get => test(in data, in pos);
            
            [MethodImpl(Inline)]
            set
            {
                if(value)
                    enable(ref data, in pos);
                else
                     disable(ref data, in pos);                    
            }            
        }

        [MethodImpl(Inline)]
        public void EnableBit(in int pos)
            => enable(ref data, in pos);

        [MethodImpl(Inline)]
        public void DisableBit(in int pos)
            => disable(ref data, in pos);

        [MethodImpl(Inline)]
        public bool TestBit(byte pos)
            => test(in data, pos);

         [MethodImpl(Inline)]
        public BitString BitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            =>  bytes(in data);

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

        public override bool Equals(object obj)
            => throw new NotSupportedException();
       
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}