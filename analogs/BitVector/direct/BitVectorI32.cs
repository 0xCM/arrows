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

    public ref struct BitVectorI32
    {
        int data;

        [MethodImpl(Inline)]
        public BitVectorI32(in int data)
            => this.data = data;        


        [MethodImpl(Inline)]
        public static implicit operator BitVector<int>(in BitVectorI32 src)
            => new BitVector<int>(in src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVectorI32(in int src)
            => new BitVectorI32(in src);

        [MethodImpl(Inline)]
        public static BitVectorI32 Define(in int src)
            => new BitVectorI32(src);    

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVectorI32 lhs, in BitVectorI32 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVectorI32 lhs, in BitVectorI32 rhs)
            => !lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static BitVectorI32 operator |(in BitVectorI32 lhs, in BitVectorI32 rhs)
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorI32 operator &(in BitVectorI32 lhs, in BitVectorI32 rhs)
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorI32 operator ^(in BitVectorI32 lhs, in BitVectorI32 rhs)
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorI32 operator ~(in BitVectorI32 src)
            => ~ src.data;            

        [MethodImpl(Inline)]
        public static BitVectorI32 operator <<(in BitVectorI32 lhs, in int rhs)
            => lhs.data << rhs;

        [MethodImpl(Inline)]
        public static BitVectorI32 operator >>(in BitVectorI32 lhs, in int rhs)
            => lhs.data >> rhs;
        
        [MethodImpl(Inline)]
        public static BitVectorI32 operator +(in BitVectorI32 lhs, in BitVectorI32 rhs)
            => lhs.data + rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorI32 operator -(in BitVectorI32 lhs, in BitVectorI32 rhs)
            => lhs.data - rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorI32 operator *(in BitVectorI32 lhs, in BitVectorI32 rhs)
            => lhs.data * rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorI32 operator /(in BitVectorI32 lhs, in BitVectorI32 rhs)
            => lhs.data / rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorI32 operator %(in BitVectorI32 lhs, in BitVectorI32 rhs)
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static BitVectorI32 operator -(in BitVectorI32 src)
            => - src.data;            

        [MethodImpl(Inline)]
        public static implicit operator int(in BitVectorI32 src)
            => src.data;
    
        public Bit this[in BitPos pos]
        {
            [MethodImpl(Inline)]
            get => Bits.test(in data, pos);
            
            [MethodImpl(Inline)]
            set
            {
                if(value)
                    Bits.enable(ref data, pos);
                else
                     Bits.disable(ref data, pos);                    
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

        public BitVectorI16 Hi
        {
            [MethodImpl(Inline)]
            get => Bits.hi(in data);        
        }
        
        public BitVectorI16 Lo
        {
            [MethodImpl(Inline)]
            get => lo(in data);        
        }

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => bytes(in data);

        [MethodImpl(Inline)]
        public BitString BitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public ulong PopCount()
            => Bits.pop((uint)data) + (data < 0 ? 1ul : 0ul);

        [MethodImpl(Inline)]
        public bool Eq(in BitVectorI32 rhs)
            => data == rhs.data;

        
        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}