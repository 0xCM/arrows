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
    using static mfunc;

    public ref struct BitVectorI128
    {        
        
        [MethodImpl(Inline)]
        public static BitVectorI128 Define(long x0, long x1)
            => new BitVectorI128(i128.Define(x0,x1));    

        [MethodImpl(Inline)]
        public static bool operator ==(BitVectorI128 lhs, BitVectorI128 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitVectorI128 lhs, BitVectorI128 rhs)
            => !lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static BitVectorI128 operator |(BitVectorI128 lhs, BitVectorI128 rhs)
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorI128 operator &(BitVectorI128 lhs, BitVectorI128 rhs)
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorI128 operator ^(BitVectorI128 lhs, BitVectorI128 rhs)
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorI128 operator ~(BitVectorI128 src)
            => ~src;

        [MethodImpl(Inline)]
        public static implicit operator BitVectorI128(i128 src)
            => new BitVectorI128(src);

        [MethodImpl(Inline)]
        public static implicit operator i128(BitVectorI128 src)
            => src.data;

        [MethodImpl(Inline)]
        public BitVectorI128(i128 src)
            => this.data = src;
        
        i128 data;

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
        public bool IsSet(int pos)
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

        public BitVectorI64 Hi
        {
            [MethodImpl(Inline)]
            get => data.x1;        
        }
        
        public BitVectorI64 Lo
        {
            [MethodImpl(Inline)]
            get => data.x0;       
        }

        [MethodImpl(Inline)]
        public bool Eq(BitVectorI128 rhs)
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