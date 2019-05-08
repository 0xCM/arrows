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


    public struct BitVectorI32 : IEquatable<BitVectorI32>
    {

        public static readonly BitVectorI32 Zero = Define(0);
        
        [MethodImpl(Inline)]
        public static BitVectorI32 Define(int src)
            => new BitVectorI32(src);    

        [MethodImpl(Inline)]
        public static bool operator ==(BitVectorI32 lhs, BitVectorI32 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitVectorI32 lhs, BitVectorI32 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static BitVectorI32 operator |(BitVectorI32 lhs, BitVectorI32 rhs)
            => lhs.data.Or(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorI32 operator &(BitVectorI32 lhs, BitVectorI32 rhs)
            => lhs.data.And(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorI32 operator ^(BitVectorI32 lhs, BitVectorI32 rhs)
            => lhs.data.XOr(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorI32 operator ~(BitVectorI32 src)
            => src.data.Flip();

        [MethodImpl(Inline)]
        public static implicit operator BitVectorI32(int src)
            => new BitVectorI32(src);

        [MethodImpl(Inline)]
        public static implicit operator int(BitVectorI32 src)
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
            => (int)Bits.popcount((uint)data) + (data < 0 ? 1 : 0);

        [MethodImpl(Inline)]
        public (BitVectorI16 x0, BitVectorI16 x1) Split()
            => Bits.split(data);

        [MethodImpl(Inline)]
        public bool Equals(BitVectorI32 rhs)
            => data == rhs.data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override string ToString()
            => BitString();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }


}