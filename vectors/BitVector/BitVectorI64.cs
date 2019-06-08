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

    public ref struct BitVectorI64
    {
        long data;

        [MethodImpl(Inline)]
        public BitVectorI64(long data)
            => this.data = data;

        [MethodImpl(Inline)]
        public static implicit operator BitVectorI64(in long src)
            => new BitVectorI64(src);

        [MethodImpl(Inline)]
        public static implicit operator BitVector<long>(in BitVectorI64 src)
            => new BitVector<long>(in src.data);

        [MethodImpl(Inline)]
        public static implicit operator long(in BitVectorI64 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static BitVectorI64 Define(long src)
            => new BitVectorI64(src);    

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVectorI64 lhs, in BitVectorI64 rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVectorI64 lhs, in BitVectorI64 rhs)
            => !lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static BitVectorI64 operator |(in BitVectorI64 lhs, in BitVectorI64 rhs)
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorI64 operator &(in BitVectorI64 lhs, in BitVectorI64 rhs)
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorI64 operator ^(in BitVectorI64 lhs, in BitVectorI64 rhs)
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorI64 operator ~(in BitVectorI64 src)
            => ~ src.data;

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
                    disable(ref data, pos);                    
            }            
        }

        [MethodImpl(Inline)]
        public bool TestBit(in int pos)
            => test(in data, in pos);

        [MethodImpl(Inline)]
        public void EnableBit(in int pos)
            => enable(ref data, in pos);

        [MethodImpl(Inline)]
        public void DisableBit(in int pos)
            => disable(ref data, in pos);
            
        public BitVectorI32 Hi
        {
            [MethodImpl(Inline)]
            get => hi(in data);        
        }
        
        public BitVectorI32 Lo
        {
            [MethodImpl(Inline)]
            get => lo(in data);        
        }

        [MethodImpl(Inline)]
        public string BitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => bytes(in data);

        [MethodImpl(Inline)]
        public int PopCount()
            => (int)pop((ulong)data) + (data < 0 ? 1 : 0);

        [MethodImpl(Inline)]
        public bool Eq(BitVectorI64 rhs)
            => data == rhs.data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}