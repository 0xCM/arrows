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
    using static Structures;

    public readonly struct num<T> : OrderedNumber<num<T>,T>
    {
        static readonly Operative.OrderedNumber<T> Ops = Resolver.ordnum<T>();

        static readonly NumberInfo<T> UnderInfo = Ops.numinfo;

        public static readonly bool Signed = UnderInfo.Signed;

        public static readonly num<T> MinVal = UnderInfo.MinVal;

        public static readonly num<T> MaxVal = UnderInfo.MaxVal;

        public static readonly num<T> Zero = Ops.zero;

        public static readonly num<T> One = Ops.one;

        public static readonly num<T> BitSize = UnderInfo.BitSize;


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

        readonly T data;

        public num<T> zero 
            => Zero;

        public num<T> one 
            => One;

        public num<T> bitsize 
            => BitSize;

        public NumberInfo<num<T>> numinfo 
            => new NumberInfo<num<T>>((MinVal, MaxVal),Signed,Zero, One, BitSize);

        [MethodImpl(Inline)]
        public bool nonzero()
            => Ops.nonzero(data);

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
            => nonzero() ? Sign.Neutral : 
               this < Zero ? Sign.Negative :
               Sign.Positive;

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
         public BitString bitstring()
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

        [MethodImpl(Inline)]
        public num<T> muladd(num<T> y, num<T> z)
            => Ops.muladd(this,y,z);

        [MethodImpl(Inline)]
        public num<T> pow(int exp)
            => Ops.pow(data, exp);
 
        [MethodImpl(Inline)]
        public int hash()
            => data.GetHashCode();

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => hash();

        public override string ToString()
            => data.ToString();

 
    }
}