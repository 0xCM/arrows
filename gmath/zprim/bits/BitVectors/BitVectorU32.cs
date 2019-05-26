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
    using static Bits;
    using static Bytes;

    public ref struct BitVectorU32
    {
        uint data;

        const int BitSize = 32;

        [MethodImpl(Inline)]
        public BitVectorU32(in uint data)
            => this.data = data;

        [MethodImpl(Inline)]
        public BitVectorU32(in Bit[] src)
        {
            this.data = 0;
            for(var i = 0; i< Math.Min(BitSize, src.Length); i++)
                if(src[i])
                    enable(ref data, i);
        }

        [MethodImpl(Inline)]
        public static BitVectorU32 Define(in uint src)
            => new BitVectorU32(src);    

        [MethodImpl(Inline)]
        public static BitVectorU32 Define(in ReadOnlySpan<Bit> src)
            => Define(in bitpack(src, out uint dst));

        [MethodImpl(Inline)]
        public static implicit operator BitVectorU32(uint src)
            => new BitVectorU32(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(in BitVectorU32 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVectorU32 lhs, in BitVectorU32 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVectorU32 lhs, in BitVectorU32 rhs)
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        public static BitVectorU32 operator |(in BitVectorU32 lhs, in BitVectorU32 rhs)
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorU32 operator &(in BitVectorU32 lhs, in BitVectorU32 rhs)
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorU32 operator ^(in BitVectorU32 lhs, in BitVectorU32 rhs)
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorU32 operator ~(in BitVectorU32 src)
            => ~src.data;

        public Bit this[in int pos]
        {
            [MethodImpl(Inline)]
            get => test(data, in pos);
            
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

        public BitVectorU16 Hi
        {
            [MethodImpl(Inline)]
            get => hi(data);        
        }
        
        public BitVectorU16 Lo
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
        public string Format()
            => BitString();

        [MethodImpl(Inline)]
        public bool Eq(in BitVectorU32 rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public bool NEq(in BitVectorU32 rhs)
            => data != rhs.data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}