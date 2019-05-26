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

    public ref struct BitVectorU128
    {        
        
        [MethodImpl(Inline)]
        public static BitVectorU128 Define(ulong x0, ulong x1)
            => new BitVectorU128(u128.Define(x0,x1));    

        public static BitVectorU128 Define(Span<Bit> src)
            => pack128(src);

        [MethodImpl(Inline)]
        public static bool operator ==(BitVectorU128 lhs, BitVectorU128 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitVectorU128 lhs, BitVectorU128 rhs)
            => !lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static BitVectorU128 operator |(BitVectorU128 lhs, BitVectorU128 rhs)
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorU128 operator &(BitVectorU128 lhs, BitVectorU128 rhs)
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorU128 operator ^(BitVectorU128 lhs, BitVectorU128 rhs)
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorU128 operator ~(BitVectorU128 src)
            => ~src;

        [MethodImpl(Inline)]
        public static implicit operator BitVectorU128(u128 src)
            => new BitVectorU128(src);

        [MethodImpl(Inline)]
        public static implicit operator u128(BitVectorU128 src)
            => src.data;

        [MethodImpl(Inline)]
        public BitVectorU128(u128 src)
            => this.data = src;
        
        u128 data;

        public Bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => data.TestBit(pos);
            
            [MethodImpl(Inline)]
            set
            {
                if(value)
                    data.EnableBit(pos);
                else
                    data.DisableBit(pos);
            }            
        }

        public Span<Bit> this[int first, int last]
        {
            [MethodImpl(Inline)]
            get => this.Bits().Slice(first, last - first + 1);
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
            => data.PopCount();

        public BitVectorU64 Hi
        {
            [MethodImpl(Inline)]
            get => data.x1;        
        }
        
        public BitVectorU64 Lo
        {
            [MethodImpl(Inline)]
            get => data.x0;
        
        }

        [MethodImpl(Inline)]
        public bool Eq(BitVectorU128 rhs)
            => data == rhs.data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public string Format()
            => BitString();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}