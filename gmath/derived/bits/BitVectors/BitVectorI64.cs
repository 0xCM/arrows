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
    using static Z0.Bits;

    public ref struct BitVectorI64
    {
        long data;

        [MethodImpl(Inline)]
        public BitVectorI64(long data)
            => this.data = data;

        [MethodImpl(Inline)]
        public static BitVectorI64 Define(long src)
            => new BitVectorI64(src);    

        [MethodImpl(Inline)]
        public static implicit operator BitVectorI64(long src)
            => new BitVectorI64(src);

        [MethodImpl(Inline)]
        public static implicit operator long(BitVectorI64 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static bool operator ==(BitVectorI64 lhs, BitVectorI64 rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator !=(BitVectorI64 lhs, BitVectorI64 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static BitVectorI64 operator |(BitVectorI64 lhs, BitVectorI64 rhs)
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorI64 operator &(BitVectorI64 lhs, BitVectorI64 rhs)
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorI64 operator ^(BitVectorI64 lhs, BitVectorI64 rhs)
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorI64 operator ~(BitVectorI64 src)
            => src.data.Flip();

        public Bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => test(data, pos);
            
            [MethodImpl(Inline)]
            set
            {
                if(value)
                    enable(ref data, pos);
                else
                    disable(data,pos);                    
            }            
        }

        [MethodImpl(Inline)]
        public bool TestBit(int index)
            => test(data,index);

        public BitVectorI32 Hi
        {
            [MethodImpl(Inline)]
            get => hi(data);        
        }
        
        public BitVectorI32 Lo
        {
            [MethodImpl(Inline)]
            get => lo(data);        
        }

        [MethodImpl(Inline)]
        public string BitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => data.ToBytes();

        [MethodImpl(Inline)]        
        public Span<Bit> BitData()
            => Bits.bits(data);

        [MethodImpl(Inline)]
        public int PopCount()
            => (int)pop((ulong)data) + (data < 0 ? 1 : 0);

        [MethodImpl(Inline)]
        public bool Equals(BitVectorI64 rhs)
            => data == rhs.data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override string ToString()
            => BitString();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }

}