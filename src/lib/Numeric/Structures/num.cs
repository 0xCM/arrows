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

    
    using static zcore;
    using static Traits;

    public readonly struct num<T> : OrderedNumber<num<T>,T>
    {
        static readonly OrderedNumber<T> Ops = Resolver.ordnum<T>();
        
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
        public static num<T> operator - (num<T> x) 
            => Ops.negate(x);


        [MethodImpl(Inline)]
        public static num<T> operator ++ (num<T> x) 
            => Ops.inc(x);

        [MethodImpl(Inline)]
        public static num<T> operator -- (num<T> x) 
            => Ops.dec(x);

        [MethodImpl(Inline)]
        public static num<T> operator + (num<T> lhs, num<T> rhs) 
            => Ops.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static num<T> operator - (num<T> lhs, num<T> rhs) 
            => Ops.sub(lhs, rhs);

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
            => Ops.lt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator <= (num<T> lhs, num<T> rhs) 
            => Ops.lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator > (num<T> lhs, num<T> rhs) 
            => Ops.gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator >= (num<T> lhs, num<T> rhs) 
            => Ops.gteq(lhs,rhs);

        [MethodImpl(Inline)]
        public num(T src)
            => this.data = src;

        public T data {get;}

        public num<T> zero 
            => Zero;

        public num<T> one 
            => One;

        public (num<T> min, num<T> max)? limits 
            => Ops.limits.TryMap(x => (x.min, x.max));

        public Addition<num<T>> addition 
            => Addition.define(this);
            
        public Multiplication<num<T>> multiplication 
            => Multiplication.define(this);

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
        public num<T> gcd(num<T> rhs)
            => Ops.gcd(this,rhs);

        [MethodImpl(Inline)]
        public Quorem<num<T>> divrem(num<T> rhs)
            => Quorem.define(this/rhs, this % rhs);

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
            => Ops.inc(this);
 
        [MethodImpl(Inline)]
        public num<T> dec()
            => Ops.dec(this);

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
 
 
        [MethodImpl(Inline)]
        public bool Equals(num<T> rhs)
            => Ops.eq(this.data, rhs.data);

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => data.ToString();


        //
        //---------------------------------------------------------------------


        [MethodImpl(Inline)]
        num<T> Incrementable<num<T>>.inc(num<T> x)
            => x.inc();

        [MethodImpl(Inline)]
        num<T> Decrementable<num<T>>.dec(num<T> x)
            => x.dec();

        [MethodImpl(Inline)]
        num<T> Negatable<num<T>>.negate(num<T> x)
            => x.negate();

        [MethodImpl(Inline)]
        num<T> Number<num<T>>.abs(num<T> x)
            => x.abs();
        
        [MethodImpl(Inline)]
        Sign Number<num<T>>.sign(num<T> x)
            => x.sign();

        [MethodImpl(Inline)]
        num<T> Additive<num<T>>.add(num<T> lhs, num<T> rhs)
            => lhs.add(rhs);

        [MethodImpl(Inline)]
        num<T> Negatable<num<T>>.sub(num<T> lhs, num<T> rhs)
            => lhs.sub(rhs);

        [MethodImpl(Inline)]
        num<T> Multiplicative<num<T>>.mul(num<T> lhs, num<T> rhs)
            => lhs.mul(rhs);

        [MethodImpl(Inline)]
        num<T> Number<num<T>>.muladd(num<T> x, num<T> y, num<T> z)
            => x*y + z;

        [MethodImpl(Inline)]
        num<T> LeftDistributive<num<T>>.distribute(num<T> lhs, (num<T> x, num<T> y) rhs)
            => lhs.distributeL(rhs);

        [MethodImpl(Inline)]
        num<T> RightDistributive<num<T>>.distribute((num<T> x, num<T> y) lhs, num<T> rhs)
            => rhs.distributeL(lhs);

        [MethodImpl(Inline)]
        num<T> Divisive<num<T>>.div(num<T> lhs, num<T> rhs)
            => lhs.div(rhs);

        [MethodImpl(Inline)]
        Quorem<num<T>> Divisive<num<T>>.divrem(num<T> lhs, num<T> rhs)
            => lhs.divrem(rhs);

        [MethodImpl(Inline)]
        num<T> Divisive<num<T>>.mod(num<T> lhs, num<T> rhs)
            => lhs.mod(rhs);

        [MethodImpl(Inline)]
        num<T> Divisive<num<T>>.gcd(num<T> lhs, num<T> rhs)
            => lhs.gcd(rhs);

        [MethodImpl(Inline)]
        num<T> Powered<num<T>, int>.pow(num<T> b, int exp)
            => Ops.pow(b,exp);

        [MethodImpl(Inline)]
        bool Ordered<num<T>>.lt(num<T> lhs, num<T> rhs)
            => lhs.lt(rhs);

        [MethodImpl(Inline)]
        bool Ordered<num<T>>.lteq(num<T> lhs, num<T> rhs)
            => lhs.lteq(rhs);

        [MethodImpl(Inline)]
        bool Ordered<num<T>>.gt(num<T> lhs, num<T> rhs)
            => lhs.gt(rhs);

        [MethodImpl(Inline)]
        bool Ordered<num<T>>.gteq(num<T> lhs, num<T> rhs)
            => lhs.gteq(rhs);

        [MethodImpl(Inline)]
        bool Equatable<num<T>>.eq(num<T> lhs, num<T> rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        bool Equatable<num<T>>.neq(num<T> lhs, num<T> rhs)
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        string Number<num<T>>.bitstring(num<T> x)
            => x.bitstring();

    }
}