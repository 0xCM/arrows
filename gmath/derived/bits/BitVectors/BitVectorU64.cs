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

    public ref struct BitVectorU64
    {
        
        [MethodImpl(Inline)]
        public static BitVectorU64 Define(ulong src)
            => new BitVectorU64(src);    

        [MethodImpl(Inline)]
        public static BitVectorU64 Define(Span<Bit> src)
            => pack64(src);

        [MethodImpl(Inline)]
        public static bool operator ==(BitVectorU64 lhs, BitVectorU64 rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator !=(BitVectorU64 lhs, BitVectorU64 rhs)
            => lhs.data != rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorU64 operator |(BitVectorU64 lhs, BitVectorU64 rhs)
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorU64 operator &(BitVectorU64 lhs, BitVectorU64 rhs)
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorU64 operator ^(BitVectorU64 lhs, BitVectorU64 rhs)
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorU64 operator ~(BitVectorU64 src)
            => ~ src.data;

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
            get => Z0.Bits.test((float)data, pos);
            
            [MethodImpl(Inline)]
            set
            {
                if(value)
                    enable(ref data, pos);
                else
                     disable(data,pos);                    
            }            
        }

        public BitVectorU32 Hi
        {
            [MethodImpl(Inline)]
            get => hi(data);        
        }
        
        public BitVectorU32 Lo
        {
            [MethodImpl(Inline)]
            get => lo(data);        
        }

        [MethodImpl(Inline)]
        public bool TestBit(int pos)
            => data.TestBit(pos);

        [MethodImpl(Inline)]
        public string BitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => data.ToBytes();

        [MethodImpl(Inline)]
        public Span<Bit> Bits()
            => data.ToBits();

        [MethodImpl(Inline)]
        public int PopCount()
            => (int)pop(data);

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