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

    public struct BitVectorI16
    {
        [MethodImpl(Inline)]
        public static implicit operator BitVectorI16(short src)
            => new BitVectorI16(src);

        [MethodImpl(Inline)]
        public static implicit operator short(BitVectorI16 src)
            => src.data;

        [MethodImpl(Inline)]
        public BitVectorI16(short data)
            => this.data = data;
        
        short data;
        
        [MethodImpl(Inline)]
        public static BitVectorI16 Define(short src)
            => new BitVectorI16(src);    

        [MethodImpl(Inline)]
        public static bool operator ==(BitVectorI16 lhs, BitVectorI16 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitVectorI16 lhs, BitVectorI16 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static BitVectorI16 operator |(BitVectorI16 lhs, BitVectorI16 rhs)
            => lhs.data.Or(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorI16 operator &(BitVectorI16 lhs, BitVectorI16 rhs)
            => lhs.data.And(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorI16 operator ^(BitVectorI16 lhs, BitVectorI16 rhs)
            => lhs.data.XOr(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorI16 operator ~(BitVectorI16 src)
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
                    disable(data, pos);                    
            }            
        }

        public BitVectorI8 Hi
        {
            [MethodImpl(Inline)]
            get => hi(data);        
        }
        
        public BitVectorI8 Lo
        {
            [MethodImpl(Inline)]
            get => lo(data);        
        }

        [MethodImpl(Inline)]
        public bool IsSet(int index)
            => test(data, index);

        [MethodImpl(Inline)]
        public string BitString()
            => bitstring(data);

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => bytes(data);

        [MethodImpl(Inline)]
        public Span<Bit> Bits()
            => bits(data);

        [MethodImpl(Inline)]
        public int PopCount()
            => (int)pop((uint)data) + (data < 0 ? 1 : 0);

        [MethodImpl(Inline)]
        public bool Equals(BitVectorI16 rhs)
            => data == rhs.data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override string ToString()
            => BitString();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}