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

    public ref struct BitVectorU16
    {
        ushort data;

        [MethodImpl(Inline)]
        public BitVectorU16(in ushort data)
            => this.data = data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector<ushort>(in BitVectorU16 src)
            => new BitVector<ushort>(in src.data);


        [MethodImpl(Inline)]
        public static BitVectorU16 Define(in ushort src)
            => new BitVectorU16(src);    

        [MethodImpl(Inline)]
        public static BitVectorU16 Define(in ReadOnlySpan<Bit> src)
            => Define(in pack(src, out ushort dst));

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

        public Bit this[in BitPos pos]
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
        public void EnableBit(in BitPos pos)
            => enable(ref data, in pos);

        [MethodImpl(Inline)]
        public void DisableBit(in BitPos pos)
            => disable(ref data, in pos);

        [MethodImpl(Inline)]
        public bool TestBit(in BitPos pos)
            => test(in data, in pos);

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
        public BitString BitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => bytes(data);

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
        public bool Eq(in BitVectorU16 rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public bool NEq(in BitVectorU16 rhs)
            => data != rhs.data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }

}