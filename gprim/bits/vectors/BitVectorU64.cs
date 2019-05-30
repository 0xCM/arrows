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

    using static Bits;
    using static Bytes;

    using static zfunc;    
    using source = System.UInt64;

    public ref struct BitVectorU64
    {
        [MethodImpl(Inline)]
        public static implicit operator BitVector<ulong>(in BitVectorU64 src)
            => new BitVector<ulong>(in src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N64,ulong>(in BitVectorU64 src)
            => NatBits.Define(in src.data);

        ulong data;

        const int BitSize = 64;

        [MethodImpl(Inline)]
        public BitVectorU64(in source data)
            => this.data = data;

        [MethodImpl(Inline)]
        public BitVectorU64(in Bit[] src)
        {
            this.data = 0;
            for(var i = 0; i< Math.Min(BitSize, src.Length); i++)
                if(src[i])
                    enable(ref data, i);
        }

        [MethodImpl(Inline)]
        public static BitVectorU64 Define(in ReadOnlySpan<Bit> src)
            => Define(in bitpack(src, out source data));

        [MethodImpl(Inline)]
        public static BitVectorU64 Define(in source src)
            => new BitVectorU64(src);    

        [MethodImpl(Inline)]
        public static implicit operator BitVectorU64(in source src)
            => new BitVectorU64(src);

        [MethodImpl(Inline)]
        public static implicit operator source(in BitVectorU64 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVectorU64 lhs, in BitVectorU64 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVectorU64 lhs, in BitVectorU64 rhs)
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        public static BitVectorU64 operator |(in BitVectorU64 lhs, in BitVectorU64 rhs)
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorU64 operator &(in BitVectorU64 lhs, in BitVectorU64 rhs)
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorU64 operator ^(in BitVectorU64 lhs, in BitVectorU64 rhs)
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorU64 operator ~(in BitVectorU64 src)
            => ~src.data;

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

        public int BitCount
        {
            [MethodImpl(Inline)]
            get => BitSize;
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
        public string BitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => bytes(data);


        [MethodImpl(Inline)]
        public int PopCount()
            => (int)pop(data);
        
        [MethodImpl(Inline)]
        public ulong Nlz()
            => nlz(data);

        [MethodImpl(Inline)]
        public ulong Ntz()
            => ntz(data);

        [MethodImpl(Inline)]
        public bool Eq(in BitVectorU64 rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public bool NEq(in BitVectorU64 rhs)
            => data != rhs.data;


        [MethodImpl(Inline)]
        public string Format()
            => BitString();

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}