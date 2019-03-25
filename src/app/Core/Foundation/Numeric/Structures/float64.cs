//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static corefunc;
    using static Traits;

    using systype = System.Double;
    using structype = float64;

    public readonly struct float64 : FiniteFloat<structype,systype>
    {
        static readonly FiniteFloat<systype> ops = floating<systype>();

        public static readonly structype Zero = ops.zero;
        
        public static readonly structype One = ops.one;
        
        [MethodImpl(Inline)]
        public static structype operator + (structype lhs, structype rhs) 
            => ops.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static structype operator - (structype lhs, structype rhs) 
            => ops.sub(lhs,rhs);

        [MethodImpl(Inline)]
        public static structype operator * (structype lhs, structype rhs) 
            => ops.mul(lhs,rhs);

        [MethodImpl(Inline)]
        public static structype operator / (structype lhs, structype rhs) 
            => ops.div(lhs,rhs);

        [MethodImpl(Inline)]
        public static structype operator % (structype lhs, structype rhs)
            => ops.mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator < (structype lhs, structype rhs) 
            => ops.lt(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static bool operator <= (structype lhs, structype rhs) 
            => ops.lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator > (structype lhs, structype rhs) 
            => ops.gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator >= (structype lhs, structype rhs) 
            => ops.gteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator == (structype lhs, structype rhs) 
            => ops.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator != (structype lhs, structype rhs) 
            => ops.neq(lhs,rhs);

        [MethodImpl(Inline)]
        public static structype operator - (structype x) 
            => ops.negate(x);

        [MethodImpl(Inline)]
        public static structype operator -- (structype x) 
            => ops.dec(x);

        [MethodImpl(Inline)]
        public static structype operator ++ (structype x) 
            => ops.inc(x);

        public systype data {get;}

        [MethodImpl(Inline)]
        public float64(systype src)
            => data = src;

        public structype zero 
            => ops.zero;

        public float64 one
            => ops.one;

        public structype minval 
            => ops.minval;

        public structype maxval 
            => ops.maxval;

        public structype ε
            => ops.ε;

        [MethodImpl(Inline)]
        public Sign sign() 
            => ops.sign(data);

        [MethodImpl(Inline)]
        public structype pow(int exp)
            => Math.Pow(data,exp);

        [MethodImpl(Inline)]
        public static implicit operator structype(systype src) 
            => new structype(src);

        [MethodImpl(Inline)]
        public static implicit operator systype(structype src) 
            => src.data;

        [MethodImpl(Inline)]
        public structype add(structype rhs)
            => this + rhs;

        [MethodImpl(Inline)]
        public structype sub(structype rhs)
            => this - rhs;

        [MethodImpl(Inline)]
        public structype mul(structype rhs)
            => this * rhs;

        [MethodImpl(Inline)]
        public structype div(structype rhs)
            => this / rhs;

        [MethodImpl(Inline)]
        public structype mod(structype rhs)
            => this % rhs;

        [MethodImpl(Inline)]
        public structype negate()
            => -this;
        
        [MethodImpl(Inline)]
        public bool lt(structype rhs)
            => this < rhs;

        [MethodImpl(Inline)]
        public bool lteq(structype rhs)
            => ops.lteq(data, rhs);

        [MethodImpl(Inline)]
        public bool gt(structype rhs)
            => this > rhs;

        [MethodImpl(Inline)]
        public bool gteq(structype rhs)
            => this >= rhs;

        [MethodImpl(Inline)]
        public bool eq(structype rhs)
            => this == rhs;

        [MethodImpl(Inline)]
        public bool neq(structype rhs)
            => this != rhs;

        [MethodImpl(Inline)]
        public structype abs() 
            => ops.abs(data);

        [MethodImpl(Inline)]
        public structype ceiling()
            => ops.ceiling(data);

        [MethodImpl(Inline)]
        public structype floor()
            => ops.floor(data);

        [MethodImpl(Inline)]
        public IEnumerable<structype> partition(structype min, structype max, structype width = default)
            => ops.partition(min,max,width).Select(x => float64(x));

        [MethodImpl(Inline)]
        public structype inc()
            => ops.inc(data);

        [MethodImpl(Inline)]
        public structype dec()
            => ops.dec(data);

        [MethodImpl(Inline)]
        public structype cos()
            => ops.cos(data);

        [MethodImpl(Inline)]
        public structype cosh()
            => ops.cosh(data);

        [MethodImpl(Inline)]
        public structype acos()
            => ops.acos(data);

        [MethodImpl(Inline)]
        public structype acosh()
            => ops.acosh(data);

        [MethodImpl(Inline)]
        public structype sin()
            => ops.sin(data);

        [MethodImpl(Inline)]
        public structype sinh()
            => ops.sinh(data);

        [MethodImpl(Inline)]
        public structype asin()
            => ops.asin(data);

        public structype asinh()
            => ops.asinh(data);

        [MethodImpl(Inline)]
         public structype tan()
            => ops.tan(data);

        [MethodImpl(Inline)]
        public structype tanh()
            => ops.tanh(data);

        [MethodImpl(Inline)]
        public structype atan()
            => ops.atan(data);

        [MethodImpl(Inline)]
        public structype atanh()
            => ops.atanh(data);

        [MethodImpl(Inline)]
        public structype sqrt()
            => ops.sqrt(this);

        [MethodImpl(Inline)]
        public string bitstring()
            => ops.bitstring(data);    

        [MethodImpl(Inline)]
        public structype distributeL((structype x, structype y) rhs)
            => this * rhs.x + this * rhs.y;
 
        [MethodImpl(Inline)]
        public structype distributeR((structype x, structype y) rhs)
            => rhs.x * this + rhs.y * this;

        [MethodImpl(Inline)]
        public structype gcd(structype rhs)
            => ops.gcd(this,rhs);

        [MethodImpl(Inline)]
        public Quorem<structype> divrem(structype rhs)
            => Quorem.define(this/rhs, this % rhs);


        [MethodImpl(Inline)]
        public bool Equals(structype rhs)
            => this == rhs;

        [MethodImpl(Inline)]
        int IComparable<structype>.CompareTo(structype other)
            => data.CompareTo(other);

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => data.ToString();

    }
}