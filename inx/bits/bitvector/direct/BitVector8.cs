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

    public ref struct BitVector8
    {
        byte data;

        [MethodImpl(Inline)]
        public BitVector8(in byte data)
            => this.data = data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N8,byte>(in BitVector8 src)
            => new BitVector<N8,byte>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector8(in byte src)
            => new BitVector8(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(in BitVector8 src)
            => src.data;

        [MethodImpl(Inline)]
        public static BitVector8 Define(
            byte? x0 = null, byte? x1 = null, byte? x2 = null, byte? x3 = null, 
            byte? x4 = null, byte? x5 = null, byte? x6 = null, byte? x7 = null)
        {
            var x = default(byte);
            if(x0 == 1) x |= (1 << 0);
            if(x1 == 1) x |= (1 << 1);
            if(x2 == 1) x |= (1 << 2);
            if(x3 == 1) x |= (1 << 3);
            if(x4 == 1) x |= (1 << 4);
            if(x5 == 1) x |= (1 << 5);
            if(x6 == 1) x |= (1 << 6);
            if(x7 == 1) x |= (1 << 7);
            return x;
        }

        [MethodImpl(Inline)]
        public static BitVector8 Define(in byte src)
            => new BitVector8(src);

        [MethodImpl(Inline)]
        public static BitVector8 Define(in ReadOnlySpan<Bit> src)
            => Define(in pack(src, out byte dst));

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector8 lhs, in BitVector8 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector8 lhs, in BitVector8 rhs)
            => !lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static BitVector8 operator |(in BitVector8 lhs, in BitVector8 rhs)
            => Define((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline)]
        public static BitVector8 operator &(in BitVector8 lhs, in BitVector8 rhs)
            => Define((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline)]
        public static BitVector8 operator ^(in BitVector8 lhs, in BitVector8 rhs)
            => Define((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline)]
        public static BitVector8 operator ~(in BitVector8 src)
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
        public bool TestBit(in int pos)
            => test(in data, in pos);

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
            => nlz(data);

        [MethodImpl(Inline)]
        public ulong Ntz()
            => ntz(data);

        [MethodImpl(Inline)]
        public bool Eq(in BitVector8 rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public bool NEq(in BitVector8 rhs)
            => data != rhs.data;

        [MethodImpl(Inline)]
        public bool AllOnes()
            => (0xFF & data) == 0xFF;
 
        [MethodImpl(Inline)]
        public bool AllZeros()
            => data == 0;

        public override bool Equals(object obj)
            => throw new NotSupportedException();
       
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}