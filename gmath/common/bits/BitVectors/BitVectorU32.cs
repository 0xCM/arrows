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


    public struct BitVectorU32 : IEquatable<BitVectorU32>
    {
        uint data;

        [MethodImpl(Inline)]
        public BitVectorU32(uint data)
            => this.data = data;

        [MethodImpl(Inline)]
        public BitVectorU32(Bit[] src)
        {
            this.data = 0;
            for(var i = 0; i< Math.Min(32, src.Length); i++)
                if(src[i])
                    Bits.set(ref data, i);
        }


        public static readonly BitVectorU32 Zero = Define(0);

        [MethodImpl(Inline)]
        public static BitVectorU32 Define(uint src)
            => new BitVectorU32(src);    

        [MethodImpl(Inline)]
        public static BitVectorU32 Define(Bit[] src)
            => new BitVectorU32(src);    

        [MethodImpl(Inline)]
        public static implicit operator BitVectorU32(uint src)
            => new BitVectorU32(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(BitVectorU32 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static bool operator ==(BitVectorU32 lhs, BitVectorU32 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitVectorU32 lhs, BitVectorU32 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static BitVectorU32 operator |(BitVectorU32 lhs, BitVectorU32 rhs)
            => lhs.data.Or(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorU32 operator &(BitVectorU32 lhs, BitVectorU32 rhs)
            => lhs.data.And(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorU32 operator ^(BitVectorU32 lhs, BitVectorU32 rhs)
            => lhs.data.XOr(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorU32 operator ~(BitVectorU32 src)
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
        public byte[] Bytes()
            => Bits.bytes(data);

        [MethodImpl(Inline)]
        public Bit[] BitData()
            => Bits.bits(data);

        [MethodImpl(Inline)]
        public int PopCount()
            => (int)Bits.popcount(data);

        [MethodImpl(Inline)]
        public (BitVectorU16 x0, BitVectorU16 x1) Split()
        {
            (var hi, var lo) = Bits.split(data);
            return (hi, lo);
        }


        [MethodImpl(Inline)]
        public bool Equals(BitVectorU32 rhs)
            => data == rhs.data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override string ToString()
            => BitString();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }


}