//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using C = Contracts;

    using static corefunc;
    using static Traits;

    public readonly struct num<T> : Number<num<T>,T>, Stepwise<num<T>, T>, Ordered<num<T>, T> 
    {
        static readonly Number<T> Ops = number<T>();
        
        static readonly Stepwise<T> step = stepwise<T>();
        
        static readonly Ordered<T> ord = ordered<T>();


        public static readonly num<T> Zero = Ops.zero;

        public static readonly num<T> One = Ops.one;

        [MethodImpl(Inline)]
        public static implicit operator num<T>(T src)
            => new num<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(num<T> src)
            => src.data;        

        [MethodImpl(Inline)]
        public static bool operator == (num<T> lhs, num<T> rhs) 
            => Ops.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator != (num<T> lhs, num<T> rhs) 
            => Ops.neq(lhs,rhs);

        [MethodImpl(Inline)]
        public static num<T> operator + (num<T> lhs, num<T> rhs) 
            => Ops.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static num<T> operator ++ (num<T> x) 
            => step.inc(x);

        [MethodImpl(Inline)]
        public static num<T> operator - (num<T> lhs, num<T> rhs) 
            => Ops.sub(lhs, rhs);

        [MethodImpl(Inline)]
        public static num<T> operator -- (num<T> x) 
            => step.dec(x);

        [MethodImpl(Inline)]
        public static num<T> operator * (num<T> lhs, num<T> rhs) 
            => Ops.mul(lhs, rhs);

        [MethodImpl(Inline)]
        public static num<T> operator / (num<T> lhs, num<T> rhs) 
            => Ops.div(lhs,rhs);

        [MethodImpl(Inline)]
        public static num<T> operator % (num<T> lhs, num<T> rhs)
            => Ops.mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator < (num<T> lhs, num<T> rhs) 
            => ord.lt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator <= (num<T> lhs, num<T> rhs) 
            => ord.lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator > (num<T> lhs, num<T> rhs) 
            => ord.gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator >= (num<T> lhs, num<T> rhs) 
            => ord.gteq(lhs,rhs);

        [MethodImpl(Inline)]
        public num(T src)
            => this.data = src;

        public T data {get;}

        public num<T> zero 
            => Zero;

        public num<T> one 
            => One;

        [MethodImpl(Inline)]
        public num<T> add(num<T> rhs)
            => this + rhs;

        [MethodImpl(Inline)]
        public num<T> sub(num<T> rhs)
            => this - rhs;

        [MethodImpl(Inline)]
        public num<T> mul(num<T> a)
            => this * a;

        [MethodImpl(Inline)]
        public num<T> div(num<T> rhs)
            => this / rhs;

        [MethodImpl(Inline)]
        public bool eq(num<T> rhs)
            => this == rhs;

        [MethodImpl(Inline)]
        public num<T> mod(num<T> rhs)
            => this % rhs;

        [MethodImpl(Inline)]
        public bool neq(num<T> rhs)
            => this != rhs;

        [MethodImpl(Inline)]
        public Sign sign()
            => Ops.sign(this);

        [MethodImpl(Inline)]
        public num<T> inc()
            => step.inc(this);
 
        [MethodImpl(Inline)]
        public num<T> dec()
            => step.dec(this);

        [MethodImpl(Inline)]
        public bool lt(num<T> rhs)
            => this < rhs;

        [MethodImpl(Inline)]
        public bool lteq(num<T> rhs)
            => this <= rhs;

        [MethodImpl(Inline)]
        public bool gt(num<T> rhs)
            => this > rhs;

        [MethodImpl(Inline)]
        public bool gteq(num<T> rhs)
            => this >= rhs;

        [MethodImpl(Inline)]
        public num<T> abs()
            => Ops.abs(this);

        [MethodImpl(Inline)]
         public string bitstring()
            => Ops.bitstring(this);

        [MethodImpl(Inline)]
        public int CompareTo(num<T> rhs)
            => this < rhs ? -1
             : this > rhs ? 1
             : 0;

        [MethodImpl(Inline)]
        public num<T> distributeL((num<T> x, num<T>y) rhs)
            => this * rhs.x + this * rhs.y;
 
        [MethodImpl(Inline)]
        public num<T> distributeR((num<T> x, num<T> y) rhs)
            => rhs.x * this + rhs.y * this;

        [MethodImpl(Inline)]
        public num<T> negate()
            => Ops.negate(this.data);

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => data.ToString();

        public num<T> gcd(num<T> rhs)
            => Ops.gcd(this,rhs);

        public Quorem<num<T>> divrem(num<T> rhs)
            => Quorem.define(this/rhs, this % rhs);
 
 
         public bool Equals(num<T> rhs)
            => Ops.eq(this.data, rhs.data);
    }
}