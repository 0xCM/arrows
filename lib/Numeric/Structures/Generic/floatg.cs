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
    using static zfunc;
    
    using static Structures;

    /// <summary>
    /// Represents an floateger predicated on (and constrained by) an underlying type
    /// </summary>
    public readonly struct floatg<T> : IEquatable<floatg<T>>
            where T : struct, IEquatable<T>
    {        
        static readonly Operative.PrimOps<T> Prim = primops.typeops<T>();

        static readonly NumberInfo<T> NumInfo = Prim.numinfo;

        public static readonly bool Signed = NumInfo.Signed;

        public static readonly floatg<T> MinVal = NumInfo.MinVal;

        public static readonly floatg<T> MaxVal = NumInfo.MaxVal;

        public static readonly floatg<T> Zero = NumInfo.Zero;

        public static readonly floatg<T> One = NumInfo.One;

        public static readonly floatg<T> Epsilon = NumInfo.Epsilon.ValueOrDefault();

        public static readonly uint BitSize = NumInfo.BitSize;
        
        
        [MethodImpl(Inline)]
        public static implicit operator floatg<T>(T src)
            => new floatg<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(floatg<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bool operator == (floatg<T> lhs, floatg<T> rhs) 
            => Prim.eq(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static bool operator != (floatg<T> lhs, floatg<T> rhs) 
            => Prim.neq(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static floatg<T> operator + (floatg<T> lhs, floatg<T> rhs) 
            => Prim.add(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static floatg<T> operator ++ (floatg<T> src) 
            => Prim.inc(src.data);

        [MethodImpl(Inline)]
        public static floatg<T> operator - (floatg<T> lhs, floatg<T> rhs) 
            => Prim.sub(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static floatg<T> operator - (floatg<T> src) 
            => Prim.negate(src.data);

        [MethodImpl(Inline)]
        public static floatg<T> operator -- (floatg<T> src) 
            => Prim.dec(src.data);

        [MethodImpl(Inline)]
        public static floatg<T> operator * (floatg<T> lhs, floatg<T> rhs) 
            => Prim.mul(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static floatg<T> operator / (floatg<T> lhs, floatg<T> rhs) 
            => Prim.div(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static floatg<T> operator % (floatg<T> lhs, floatg<T> rhs)
            => Prim.mod(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static bool operator < (floatg<T> lhs, floatg<T> rhs) 
            => Prim.lt(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static bool operator <= (floatg<T> lhs, floatg<T> rhs) 
            => Prim.lteq(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static bool operator > (floatg<T> lhs, floatg<T> rhs) 
            => Prim.gt(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static bool operator >= (floatg<T> lhs, floatg<T> rhs) 
            => Prim.gteq(lhs.data, rhs.data);

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
        public uint bitsize 
        {
            [MethodImpl(Inline)]
            get{return BitSize;}
        }

        [MethodImpl(Inline)]
        public floatg (T src) 
            => data = src;

        [MethodImpl(Inline)]
        public T unwrap()
            => data;

        [MethodImpl(Inline)]
        public floatg<T> add(floatg<T> rhs)
            => Prim.add(data,rhs.data);

        [MethodImpl(Inline)]
        public floatg<T> inc()
            => Prim.inc(data);

        [MethodImpl(Inline)]
        public floatg<T> sub(floatg<T> rhs)
            => Prim.sub(data,rhs.data);

        [MethodImpl(Inline)]
        public floatg<T> dec() 
            => Prim.dec(data);

        [MethodImpl(Inline)]
        public floatg<T> mul(floatg<T> rhs)
            => Prim.mul(data,rhs.data);
        
        [MethodImpl(Inline)]
        public floatg<T> div(floatg<T> rhs)
            => Prim.div(data,rhs.data);

        [MethodImpl(Inline)]
        public floatg<T> mod(floatg<T> rhs)
            => Prim.mod(data,rhs.data);

        [MethodImpl(Inline)]
        public bool divides(floatg<T> lhs)
            => Prim.eq(Prim.mod(lhs.data, data), Zero.data);

        [MethodImpl(Inline)]
        public bool even()
            => Prim.even(data);

        [MethodImpl(Inline)]
        public bool odd()
            => not(even());

        [MethodImpl(Inline)]
        public bool eq(floatg<T> rhs)
            => Prim.eq(data,rhs.data);

        [MethodImpl(Inline)]
        public bool neq(floatg<T> rhs)
            => Prim.neq(data,rhs.data);
 
        [MethodImpl(Inline)]
        public bool lteq(floatg<T> rhs) 
            => Prim.lteq(data,rhs.data);

        [MethodImpl(Inline)]
        public bool gteq(floatg<T> rhs) 
            => Prim.gteq(data,rhs.data);

        [MethodImpl(Inline)]
        public bool lt(floatg<T> rhs) 
            => Prim.lt(data,rhs.data);

        [MethodImpl(Inline)]
        public bool gt(floatg<T> rhs) 
            => Prim.gt(data,rhs.data);

        [MethodImpl(Inline)]
        public floatg<T> abs()
            => Prim.abs(data);

        [MethodImpl(Inline)]
        public Sign sign()
            => Prim.sign(data);

        [MethodImpl(Inline)]
        public floatg<T> resign(Sign sign)
            => throw new NotImplementedException();

        [MethodImpl(Inline)]
        public floatg<T> gcd(floatg<T> rhs)
            => Prim.gcd(data, rhs);

        [MethodImpl(Inline)]
        public floatg<T> distributeL((floatg<T> x, floatg<T>y) rhs)
            => Prim.add(
                    Prim.mul(rhs.x.data, data), 
                    Prim.mul(rhs.y.data, data)
                    );
 
        [MethodImpl(Inline)]
        public floatg<T> distributeR((floatg<T> x, floatg<T> y) rhs)
            => Prim.add(
                    Prim.mul(rhs.x.data, data), 
                    Prim.mul(rhs.y.data, data)
                    );

        [MethodImpl(Inline)]
        public floatg<T> negate()
            => Prim.negate(data);

        /// <summary>
        /// Represents the floateger as a sequence of 10-based digits
        /// </summary>
        [MethodImpl(Inline)]
        public byte[] digits()
            => (from c in data.ToString() select byte.Parse(c.ToString())).ToArray();

        [MethodImpl(Inline)]
        public floatg<T> sqrt()
            => Prim.sqrt(data);

        [MethodImpl(Inline)]
        public floatg<T> pow(int exp)
            => Prim.pow(this,exp);

        [MethodImpl(Inline)]
        public floatg<T> ceiling()
            => Prim.ceiling(data);

        [MethodImpl(Inline)]
        public floatg<T> floor()
            => Prim.floor(data);

        [MethodImpl(Inline)]
        public floatg<T> cos()
            => Prim.cos(this.data);

        [MethodImpl(Inline)]
        public floatg<T> cosh()
            => Prim.cosh(this.data);

        [MethodImpl(Inline)]
        public floatg<T> acos()
            => Prim.acos(this.data);

        [MethodImpl(Inline)]
        public floatg<T> acosh()
            => Prim.acosh(this.data);

        [MethodImpl(Inline)]
        public floatg<T> sin()
            => Prim.sin(this.data);

        [MethodImpl(Inline)]
        public floatg<T> sinh()
            => Prim.sinh(this.data);

        [MethodImpl(Inline)]
        public floatg<T> asin()
            => Prim.asin(this.data);

        [MethodImpl(Inline)]
        public floatg<T> asinh()
            => Prim.asinh(this.data);

        [MethodImpl(Inline)]
        public floatg<T> tan()
            => Prim.atanh(this.data);

        [MethodImpl(Inline)]
        public floatg<T> tanh()
            => Prim.tanh(this.data);

        [MethodImpl(Inline)]
        public floatg<T> atan()
            => Prim.atan(this.data);

        [MethodImpl(Inline)]
        public floatg<T> atanh()
            => Prim.atanh(this.data); 

        [MethodImpl(Inline)]
        public floatg<T> muladd(floatg<T> y, floatg<T> z)
            => Prim.muladd(data,y.data,z.data);


        [MethodImpl(Inline)]
        public bool testbit(int pos)
            => Prim.TestBit(data, pos);

        [MethodImpl(Inline)]
        public byte[] bytes()
            => Prim.Bytes(data);

        [MethodImpl(Inline)]
        public int hash()
            => data.GetHashCode();

        [MethodImpl(Inline)]
        public string format()
            => data.ToString();
        
        [MethodImpl(Inline)]
        public bool Equals(floatg<T> rhs)
            => Prim.eq(data, rhs.data);


        public override int GetHashCode()
            => hash();

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override string ToString()
            => format();

        [MethodImpl(Inline)]
        public int CompareTo(floatg<T> rhs)
            => Prim.CompareTo(data, rhs.data);


    }
}