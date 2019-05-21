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
    using static Bits;
    using static Bytes;

    public ref struct BitVectorU8
    {
        byte data;

        [MethodImpl(Inline)]
        public BitVectorU8(in byte data)
            => this.data = data;
        
        const int BitSize = 8;

        [MethodImpl(Inline)]
        public static implicit operator BitVectorU8(in byte src)
            => new BitVectorU8(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(in BitVectorU8 src)
            => src.data;

        [MethodImpl(Inline)]
        public static BitVectorU8 Define(in byte src)
            => new BitVectorU8(src);

        public static BitVectorU8 Define(in ReadOnlySpan<Bit> src)
            => Define(in bitpack(src, out byte dst));

        [MethodImpl(Inline)]
        public static BitVectorU8 Define(
            in Bit x00, in Bit x01, in Bit x02, in Bit x03, 
            in Bit x04, in Bit x05, in Bit x06, in Bit x07)
                => Bits.pack8(
                    x00, x01, x02, x03, 
                    x04, x05, x06, x07);

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVectorU8 lhs, in BitVectorU8 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVectorU8 lhs, in BitVectorU8 rhs)
            => !lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static BitVectorU8 operator |(in BitVectorU8 lhs, in BitVectorU8 rhs)
            => Define((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline)]
        public static BitVectorU8 operator &(in BitVectorU8 lhs, in BitVectorU8 rhs)
            => Define((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline)]
        public static BitVectorU8 operator ^(in BitVectorU8 lhs, in BitVectorU8 rhs)
            => Define((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline)]
        public static BitVectorU8 operator ~(in BitVectorU8 src)
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
        public ref Bit TestBit(in int pos, out Bit dst)
        {
            test(in data, in pos, out dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public string BitString()
            => bitstring(data);

        [MethodImpl(Inline)]
        public Span<Bit> BitData()
            => bitspan(data);

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            =>  bytes(in data);

        [MethodImpl(Inline)]
        public ulong PopCount()
            => pop(data);

        [MethodImpl(Inline)]
        public bool Eq(in BitVectorU8 rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public string Format()
            => BitString();
 
        public override bool Equals(object obj)
            => throw new NotSupportedException();
       
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}