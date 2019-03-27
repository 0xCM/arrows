//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using static zcore;
    
    using static Traits;

    public readonly struct real<T> : Real<real<T>, T>
    {
        static readonly Real<T> Ops = ops<T,Real<T>>();
        static readonly real<T> Epsilon = Ops.ε;

        public static readonly real<T> Zero = Ops.zero;

        public static readonly real<T> One = Ops.one;

        [MethodImpl(Inline)]
        public static implicit operator real<T>(T src)
            => new real<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(real<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bool operator == (real<T> lhs, real<T> rhs) 
            => Ops.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator != (real<T> a, real<T> b) 
            => Ops.neq(a,b);


        [MethodImpl(Inline)]
        public static real<T> operator - (real<T> x) 
            => Ops.negate(x);


        [MethodImpl(Inline)]
        public static real<T> operator -- (real<T> x) 
            =>  Ops.dec(x);

        [MethodImpl(Inline)]
        public static real<T> operator ++ (real<T> x) 
            => Ops.inc(x);

        [MethodImpl(Inline)]
        public static real<T> operator + (real<T> lhs, real<T> rhs) 
            => Ops.add(lhs, rhs);


        [MethodImpl(Inline)]
        public static real<T> operator - (real<T> lhs, real<T> rhs) 
            => Ops.sub(lhs, rhs);

        [MethodImpl(Inline)]
        public static real<T> operator * (real<T> lhs, real<T> rhs) 
            => Ops.mul(lhs, rhs);

        [MethodImpl(Inline)]
        public static real<T> operator / (real<T> lhs, real<T> rhs) 
            => Ops.div(lhs,rhs);

        [MethodImpl(Inline)]
        public static real<T> operator % (real<T> lhs, real<T> rhs)
            => Ops.mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator < (real<T> lhs, real<T> rhs) 
            => Ops.lt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator <= (real<T> lhs, real<T> rhs) 
            => Ops.lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator > (real<T> lhs, real<T> rhs) 
            => Ops.gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator >= (real<T> lhs, real<T> rhs) 
            => Ops.gteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static real<T> operator & (real<T> lhs, real<T> rhs) 
            => Ops.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static real<T> operator | (real<T> lhs, real<T> rhs) 
            => Ops.or(lhs,rhs);

        [MethodImpl(Inline)]
        public static real<T> operator ^ (real<T> lhs, real<T> rhs) 
            => Ops.xor(lhs,rhs);

        [MethodImpl(Inline)]
        public static real<T> operator ~ (real<T> x) 
            => Ops.flip(x);

        [MethodImpl(Inline)]
        public static real<T> operator >> (real<T> lhs, int rhs) 
            => Ops.rshift(lhs, rhs);

        [MethodImpl(Inline)]
        public static real<T> operator << (real<T> lhs, int rhs) 
            => Ops.lshift(lhs, rhs);

        [MethodImpl(Inline)]
        public real(T src)
            => this.data = src;

        public T data {get;}

        public bool infinite 
            => false;

        public real<T> ε 
            => Epsilon;

        [MethodImpl(Inline)]
        public real<Y> convert<Y>()            
            => zcore.convert<Y>(data);

        [MethodImpl(Inline)]
        public real<T> inc()
            => Ops.inc(data);

        [MethodImpl(Inline)]
        public real<T> dec()
            => Ops.dec(data);

        [MethodImpl(Inline)]
        public real<T> negate()
            => Ops.negate(data);

        [MethodImpl(Inline)]
        public Sign sign()
            => Ops.sign(data);

        [MethodImpl(Inline)]
        public real<T> add(real<T> rhs)
            => Ops.add(data, rhs.data);

        [MethodImpl(Inline)]
        public real<T> mul(real<T> rhs)
            => Ops.mul(data,rhs);

        [MethodImpl(Inline)]
        public real<T> div(real<T> rhs)
            => Ops.div(data,rhs);

        [MethodImpl(Inline)]
        public real<T> mod(real<T> rhs)
            => Ops.mod(data,rhs);


        [MethodImpl(Inline)]
        public Quorem<real<T>> divrem(real<T> rhs)
            => Quorem.define<real<T>>(Ops.div(data, rhs), Ops.mod(data, rhs));

        [MethodImpl(Inline)]
        public real<T> abs()
            => Ops.abs(data);

        [MethodImpl(Inline)]
        public real<T> and(real<T> rhs)
            => Ops.and(data, rhs.data);

        [MethodImpl(Inline)]
        public string bitstring()
            => Ops.bitstring(data);

        [MethodImpl(Inline)]
        public real<T> ceiling()
            => Ops.ceiling(data);

        [MethodImpl(Inline)]
        public real<T> distributeL((real<T> x, real<T> y) rhs)
            => Ops.distribute(data,rhs);

        [MethodImpl(Inline)]
        public real<T> distributeR((real<T> x, real<T> y) lhs)
            => Ops.distribute(lhs,data);

        [MethodImpl(Inline)]
        public bool eq(real<T> rhs)
            => Ops.eq(data,rhs);

        [MethodImpl(Inline)]
        public real<T> floor()
            => Ops.floor(data);

        [MethodImpl(Inline)]
        public real<T> gcd(real<T> rhs)
            => Ops.gcd(data,rhs);

        [MethodImpl(Inline)]
        public bool gt(real<T> rhs)
            => Ops.gt(data,rhs);

        [MethodImpl(Inline)]
        public bool gteq(real<T> rhs)
            => Ops.gteq(data,rhs);

        [MethodImpl(Inline)]
        public bool lt(real<T> rhs)
            => Ops.lt(data,rhs);

        [MethodImpl(Inline)]
        public bool lteq(real<T> rhs)
            => Ops.lteq(data,rhs);

        [MethodImpl(Inline)]
        public bool neq(real<T> rhs)
            => Ops.neq(data,rhs);

        [MethodImpl(Inline)]
        public real<T> or(real<T> rhs)
            => Ops.or(data, rhs.data);

        [MethodImpl(Inline)]
        public real<T> lshift(int rhs)
            => Ops.lshift(data,rhs);

        [MethodImpl(Inline)]
        public real<T> xor(real<T> rhs)
            => Ops.xor(data,rhs);

        [MethodImpl(Inline)]
        public real<T> rshift(int rhs)
            => Ops.rshift(data, rhs);

        [MethodImpl(Inline)]
        public real<T> flip()
            => Ops.flip(data);

        [MethodImpl(Inline)]
        public real<T> sin()
            => Ops.sin(data);

        [MethodImpl(Inline)]
        public real<T> sinh()
            => Ops.sinh(data);

        [MethodImpl(Inline)]
        public real<T> asin()
            => Ops.asin(data);

        [MethodImpl(Inline)]
        public real<T> asinh()
            => Ops.asinh(data);

        [MethodImpl(Inline)]
        public real<T> acos()
            => Ops.acos(data);

        [MethodImpl(Inline)]
        public real<T> acosh()
            => Ops.acosh(data);

        [MethodImpl(Inline)]
        public real<T> atan()
            => Ops.atan(data);

        [MethodImpl(Inline)]
        public real<T> atanh()
            => Ops.atanh(data);

        [MethodImpl(Inline)]
        public real<T> cos()
            => Ops.cos(data);

        [MethodImpl(Inline)]
        public real<T> cosh()
            => Ops.cosh(data);

        [MethodImpl(Inline)]
        public real<T> tan()
            => Ops.tan(data);

        [MethodImpl(Inline)]
        public real<T> tanh()
            => Ops.tanh(data);

        [MethodImpl(Inline)]
        public real<T> sqrt()
            => Ops.sqrt(data);

        [MethodImpl(Inline)]
        public bool Equals(real<T> rhs)
        => Ops.eq(this.data, rhs.data);

        [MethodImpl(Inline)]
        public int CompareTo(real<T> rhs)
            => this < rhs ? -1
             : this > rhs ? 1
             : 0;

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => data.ToString();

        real<T> Floating<real<T>>.ε 
            => Ops.ε;

        Addition<real<T>> SemigroupA<real<T>>.addition 
            => new Addition<real<T>>(this);

        real<T> Nullary<real<T>>.zero 
            => Ops.zero;

        Multiplication<real<T>> SemigroupM<real<T>>.multiplication 
            => new Multiplication<real<T>>(this);
        
        real<T> Unital<real<T>>.one 
            => Ops.one;

        [MethodImpl(Inline)]
        real<T> BitLogic<real<T>>.and(real<T> lhs, real<T> rhs)
            => lhs.and(rhs);

        [MethodImpl(Inline)]
        real<T> BitLogic<real<T>>.or(real<T> lhs, real<T> rhs)
            => lhs.or(rhs);

        [MethodImpl(Inline)]
        real<T> BitLogic<real<T>>.xor(real<T> lhs, real<T> rhs)
            => lhs.xor(rhs);

        [MethodImpl(Inline)]
        real<T> BitLogic<real<T>>.flip(real<T> x)
            => x.flip();

        [MethodImpl(Inline)]
        real<T> BitShifts<real<T>>.lshift(real<T> lhs, int rhs)
            => lhs.lshift(rhs);

        [MethodImpl(Inline)]
        real<T> BitShifts<real<T>>.rshift(real<T> lhs, int rhs)
            => lhs.rshift(rhs);

        [MethodImpl(Inline)]
        real<T> Floating<real<T>>.sqrt(real<T> x)
            => x.sqrt();

        [MethodImpl(Inline)]
        real<T> Fractional<real<T>>.ceiling(real<T> x)
            => x.ceiling();

        [MethodImpl(Inline)]
        real<T> Fractional<real<T>>.floor(real<T> x)
            => x.floor();

        [MethodImpl(Inline)]
        real<T> Number<real<T>>.muladd(real<T> x, real<T> y, real<T> z)
            => throw new NotImplementedException();

        [MethodImpl(Inline)]
        real<T> Number<real<T>>.abs(real<T> x)
            => x.abs();

        [MethodImpl(Inline)]
        Sign Number<real<T>>.sign(real<T> x)
            => x.sign();

        [MethodImpl(Inline)]
        string Number<real<T>>.bitstring(real<T> x)
            => x.bitstring();

        [MethodImpl(Inline)]
        real<T> LeftDistributive<real<T>>.distribute(real<T> lhs, (real<T> x, real<T> y) rhs)
            => lhs.distributeR(rhs);

        [MethodImpl(Inline)]
        real<T> RightDistributive<real<T>>.distribute((real<T> x, real<T> y) lhs, real<T> rhs)
            => rhs.distributeL(lhs);

        [MethodImpl(Inline)]
        real<T> Multiplicative<real<T>>.mul(real<T> lhs, real<T> rhs)
            => lhs.mul(rhs);

        [MethodImpl(Inline)]
        real<T> Additive<real<T>>.add(real<T> lhs, real<T> rhs)
            => lhs.add(rhs);

        [MethodImpl(Inline)]
        real<T> Divisive<real<T>>.div(real<T> lhs, real<T> rhs)
            => lhs.div(rhs);

        [MethodImpl(Inline)]
        real<T> Divisive<real<T>>.gcd(real<T> lhs, real<T> rhs)
            => lhs.gcd(rhs);

        [MethodImpl(Inline)]
        Quorem<real<T>> Divisive<real<T>>.divrem(real<T> lhs, real<T> rhs)
            => lhs.divrem(rhs);


        [MethodImpl(Inline)]
        real<T> Divisive<real<T>>.mod(real<T> lhs, real<T> rhs)
            => lhs.mod(rhs);

        [MethodImpl(Inline)]
        real<T> Powered<real<T>, int>.pow(real<T> b, int exp)
            => throw new NotImplementedException();

        [MethodImpl(Inline)]
        real<T> Negatable<real<T>>.negate(real<T> x)
            => x.negate();

        [MethodImpl(Inline)]
        real<T> Negatable<real<T>>.sub(real<T> lhs, real<T> rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        bool Ordered<real<T>>.lt(real<T> lhs, real<T> rhs)
            => lhs.lt(rhs);

        [MethodImpl(Inline)]
        bool Ordered<real<T>>.lteq(real<T> lhs, real<T> rhs)
            => lhs.lteq(rhs);

        [MethodImpl(Inline)]
        bool Ordered<real<T>>.gt(real<T> lhs, real<T> rhs)
            => lhs.gt(rhs);

        [MethodImpl(Inline)]
        bool Ordered<real<T>>.gteq(real<T> lhs, real<T> rhs)
            => lhs.gteq(rhs);

        [MethodImpl(Inline)]
        real<T> Incrementable<real<T>>.inc(real<T> x)
            => x.inc();

        [MethodImpl(Inline)]
        real<T> Decrementable<real<T>>.dec(real<T> x)
            => x.dec();

        [MethodImpl(Inline)]
        bool Equatable<real<T>>.eq(real<T> lhs, real<T> rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        bool Equatable<real<T>>.neq(real<T> lhs, real<T> rhs)
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        real<T> Trigonmetric<real<T>>.sin(real<T> x)
            => x.sin();

        [MethodImpl(Inline)]
        real<T> Trigonmetric<real<T>>.sinh(real<T> x)
            => x.sinh();

        [MethodImpl(Inline)]
        real<T> Trigonmetric<real<T>>.asin(real<T> x)
            => x.asin();

        [MethodImpl(Inline)]
        real<T> Trigonmetric<real<T>>.asinh(real<T> x)
            => x.asinh();

        [MethodImpl(Inline)]
        real<T> Trigonmetric<real<T>>.cos(real<T> x)
            => x.cos();

        [MethodImpl(Inline)]
        real<T> Trigonmetric<real<T>>.cosh(real<T> x)
            => x.cosh();

        [MethodImpl(Inline)]
        real<T> Trigonmetric<real<T>>.acos(real<T> x)
            => x.acos();

        [MethodImpl(Inline)]
        real<T> Trigonmetric<real<T>>.acosh(real<T> x)
            => x.acosh();

        [MethodImpl(Inline)]
        real<T> Trigonmetric<real<T>>.tan(real<T> x)
            => x.tan();

        [MethodImpl(Inline)]
        real<T> Trigonmetric<real<T>>.tanh(real<T> x)
            => x.tanh();

        [MethodImpl(Inline)]
        real<T> Trigonmetric<real<T>>.atan(real<T> x)
            => x.atan();

        [MethodImpl(Inline)]
        real<T> Trigonmetric<real<T>>.atanh(real<T> x)
            => x.atanh();

    }
}