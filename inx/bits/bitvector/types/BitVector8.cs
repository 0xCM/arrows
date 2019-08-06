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

    public ref struct BitVector8
    {
        public const int ByteSize = 1;

        public const int BitSize = ByteSize * 8;

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
        public static Bit operator *(in BitVector8 lhs, in BitVector8 rhs)
            => (lhs & rhs) != 0;

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

        public Bit this[byte pos]
        {
            [MethodImpl(Inline)]
            get => BitMask.test(in data, pos);
            
            [MethodImpl(Inline)]
            set
            {
                if(value)
                    BitMask.enable(ref data, pos);
                else
                    BitMask.disable(ref data, pos);                    
            }            
        }

        [MethodImpl(Inline)]
        public byte Extract(int first, int last)
        {
            var len = (byte)(last - first+ 1);
            return Bits.extract(in data, (byte)first, len);

        }

        public byte this[Range range]
        {
            [MethodImpl(Inline)]
            get => Extract(range.Start.Value, range.End.Value);
        }

        public Bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => this[(byte)pos];
            [MethodImpl(Inline)]
            set => this[(byte)pos] = value;
        }


        [MethodImpl(Inline)]
        public void EnableBit(byte pos)
            => BitMask.enable(ref data, pos);

        [MethodImpl(Inline)]
        public void DisableBit(byte pos)
            => BitMask.disable(ref data, pos);

        [MethodImpl(Inline)]
        public bool TestBit(byte pos)
            => BitMask.test(in data, pos);

         [MethodImpl(Inline)]
        public BitString ToBitString()
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