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


    /// <summary>
    /// Represents an floateger predicated on (and constrained by) an underlying type
    /// </summary>
    public readonly struct floatg<T> : Floating<floatg<T>,T>
    {
        static readonly Floating<T> Ops = floating<T>();

        public static readonly floatg<T> Zero = Ops.zero;

        public static readonly floatg<T> One = Ops.one;

        public static readonly floatg<T> Epsilon = Ops.ε;

        [MethodImpl(Inline)]
        public static implicit operator floatg<T>(T src)
            => new floatg<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(floatg<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bool operator == (floatg<T> lhs, floatg<T> rhs) 
            => Ops.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator != (floatg<T> a, floatg<T> b) 
            => Ops.neq(a,b);

        [MethodImpl(Inline)]
        public static floatg<T> operator + (floatg<T> lhs, floatg<T> rhs) 
            => Ops.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static floatg<T> operator ++ (floatg<T> x) 
            => Ops.inc(x);


        [MethodImpl(Inline)]
        public static floatg<T> operator - (floatg<T> lhs, floatg<T> rhs) 
            => Ops.sub(lhs, rhs);

        [MethodImpl(Inline)]
        public static floatg<T> operator -- (floatg<T> x) 
            =>  Ops.dec(x);

        [MethodImpl(Inline)]
        public static floatg<T> operator * (floatg<T> lhs, floatg<T> rhs) 
            => Ops.mul(lhs, rhs);

        [MethodImpl(Inline)]
        public static floatg<T> operator / (floatg<T> lhs, floatg<T> rhs) 
            => Ops.div(lhs,rhs);

        [MethodImpl(Inline)]
        public static floatg<T> operator % (floatg<T> lhs, floatg<T> rhs)
            => Ops.mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator < (floatg<T> lhs, floatg<T> rhs) 
            => Ops.lt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator <= (floatg<T> lhs, floatg<T> rhs) 
            => Ops.lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator > (floatg<T> lhs, floatg<T> rhs) 
            => Ops.gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator >= (floatg<T> lhs, floatg<T> rhs) 
            => Ops.gteq(lhs,rhs);



        public T data {get;}

        public floatg<T> zero 
        {
            [MethodImpl(Inline)]
            get{return Zero;}
        }

        public floatg<T> one 
        {
            [MethodImpl(Inline)]
            get{return One;}
        }

        public floatg<T> ε 
            => Epsilon;

        [MethodImpl(Inline)]
        public floatg (T x) 
            => data = x;

        [MethodImpl(Inline)]
        public floatg<T> add(floatg<T> rhs)
            => this + rhs;

        [MethodImpl(Inline)]
        public floatg<T> inc()
            => Ops.inc(data);

        [MethodImpl(Inline)]
        public floatg<T> sub(floatg<T> rhs)
            => this - rhs;

        [MethodImpl(Inline)]
        public floatg<T> dec() 
            => Ops.dec(data);

        [MethodImpl(Inline)]
        public floatg<T> mul(floatg<T> rhs)
            => this * rhs;
        
        [MethodImpl(Inline)]
        public floatg<T> div(floatg<T> rhs)
            => this / rhs;

        [MethodImpl(Inline)]
        public floatg<T> mod(floatg<T> rhs)
            => this % rhs;

        [MethodImpl(Inline)]
        public bool divides(floatg<T> lhs)
            => lhs % this == Zero;

        [MethodImpl(Inline)]
        public bool even()
            => this % One.inc() == Zero;

        [MethodImpl(Inline)]
        public bool odd()
            => not(even());

        [MethodImpl(Inline)]
        public Quorem<floatg<T>> divrem(floatg<T> rhs)
            => map(Ops.divrem(data,rhs), x => Quorem.define<floatg<T>>(x.q,x.r));

        [MethodImpl(Inline)]
        public bool eq(floatg<T> rhs)
            => this == rhs;

        [MethodImpl(Inline)]
        public bool neq(floatg<T> rhs)
            => this != rhs;
 
        [MethodImpl(Inline)]
        public bool lteq(floatg<T> rhs) 
            => this <= rhs;

        [MethodImpl(Inline)]
        public bool gteq(floatg<T> rhs) 
            => this >= rhs;

        [MethodImpl(Inline)]
        public bool lt(floatg<T> rhs) 
            => this < rhs;

        [MethodImpl(Inline)]
        public bool gt(floatg<T> rhs) 
            => this > rhs;

        [MethodImpl(Inline)]
        public floatg<T> abs()
            => Ops.abs(data);

        [MethodImpl(Inline)]
        public Sign sign()
            => Ops.sign(data);

        [MethodImpl(Inline)]
        public floatg<T> gcd(floatg<T> rhs)
            => Ops.gcd(data, rhs);

        [MethodImpl(Inline)]
        public string bitstring()
            => Ops.bitstring(data);

        [MethodImpl(Inline)]
        public floatg<T> distributeL((floatg<T> x, floatg<T>y) rhs)
            => this * rhs.x + this * rhs.y;
 
        [MethodImpl(Inline)]
        public floatg<T> distributeR((floatg<T> x, floatg<T> y) rhs)
            => rhs.x * this + rhs.y * this;

        [MethodImpl(Inline)]
        int IComparable<floatg<T>>.CompareTo(floatg<T> rhs)
            => this < rhs ? -1
             : this > rhs ? 1
             : 0;

        [MethodImpl(Inline)]
        public floatg<T> negate()
            => Ops.negate(data);

        /// <summary>
        /// Represents the floateger as a sequence of 10-based digits
        /// </summary>
        [MethodImpl(Inline)]
        public byte[] digits()
            => (from c in data.ToString() select byte.Parse(c.ToString())).ToArray();

        [MethodImpl(Inline)]
        public floatg<T> sqrt()
            => Ops.sqrt(data);

        public IEnumerable<floatg<T>> partition(floatg<T> min, floatg<T> max, floatg<T> width = default)
            => map(Ops.partition(min,max,width), x => new floatg<T>(x));
 
        [MethodImpl(Inline)]
        public floatg<T> ceiling()
            => Ops.ceiling(data);

        [MethodImpl(Inline)]
        public floatg<T> floor()
            => Ops.floor(data);

        [MethodImpl(Inline)]
        public floatg<T> cos()
            => Ops.cos(this.data);

        [MethodImpl(Inline)]
        public floatg<T> cosh()
            => Ops.cosh(this.data);

        [MethodImpl(Inline)]
        public floatg<T> acos()
            => Ops.acos(this.data);

        [MethodImpl(Inline)]
        public floatg<T> acosh()
            => Ops.acosh(this.data);

        [MethodImpl(Inline)]
        public floatg<T> sin()
            => Ops.sin(this.data);

        [MethodImpl(Inline)]
        public floatg<T> sinh()
            => Ops.sinh(this.data);

        [MethodImpl(Inline)]
        public floatg<T> asin()
            => Ops.asin(this.data);

        [MethodImpl(Inline)]
        public floatg<T> asinh()
            => Ops.asinh(this.data);

        [MethodImpl(Inline)]
        public floatg<T> tan()
            => Ops.atanh(this.data);

        [MethodImpl(Inline)]
        public floatg<T> tanh()
            => Ops.tanh(this.data);

        [MethodImpl(Inline)]
        public floatg<T> atan()
            => Ops.atan(this.data);

        [MethodImpl(Inline)]
        public floatg<T> atanh()
            => Ops.atanh(this.data); 

        /// <summary>
        /// x:floatg[T] => x:intg[I]
        /// </summary>
        /// <typeparam name="I">The underlying type of the destination</typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public intg<I> intg<I>()
            => convert<I>(data);

        [MethodImpl(Inline)]
         public override bool Equals(object rhs)
            => data.Equals(rhs);

        [MethodImpl(Inline)]
        public override int GetHashCode()
            => data.GetHashCode();

        [MethodImpl(Inline)]
        public override string ToString()
            => data.ToString();

        public bool Equals(floatg<T> rhs)
            => this == rhs;
    }
}