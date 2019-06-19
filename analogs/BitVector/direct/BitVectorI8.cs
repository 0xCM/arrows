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

    public ref struct BitVectorI8 
    {
        sbyte data;

        [MethodImpl(Inline)]
        public BitVectorI8(in sbyte data)
            => this.data = data;

        [MethodImpl(Inline)]
        public static implicit operator BitVectorI8(in sbyte src)
            => new BitVectorI8(src);

        [MethodImpl(Inline)]
        public static implicit operator sbyte(in BitVectorI8 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static implicit operator BitVector<sbyte>(in BitVectorI8 src)
            => new BitVector<sbyte>(in src.data);


        [MethodImpl(Inline)]
        public static BitVectorI8 Define(in sbyte src)
            => new BitVectorI8(src);


        [MethodImpl(Inline)]
        public static bool operator ==(in BitVectorI8 lhs, in BitVectorI8 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVectorI8 lhs, in BitVectorI8 rhs)
            => !lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static BitVectorI8 operator |(in BitVectorI8 lhs, in BitVectorI8 rhs)
            => Define((sbyte)(lhs.data | rhs.data));

        [MethodImpl(Inline)]
        public static BitVectorI8 operator &(in BitVectorI8 lhs, in BitVectorI8 rhs)
            => Define((sbyte)(lhs.data & rhs.data));

        [MethodImpl(Inline)]
        public static BitVectorI8 operator ^(in BitVectorI8 lhs, in BitVectorI8 rhs)
            => Define((sbyte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline)]
        public static BitVectorI8 operator ~(in BitVectorI8 src)
            => Define((sbyte) ~ src.data);

        public Bit this[in BitPos index]
        {
            [MethodImpl(Inline)]
            get => test(in data, in index);
            
            [MethodImpl(Inline)]
            set
            {
                if(value) 
                    enable(ref data, in index); 
                else 
                    disable(ref data, in index);
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

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            =>  bytes(in data);

        [MethodImpl(Inline)]
        public BitString BitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public ulong PopCount()
            => pop((uint)data) + (data < 0 ? 1ul : 0ul);

        [MethodImpl(Inline)]
        public bool Eq(in BitVectorI8 rhs)
            => data == rhs.data;



        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}