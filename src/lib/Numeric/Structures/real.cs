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

    public readonly struct real<T> : Structure.RealNumber<real<T>, T>, Operative.Equatable<real<T>>,  IConvertible
        where T : IConvertible
    {
        static readonly Operative.RealNumber<T> Ops = Resolver.real<T>();
        
        static readonly NumberInfo<T> UnderInfo = Ops.numinfo;

        public static readonly bool Signed = UnderInfo.Signed;

        public static readonly real<T> MinVal = UnderInfo.MinVal;

        public static readonly real<T> MaxVal = UnderInfo.MaxVal;

        public static readonly real<T> Zero = Ops.zero;

        public static readonly real<T> One = Ops.one;

        public static readonly uint BitSize = UnderInfo.BitSize;


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
        public real(T src)
            => this.data = src;

        public T data {get;}

        public bool infinite 
            => false;

        public NumberInfo<real<T>> numinfo
            => new NumberInfo<real<T>>((MinVal, MaxVal),Signed,Zero, One, BitSize);                 


        [MethodImpl(Inline)]
        public real<Y> convert<Y>()    
            where Y : IConvertible        
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
        public string bitstring()
            => Ops.bitstring(data);

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
        public bool neq(real<T> rhs)
            => Ops.neq(data,rhs);

        [MethodImpl(Inline)]
        public bool eq(real<T> lhs, real<T> rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        public bool neq(real<T> lhs, real<T> rhs)
            => lhs.neq(rhs);


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

        public real<T> zero 
            => Ops.zero;

        public real<T> one 
            => Ops.zero;

        [MethodImpl(Inline)]
        public real<T> muladd(real<T> y, real<T> z)
            => Ops.muladd(this, y, z);

        [MethodImpl(Inline)]
        public real<T> sin()
            => Ops.sin(this);

        [MethodImpl(Inline)]
        public real<T> sinh()
            => Ops.sinh(this);

        [MethodImpl(Inline)]
        public real<T> asin()
            => Ops.asin(this);

        [MethodImpl(Inline)]
        public real<T> asinh()
            => Ops.asinh(this);

        [MethodImpl(Inline)]
        public real<T> cos()
            => Ops.cos(this);

        [MethodImpl(Inline)]
        public real<T> cosh()
            => Ops.cosh(this);

        [MethodImpl(Inline)]
        public real<T> acos()
            => Ops.acos(this);

        [MethodImpl(Inline)]
        public real<T> acosh()
            => Ops.acosh(this);

        [MethodImpl(Inline)]
        public real<T> tan()
            => Ops.tan(this);

        [MethodImpl(Inline)]
        public real<T> tanh()
            => Ops.tanh(this);

        [MethodImpl(Inline)]
        public real<T> atan()
            => Ops.atan(this);

        [MethodImpl(Inline)]
        public real<T> atanh()
            => Ops.atanh(this);

        public real<T> pow(int exp)
            => Ops.pow(data, exp);

        #region IConvertible
        [MethodImpl(Inline)]
        TypeCode IConvertible.GetTypeCode()
            => data.GetTypeCode();

        [MethodImpl(Inline)]
        bool IConvertible.ToBoolean(IFormatProvider provider)
            => data.ToBoolean(provider);
 
        [MethodImpl(Inline)]
        byte IConvertible.ToByte(IFormatProvider provider)
            => data.ToByte(provider);

        [MethodImpl(Inline)]
        char IConvertible.ToChar(IFormatProvider provider)
            => data.ToChar(provider);

        [MethodImpl(Inline)]
        DateTime IConvertible.ToDateTime(IFormatProvider provider)
            => data.ToDateTime(provider);

        [MethodImpl(Inline)]
        decimal IConvertible.ToDecimal(IFormatProvider provider)
            => data.ToDecimal(provider);

        [MethodImpl(Inline)]
        double IConvertible.ToDouble(IFormatProvider provider)
            => data.ToDouble(provider);

        [MethodImpl(Inline)]
        short IConvertible.ToInt16(IFormatProvider provider)
            => data.ToInt16(provider);

        [MethodImpl(Inline)]
        int IConvertible.ToInt32(IFormatProvider provider)
            => data.ToInt32(provider);

        [MethodImpl(Inline)]
        long IConvertible.ToInt64(IFormatProvider provider)
            => data.ToInt64(provider);

        [MethodImpl(Inline)]
        sbyte IConvertible.ToSByte(IFormatProvider provider)
            => data.ToSByte(provider);

        [MethodImpl(Inline)]
        float IConvertible.ToSingle(IFormatProvider provider)
            => data.ToSingle(provider);

        [MethodImpl(Inline)]
        string IConvertible.ToString(IFormatProvider provider)
            => data.ToString(provider);

        [MethodImpl(Inline)]
        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
            => data.ToType(conversionType, provider);

        [MethodImpl(Inline)]
        ushort IConvertible.ToUInt16(IFormatProvider provider)
            => data.ToUInt16(provider);

        [MethodImpl(Inline)]
        uint IConvertible.ToUInt32(IFormatProvider provider)
            => data.ToUInt32(provider);

        [MethodImpl(Inline)]
        ulong IConvertible.ToUInt64(IFormatProvider provider)
            => data.ToUInt64(provider);

        #endregion

    }
}