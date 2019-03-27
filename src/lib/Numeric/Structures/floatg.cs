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
        public static floatg<T> operator - (floatg<T> x) 
            => Ops.negate(x);

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
            => apply(Ops.divrem(data,rhs), x => Quorem.define<floatg<T>>(x.q,x.r));

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
        public bool Equals(floatg<T> rhs)
            => this == rhs;

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => data.ToString();
  
        //
        //---------------------------------------------------------------------
        Addition<floatg<T>> SemigroupA<floatg<T>>.addition 
            => new Addition<floatg<T>>(this);

        Multiplication<floatg<T>> SemigroupM<floatg<T>>.multiplication 
            => new Multiplication<floatg<T>>(this);

        [MethodImpl(Inline)]
        floatg<T> Incrementable<floatg<T>>.inc(floatg<T> x)
            => x.inc();

        [MethodImpl(Inline)]
        floatg<T> Decrementable<floatg<T>>.dec(floatg<T> x)
            => x.dec();

        [MethodImpl(Inline)]
        floatg<T> Negatable<floatg<T>>.negate(floatg<T> x)
            => x.negate();

        [MethodImpl(Inline)]
        floatg<T> Number<floatg<T>>.abs(floatg<T> x)
            => x.abs();
        
        [MethodImpl(Inline)]
        Sign Number<floatg<T>>.sign(floatg<T> x)
            => x.sign();

        [MethodImpl(Inline)]
        floatg<T> Additive<floatg<T>>.add(floatg<T> lhs, floatg<T> rhs)
            => lhs.add(rhs);

        [MethodImpl(Inline)]
        floatg<T> Negatable<floatg<T>>.sub(floatg<T> lhs, floatg<T> rhs)
            => lhs.sub(rhs);

        [MethodImpl(Inline)]
        floatg<T> Multiplicative<floatg<T>>.mul(floatg<T> lhs, floatg<T> rhs)
            => lhs.mul(rhs);

        [MethodImpl(Inline)]
        floatg<T> Number<floatg<T>>.muladd(floatg<T> x, floatg<T> y, floatg<T> z)
            => x*y + z;

        [MethodImpl(Inline)]
        floatg<T> LeftDistributive<floatg<T>>.distribute(floatg<T> lhs, (floatg<T> x, floatg<T> y) rhs)
            => lhs.distributeL(rhs);

        [MethodImpl(Inline)]
        floatg<T> RightDistributive<floatg<T>>.distribute((floatg<T> x, floatg<T> y) lhs, floatg<T> rhs)
            => rhs.distributeL(lhs);

        [MethodImpl(Inline)]
        floatg<T> Divisive<floatg<T>>.div(floatg<T> lhs, floatg<T> rhs)
            => lhs.div(rhs);

        [MethodImpl(Inline)]
        Quorem<floatg<T>> Divisive<floatg<T>>.divrem(floatg<T> lhs, floatg<T> rhs)
            => lhs.divrem(rhs);

        [MethodImpl(Inline)]
        floatg<T> Divisive<floatg<T>>.mod(floatg<T> lhs, floatg<T> rhs)
            => lhs.mod(rhs);

        [MethodImpl(Inline)]
        floatg<T> Divisive<floatg<T>>.gcd(floatg<T> lhs, floatg<T> rhs)
            => lhs.gcd(rhs);

        [MethodImpl(Inline)]
        floatg<T> Powered<floatg<T>, int>.pow(floatg<T> b, int exp)
            => Ops.pow(b.data,exp);

        [MethodImpl(Inline)]
        bool Ordered<floatg<T>>.lt(floatg<T> lhs, floatg<T> rhs)
            => lhs.lt(rhs);

        [MethodImpl(Inline)]
        bool Ordered<floatg<T>>.lteq(floatg<T> lhs, floatg<T> rhs)
            => lhs.lteq(rhs);

        [MethodImpl(Inline)]
        bool Ordered<floatg<T>>.gt(floatg<T> lhs, floatg<T> rhs)
            => lhs.gt(rhs);

        [MethodImpl(Inline)]
        bool Ordered<floatg<T>>.gteq(floatg<T> lhs, floatg<T> rhs)
            => lhs.gteq(rhs);

        [MethodImpl(Inline)]
        bool Equatable<floatg<T>>.eq(floatg<T> lhs, floatg<T> rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        bool Equatable<floatg<T>>.neq(floatg<T> lhs, floatg<T> rhs)
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        floatg<T> Trigonmetric<floatg<T>>.sin(floatg<T> x)
            => x.sin();

        [MethodImpl(Inline)]
        floatg<T> Trigonmetric<floatg<T>>.sinh(floatg<T> x)
            => x.sinh();

        [MethodImpl(Inline)]
        floatg<T> Trigonmetric<floatg<T>>.asin(floatg<T> x)
            => x.asin();

        [MethodImpl(Inline)]
        floatg<T> Trigonmetric<floatg<T>>.asinh(floatg<T> x)
            => x.asinh();

        [MethodImpl(Inline)]
        floatg<T> Trigonmetric<floatg<T>>.cos(floatg<T> x)
            => x.cos();

        [MethodImpl(Inline)]
        floatg<T> Trigonmetric<floatg<T>>.cosh(floatg<T> x)
            => x.cosh();

        [MethodImpl(Inline)]
        floatg<T> Trigonmetric<floatg<T>>.acos(floatg<T> x)
            => x.acos();

        [MethodImpl(Inline)]
        floatg<T> Trigonmetric<floatg<T>>.acosh(floatg<T> x)
            => x.acosh();

        [MethodImpl(Inline)]
        floatg<T> Trigonmetric<floatg<T>>.tan(floatg<T> x)
            => x.tan();

        [MethodImpl(Inline)]
        floatg<T> Trigonmetric<floatg<T>>.tanh(floatg<T> x)
            => x.tanh();

        [MethodImpl(Inline)]
        floatg<T> Trigonmetric<floatg<T>>.atan(floatg<T> x)
            => x.atan();

        [MethodImpl(Inline)]
        floatg<T> Trigonmetric<floatg<T>>.atanh(floatg<T> x)
            => x.atanh();


        [MethodImpl(Inline)]
        floatg<T> Floating<floatg<T>>.sqrt(floatg<T> x)
            => x.sqrt();

        [MethodImpl(Inline)]
        floatg<T> Fractional<floatg<T>>.ceiling(floatg<T> x)
            => x.ceiling();

        [MethodImpl(Inline)]
        floatg<T> Fractional<floatg<T>>.floor(floatg<T> x)
            => x.floor();

        [MethodImpl(Inline)]
        string Number<floatg<T>>.bitstring(floatg<T> x)
            => x.bitstring();
    }
}