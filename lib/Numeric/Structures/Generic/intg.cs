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
        where T : struct, IEquatable<T>
    {
        static readonly Operative.PrimOps<T> Prim = primops.typeops<T>();

        static readonly NumberInfo<T> BaseInfo = Prim.numinfo;

        public static readonly intg<T> Zero = BaseInfo.Zero;

        public static readonly intg<T> One = BaseInfo.One;

        public static readonly intg<T> Two = Prim.inc(One.data);

        public static readonly bool Signed = BaseInfo.Signed;

        public static readonly intg<T> MinVal = BaseInfo.MinVal;

        public static readonly intg<T> MaxVal = BaseInfo.MaxVal;

        public static readonly uint BitSize = BaseInfo.BitSize;            

        
        /// <summary>
        /// Tests all bits in an integer and returns a bitstring reporting the result
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
        /// <remarks>The just a (likely) more expensive aproach for extracting a bitstring from an integer</remarks>
        [MethodImpl(Inline)]   
        public static BitString testall(intg<T> src)
        {
            var len = (int)src.bitsize;
            var bits = new bit[len];
            for(var i = 0; i < len; i++)
                bits[i] = src.testbit(i);
            return new BitString(bits);
        }
        
        [MethodImpl(Inline)]
        public static explicit operator byte(intg<T> src)
            =>  ClrConverter.convert<T,byte>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(intg<T> src)
            => ClrConverter.convert<T,sbyte>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator short(intg<T> src)
            => ClrConverter.convert<T,short>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator ushort(intg<T> src)
            => ClrConverter.convert<T,ushort>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator int(intg<T> src)
            => ClrConverter.convert<T,int>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator uint(intg<T> src)
            => ClrConverter.convert<T,uint>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator long(intg<T> src)
            => ClrConverter.convert<T,long>(src.data);

        [MethodImpl(Inline)]
        public static explicit operator ulong(intg<T> src)
            => ClrConverter.convert<T,ulong>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator intg<T>(T src)
            => new intg<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(intg<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bool operator == (intg<T> lhs, intg<T> rhs) 
            => Prim.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator != (intg<T> a, intg<T> b) 
            => Prim.neq(a,b);

        [MethodImpl(Inline)]
        public static intg<T> operator + (intg<T> lhs, intg<T> rhs) 
            => Prim.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator - (intg<T> lhs, intg<T> rhs) 
            => Prim.sub(lhs, rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator -- (intg<T> x) 
            =>  Prim.dec(x);

        [MethodImpl(Inline)]
        public static intg<T> operator ++ (intg<T> x) 
            => Prim.inc(x);

        [MethodImpl(Inline)]
        public static intg<T> operator - (intg<T> x) 
            => Prim.negate(x);

        [MethodImpl(Inline)]
        public static intg<T> operator * (intg<T> lhs, intg<T> rhs) 
            => Prim.mul(lhs, rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator / (intg<T> lhs, intg<T> rhs) 
            => Prim.div(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator % (intg<T> lhs, intg<T> rhs)
            => Prim.mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator < (intg<T> lhs, intg<T> rhs) 
            => Prim.lt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator <= (intg<T> lhs, intg<T> rhs) 
            => Prim.lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator > (intg<T> lhs, intg<T> rhs) 
            => Prim.gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator >= (intg<T> lhs, intg<T> rhs) 
            => Prim.gteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator & (intg<T> lhs, intg<T> rhs) 
            => Prim.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator | (intg<T> lhs, intg<T> rhs) 
            => Prim.or(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator ^ (intg<T> lhs, intg<T> rhs) 
            => Prim.xor(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator ~ (intg<T> x) 
            => Prim.flip(x);

        [MethodImpl(Inline)]
        public static intg<T> operator >> (intg<T> lhs, int rhs) 
            => Prim.rshift(lhs, rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator << (intg<T> lhs, int rhs) 
            => Prim.lshift(lhs, rhs);

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

        public uint bitsize 
        {
            [MethodImpl(Inline)]
            get{return BitSize;}
        }
        
        readonly T data;

        [MethodImpl(Inline)]
        public intg (T x) 
            => data = x;

        [MethodImpl(Inline)]
        public T unwrap()
            => data;

        [MethodImpl(Inline)]
        public intg<T> inc()
            => Prim.inc(data);

        [MethodImpl(Inline)]
        public intg<T> dec() 
            => Prim.dec(data);

        [MethodImpl(Inline)]
        public intg<T> negate()
            => Prim.negate(data);

        [MethodImpl(Inline)]
        public intg<T> add(intg<T> rhs)
            => Prim.add(data,rhs.data);

        [MethodImpl(Inline)]
        public intg<T> sub(intg<T> rhs)
            => Prim.sub(data,rhs.data);

        [MethodImpl(Inline)]
        public intg<T> mul(intg<T> rhs)
            => Prim.mul(data,rhs.data);
        
        [MethodImpl(Inline)]
        public intg<T> div(intg<T> rhs)
            => Prim.div(data,rhs.data);

        [MethodImpl(Inline)]
        public intg<T> mod(intg<T> rhs)
            => Prim.mod(data,rhs.data);

        [MethodImpl(Inline)]
        public bool divides(intg<T> rhs)
            => Prim.divides(data, rhs);

        [MethodImpl(Inline)]
        public intg<T> pow(int rhs)
            => Prim.pow(data,rhs);
        
        [MethodImpl(Inline)]
        public bool even()
            => Prim.even(data);

        [MethodImpl(Inline)]
        public bool odd()
            => not(even());

        [MethodImpl(Inline)]
        public bool testbit(int pos)            
            => Prim.testbit(data,pos);

        [MethodImpl(Inline)]
        public intg<T> and(intg<T> rhs)
            => Prim.and(data,rhs.data);

        [MethodImpl(Inline)]
        public intg<T> or(intg<T> rhs)
            => Prim.or(data,rhs.data);

        [MethodImpl(Inline)]
        public intg<T> xor(intg<T> rhs)
            => Prim.xor(data,rhs.data);

        [MethodImpl(Inline)]
        public intg<T> flip()
            => Prim.flip(data);

        [MethodImpl(Inline)]
        public intg<T> lshift(int rhs)
            => Prim.lshift(data,rhs);

        [MethodImpl(Inline)]
        public intg<T> rshift(int rhs)
            => Prim.rshift(data,rhs);

        [MethodImpl(Inline)]
        public bool eq(intg<T> rhs)
            => Prim.eq(data,rhs.data);

        [MethodImpl(Inline)]
        public bool neq(intg<T> rhs)
            => Prim.neq(data,rhs.data);
 
        [MethodImpl(Inline)]
        public bool lteq(intg<T> rhs) 
            => Prim.lteq(data,rhs.data);

        [MethodImpl(Inline)]
        public bool gteq(intg<T> rhs) 
            => Prim.gteq(data,rhs.data);

        [MethodImpl(Inline)]
        public bool lt(intg<T> rhs) 
            => Prim.lt(data,rhs.data);

        [MethodImpl(Inline)]
        public bool gt(intg<T> rhs) 
            => Prim.gt(data,rhs.data);

        [MethodImpl(Inline)]
        public intg<T> abs()
            => Prim.abs(data);

        [MethodImpl(Inline)]
        public Sign sign()
            => this == Zero ? Sign.Neutral : 
               this < Zero ? Sign.Negative :
               Sign.Positive;

        [MethodImpl(Inline)]
        public intg<T> gcd(intg<T> rhs)
            => Prim.gcd(data, rhs.data);

        [MethodImpl(Inline)]
        public BitString bitstring()
            => Prim.bitstring(data);

        [MethodImpl(Inline)]
        public byte[] bytes()
            => Prim.bytes(data);

        [MethodImpl(Inline)]
        public intg<T> distributeL((intg<T> x, intg<T>y) rhs)
            => Prim.add(
                Prim.mul(data, rhs.x),  
                Prim.mul(data,  rhs.y)
                );
 
        [MethodImpl(Inline)]
        public intg<T> distributeR((intg<T> x, intg<T> y) rhs)
            => Prim.add(
                Prim.mul(rhs.x, data),  
                Prim.mul(rhs.y, data)
                );

 
        [MethodImpl(Inline)]
        public byte[] digits()
            => (from c in data.ToString() select byte.Parse(c.ToString())).ToArray();
        
        [MethodImpl(Inline)]
        public intg<T> muladd(intg<T> y, intg<T> z)
            => Prim.muladd(data, y.data, z.data);

        [MethodImpl(Inline)]
        public intg<T> sin()
            => Prim.sin(data);

        [MethodImpl(Inline)]
        public intg<T> sinh()
            => Prim.sinh(data);

        [MethodImpl(Inline)]
        public intg<T> asin()
            => Prim.asin(data);

        [MethodImpl(Inline)]
        public intg<T> asinh()
            => Prim.asinh(data);

        [MethodImpl(Inline)]
        public intg<T> cos()
            => Prim.cos(data);

        [MethodImpl(Inline)]
        public intg<T> cosh()
            => Prim.cosh(data);

        [MethodImpl(Inline)]
        public intg<T> acos()
            => Prim.acos(data);

        [MethodImpl(Inline)]
        public intg<T> acosh()
            => Prim.acosh(data);

        [MethodImpl(Inline)]
        public intg<T> tan()
            => Prim.tan(data);

        [MethodImpl(Inline)]
        public intg<T> tanh()
            => Prim.tanh(data);

        [MethodImpl(Inline)]
        public intg<T> atan()
            => Prim.atan(data);

        [MethodImpl(Inline)]
        public intg<T> atanh()
            => Prim.atanh(data);

        [MethodImpl(Inline)]
        public int CompareTo(intg<T> rhs)
            => Prim.CompareTo(data, rhs.data);

        [MethodImpl(Inline)]
        public bool eq(intg<T> lhs, intg<T> rhs)
            => Prim.eq(lhs.data,rhs.data);
 
        [MethodImpl(Inline)]
        public bool neq(intg<T> lhs, intg<T> rhs)
            => Prim.neq(lhs.data,rhs.data);
 
        [MethodImpl(Inline)]
        public intg<T> min(intg<T> rhs)
            => rhs < this ? rhs : this;

        [MethodImpl(Inline)]
        public intg<T> max(intg<T> rhs) 
            => rhs > this ? rhs : this;

        [MethodImpl(Inline)]
        public string format()
            => data.ToString();

        [MethodImpl(Inline)]
        public bool Equals(intg<T> rhs)
                => this == rhs;

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

         public override int GetHashCode()
            => hash();

        public override bool Equals(object rhs)
            => data.Equals(rhs);
        
        public override string ToString()
            => format();
  
    }
}