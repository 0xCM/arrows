//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using C = Contracts;
    using static corefunc;

    using system = System.Double;
    using structure = float64;
    using System.Collections.Generic;

    public readonly struct float64 : C.BoundFloat<structure,system>
    {
        static readonly C.BoundFloat<system> ops = MathOps.floating<system>();

        public static readonly structure Zero = ops.zero;
        
        public static readonly structure One = ops.one;
        
        [MethodImpl(Inline)]
        public static structure operator + (structure lhs, structure rhs) 
            => ops.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static structure operator - (structure lhs, structure rhs) 
            => ops.sub(lhs,rhs);

        [MethodImpl(Inline)]
        public static structure operator * (structure lhs, structure rhs) 
            => ops.mul(lhs,rhs);

        [MethodImpl(Inline)]
        public static structure operator / (structure lhs, structure rhs) 
            => ops.div(lhs,rhs);

        [MethodImpl(Inline)]
        public static structure operator % (structure lhs, structure rhs)
            => ops.mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator < (structure lhs, structure rhs) 
            => ops.lt(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static bool operator <= (structure lhs, structure rhs) 
            => ops.lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator > (structure lhs, structure rhs) 
            => ops.gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator >= (structure lhs, structure rhs) 
            => ops.gteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator == (structure lhs, structure rhs) 
            => ops.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator != (structure lhs, structure rhs) 
            => ops.neq(lhs,rhs);

        [MethodImpl(Inline)]
        public static structure operator - (structure x) 
            => ops.negate(x);

        [MethodImpl(Inline)]
        public static structure operator -- (structure x) 
            => ops.dec(x);

        [MethodImpl(Inline)]
        public static structure operator ++ (structure x) 
            => ops.inc(x);

        public system data {get;}

        [MethodImpl(Inline)]
        public float64(system src)
            => data = src;

        public structure zero 
            => ops.zero;

        public float64 one
            => ops.one;

        public structure minval 
            => ops.minval;

        public structure maxval 
            => ops.maxval;

        [MethodImpl(Inline)]
        public Sign sign() 
            => ops.sign(data);

        [MethodImpl(Inline)]
        public float64 pow(int exp)
            => Math.Pow(data,exp);

        [MethodImpl(Inline)]
        public static implicit operator float64(double src) 
            => new float64(src);

        [MethodImpl(Inline)]
        public static implicit operator double(float64 src) 
            => src.data;

        [MethodImpl(Inline)]
        public float64 add(float64 rhs)
            => ops.add(data, rhs);

        [MethodImpl(Inline)]
        public float64 sub(float64 rhs)
            => ops.sub(data, rhs);

        [MethodImpl(Inline)]
        public float64 mul(float64 rhs)
            => ops.mul(data,rhs);

        [MethodImpl(Inline)]
        public float64 div(float64 rhs)
            => ops.div(data,rhs);

        [MethodImpl(Inline)]
        public float64 mod(float64 rhs)
            => ops.mod(data,rhs);

        [MethodImpl(Inline)]
        public float64 negate()
            => ops.negate(data);
        
        [MethodImpl(Inline)]
        public bool lt(float64 rhs)
            => ops.lt(data, rhs);

        [MethodImpl(Inline)]
        public bool lteq(float64 rhs)
            => ops.lteq(data, rhs);

        [MethodImpl(Inline)]
        public bool gt(float64 rhs)
            => ops.gt(data, rhs);

        [MethodImpl(Inline)]
        public bool gteq(structure rhs)
            => ops.gteq(data, rhs);

        [MethodImpl(Inline)]
        public bool eq(structure rhs)
            => ops.eq(data,rhs);

        [MethodImpl(Inline)]
        public bool neq(structure rhs)
            => ops.neq(data,rhs);

        [MethodImpl(Inline)]
        public structure abs() 
            => ops.abs(data);

        [MethodImpl(Inline)]
        public structure ceiling()
            => ops.ceiling(data);

        [MethodImpl(Inline)]
        public structure floor()
            => ops.floor(data);

        [MethodImpl(Inline)]
        public double cos(double x)
            => ops.cos(x);

        [MethodImpl(Inline)]
        public double cosh(double x)
            => ops.cosh(x);

        [MethodImpl(Inline)]
        public double acos(double x)
            => ops.acos(x);

        [MethodImpl(Inline)]
        public double acosh(double x)
            => ops.acosh(x);

        public double sin(double x)
            => ops.sin(x);

        [MethodImpl(Inline)]
        public double sinh(double x)
            => ops.sinh(x);

        [MethodImpl(Inline)]
        public double asin(double x)
            => ops.asin(x);

        [MethodImpl(Inline)]
        public double asinh(double x)
            => ops.asinh(x);

        [MethodImpl(Inline)]
        public double tan(double x)
            => ops.tan(x);

        [MethodImpl(Inline)]
        public double tanh(double x)
            => ops.tanh(x);

        [MethodImpl(Inline)]
        public double atan(double x)
            => ops.atan(x);

        [MethodImpl(Inline)]
        public double atanh(double x)
            => ops.atanh(x);

        [MethodImpl(Inline)]
        public structure inc()
            => ops.inc(data);

        [MethodImpl(Inline)]
        public structure dec()
            => ops.dec(data);

        [MethodImpl(Inline)]
        public IEnumerable<structure> partition(structure min, structure max, structure width = default)
            => ops.partition(min,max,width).Select(x => float64(x));

        [MethodImpl(Inline)]
        public structure cos()
            => ops.cos(data);

        [MethodImpl(Inline)]
        public structure cosh()
            => ops.cosh(data);

        [MethodImpl(Inline)]
        public structure acos()
            => ops.acos(data);

        [MethodImpl(Inline)]
        public structure acosh()
            => ops.acosh(data);

        [MethodImpl(Inline)]
        public structure sin()
            => ops.sin(data);

        [MethodImpl(Inline)]
        public structure sinh()
            => ops.sinh(data);

        [MethodImpl(Inline)]
        public structure asin()
            => ops.asin(data);

        public structure asinh()
            => ops.asinh(data);

        [MethodImpl(Inline)]
         public structure tan()
            => ops.tan(data);

        [MethodImpl(Inline)]
        public structure tanh()
            => ops.tanh(data);

        [MethodImpl(Inline)]
        public structure atan()
            => ops.atan(data);

        [MethodImpl(Inline)]
        public structure atanh()
            => ops.atanh(data);
    
        [MethodImpl(Inline)]
        int IComparable<float64>.CompareTo(float64 other)
            => data.CompareTo(other);

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => data.ToString();
    }
}