//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;

    
    public readonly struct PrimOps<T> : 
        Additive<T>, 
        Multiplicative<T>, 
        Divisive<T>, 
        Negatable<T>, 
        Absolutive<T>, 
        Nullary<T>, 
        Unital<T>,
        Ordered<T>,
        Stepwise<T>,
        Bitwise<T>,
        Semigroup<T>
    {
        public static readonly PrimOps<T> Inhabitant = default;
        static readonly Additive<T> Additive = PrimOps.Additive.Operator<T>();

        static readonly Divisive<T> Divisive = PrimOps.Divisive.Operator<T>();

        static readonly Multiplicative<T> Multiplicative = PrimOps.Multiplicative.Operator<T>();

        static readonly Absolutive<T> Absolutive = PrimOps.Absolutive.Operator<T>();

        static readonly Subtractive<T> Subtractive = PrimOps.Subtractive.Operator<T>();

        static readonly Negatable<T> Negatable = PrimOps.Negatable.Operator<T>();

        static readonly Nullary<T> Nullary = PrimOps.Nullary.Operator<T>();

        static readonly Unital<T> Unital = PrimOps.Unital.Operator<T>();

        static readonly Ordered<T> Ordered = PrimOps.Ordered.Operator<T>();

        static readonly Stepwise<T> Stepwise = PrimOps.Stepwise.Operator<T>();

        static readonly Bitwise<T> Bitwise = PrimOps.Bitwise.Operator<T>();

        static readonly Semigroup<T> Equality = PrimOps.Equality.Operator<T>();

        public T zero
        {
            [MethodImpl(Inline)]
            get => Nullary.zero;
        }

        public T one
        {
            [MethodImpl(Inline)]
            get => Unital.one;
        }

        [MethodImpl(Inline)]
        public T add(T lhs, T rhs)
            => Additive.add(lhs,rhs);

        [MethodImpl(Inline)]
        public T mul(T lhs, T rhs)
            => Multiplicative.mul(lhs,rhs);

        [MethodImpl(Inline)]
        public T div(T lhs, T rhs)
            => Divisive.div(lhs,rhs);

        [MethodImpl(Inline)]
        public T mod(T lhs, T rhs)
            => Divisive.mod(lhs,rhs);

        [MethodImpl(Inline)]
        public Quorem<T> divrem(T lhs, T rhs)
            => Divisive.divrem(lhs,rhs);
        
        [MethodImpl(Inline)]
        public T gcd(T lhs, T rhs)
            => Divisive.gcd(lhs,rhs);

        [MethodImpl(Inline)]
        public T negate(T x)
            => Negatable.negate(x);

        [MethodImpl(Inline)]
        public T sub(T lhs, T rhs)
            => Subtractive.sub(lhs,rhs);

        [MethodImpl(Inline)]
        public T abs(T x)
            => Absolutive.abs(x);

        [MethodImpl(Inline)]
        public bool lt(T lhs, T rhs)
            => Ordered.lt(lhs,rhs);
 
        [MethodImpl(Inline)]
        public bool lteq(T lhs, T rhs)
            => Ordered.lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public bool gt(T lhs, T rhs)
            => Ordered.gt(lhs,rhs);

        [MethodImpl(Inline)]
        public bool gteq(T lhs, T rhs)
            => Ordered.gteq(lhs,rhs);

        [MethodImpl(Inline)]
        public T inc(T x)
            => Stepwise.inc(x);

        [MethodImpl(Inline)]
        public T dec(T x)
            => Stepwise.dec(x);

        [MethodImpl(Inline)]
        public T and(T lhs, T rhs)
            => Bitwise.and(lhs,rhs);
 
        [MethodImpl(Inline)]
        public T or(T lhs, T rhs)
            => Bitwise.or(lhs,rhs);

        [MethodImpl(Inline)]
        public T xor(T lhs, T rhs)
            => Bitwise.xor(lhs,rhs);

        [MethodImpl(Inline)]
        public T flip(T x)
            => Bitwise.flip(x);

        [MethodImpl(Inline)]
        public T lshift(T lhs, int rhs)
            => Bitwise.lshift(lhs,rhs);

        [MethodImpl(Inline)]
        public T rshift(T lhs, int rhs)
            => Bitwise.rshift(lhs,rhs);

        [MethodImpl(Inline)]
        public BitString bitstring(T x)
            => Bitwise.bitstring(x);

        [MethodImpl(Inline)]
        public bool eq(T lhs, T rhs)
            => Equality.eq(lhs,rhs);
 
        [MethodImpl(Inline)]
        public bool neq(T lhs, T rhs)
            => Equality.neq(lhs,rhs);
    }
}