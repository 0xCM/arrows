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
        where T : struct, IEquatable<T>
    {
        static readonly Operative.PrimOps<T> Prim = primops.type<T>();

        static readonly NumberInfo<T> NumInfo = Prim.numinfo;

        public static readonly bool Signed = NumInfo.Signed;

        public static readonly num<T> MinVal = NumInfo.MinVal;

        public static readonly num<T> MaxVal = NumInfo.MaxVal;

        public static readonly num<T> Zero = NumInfo.Zero;

        public static readonly num<T> One = NumInfo.One;

        public static readonly uint BitSize = NumInfo.BitSize;


        [MethodImpl(Inline)]
        public static implicit operator num<T>(T src)
            => new num<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(num<T> src)
            => src.data;        

        [MethodImpl(Inline)]
        public static bool operator == (num<T> lhs, num<T> rhs) 
            => Prim.eq(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static bool operator != (num<T> lhs, num<T> rhs) 
            => Prim.neq(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static num<T> operator - (num<T> src) 
            => Prim.negate(src.data);

        [MethodImpl(Inline)]
        public static num<T> operator ++ (num<T> src) 
            => Prim.inc(src.data);

        [MethodImpl(Inline)]
        public static num<T> operator -- (num<T> src) 
            => Prim.dec(src.data);

        [MethodImpl(Inline)]
        public static num<T> operator + (num<T> lhs, num<T> rhs) 
            => Prim.add(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static num<T> operator - (num<T> lhs, num<T> rhs) 
            => Prim.sub(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static num<T> operator * (num<T> lhs, num<T> rhs) 
            => Prim.mul(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static num<T> operator / (num<T> lhs, num<T> rhs) 
            => Prim.div(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static num<T> operator % (num<T> lhs, num<T> rhs)
            => Prim.mod(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static bool operator < (num<T> lhs, num<T> rhs) 
            => Prim.lt(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static bool operator <= (num<T> lhs, num<T> rhs) 
            => Prim.lteq(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static bool operator > (num<T> lhs, num<T> rhs) 
            => Prim.gt(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static bool operator >= (num<T> lhs, num<T> rhs) 
            => Prim.gteq(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public num(T src)
            => this.data = src;

        [MethodImpl(Inline)]
        public T unwrap()
            => data;

        readonly T data;

        public num<T> zero 
        {
            [MethodImpl(Inline)]
            get{return Zero;}
        }

        public num<T> one 
        {
            [MethodImpl(Inline)]
            get{return One;}
        }


        [MethodImpl(Inline)]
        public num<T> add(num<T> rhs)
            => Prim.add(data, rhs.data);

        [MethodImpl(Inline)]
        public num<T> sub(num<T> rhs)
            => Prim.sub(data, rhs.data);

        [MethodImpl(Inline)]
        public num<T> mul(num<T> rhs)
            => Prim.mul(data, rhs.data);

        [MethodImpl(Inline)]
        public num<T> div(num<T> rhs)
            => Prim.div(data, rhs.data);

        [MethodImpl(Inline)]
        public num<T> gcd(num<T> rhs)
            => Prim.gcd(data, rhs.data);

        [MethodImpl(Inline)]
        public bool eq(num<T> rhs)
            => Prim.eq(data,rhs.data);

        [MethodImpl(Inline)]
        public num<T> mod(num<T> rhs)
            => Prim.mod(data,rhs.data);

        [MethodImpl(Inline)]
        public bool neq(num<T> rhs)
            => Prim.neq(data,rhs.data);

        [MethodImpl(Inline)]
        public Sign sign()
            => Prim.sign(data);

        [MethodImpl(Inline)]
        public num<T> inc()
            => Prim.inc(data);
 
        [MethodImpl(Inline)]
        public num<T> dec()
            => Prim.dec(data);

        [MethodImpl(Inline)]
        public bool lt(num<T> rhs)
            => Prim.lt(data,rhs.data);

        [MethodImpl(Inline)]
        public bool lteq(num<T> rhs)
            => Prim.lteq(data,rhs.data);

        [MethodImpl(Inline)]
        public bool gt(num<T> rhs)
            => Prim.gt(data,rhs.data);

        [MethodImpl(Inline)]
        public bool gteq(num<T> rhs)
            => Prim.gteq(data,rhs.data);

        [MethodImpl(Inline)]
        public num<T> abs()
            => Prim.abs(data);

        [MethodImpl(Inline)]
         public BitString bitstring()
            => Prim.bitstring(this);

        [MethodImpl(Inline)]
        public byte[] bytes()
            => Prim.bytes(data);

        [MethodImpl]
        public bool testbit(int pos)
            => Prim.testbit(data,pos);

        [MethodImpl(Inline)]
        public int CompareTo(num<T> rhs)
            => Prim.CompareTo(data, rhs.data);

        [MethodImpl(Inline)]
        public num<T> distributeL((num<T> x, num<T>y) rhs)
            => Prim.add(
                Prim.mul(data, rhs.x),  
                Prim.mul(data, rhs.y)
                );
 
        [MethodImpl(Inline)]
        public num<T> distributeR((num<T> x, num<T> y) rhs)
            => Prim.add(
                Prim.mul(rhs.x, data),  
                Prim.mul(rhs.y, data)
                );

        [MethodImpl(Inline)]
        public num<T> negate()
            => Prim.negate(data);
  
        [MethodImpl(Inline)]
        public bool Equals(num<T> rhs)
            => Prim.eq(data, rhs.data);

        [MethodImpl(Inline)]
        public num<T> muladd(num<T> y, num<T> z)
            => Prim.muladd(data,y.data,z.data);

        [MethodImpl(Inline)]
        public num<T> pow(int exp)
            => Prim.pow(data, exp);
 
        [MethodImpl(Inline)]
        public num<T> sin()
            => Prim.sin(data);

        [MethodImpl(Inline)]
        public num<T> sinh()
            => Prim.sinh(data);

        [MethodImpl(Inline)]
        public num<T> asin()
            => Prim.asin(data);

        [MethodImpl(Inline)]
        public num<T> asinh()
            => Prim.asinh(data);

        [MethodImpl(Inline)]
        public num<T> cos()
            => Prim.cos(data);

        [MethodImpl(Inline)]
        public num<T> cosh()
            => Prim.cosh(data);

        [MethodImpl(Inline)]
        public num<T> acos()
            => Prim.acos(data);

        [MethodImpl(Inline)]
        public num<T> acosh()
            => Prim.acosh(data);

        [MethodImpl(Inline)]
        public num<T> tan()
            => Prim.tan(data);

        [MethodImpl(Inline)]
        public num<T> tanh()
            => Prim.tanh(data);

        [MethodImpl(Inline)]
        public num<T> atan()
            => Prim.atan(data);

        [MethodImpl(Inline)]
        public num<T> atanh()
            => Prim.atanh(data);

        [MethodImpl(Inline)]
        public int hash()
            => data.GetHashCode();

        [MethodImpl(Inline)]
        public string format()
            => data.ToString();

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

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => hash();

        public override string ToString()
            => format();
    }
}