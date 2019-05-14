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



    public struct BitVectorU16
    {
        ushort data;

        [MethodImpl(Inline)]
        public BitVectorU16(ushort data)
            => this.data = data;

        public static readonly BitVectorU16 Zero = Define(0);

        [MethodImpl(Inline)]
        public static BitVectorU16 Define(Bit x00, Bit x01, Bit x02, Bit x03, Bit x04, Bit x05, Bit x06, Bit x07,
            Bit x08, Bit x09, Bit x10, Bit x11, Bit x12, Bit x13, Bit x14, Bit x15)
            => Bits.bitpack(x00, x01, x02, x03, x04, x05, x06, x07, x08, x09, x10, x11, x12, x13, x14, x15);

        [MethodImpl(Inline)]
        public static BitVectorU16 Define(ushort src)
            => new BitVectorU16(src);    

        [MethodImpl(Inline)]
        public static implicit operator BitVectorU16(ushort src)
            => new BitVectorU16(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(BitVectorU16 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static bool operator ==(BitVectorU16 lhs, BitVectorU16 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitVectorU16 lhs, BitVectorU16 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static BitVectorU16 operator |(BitVectorU16 lhs, BitVectorU16 rhs)
            => lhs.data.Or(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorU16 operator &(BitVectorU16 lhs, BitVectorU16 rhs)
            => lhs.data.And(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorU16 operator ^(BitVectorU16 lhs, BitVectorU16 rhs)
            => lhs.data.XOr(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorU16 operator ~(BitVectorU16 src)
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
            => (int)Bits.pop(data);

        [MethodImpl(Inline)]
        public (BitVectorU8 x0, BitVectorU8 x1) Split()
            => Bits.split(data);


        [MethodImpl(Inline)]
        public bool Equals(BitVectorU16 rhs)
            => data == rhs.data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override string ToString()
            => BitString();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }

}