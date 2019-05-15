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

        public static readonly BitVectorI16 Zero = Define(0);
        
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
            get => Bits.test(data, pos);
            
            [MethodImpl(Inline)]
            set
            {
                if(value)
                    Bits.set(ref data, pos);
                else
                     Bits.unset(data,pos);                    
            }
            
        }

        [MethodImpl(Inline)]
        public bool IsSet(int index)
            => Bits.test(data,index);

        [MethodImpl(Inline)]
        public string BitString()
            => Bits.bitstring(data);

        [MethodImpl(Inline)]
        public Bit[] BitData()
            => Bits.bits(data);

        [MethodImpl(Inline)]
        public int PopCount()
            => (int)Bits.pop((uint)data) + (data < 0 ? 1 : 0);

        [MethodImpl(Inline)]
        public (BitVectorI8 x0, BitVectorI8 x1) Split()
            => Bits.split(data);

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