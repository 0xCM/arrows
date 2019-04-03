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
    /// Represents an integer predicated on (and constrained by) an underlying type
    /// </summary>
    public readonly struct intg<T> : Integer<intg<T>,T>
    {
        static readonly Operative.Integer<T> Ops = Resolver.integer<T>();

        static readonly NumberInfo<T> BaseInfo = Ops.numinfo;

        public static readonly intg<T> Zero = BaseInfo.Zero;

        public static readonly intg<T> One = BaseInfo.One;

        public static readonly bool Signed = BaseInfo.Signed;

        public static readonly intg<T> MinVal = BaseInfo.MinVal;

        public static readonly intg<T> MaxVal = BaseInfo.MaxVal;

        public static readonly intg<T> BitSize = BaseInfo.BitSize;            

        [MethodImpl(Inline)]
        public static explicit operator byte(intg<T> src)
            => convert<byte>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(intg<T> src)
            => convert<sbyte>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator short(intg<T> src)
            => convert<short>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator ushort(intg<T> src)
            => convert<ushort>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator int(intg<T> src)
            => convert<int>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator uint(intg<T> src)
            => convert<uint>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator long(intg<T> src)
            => convert<long>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator ulong(intg<T> src)
            => convert<ulong>(src.data);

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

        public intg<T> bitsize 
            => BitSize;

        public NumberInfo<intg<T>> numinfo 
            => new NumberInfo<intg<T>>((MinVal, MaxVal),Signed,Zero, One, BitSize);

        readonly T data;

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
            => Ops.pow(this.data,rhs);
        
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
            => nonzero() ? Sign.Neutral : 
               this < Zero ? Sign.Negative :
               Sign.Positive;

        [MethodImpl(Inline)]
        public intg<T> gcd(intg<T> rhs)
            => Ops.gcd(data, rhs);

        [MethodImpl(Inline)]
        public BitString bitstring()
            => Ops.bitstring(data);

        [MethodImpl(Inline)]
        public intg<T> distributeL((intg<T> x, intg<T>y) rhs)
            => this * rhs.x + this * rhs.y;
 
        [MethodImpl(Inline)]
        public intg<T> distributeR((intg<T> x, intg<T> y) rhs)
            => rhs.x * this + rhs.y * this;

        [MethodImpl(Inline)]
        public bool nonzero()
            => Ops.nonzero(data);

        [MethodImpl(Inline)]
        public byte[] digits()
            => (from c in data.ToString() select byte.Parse(c.ToString())).ToArray();
        
        [MethodImpl(Inline)]
        public intg<T> muladd(intg<T> y, intg<T> z)
            => Ops.muladd(this, y, z);

        [MethodImpl(Inline)]
        public intg<T> sin()
            => Ops.sin(this);

        [MethodImpl(Inline)]
        public intg<T> sinh()
            => Ops.sinh(this);

        [MethodImpl(Inline)]
        public intg<T> asin()
            => Ops.asin(this);

        [MethodImpl(Inline)]
        public intg<T> asinh()
            => Ops.asinh(this);

        [MethodImpl(Inline)]
        public intg<T> cos()
            => Ops.cos(this);

        [MethodImpl(Inline)]
        public intg<T> cosh()
            => Ops.cosh(this);

        [MethodImpl(Inline)]
        public intg<T> acos()
            => Ops.acos(this);

        [MethodImpl(Inline)]
        public intg<T> acosh()
            => Ops.acosh(this);

        [MethodImpl(Inline)]
        public intg<T> tan()
            => Ops.tan(this);

        [MethodImpl(Inline)]
        public intg<T> tanh()
            => Ops.tanh(this);

        [MethodImpl(Inline)]
        public intg<T> atan()
            => Ops.atan(this);

        [MethodImpl(Inline)]
        public intg<T> atanh()
            => Ops.atanh(this);

        [MethodImpl(Inline)]
        public int CompareTo(intg<T> other)
            => throw new NotImplementedException();

        [MethodImpl(Inline)]
        public bool eq(intg<T> lhs, intg<T> rhs)
            => lhs.eq(rhs);
 
        [MethodImpl(Inline)]
        public bool neq(intg<T> lhs, intg<T> rhs)
            => lhs.neq(rhs);
 
        [MethodImpl(Inline)]
        public intg<T> min(intg<T> rhs)
            => rhs < this ? rhs : this;

        [MethodImpl(Inline)]
        public intg<T> max(intg<T> rhs) 
            => rhs > this ? rhs : this;

        [MethodImpl(Inline)]
        public bool Equals(intg<T> rhs)
                => this == rhs;

        [MethodImpl(Inline)]
        public int hash()
            => data.GetHashCode();

        public override int GetHashCode()
            => hash();

        public override bool Equals(object rhs)
            => data.Equals(rhs);
        
        public override string ToString()
            => data.ToString(); 
    }
}