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

    public ref struct BitVectorI32
    {
        
        [MethodImpl(Inline)]
        public static BitVectorI32 Define(int src)
            => new BitVectorI32(src);    

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N32>(BitVectorI32 src)
            => BitVector.Define(src.data);

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVectorI32 lhs, in BitVectorI32 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVectorI32 lhs, in BitVectorI32 rhs)
            => !lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static BitVectorI32 operator |(BitVectorI32 lhs, in BitVectorI32 rhs)
            => lhs.data.Or(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorI32 operator &(BitVectorI32 lhs, in BitVectorI32 rhs)
            => lhs.data.And(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorI32 operator ^(BitVectorI32 lhs, in BitVectorI32 rhs)
            => lhs.data.XOr(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorI32 operator ~(BitVectorI32 src)
            => src.data.Flip();

        [MethodImpl(Inline)]
        public static implicit operator BitVectorI32(int src)
            => new BitVectorI32(src);

        [MethodImpl(Inline)]
        public static implicit operator int(in BitVectorI32 src)
            => src.data;

        [MethodImpl(Inline)]
        public BitVectorI32(int data)
            => this.data = data;
        
        int data;

        public Bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => Bits.test(data, pos);
            
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
            get => Bits.hi(data);
        
        }
        
        public BitVectorI16 Lo
        {
            [MethodImpl(Inline)]
            get => Bits.lo(data);        
        }

        [MethodImpl(Inline)]
        public string BitString()
            => Bits.bitstring(data);

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => Bits.bytes(data);

        [MethodImpl(Inline)]
        public Span<Bit> BitData()
            => Bits.bitspan(data);

        [MethodImpl(Inline)]
        public int PopCount()
            => (int)Bits.pop((uint)data) + (data < 0 ? 1 : 0);


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