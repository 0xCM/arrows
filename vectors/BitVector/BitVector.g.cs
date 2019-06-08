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

    using static Bits;
    using static Bytes;

    using static zfunc;    

    /// <summary>
    /// Defines a bitvector over a single data component
    /// </summary>
    public ref struct BitVector<T>
        where T : struct
    {
        T data;

        public static readonly int BitCount = SizeOf<T>.BitSize;

        public static readonly int DataSize = SizeOf<T>.Size;

        [MethodImpl(Inline)]
        public BitVector(in T data)
            => this.data = data;

        [MethodImpl(Inline)]
        public static BitVector<T> Define(in T src)
            => new BitVector<T>(src);    

        [MethodImpl(Inline)]
        public static implicit operator BitVector<T>(in T src)
            => new BitVector<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(in BitVector<T> src)
            => src.data;        

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector<T> lhs, in BitVector<T> rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector<T> lhs, in BitVector<T> rhs)
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        public static BitVector<T> operator |(in BitVector<T> lhs, in BitVector<T> rhs)
            => gmath.or(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static BitVector<T> operator &(in BitVector<T> lhs, in BitVector<T> rhs)
            => gmath.and(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static BitVector<T> operator ^(in BitVector<T> lhs, in BitVector<T> rhs)
            => gmath.xor(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static BitVector<T> operator ~(in BitVector<T> src)
            => gmath.flip(src.data);
        
        public Bit this[in int pos]
        {
            [MethodImpl(Inline)]
            get => gbits.test(in data, in pos);
            
            [MethodImpl(Inline)]
            set
            {
                if(value)
                    gbits.enable(ref data, in pos);
                else
                    gbits.disable(ref data, in pos);                    
            }            
        }

        [MethodImpl(Inline)]
        public void Toggle(in int pos)
            => gbits.toggle(ref data, in pos);

        [MethodImpl(Inline)]
        public void RotR(in int pos)
            => gbits.rotr(ref data, in pos);

        [MethodImpl(Inline)]
        public void RotL(in int pos)
            => gbits.rotl(ref data, in pos);

        [MethodImpl(Inline)]
        public void Enable(in int pos)
            => gbits.enable(ref data, in pos);

        [MethodImpl(Inline)]
        public void Disable(in int pos)
            => gbits.disable(ref data, in pos);

        [MethodImpl(Inline)]
        public bool Test(in int pos)
            => gbits.test(in data, in pos);

        [MethodImpl(Inline)]
        public string BitString()
            => gbits.bitstring(in data);

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => bytes(in data);

        [MethodImpl(Inline)]
        public ulong Pop()
            => gbits.pop(data);
        
        [MethodImpl(Inline)]
        public ulong Nlz()
            => gbits.nlz(in data);

        [MethodImpl(Inline)]
        public ulong Ntz()
            => gbits.ntz(in data);

        [MethodImpl(Inline)]
        public bool Eq(in BitVector<T> rhs)
            => gmath.eq(data, rhs.data);

        [MethodImpl(Inline)]
        public bool NEq(in BitVector<T> rhs)
            => gmath.neq(data, rhs.data);

        [MethodImpl(Inline)]
        public string Format()
            => BitString();

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}