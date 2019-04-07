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

    /// <summary>
    /// Represents an floateger predicated on (and constrained by) an underlying type
    /// </summary>
    public readonly struct floatg<T> : Floating<floatg<T>,T>
    {
        static readonly Operative.Floating<T> Ops = Resolver.floating<T>();

        static readonly NumberInfo<T> UnderInfo = Ops.numinfo;

        public static readonly bool Signed = UnderInfo.Signed;

        public static readonly floatg<T> MinVal = UnderInfo.MinVal;

        public static readonly floatg<T> MaxVal = UnderInfo.MaxVal;

        public static readonly floatg<T> Zero = Ops.zero;

        public static readonly floatg<T> One = Ops.one;

        public static readonly floatg<T> Epsilon = Ops.epsilon;

        public static readonly floatg<T> BitSize = UnderInfo.BitSize;
        
        
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

        public NumberInfo<floatg<T>> numinfo 
            => new NumberInfo<floatg<T>>((MinVal, MaxVal),Signed,Zero, One, BitSize);

        readonly T data;

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

        public floatg<T> epsilon 
        {
            [MethodImpl(Inline)]
            get{return Epsilon;}
        }
        public floatg<T> bitsize 
        {
            [MethodImpl(Inline)]
            get{return BitSize;}
        }

        [MethodImpl(Inline)]
        public floatg (T x) 
            => data = x;

        [MethodImpl(Inline)]
        public T unwrap()
            => data;

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

        // [MethodImpl(Inline)]
        // public Quorem<floatg<T>> divrem(floatg<T> rhs)
        //     => apply(Ops.divrem(data,rhs), x => Quorem.define<floatg<T>>(x.q,x.r));

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
        public BitString bitstring()
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

        [MethodImpl(Inline)]
        public intg<I> intg<I>()
            where I : IConvertible
            => convert<I>(data);

        [MethodImpl(Inline)]
        public bool Equals(floatg<T> rhs)
            => this == rhs;

        [MethodImpl(Inline)]
        public floatg<T> muladd(floatg<T> y, floatg<T> z)
            => Ops.muladd(this.data,y,z);

        [MethodImpl(Inline)]
        public floatg<T> pow(int exp)
            => Ops.pow(this,exp);

        [MethodImpl(Inline)]
        public floatg<T> resign(Sign sign)
            => Ops.resign(data, sign);

        [MethodImpl(Inline)]
        public int hash()
            => data.GetHashCode();

        public override int GetHashCode()
            => hash();

        public override bool Equals(object rhs)
            => data.Equals(rhs);


        public override string ToString()
            => data.ToString();

        public int CompareTo(floatg<T> other)
            => throw new NotImplementedException();

    }
}