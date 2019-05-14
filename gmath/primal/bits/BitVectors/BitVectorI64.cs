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


    public struct BitVectorI64 : IEquatable<BitVectorI64>
    {
        long data;

        [MethodImpl(Inline)]
        public BitVectorI64(long data)
            => this.data = data;

        public static readonly BitVectorI64 Zero = Define(0);

        [MethodImpl(Inline)]
        public static BitVectorI64 Define(long src)
            => new BitVectorI64(src);    

        [MethodImpl(Inline)]
        public static implicit operator BitVectorI64(long src)
            => new BitVectorI64(src);

        [MethodImpl(Inline)]
        public static implicit operator long(BitVectorI64 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static bool operator ==(BitVectorI64 lhs, BitVectorI64 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitVectorI64 lhs, BitVectorI64 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static BitVectorI64 operator |(BitVectorI64 lhs, BitVectorI64 rhs)
            => lhs.data.Or(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorI64 operator &(BitVectorI64 lhs, BitVectorI64 rhs)
            => lhs.data.And(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorI64 operator ^(BitVectorI64 lhs, BitVectorI64 rhs)
            => lhs.data.XOr(rhs.data);

        [MethodImpl(Inline)]
        public static BitVectorI64 operator ~(BitVectorI64 src)
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
        public (BitVectorI32 x0, BitVectorI32 x1) Split()
            => Bits.split(data);

        [MethodImpl(Inline)]
        public string BitString()
            => Bits.bitstring(data);

        [MethodImpl(Inline)]
        public Bit[] BitData()
            => Bits.bits(data);

        [MethodImpl(Inline)]
        public int PopCount()
            => (int)Bits.pop((ulong)data) + (data < 0 ? 1 : 0);

        [MethodImpl(Inline)]
        public bool Equals(BitVectorI64 rhs)
            => data == rhs.data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override string ToString()
            => BitString();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }


}