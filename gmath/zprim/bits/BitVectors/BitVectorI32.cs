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
    using static Bytes;

    public ref struct BitVectorI32
    {
        int data;
        
        [MethodImpl(Inline)]
        public static BitVectorI32 Define(in int src)
            => new BitVectorI32(src);    

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N32>(in BitVectorI32 src)
            => BitVector.Define(in src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVectorI32(in int src)
            => new BitVectorI32(in src);

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

        [MethodImpl(Inline)]
        public BitVectorI32(in int data)
            => this.data = data;
        

        public Bit this[in int pos]
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
        public string BitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public ulong PopCount()
            => Bits.pop((uint)data) + (data < 0 ? 1ul : 0ul);

        [MethodImpl(Inline)]
        public bool Eq(in BitVectorI32 rhs)
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