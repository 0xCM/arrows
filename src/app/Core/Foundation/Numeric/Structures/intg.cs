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

    using static corefunc;
    using static Traits;

    public static class intG
    {




    }    

    /// <summary>
    /// Represents an integer predicated on (and constrained by) an underlying type
    /// </summary>
    public readonly struct intg<T> : Integer<intg<T>,T> 
    {
        static readonly Integer<T> ops = integer<T>();

        public static readonly intg<T> Zero = ops.zero;

        public static readonly intg<T> One = ops.one;

        [MethodImpl(Inline)]
        public static implicit operator intg<T>(T src)
            => new intg<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(intg<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bool operator == (intg<T> lhs, intg<T> rhs) 
            => ops.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator != (intg<T> a, intg<T> b) 
            => ops.neq(a,b);

        [MethodImpl(Inline)]
        public static intg<T> operator + (intg<T> lhs, intg<T> rhs) 
            => ops.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator ++ (intg<T> x) 
            => ops.inc(x);


        [MethodImpl(Inline)]
        public static intg<T> operator - (intg<T> lhs, intg<T> rhs) 
            => ops.sub(lhs, rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator -- (intg<T> x) 
            =>  ops.dec(x);

        [MethodImpl(Inline)]
        public static intg<T> operator * (intg<T> lhs, intg<T> rhs) 
            => ops.mul(lhs, rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator / (intg<T> lhs, intg<T> rhs) 
            => ops.div(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator % (intg<T> lhs, intg<T> rhs)
            => ops.mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator < (intg<T> lhs, intg<T> rhs) 
            => ops.lt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator <= (intg<T> lhs, intg<T> rhs) 
            => ops.lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator > (intg<T> lhs, intg<T> rhs) 
            => ops.gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator >= (intg<T> lhs, intg<T> rhs) 
            => ops.gteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator & (intg<T> lhs, intg<T> rhs) 
            => ops.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator | (intg<T> lhs, intg<T> rhs) 
            => ops.or(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator ^ (intg<T> lhs, intg<T> rhs) 
            => ops.xor(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator ~ (intg<T> x) 
            => ops.flip(x);

        [MethodImpl(Inline)]
        public static intg<T> operator >> (intg<T> lhs, int rhs) 
            => ops.rshift(lhs, rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator << (intg<T> lhs, int rhs) 
            => ops.lshift(lhs, rhs);

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
        public intg<T> add(intg<T> rhs)
            => this + rhs;

        [MethodImpl(Inline)]
        public intg<T> inc()
            => ops.inc(data);

        [MethodImpl(Inline)]
        public intg<T> sub(intg<T> rhs)
            => this - rhs;

        [MethodImpl(Inline)]
        public intg<T> dec() 
            => ops.dec(data);

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
        public bool even()
            => this % One.inc() == Zero;

        [MethodImpl(Inline)]
        public bool odd()
            => not(even());

        [MethodImpl(Inline)]
        public Quorem<intg<T>> divrem(intg<T> rhs)
            => map(ops.divrem(data,rhs), x => Quorem.define<intg<T>>(x.q,x.r));

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
            => ops.flip(this);

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
            => ops.abs(data);

        [MethodImpl(Inline)]
        public Sign sign()
            => ops.sign(data);

        [MethodImpl(Inline)]
        public intg<T> gcd(intg<T> rhs)
            => ops.gcd(data, rhs);

        [MethodImpl(Inline)]
        public string bitstring()
            => ops.bitstring(data);

        [MethodImpl(Inline)]
        public intg<T> distributeL((intg<T> x, intg<T>y) rhs)
            => this * rhs.x + this * rhs.y;
 
        [MethodImpl(Inline)]
        public intg<T> distributeR((intg<T> x, intg<T> y) rhs)
            => rhs.x * this + rhs.y * this;

        [MethodImpl(Inline)]
        int IComparable<intg<T>>.CompareTo(intg<T> rhs)
            => this < rhs ? -1
             : this > rhs ? 1
             : 0;

        /// <summary>
        /// Returns true of the number is nonzero; false otherwise
        /// </summary>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public bool nonzero()
            => this != Zero;

        [MethodImpl(Inline)]
        public intg<T> negate()
            => ops.negate(data);

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

    }
}