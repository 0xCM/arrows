//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;

    using static Traits;
    using operand = System.Double;
    using reify = Float64Ops;
    using SysMath = System.Math;

    [TypeClass(typeof(reify),typeof(operand))]
    internal readonly struct Float64Ops :  FiniteFloat<reify,operand> 
    {        
        public static readonly reify Inhabitant = default;
    
        public const operand Zero = 0;

        public const operand One = 1;

        public const uint BitSize = sizeof(operand);

        public const operand MinVal = operand.MinValue;            

        public const operand MaxVal = operand.MaxValue;

        public const operand Epsilon = operand.Epsilon;

        public const bool Signed = true;

        public static readonly NumberInfo<operand> Info = new NumberInfo<operand>((MinVal,MaxVal), Signed, Zero, One, BitSize);

        public NumberInfo<operand> numinfo 
            => Info;

        public reify inhabitant 
            => Inhabitant;

        public operand zero 
            => Zero;

        public operand one 
            => One;

        public operand epsilon
            => Epsilon;

        public uint bitsize 
            => BitSize;

        public Addition<operand> addition 
            => Addition.define(this);

        public Multiplication<operand> multiplication 
            => Multiplication.define(this);

        public bool infinite 
            => false;

        public operand inc(operand x)
            => ++x;

        public operand dec(operand x)
            => --x;

        [MethodImpl(Inline)]   
        public operand add(operand a, operand b) 
            => a + b;

        [MethodImpl(Inline)]   
        public operand div(operand a, operand b)
            => a / b;

        [MethodImpl(Inline)]   
        public bool eq(operand lhs, operand rhs) 
            => lhs == rhs;

        [MethodImpl(Inline)]   
        public bool neq(operand lhs, operand rhs) 
            => lhs != rhs;

        [MethodImpl(Inline)]   
        public bool gt(operand lhs, operand rhs) 
            => lhs > rhs;

        [MethodImpl(Inline)]   
        public bool lt(operand a, operand b) 
            => a < b;

        [MethodImpl(Inline)]   
        public operand mod(operand a, operand b) 
            => a % b;

        [MethodImpl(Inline)]   
        public operand mul(operand a, operand b) 
            => a * b;

        [MethodImpl(Inline)]   
        public operand muladd(operand x, operand y, operand z)
            => SysMath.FusedMultiplyAdd(x,y,z);

        [MethodImpl(Inline)]   
        public operand negate(operand a) 
            => -a;

        [MethodImpl(Inline)]   
        public operand pow(operand b, int exp) 
            => SysMath.Pow(b,exp);

        [MethodImpl(Inline)]   
        public operand sub(operand x, operand y) 
            => x - y;

        [MethodImpl(Inline)]   
        public operand acos(operand x)
            => SysMath.Acos(x);

        [MethodImpl(Inline)]   
        public operand acosh(operand x)
            => SysMath.Acosh(x);

        [MethodImpl(Inline)]   
        public operand asin(operand x)
            => SysMath.Asin(x);

        [MethodImpl(Inline)]   
        public operand asinh(operand x)
            => SysMath.Asinh(x);

        [MethodImpl(Inline)]   
        public operand atan(operand x)
            => SysMath.Atan(x);

        [MethodImpl(Inline)]   
        public operand atanh(operand x)
            => SysMath.Atanh(x);

        [MethodImpl(Inline)]   
        public operand cos(operand x)
            => SysMath.Cos(x);

        [MethodImpl(Inline)]   
        public operand cosh(operand x)
            => SysMath.Cosh(x);

        [MethodImpl(Inline)]   
        public operand sin(operand x)
            => SysMath.Sin(x);

        [MethodImpl(Inline)]   
        public operand sinh(operand x)
            => SysMath.Sinh(x);
        
        [MethodImpl(Inline)]   
        public operand tan(operand x)
            => SysMath.Tan(x);

        [MethodImpl(Inline)]   
        public operand tanh(operand x)
            => SysMath.Tanh(x);
            
        [MethodImpl(Inline)]   
        public bool lteq(operand lhs, operand rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]   
        public bool gteq(operand lhs, operand rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]   
        public Sign sign(operand x)
            => x switch
            {
                operand t when t > 0 => Sign.Positive,
                operand t when t < 0 => Sign.Negative,
                _                    => Sign.Neutral                    
            };

        [MethodImpl(Inline)]   
        public operand ceiling(operand x)
            => SysMath.Ceiling(x);

        [MethodImpl(Inline)]   
        public operand floor(operand x)
            => SysMath.Floor(x);

        [MethodImpl(Inline)]   
        public operand sqrt(operand x)
            => SysMath.Sqrt(x);

        [MethodImpl(Inline)]   
        public operand distribute(operand lhs, (operand x, operand y) rhs)
            => lhs * rhs.x + lhs * rhs.y;

        [MethodImpl(Inline)]   
        public operand distribute((operand x, operand y) lhs, operand rhs)
            => lhs.x * rhs + lhs.y * rhs;

        public IEnumerable<operand> partition(operand min, operand max, operand width)
        {
            var current = min;
            width = width != 0 ? width : operand.Epsilon;
            while(current <= max)
            {
                yield return current;
                current += width;
            }            
        }

        [MethodImpl(Inline)]
        public operand abs(operand x)
            => SysMath.Abs(x);

        public operand gcd(operand lhs, operand rhs)
        {
            while (rhs != Zero)
            {
                var rem = mod(lhs,rhs);
                lhs = rhs;
                rhs = rem;
            }
            return lhs;
        }

        [MethodImpl(Inline)]   
        public Quorem<operand> divrem(operand lhs, operand rhs)
            => new Quorem<operand>(lhs/rhs,lhs%rhs);

        [MethodImpl(Inline)]   
        public operand and(operand lhs, operand rhs)
            => (long)lhs & (long)rhs;

        [MethodImpl(Inline)]   
        public operand or(operand lhs, operand rhs)
            => (long)lhs | (long)rhs;

        [MethodImpl(Inline)]   
        public operand xor(operand lhs, operand rhs)
            => (long)lhs ^ (long)rhs;

        [MethodImpl(Inline)]   
        public operand flip(operand x)
            => ~(long)x;

        [MethodImpl(Inline)]   
        public operand lshift(operand lhs, int rhs)
            => (long)lhs << rhs;

        [MethodImpl(Inline)]   
        public operand rshift(operand lhs, int rhs)
            => (long)lhs >> rhs;
                
        [MethodImpl(Inline)]   
        public string bitstring(double x)
            => x.ToBitString();


    }
 
}