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
    
    using static Structures;

    public readonly struct real<T> : IEquatable<real<T>>  //RealNumber<real<T>, T>
        where T : struct, IEquatable<T>
    {
        static readonly Operative.PrimOps<T> Prim = primops.typeops<T>();
        
        static readonly NumberInfo<T> NumInfo = Prim.numinfo;

        public static readonly bool Signed = NumInfo.Signed;

        public static readonly real<T> MinVal = NumInfo.MinVal;

        public static readonly real<T> MaxVal = NumInfo.MaxVal;

        public static readonly real<T> Zero = NumInfo.Zero;

        public static readonly real<T> One = NumInfo.One;

        public static readonly uint BitSize = NumInfo.BitSize;


        [MethodImpl(Inline)]
        public static explicit operator byte(real<T> src)
            => ClrConverter.convert<T,byte>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(real<T> src)
            => ClrConverter.convert<T,sbyte>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator short(real<T> src)
            => ClrConverter.convert<T,short>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator ushort(real<T> src)
            => ClrConverter.convert<T,ushort>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator int(real<T> src)
            => ClrConverter.convert<T,int>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator uint(real<T> src)
            => ClrConverter.convert<T,uint>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator long(real<T> src)
            => ClrConverter.convert<T,long>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator ulong(real<T> src)
            => ClrConverter.convert<T,ulong>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator float(real<T> src)
            => ClrConverter.convert<T,float>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator double(real<T> src)
            => ClrConverter.convert<T,double>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator decimal(real<T> src)
            => ClrConverter.convert<T,decimal>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator real<T>(T src)
            => new real<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(real<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bool operator == (real<T> lhs, real<T> rhs) 
            => Prim.eq(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static bool operator != (real<T> lhs, real<T> rhs) 
            => Prim.neq(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static real<T> operator - (real<T> src) 
            => Prim.negate(src.data);

        [MethodImpl(Inline)]
        public static real<T> operator -- (real<T> src) 
            =>  Prim.dec(src.data);

        [MethodImpl(Inline)]
        public static real<T> operator ++ (real<T> src) 
            => Prim.inc(src.data);

        [MethodImpl(Inline)]
        public static real<T> operator + (real<T> lhs, real<T> rhs) 
            => Prim.add(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static real<T> operator - (real<T> lhs, real<T> rhs) 
            => Prim.sub(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static real<T> operator * (real<T> lhs, real<T> rhs) 
            => Prim.mul(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static real<T> operator / (real<T> lhs, real<T> rhs) 
            => Prim.div(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static real<T> operator % (real<T> lhs, real<T> rhs)
            => Prim.mod(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static bool operator < (real<T> lhs, real<T> rhs) 
            => Prim.lt(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static bool operator <= (real<T> lhs, real<T> rhs) 
            => Prim.lteq(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static bool operator > (real<T> lhs, real<T> rhs) 
            => Prim.gt(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static bool operator >= (real<T> lhs, real<T> rhs) 
            => Prim.gteq(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public real(T src)
            => this.data = src;

        readonly T data;

        public real<T> zero 
        {
            [MethodImpl(Inline)]
            get{return Zero;}
        }

        public real<T> one 
        {
            [MethodImpl(Inline)]
            get{return One;}
        }

        [MethodImpl(Inline)]
        public T unwrap()
            => data;

        [MethodImpl(Inline)]
        public real<T> inc()
            => Prim.inc(data);

        [MethodImpl(Inline)]
        public real<T> dec()
            => Prim.dec(data);

        [MethodImpl(Inline)]
        public real<T> add(real<T> rhs)
            => Prim.add(data, rhs.data);

        [MethodImpl(Inline)]
        public real<T> sub(real<T> rhs)
            => Prim.sub(data, rhs.data);

        [MethodImpl(Inline)]
        public real<T> mul(real<T> rhs)
            => Prim.mul(data,rhs.data);

        [MethodImpl(Inline)]
        public real<T> div(real<T> rhs)
            => Prim.div(data,rhs.data);

        [MethodImpl(Inline)]
        public real<T> mod(real<T> rhs)
            => Prim.mod(data,rhs.data);

        static Quorem<real<T>> translate(Quorem<T> qr)
            => Quorem.define(real(qr.q),real(qr.r));

        [MethodImpl(Inline)]
        public Quorem<real<T>> divrem(real<T> rhs)
            =>  translate(Prim.divrem(data, rhs.data));

        [MethodImpl(Inline)]
        public real<T> negate()
            => Prim.negate(data);

        [MethodImpl(Inline)]
        public bool nonzero()
            => Prim.neq(data, Zero.data);

        [MethodImpl(Inline)]
        public Sign sign()
            => Prim.sign(data);
 
        [MethodImpl(Inline)]
        public real<T> abs()
            => Prim.abs(data);

        [MethodImpl(Inline)]
        public real<T> distributeL((real<T> x, real<T> y) rhs)
            => Prim.add(
                Prim.mul(data, rhs.x.data),  
                Prim.mul(data, rhs.y.data)
                );

        [MethodImpl(Inline)]
        public real<T> distributeR((real<T> x, real<T> y) lhs)
            => Prim.add(
                Prim.mul(lhs.x.data, data),  
                Prim.mul(lhs.y.data, data)
                );

        [MethodImpl(Inline)]
        public bool eq(real<T> rhs)
            => Prim.eq(data,rhs.data);

        [MethodImpl(Inline)]
        public bool neq(real<T> rhs)
            => Prim.neq(data,rhs.data);

        [MethodImpl(Inline)]
        public real<T> gcd(real<T> rhs)
            => Prim.gcd(data,rhs.data);

        [MethodImpl(Inline)]
        public bool gt(real<T> rhs)
            => Prim.gt(data,rhs.data);

        [MethodImpl(Inline)]
        public bool gteq(real<T> rhs)
            => Prim.gteq(data,rhs.data);

        [MethodImpl(Inline)]
        public bool lt(real<T> rhs)
            => Prim.lt(data,rhs.data);

        [MethodImpl(Inline)]
        public bool lteq(real<T> rhs)
            => Prim.lteq(data,rhs.data);

        [MethodImpl(Inline)]
        public bool Equals(real<T> rhs)
            => Prim.eq(data, rhs.data);

        [MethodImpl(Inline)]
        public int CompareTo(real<T> rhs)
            => Prim.CompareTo(data, rhs.data);

        [MethodImpl(Inline)]
        public real<T> muladd(real<T> y, real<T> z)
            => Prim.muladd(data, y.data, z.data);

        [MethodImpl(Inline)]
        public BitString bitstring()
            => Prim.bitstring(data);

        [MethodImpl(Inline)]
        public byte[] bytes()
            => Prim.bytes(data);

        [MethodImpl]
        public bool testbit(int pos)
            => Prim.testbit(data,pos);

        [MethodImpl(Inline)]
        public real<T> sin()
            => Prim.sin(data);

        [MethodImpl(Inline)]
        public real<T> sinh()
            => Prim.sinh(data);

        [MethodImpl(Inline)]
        public real<T> asin()
            => Prim.asin(data);

        [MethodImpl(Inline)]
        public real<T> asinh()
            => Prim.asinh(data);

        [MethodImpl(Inline)]
        public real<T> cos()
            => Prim.cos(data);

        [MethodImpl(Inline)]
        public real<T> cosh()
            => Prim.cosh(data);

        [MethodImpl(Inline)]
        public real<T> acos()
            => Prim.acos(data);

        [MethodImpl(Inline)]
        public real<T> acosh()
            => Prim.acosh(data);

        [MethodImpl(Inline)]
        public real<T> tan()
            => Prim.tan(data);

        [MethodImpl(Inline)]
        public real<T> tanh()
            => Prim.tanh(data);

        [MethodImpl(Inline)]
        public real<T> atan()
            => Prim.atan(data);

        [MethodImpl(Inline)]
        public real<T> atanh()
            => Prim.atanh(data);

        [MethodImpl(Inline)]
        public real<T> pow(int exp)
            => Prim.pow(data,exp);

        [MethodImpl(Inline)]
        public int hash()
            => data.GetHashCode();

         [MethodImpl(Inline)]
        public intg<I> ToIntG<I>()
            where I : struct, IEquatable<I>
                => convert<T,I>(data);

        [MethodImpl(Inline)]
        public real<R> ToRealG<R>()
            where R : struct, IEquatable<R>
                => convert<T,R>(data);

        [MethodImpl(Inline)]   
        public C ToClr<C>()
            where C : struct, IEquatable<C>
                => convert<T,C>(data);

        [MethodImpl(Inline)]
        public floatg<F> ToFloatG<F>()
            where F : struct, IEquatable<F>
                => convert<T,F>(data);

        [MethodImpl(Inline)]
        public string format()
            => data.ToString();

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => hash();

        public override string ToString()
            => format();

    }
}