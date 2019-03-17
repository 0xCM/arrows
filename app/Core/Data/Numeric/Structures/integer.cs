//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;    
    using C = Contracts;

    using static corefunc;
    using static MathOps;

    /// <summary>
    /// Represents an integer predicated on (and constrained by) an underlying type
    /// </summary>
    public readonly struct integer<T> : C.SignedInt<integer<T>,T> 
        where T : new()
    {
        static readonly C.SignedInt<T> ops 
            = MathOps.signedint<T>();

        public static readonly integer<T> Zero = ops.zero;

        public static readonly integer<T> One = ops.one;

        public static implicit operator integer<T>(T src)
            => new integer<T>(src);

        public static implicit operator T(integer<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static integer<T> operator + (integer<T> a, integer<T> b) 
            => ops.add(a.data, b.data);

        [MethodImpl(Inline)]
        public static integer<T> operator - (integer<T> a, integer<T> b) 
            => ops.sub(a.data, b.data);

        [MethodImpl(Inline)]
        public static integer<T> operator * (integer<T> a, integer<T> b) 
            => ops.mul(a.data, b.data);

        [MethodImpl(Inline)]
        public static QR<integer<T>> operator / (integer<T> a, integer<T> b) 
            => map(ops.divrem(a.data, b.data), q => new QR<integer<T>>(q.q, q.r));

        [MethodImpl(Inline)]
        public static integer<T> operator & (integer<T> a, integer<T> b) 
            => ops.and(a,b);

        [MethodImpl(Inline)]
        public static integer<T> operator | (integer<T> a, integer<T> b) 
            => ops.or(a,b);

        [MethodImpl(Inline)]
        public static integer<T> operator ^ (integer<T> a, integer<T> b) 
            => ops.xor(a,b);

        [MethodImpl(Inline)]
        public static integer<T> operator ~ (integer<T> a) 
            => ops.flip(a);

        [MethodImpl(Inline)]
        public static integer<T> operator >> (integer<T> a, int shift) 
            => ops.rshift(a, shift);

        [MethodImpl(Inline)]
        public static integer<T> operator << (integer<T> a, int shift) 
            => ops.lshift(a, shift);

        public T data {get;}

        public integer<T> zero => Zero;

        public integer<T> one => One;

        [MethodImpl(Inline)]
        public Sign sign() 
            => ops.sign(data);

        public integer (T n) 
            => data = n;

        [MethodImpl(Inline)]
        public integer<T> dec() 
            => ops.dec(data);

        [MethodImpl(Inline)]
        public integer<T> add(integer<T> rhs)
            => ops.add(data, rhs);
        
        [MethodImpl(Inline)]
        public integer<T> sub(integer<T> rhs)
            => ops.sub(data,rhs);

        [MethodImpl(Inline)]
        public integer<T> mul(integer<T> rhs)
            => ops.mul(data,rhs);

        [MethodImpl(Inline)]
        public QR<integer<T>> div(integer<T> rhs)
            => this / rhs;

        [MethodImpl(Inline)]
        public integer<T> and(integer<T> rhs)
            => ops.and(data,rhs);

        [MethodImpl(Inline)]
        public integer<T> or(integer<T> rhs)
            => ops.or(data,rhs);

        [MethodImpl(Inline)]
        public integer<T> xor(integer<T> rhs)
            => ops.xor(data,rhs);

        [MethodImpl(Inline)]
        public integer<T> flip()
            => ops.flip(data);

        [MethodImpl(Inline)]
        public integer<T> lshift(int rhs)
            => ops.lshift(data, rhs);

        [MethodImpl(Inline)]
        public bool eq(integer<T> rhs)
            => ops.eq(this,rhs);

        [MethodImpl(Inline)]
        public bool neq(integer<T> rhs)
            => ops.neq(data,rhs);

        [MethodImpl(Inline)]
        public integer<T> rshift(int rhs)
            => ops.rshift(data, rhs);
 
        [MethodImpl(Inline)]
        public bool lteq(integer<T> rhs) 
            => ops.lteq(this, rhs);

        [MethodImpl(Inline)]
        public bool gteq(integer<T> rhs) 
            => ops.gteq(this, rhs);

        [MethodImpl(Inline)]
        public bool lt(integer<T> rhs) 
            => ops.lt(this, rhs);

        [MethodImpl(Inline)]
        public bool gt(integer<T> rhs) 
            => ops.gt(this, rhs);

        [MethodImpl(Inline)]
        public integer<T> abs()
            => ops.abs(data);

        [MethodImpl(Inline)]
        public integer<T> inc()
            =>  ops.inc(data);

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => data.ToString();

        public int CompareTo(integer<T> other)
            => throw new NotImplementedException();

    }
}