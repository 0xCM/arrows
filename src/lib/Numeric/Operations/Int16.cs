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
    using static Operative;
    
    using operand = System.Int16;
    using reify = Int16Ops;

    [Structure(typeof(reify),typeof(operand))]
    internal readonly struct Int16Ops : FiniteSignedInt<operand>

    {        
        public static readonly reify Inhabitant = default;
    
        public const operand Zero = 0;

        public const operand One = 1;

        public const operand BitSize = sizeof(operand) * 8;

        public const operand MinVal = operand.MinValue;

        public const operand MaxVal = operand.MaxValue;

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

        public operand bitsize 
            => BitSize;

        public bool infinite 
            => false;

        public operand ε 
            => Zero;

        [MethodImpl(Inline)]   
        public bool nonzero(operand x)
            => x != 0;

        [MethodImpl(Inline)]   
        public operand add(operand a, operand b) 
            => (operand)(a + b);

        [MethodImpl(Inline)]   
        public operand and(operand a, operand b) 
            => (operand)(a & b);

        [MethodImpl(Inline)]   
        public Quorem<short> divrem(operand a, operand b)
            => new Quorem<short>((operand) (a/b),(operand)(a%b));

        public operand div(operand lhs, operand rhs)
            => (operand)(lhs/rhs);

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
        public operand negate(operand a) 
            => (operand)(-a);

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
            => (operand)(~ a);

        [MethodImpl(Inline)]   
        public operand rshift(operand a, int shift) 
            => (operand)(a >> shift);

        [MethodImpl(Inline)]   
        public operand pow(operand b, int exp) 
            => fold(repeat(b,exp), mul,One);

        [MethodImpl(Inline)]   
        public operand sub(operand x, operand y) 
            => (operand)(x - y);

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
        public operand dec(operand x)
            => --x;

        [MethodImpl(Inline)]   
        public operand abs(operand x)
            => Math.Abs(x);

        [MethodImpl(Inline)]   
        public Sign sign(operand x)
            => x switch
            {
                operand t when t > 0 => Sign.Positive,
                operand t when t < 0 => Sign.Negative,
                _                    => Sign.Neutral                    
            };

        [MethodImpl(Inline)]   
        public operand distribute(operand lhs, (operand x, operand y) rhs)
            => add(mul(lhs, rhs.x),  mul(lhs, rhs.y));

        [MethodImpl(Inline)]   
        public operand distribute((operand x, operand y) lhs, operand rhs)
            => add(mul(lhs.x, rhs), mul(lhs.y, rhs));

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

       public operand gcd(operand lhs, operand rhs)
        {
            lhs = abs(lhs);
            rhs = abs(lhs);
            while (rhs != Zero)
            {
                var rem = mod(lhs,rhs);
                lhs = rhs;
                rhs = rem;
            }
            return lhs;
        }

        [MethodImpl(Inline)]   
        public BitString bitstring(operand x)
            => BitString.define(x);
    }
 
}