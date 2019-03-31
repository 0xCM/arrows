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

    using operand = System.UInt16;
    using reify = UInt16Ops;

    [Structure(typeof(reify),typeof(operand))]
    internal readonly struct UInt16Ops : Operative.FiniteNatural<operand>
    {
        public static readonly reify Inhabitant = default;
    
        public const operand Zero = 0;

        public const operand One = 1;

        public const uint BitSize = sizeof(operand);

        public const operand MinVal = operand.MinValue;

        public const operand MaxVal = operand.MaxValue;

        public const bool Signed = true;

        public static readonly NumberInfo<operand> Info = new NumberInfo<operand>((MinVal,MaxVal), Signed, Zero, One, BitSize);

        public NumberInfo<operand> numinfo 
            => Info;

        public reify inhabitant 
            => Inhabitant;

        public operand zero 
        {
            [MethodImpl(Inline)]   
            get{return Zero;}
        }

        public operand one
        {
            [MethodImpl(Inline)]   
            get{return One;}
        }


        public uint bitsize 
            => BitSize;

        [MethodImpl(Inline)]               
        public operand negate(operand src)
            => src;

        [MethodImpl(Inline)]   
        public operand add(operand a, operand b) 
            => (operand)(a + b);

        [MethodImpl(Inline)]   
        public operand and(operand a, operand b) 
            => (operand)(a & b);

        [MethodImpl(Inline)]   
        public operand div(operand lhs, operand rhs)
            => (operand)(lhs/rhs);
        
        [MethodImpl(Inline)]   
        public Quorem<operand> divrem(operand a, operand b)
            => new Quorem<operand>((operand)(a/b), (operand)( a%b));

        [MethodImpl(Inline)]   
        public bool eq(operand lhs, operand rhs) 
            => lhs == rhs;

        [MethodImpl(Inline)]   
        public bool neq(operand lhs, operand rhs) 
            => lhs != rhs;

        [MethodImpl(Inline)]   
        public bool gt(operand a, operand b) 
            => a > b;

        [MethodImpl(Inline)]   
        public bool lt(operand a, operand b) 
            => a < b;

        [MethodImpl(Inline)]   
        public operand mod(operand a, operand b) 
            => (operand)(a % b);

        [MethodImpl(Inline)]   
        public operand mul(operand a, operand b) 
            => (operand)(a * b);

        [MethodImpl(Inline)]   
        public operand neg(operand a) 
            => a;

        [MethodImpl(Inline)]   
        public operand or(operand a, operand b) 
            => (operand)(a | b);

        [MethodImpl(Inline)]   
        public operand xor(operand a, operand b) 
            => (operand)(a ^ b);

        [MethodImpl(Inline)]   
        public operand lshift(operand a, int shift) 
            => (operand)(a << shift);

        [MethodImpl(Inline)]   
        public operand flip(operand a) 
            => (operand)~ a;

        [MethodImpl(Inline)]   
        public operand rshift(operand a, int shift) 
            => (operand)(a >> shift);

        [MethodImpl(Inline)]   
        public operand pow(operand b, int exp) 
            => fold(repeat(b,(long)exp), mul);

        [MethodImpl(Inline)]   
        public operand sub(operand x, operand y) 
            => (operand)(x - y);

        [MethodImpl(Inline)]   
        public operand dec(operand x)
            => --x;

        [MethodImpl(Inline)]   
        public operand muladd(operand x, operand y,operand z) 
            => (operand)(x*y + z);

    
        [MethodImpl(Inline)]   
        public bool lteq(operand lhs, operand rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]   
        public bool gteq(operand lhs, operand rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]   
        public operand inc(operand x)
            => ++x;

        [MethodImpl(Inline)]   
        public operand abs(operand x)
            => x;

        [MethodImpl(Inline)]   
        public Sign sign(operand x)
            => x == 0 ? Sign.Neutral : Sign.Positive;

        [MethodImpl(Inline)]   
        public operand distribute(operand lhs, (operand x, operand y) rhs)
            => add(mul(lhs, rhs.x),  mul(lhs, rhs.y));

        [MethodImpl(Inline)]   
        public operand distribute((operand x, operand y) lhs, operand rhs)
            => add(mul(lhs.x, rhs), mul(lhs.y, rhs));

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
        public operand sqrt(operand x)
            => (operand)MathF.Sqrt(x);
 
        [MethodImpl(Inline)]   
        public operand ceiling(operand x)
            => (operand)MathF.Ceiling(x);

        [MethodImpl(Inline)]   
        public operand floor(operand x)
            => (operand)MathF.Floor(x);

        [MethodImpl(Inline)]   
        public operand sin(operand x)
            => (operand)MathF.Sin(x);

        [MethodImpl(Inline)]   
        public operand sinh(operand x)
            => (operand)MathF.Sinh(x);

        [MethodImpl(Inline)]   
        public operand asin(operand x)
            => (operand)MathF.Asin(x);

        [MethodImpl(Inline)]   
        public operand asinh(operand x)
            => (operand)MathF.Asinh(x);

        [MethodImpl(Inline)]   
        public operand cos(operand x)
            => (operand)MathF.Cos(x);

        [MethodImpl(Inline)]   
        public operand cosh(operand x)
            => (operand)MathF.Cosh(x);

        [MethodImpl(Inline)]   
        public operand acos(operand x)
            => (operand)MathF.Acos(x);

        [MethodImpl(Inline)]   
        public operand acosh(operand x)
            => (operand)MathF.Acosh(x);

        [MethodImpl(Inline)]   
        public operand tan(operand x)
            => (operand)MathF.Tan(x);

        [MethodImpl(Inline)]   
        public operand tanh(operand x)
            => (operand)MathF.Tanh(x);

        [MethodImpl(Inline)]   
        public operand atan(operand x)
            => (operand)MathF.Atan(x);

        [MethodImpl(Inline)]   
        public operand atanh(operand x)
            => (operand)MathF.Atanh(x);

        [MethodImpl(Inline)]   
        public string bitstring(operand src)
            => src.ToBitString();
    }
}