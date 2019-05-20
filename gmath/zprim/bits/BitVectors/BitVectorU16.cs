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


    public ref struct BitVectorU16
    {
        ushort data;

        [MethodImpl(Inline)]
        public BitVectorU16(in ushort data)
            => this.data = data;

        [MethodImpl(Inline)]
        public static BitVectorU16 Define(
            in Bit x00, in Bit x01, in Bit x02, in Bit x03, 
            in Bit x04, in Bit x05, in Bit x06, in Bit x07,
            in Bit x08, in Bit x09, in Bit x10, in Bit x11, 
            in Bit x12, in Bit x13, in Bit x14, in Bit x15)
                => Bits.pack16(
                    x00, x01, x02, x03, 
                    x04, x05, x06, x07, 
                    x08, x09, x10, x11, 
                    x12, x13, x14, x15);

        [MethodImpl(Inline)]
        public static BitVectorU16 Define(in ushort src)
            => new BitVectorU16(src);    

        [MethodImpl(Inline)]
        public static BitVectorU16 Define(in ReadOnlySpan<Bit> src)
            => Define(in bitpack(src, out ushort dst));

        [MethodImpl(Inline)]
        public static implicit operator BitVectorU16(in ushort src)
            => new BitVectorU16(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(in BitVectorU16 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVectorU16 lhs, in BitVectorU16 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVectorU16 lhs, in BitVectorU16 rhs)
            => !lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static BitVectorU16 operator |(in BitVectorU16 lhs, in BitVectorU16 rhs)
            => Define((ushort)(lhs.data | rhs.data));

        [MethodImpl(Inline)]
        public static BitVectorU16 operator &(in BitVectorU16 lhs, in BitVectorU16 rhs)
            => Define((ushort)(lhs.data & rhs.data));

        [MethodImpl(Inline)]
        public static BitVectorU16 operator ^(in BitVectorU16 lhs, in BitVectorU16 rhs)
            => Define((ushort)(lhs.data ^ rhs.data));

        [MethodImpl(Inline)]
        public static BitVectorU16 operator ~(in BitVectorU16 src)
            => Define((ushort) ~ src.data);

        public Bit this[in int pos]
        {
            [MethodImpl(Inline)]
            get => Bits.test(in data, in pos);
            
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

        public BitVectorU8 Hi
        {
            [MethodImpl(Inline)]
            get => hi(in data);        
        }
        
        public BitVectorU8 Lo
        {
            [MethodImpl(Inline)]
            get => lo(in data);        
        }

        [MethodImpl(Inline)]
        public string BitString()
            => bitstring(data);

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => bytes(data);

        [MethodImpl(Inline)]
        public Span<Bit> BitData()
            => bitspan(data);

        [MethodImpl(Inline)]
        public int PopCount()
            => pop(data);

        [MethodImpl(Inline)]
        public bool Eq(in BitVectorU16 rhs)
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