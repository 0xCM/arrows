//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
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
        static readonly Number<T> ops = Resolve.number<T>();
        
        static readonly Stepwise<T> step = Resolve.stepwise<T>();
        
        static readonly Ordered<T> ord = Resolve.ordered<T>();


        public static readonly num<T> Zero = ops.zero;

        public static readonly num<T> One = ops.one;

        [MethodImpl(Inline)]
        public static implicit operator num<T>(T src)
            => new num<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(num<T> src)
            => src.data;        

        [MethodImpl(Inline)]
        public static bool operator == (num<T> lhs, num<T> rhs) 
            => ops.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator != (num<T> lhs, num<T> rhs) 
            => ops.neq(lhs,rhs);

        [MethodImpl(Inline)]
        public static num<T> operator + (num<T> lhs, num<T> rhs) 
            => ops.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static num<T> operator ++ (num<T> x) 
            => step.inc(x);

        [MethodImpl(Inline)]
        public static num<T> operator - (num<T> lhs, num<T> rhs) 
            => ops.sub(lhs, rhs);

        [MethodImpl(Inline)]
        public static num<T> operator -- (num<T> x) 
            => step.dec(x);

        [MethodImpl(Inline)]
        public static num<T> operator * (num<T> lhs, num<T> rhs) 
            => ops.mul(lhs, rhs);

        [MethodImpl(Inline)]
        public static num<T> operator / (num<T> lhs, num<T> rhs) 
            => ops.div(lhs,rhs);

        [MethodImpl(Inline)]
        public static num<T> operator % (num<T> lhs, num<T> rhs)
            => ops.mod(lhs,rhs);

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
            => ops.sign(this);

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
            => ops.abs(this);

        [MethodImpl(Inline)]
         public string bitstring()
            => ops.bitstring(this);

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
            => ops.negate(this.data);

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => data.ToString();

        public num<T> gcd(num<T> rhs)
            => ops.gcd(this,rhs);

        public Quorem<num<T>> divrem(num<T> rhs)
            => Quorem.define(this/rhs, this % rhs);
    }
}