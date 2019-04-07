//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;
    using Primal = PrimOps.Reify;

    public readonly struct PrimOps<T> : Operative.PrimOps<T>
    {
        public static readonly PrimOps<T> Inhabitant = default;
        static readonly Operative.Additive<T> Additive = Primal.Additive.Operator<T>();

        static readonly Operative.Divisive<T> Divisive = Primal.Divisive.Operator<T>();

        static readonly Operative.Multiplicative<T> Multiplicative = Primal.Multiplicative.Operator<T>();

        static readonly Operative.Absolutive<T> Absolutive = Primal.Absolutive.Operator<T>();

        static readonly Operative.Subtractive<T> Subtractive = Primal.Subtractive.Operator<T>();

        static readonly Operative.Negatable<T> Negatable = Primal.Negatable.Operator<T>();

        static readonly Operative.Nullary<T> Nullary = Primal.Nullary.Operator<T>();

        static readonly Operative.Unital<T> Unital = Primal.Unital.Operator<T>();

        static readonly Operative.Ordered<T> Ordered = Primal.Ordered.Operator<T>();

        static readonly Operative.Stepwise<T> Stepwise = Primal.Stepwise.Operator<T>();

        static readonly Operative.Bitwise<T> Bitwise = Primal.Bitwise.Operator<T>();

        static readonly Operative.Semigroup<T> Equality = Primal.Equality.Operator<T>();

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
        public IEnumerable<T> add(IEnumerable<T> lhs, IEnumerable<T> rhs)
            =>  fuse(lhs,rhs,add);

        [MethodImpl(Inline)]
        public IReadOnlyList<T> add(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            =>  fuse(lhs,rhs,add);

        [MethodImpl(Inline)]
        public T mul(T lhs, T rhs)
            => Multiplicative.mul(lhs,rhs);

        [MethodImpl(Inline)]
        public IEnumerable<T> mul(IEnumerable<T> lhs, IEnumerable<T> rhs)
            =>  fuse(lhs,rhs,mul);

        [MethodImpl(Inline)]
        public IReadOnlyList<T> mul(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            => fuse(lhs,rhs,mul);

        [MethodImpl(Inline)]
        public T div(T lhs, T rhs)
            => Divisive.div(lhs,rhs);

        [MethodImpl(Inline)]
        public IEnumerable<T> div(IEnumerable<T> lhs, IEnumerable<T> rhs)
            =>  fuse(lhs,rhs,div);
        

        [MethodImpl(Inline)]
        public IReadOnlyList<T> div(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            =>  fuse(lhs,rhs,div);

        [MethodImpl(Inline)]
        public T mod(T lhs, T rhs)
            => Divisive.mod(lhs,rhs);

        [MethodImpl(Inline)]
        public IEnumerable<T> mod(IEnumerable<T> lhs, IEnumerable<T> rhs)
            =>  fuse(lhs,rhs,mod);

        [MethodImpl(Inline)]
        public IReadOnlyList<T> mod(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            =>  fuse(lhs,rhs,mod);


        [MethodImpl(Inline)]
        public T gcd(T lhs, T rhs)
            => Divisive.gcd(lhs,rhs);

        [MethodImpl(Inline)]
        public IEnumerable<T> gcd(IEnumerable<T> lhs, IEnumerable<T> rhs)
            =>  fuse(lhs,rhs,gcd);

        [MethodImpl(Inline)]
        public IReadOnlyList<T> gcd(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            =>  fuse(lhs,rhs,gcd);
        
        [MethodImpl(Inline)]
        public T negate(T x)
            => Negatable.negate(x);

        [MethodImpl(Inline)]
        public IEnumerable<T> negate(IEnumerable<T> src)
            =>  map(src,negate);

        [MethodImpl(Inline)]
        public IReadOnlyList<T> negate(IReadOnlyList<T> src)
            =>  map(src,negate);

        [MethodImpl(Inline)]
        public T sub(T lhs, T rhs)
            => Subtractive.sub(lhs,rhs);

        [MethodImpl(Inline)]
        public IEnumerable<T> sub(IEnumerable<T> lhs, IEnumerable<T> rhs)
            =>  fuse(lhs,rhs,sub);
        
        [MethodImpl(Inline)]
        public IReadOnlyList<T> sub(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            =>  fuse(lhs,rhs,sub);

        [MethodImpl(Inline)]
        public T abs(T x)
            => Absolutive.abs(x);

        [MethodImpl(Inline)]
        public IEnumerable<T> abs(IEnumerable<T> src)
            =>  map(src,abs);


        [MethodImpl(Inline)]
        public IReadOnlyList<T> abs(IReadOnlyList<T> src)
            =>  map(src,abs);

        [MethodImpl(Inline)]
        public bool lt(T lhs, T rhs)
            => Ordered.lt(lhs,rhs);

        [MethodImpl(Inline)]
        public IEnumerable<bool> lt(IEnumerable<T> lhs, IEnumerable<T> rhs)
            =>  fuse(lhs,rhs,lt);

        [MethodImpl(Inline)]
        public IReadOnlyList<bool> lt(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            =>  fuse(lhs,rhs,lt);

        [MethodImpl(Inline)]
        public bool lteq(T lhs, T rhs)
            => Ordered.lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public IEnumerable<bool> lteq(IEnumerable<T> lhs, IEnumerable<T> rhs)
            =>  fuse(lhs,rhs,lteq);


        [MethodImpl(Inline)]
        public IReadOnlyList<bool> lteq(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            =>  fuse(lhs,rhs,lteq);

        [MethodImpl(Inline)]
        public bool gt(T lhs, T rhs)
            => Ordered.gt(lhs,rhs);

        [MethodImpl(Inline)]
        public IEnumerable<bool> gt(IEnumerable<T> lhs, IEnumerable<T> rhs)
            =>  fuse(lhs,rhs,gt);

        [MethodImpl(Inline)]
        public IReadOnlyList<bool> gt(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            =>  fuse(lhs,rhs,gt);

        [MethodImpl(Inline)]
        public bool gteq(T lhs, T rhs)
            => Ordered.gteq(lhs,rhs);

        [MethodImpl(Inline)]
        public IEnumerable<bool> gteq(IEnumerable<T> lhs, IEnumerable<T> rhs)
            =>  fuse(lhs,rhs,gteq);

        [MethodImpl(Inline)]
        public IReadOnlyList<bool> gteq(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            =>  fuse(lhs,rhs,gteq);

        [MethodImpl(Inline)]
        public T inc(T x)
            => Stepwise.inc(x);

        [MethodImpl(Inline)]
        public IEnumerable<T> inc(IEnumerable<T> src)
            =>  map(src,inc);

        [MethodImpl(Inline)]
        public IReadOnlyList<T> inc(IReadOnlyList<T> src)
            =>  map(src,inc);

        [MethodImpl(Inline)]
        public T dec(T x)
            => Stepwise.dec(x);

        [MethodImpl(Inline)]
        public IEnumerable<T> dec(IEnumerable<T> src)
            =>  map(src,dec);

        [MethodImpl(Inline)]
        public IReadOnlyList<T> dec(IReadOnlyList<T> src)
            =>  map(src,dec);

        [MethodImpl(Inline)]
        public T and(T lhs, T rhs)
            => Bitwise.and(lhs,rhs);

        [MethodImpl(Inline)]
        public IEnumerable<T> and(IEnumerable<T> lhs, IEnumerable<T> rhs)
            =>  fuse(lhs,rhs,and);

        [MethodImpl(Inline)]
        public IReadOnlyList<T> and(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            =>  fuse(lhs,rhs,and);

        [MethodImpl(Inline)]
        public T or(T lhs, T rhs)
            => Bitwise.or(lhs,rhs);

        [MethodImpl(Inline)]
        public IEnumerable<T> or(IEnumerable<T> lhs, IEnumerable<T> rhs)
            =>  fuse(lhs,rhs,or);

        [MethodImpl(Inline)]
        public IReadOnlyList<T> or(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            =>  fuse(lhs,rhs,or);

        [MethodImpl(Inline)]
        public T xor(T lhs, T rhs)
            => Bitwise.xor(lhs,rhs);
        
        [MethodImpl(Inline)]
        public IEnumerable<T> xor(IEnumerable<T> lhs, IEnumerable<T> rhs)
            =>  fuse(lhs,rhs,xor);

        [MethodImpl(Inline)]
        public IReadOnlyList<T> xor(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            =>  fuse(lhs,rhs,xor);

        [MethodImpl(Inline)]
        public T flip(T x)
            => Bitwise.flip(x);

        [MethodImpl(Inline)]
        public IEnumerable<T> flip(IEnumerable<T> src)
            =>  map(src,flip);

        [MethodImpl(Inline)]
        public IReadOnlyList<T> flip(IReadOnlyList<T> src)
            =>  map(src,flip);

        [MethodImpl(Inline)]
        public T lshift(T lhs, int rhs)
            => Bitwise.lshift(lhs,rhs);

        [MethodImpl(Inline)]
        public IEnumerable<T> lshift(IEnumerable<T> lhs, int rhs)
        {
            foreach(var x in lhs)
                yield return lshift(x,rhs);
        }

        [MethodImpl(Inline)]
        public T rshift(T lhs, int rhs)
            => Bitwise.rshift(lhs,rhs);

        [MethodImpl(Inline)]
        public IEnumerable<T> rshift(IEnumerable<T> lhs, int rhs)
        {
            foreach(var x in lhs)
                yield return rshift(x,rhs);
        }

        [MethodImpl(Inline)]
        public BitString bitstring(T x)
            => Bitwise.bitstring(x);

        [MethodImpl(Inline)]
        public IEnumerable<BitString> bitstring(IEnumerable<T> src)
            => map(src,bitstring);

        [MethodImpl(Inline)]
        public IReadOnlyList<BitString> bitstring(IReadOnlyList<T> src)
            => map(src,bitstring);

        [MethodImpl(Inline)]
        public bool eq(T lhs, T rhs)
            => Equality.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public IEnumerable<bool> eq(IEnumerable<T> lhs, IEnumerable<T> rhs)
            =>  fuse(lhs,rhs,eq);

        [MethodImpl(Inline)]
        public IReadOnlyList<bool> eq(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            =>  fuse(lhs,rhs,eq);

        [MethodImpl(Inline)]
        public bool neq(T lhs, T rhs)
            => Equality.neq(lhs,rhs);

        [MethodImpl(Inline)]
        public IEnumerable<bool> neq(IEnumerable<T> lhs, IEnumerable<T> rhs)
            =>  fuse(lhs,rhs,neq);

        [MethodImpl(Inline)]
        public IReadOnlyList<bool> neq(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            =>  fuse(lhs,rhs,neq);

    }    
}

