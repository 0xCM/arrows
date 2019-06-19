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
    /// Defines a generic bitvector
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
        
        public Bit this[in BitPos pos]
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

        public T this[in BitPos pos, byte len]
        {
            [MethodImpl(Inline)]
            get => gbits.range(in data, in pos, len);
        }

        [MethodImpl(Inline)]
        public void Toggle(in BitPos pos)
            => gbits.toggle(ref data, in pos);

        [MethodImpl(Inline)]
        public void RotR(in int dist)
            => gbits.rotr(ref data, in dist);

        [MethodImpl(Inline)]
        public void RotL(in int dist)
            => gbits.rotl(ref data, in dist);

        [MethodImpl(Inline)]
        public void Enable(in BitPos pos)
            => gbits.enable(ref data, in pos);

        [MethodImpl(Inline)]
        public void Disable(in BitPos pos)
            => gbits.disable(ref data, in pos);

        [MethodImpl(Inline)]
        public bool Test(in BitPos pos)
            => gbits.test(in data, in pos);

        [MethodImpl(Inline)]
        public BitString BitString()
            => BitStringConvert.FromValue(in data);

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

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}