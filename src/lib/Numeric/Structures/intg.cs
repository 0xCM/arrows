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

    public static class intG
    {




    }    

    /// <summary>
    /// Represents an integer predicated on (and constrained by) an underlying type
    /// </summary>
    public readonly struct intg<T> : Integer<intg<T>,T>
    {
        static readonly Integer<T> Ops = integer<T>();

        public static readonly intg<T> Zero = Ops.zero;

        public static readonly intg<T> One = Ops.one;

        [MethodImpl(Inline)]
        public static implicit operator intg<T>(T src)
            => new intg<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(intg<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bool operator == (intg<T> lhs, intg<T> rhs) 
            => Ops.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator != (intg<T> a, intg<T> b) 
            => Ops.neq(a,b);

        [MethodImpl(Inline)]
        public static intg<T> operator + (intg<T> lhs, intg<T> rhs) 
            => Ops.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator - (intg<T> lhs, intg<T> rhs) 
            => Ops.sub(lhs, rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator -- (intg<T> x) 
            =>  Ops.dec(x);

        [MethodImpl(Inline)]
        public static intg<T> operator ++ (intg<T> x) 
            => Ops.inc(x);

        [MethodImpl(Inline)]
        public static intg<T> operator - (intg<T> x) 
            => Ops.negate(x);

        [MethodImpl(Inline)]
        public static intg<T> operator * (intg<T> lhs, intg<T> rhs) 
            => Ops.mul(lhs, rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator / (intg<T> lhs, intg<T> rhs) 
            => Ops.div(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator % (intg<T> lhs, intg<T> rhs)
            => Ops.mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator < (intg<T> lhs, intg<T> rhs) 
            => Ops.lt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator <= (intg<T> lhs, intg<T> rhs) 
            => Ops.lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator > (intg<T> lhs, intg<T> rhs) 
            => Ops.gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator >= (intg<T> lhs, intg<T> rhs) 
            => Ops.gteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator & (intg<T> lhs, intg<T> rhs) 
            => Ops.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator | (intg<T> lhs, intg<T> rhs) 
            => Ops.or(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator ^ (intg<T> lhs, intg<T> rhs) 
            => Ops.xor(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator ~ (intg<T> x) 
            => Ops.flip(x);

        [MethodImpl(Inline)]
        public static intg<T> operator >> (intg<T> lhs, int rhs) 
            => Ops.rshift(lhs, rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator << (intg<T> lhs, int rhs) 
            => Ops.lshift(lhs, rhs);

        public T data {get;}

        public intg<T> zero 
        {
            [MethodImpl(Inline)]
            get{return Zero;}
        }

        public intg<T> one 
        {
            [MethodImpl(Inline)]
            get{return One;}
        }


        [MethodImpl(Inline)]
        public intg (T x) 
            => data = x;

        [MethodImpl(Inline)]
        public intg<T> inc()
            => Ops.inc(data);

        [MethodImpl(Inline)]
        public intg<T> dec() 
            => Ops.dec(data);


        [MethodImpl(Inline)]
        public intg<T> negate()
            => Ops.negate(data);

        [MethodImpl(Inline)]
        public intg<T> add(intg<T> rhs)
            => this + rhs;

        [MethodImpl(Inline)]
        public intg<T> sub(intg<T> rhs)
            => this - rhs;

        [MethodImpl(Inline)]
        public intg<T> mul(intg<T> rhs)
            => this * rhs;
        
        [MethodImpl(Inline)]
        public intg<T> div(intg<T> rhs)
            => this / rhs;

        [MethodImpl(Inline)]
        public intg<T> mod(intg<T> rhs)
            => this % rhs;

        [MethodImpl(Inline)]
        public bool divides(intg<T> lhs)
            => lhs % this == Zero;

        [MethodImpl(Inline)]
        public intg<T> pow(int rhs)
            => Ops.pow(data, rhs);
        
        [MethodImpl(Inline)]
        public bool even()
            => this % One.inc() == Zero;

        [MethodImpl(Inline)]
        public bool odd()
            => not(even());

        [MethodImpl(Inline)]
        public Quorem<intg<T>> divrem(intg<T> rhs)
            => apply(Ops.divrem(data,rhs), x => Quorem.define<intg<T>>(x.q,x.r));

        [MethodImpl(Inline)]
        public intg<T> and(intg<T> rhs)
            => this & rhs;

        [MethodImpl(Inline)]
        public intg<T> or(intg<T> rhs)
            => this | rhs;

        [MethodImpl(Inline)]
        public intg<T> xor(intg<T> rhs)
            => this ^ rhs;

        [MethodImpl(Inline)]
        public intg<T> flip()
            => Ops.flip(this);

        [MethodImpl(Inline)]
        public intg<T> lshift(int rhs)
            => this << rhs;

        [MethodImpl(Inline)]
        public intg<T> rshift(int rhs)
            => this >> rhs;

        [MethodImpl(Inline)]
        public bool eq(intg<T> rhs)
            => this == rhs;

        [MethodImpl(Inline)]
        public bool neq(intg<T> rhs)
            => this != rhs;
 
        [MethodImpl(Inline)]
        public bool lteq(intg<T> rhs) 
            => this <= rhs;

        [MethodImpl(Inline)]
        public bool gteq(intg<T> rhs) 
            => this >= rhs;

        [MethodImpl(Inline)]
        public bool lt(intg<T> rhs) 
            => this < rhs;

        [MethodImpl(Inline)]
        public bool gt(intg<T> rhs) 
            => this > rhs;

        [MethodImpl(Inline)]
        public intg<T> abs()
            => Ops.abs(data);

        [MethodImpl(Inline)]
        public Sign sign()
            => Ops.sign(data);

        [MethodImpl(Inline)]
        public intg<T> gcd(intg<T> rhs)
            => Ops.gcd(data, rhs);

        [MethodImpl(Inline)]
        public string bitstring()
            => Ops.bitstring(data);

        [MethodImpl(Inline)]
        public intg<T> distributeL((intg<T> x, intg<T>y) rhs)
            => this * rhs.x + this * rhs.y;
 
        [MethodImpl(Inline)]
        public intg<T> distributeR((intg<T> x, intg<T> y) rhs)
            => rhs.x * this + rhs.y * this;


        /// <summary>
        /// Returns true of the number is nonzero; false otherwise
        /// </summary>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public bool nonzero()
            => this != Zero;

        /// <summary>
        /// Represents the integer as a sequence of 10-based digits
        /// </summary>
        [MethodImpl(Inline)]
        public byte[] digits()
            => (from c in data.ToString() select byte.Parse(c.ToString())).ToArray();

        
        public bool Equals(intg<T> rhs)
            => this == rhs;

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => data.ToString();


    

        //
        //---------------------------------------------------------------------
        intg<T> Nullary<intg<T>>.zero 
            => Zero;

        intg<T> Unital<intg<T>>.one 
            => One;
 
        Addition<intg<T>> SemigroupA<intg<T>>.addition 
            => new Addition<intg<T>>(this);

        Multiplication<intg<T>> SemigroupM<intg<T>>.multiplication 
            => new Multiplication<intg<T>>(this);



        [MethodImpl(Inline)]
        intg<T> Incrementable<intg<T>>.inc(intg<T> x)
            => x.inc();

        [MethodImpl(Inline)]
        intg<T> Decrementable<intg<T>>.dec(intg<T> x)
            => x.dec();

        [MethodImpl(Inline)]
        intg<T> Negatable<intg<T>>.negate(intg<T> x)
            => x.negate();

        [MethodImpl(Inline)]
        intg<T> Number<intg<T>>.abs(intg<T> x)
            => x.abs();
        
        [MethodImpl(Inline)]
        Sign Number<intg<T>>.sign(intg<T> x)
            => x.sign();

        [MethodImpl(Inline)]
        intg<T> Additive<intg<T>>.add(intg<T> lhs, intg<T> rhs)
            => lhs.add(rhs);

        [MethodImpl(Inline)]
        intg<T> Negatable<intg<T>>.sub(intg<T> lhs, intg<T> rhs)
            => lhs.sub(rhs);

        [MethodImpl(Inline)]
        intg<T> Multiplicative<intg<T>>.mul(intg<T> lhs, intg<T> rhs)
            => lhs.mul(rhs);

        [MethodImpl(Inline)]
        intg<T> Number<intg<T>>.muladd(intg<T> x, intg<T> y, intg<T> z)
            => x*y + z;

        [MethodImpl(Inline)]
        intg<T> LeftDistributive<intg<T>>.distribute(intg<T> lhs, (intg<T> x, intg<T> y) rhs)
            => lhs.distributeL(rhs);

        [MethodImpl(Inline)]
        intg<T> RightDistributive<intg<T>>.distribute((intg<T> x, intg<T> y) lhs, intg<T> rhs)
            => rhs.distributeL(lhs);

        [MethodImpl(Inline)]
        intg<T> Divisive<intg<T>>.div(intg<T> lhs, intg<T> rhs)
            => lhs.div(rhs);

        [MethodImpl(Inline)]
        Quorem<intg<T>> Divisive<intg<T>>.divrem(intg<T> lhs, intg<T> rhs)
            => lhs.divrem(rhs);

        [MethodImpl(Inline)]
        intg<T> Divisive<intg<T>>.mod(intg<T> lhs, intg<T> rhs)
            => lhs.mod(rhs);

        [MethodImpl(Inline)]
        intg<T> Divisive<intg<T>>.gcd(intg<T> lhs, intg<T> rhs)
            => lhs.gcd(rhs);

        [MethodImpl(Inline)]
        intg<T> Powered<intg<T>, int>.pow(intg<T> b, int exp)
            => b.pow(exp);

        [MethodImpl(Inline)]
        bool Ordered<intg<T>>.lt(intg<T> lhs, intg<T> rhs)
            => lhs.lt(rhs);

        [MethodImpl(Inline)]
        bool Ordered<intg<T>>.lteq(intg<T> lhs, intg<T> rhs)
            => lhs.lteq(rhs);

        [MethodImpl(Inline)]
        bool Ordered<intg<T>>.gt(intg<T> lhs, intg<T> rhs)
            => lhs.gt(rhs);

        [MethodImpl(Inline)]
        bool Ordered<intg<T>>.gteq(intg<T> lhs, intg<T> rhs)
            => lhs.gteq(rhs);

        [MethodImpl(Inline)]
        bool Equatable<intg<T>>.eq(intg<T> lhs, intg<T> rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        bool Equatable<intg<T>>.neq(intg<T> lhs, intg<T> rhs)
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        intg<T> BitLogic<intg<T>>.and(intg<T> lhs, intg<T> rhs)
            => lhs & rhs;

        [MethodImpl(Inline)]
        intg<T> BitLogic<intg<T>>.or(intg<T> lhs, intg<T> rhs)
            => lhs.or(rhs);

        [MethodImpl(Inline)]
        intg<T> BitLogic<intg<T>>.xor(intg<T> lhs, intg<T> rhs)
            => lhs.xor(rhs);

        [MethodImpl(Inline)]
        intg<T> BitLogic<intg<T>>.flip(intg<T> x)
            => x.flip();

        [MethodImpl(Inline)]
        intg<T> BitShifts<intg<T>>.lshift(intg<T> lhs, int rhs)
            => lhs.lshift(rhs);

        [MethodImpl(Inline)]
        intg<T> BitShifts<intg<T>>.rshift(intg<T> lhs, int rhs)
            => lhs.rshift(rhs);

        [MethodImpl(Inline)]
        string Number<intg<T>>.bitstring(intg<T> x)
            => x.bitstring();

    }
}