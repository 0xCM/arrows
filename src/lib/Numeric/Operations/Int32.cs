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

    using operand = System.Int32;
    using reify = Int32Ops;

    [TypeClass(typeof(reify),typeof(operand))]
    internal readonly struct Int32Ops : RealFiniteInt<reify,operand>

    {
        public static readonly reify Inhabitant = default;
    
        public const operand Zero = 0;

        public const operand One = 1;

        public const byte BitSize = 32;

        public const operand MinVal = operand.MinValue;

        public const operand MaxVal = operand.MaxValue;

        public (operand min, operand max)? limits 
            => (MinVal,MaxVal);

        public reify inhabitant 
            => Inhabitant;

        public operand zero 
            => Zero;

        public operand one 
            => One;

        public operand supremum 
            => MinVal;

        public operand infimum 
            => MaxVal;

        public Addition<operand> addition 
            => Addition.define(this);

        public Multiplication<operand> multiplication 
            => Multiplication.define(this);

        public bool infinite 
            => false;

        public operand ε 
            => Zero;

        public operand apply(operand lhs, operand rhs)
            => throw new NotImplementedException();

        [MethodImpl(Inline)]   
        public operand add(operand a, operand b) 
            => a + b;

        [MethodImpl(Inline)]   
        public operand and(operand a, operand b) 
            => a & b;

        [MethodImpl(Inline)]   
        public operand div(operand lhs, operand rhs)
            => lhs/rhs;

        [MethodImpl(Inline)]   
        public Quorem<operand> divrem(operand lhs, operand rhs)
            => new Quorem<operand>(lhs/rhs,lhs%rhs);

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
            => a % b;

        [MethodImpl(Inline)]   
        public operand mul(operand a, operand b) 
            => a * b;

        [MethodImpl(Inline)]   
        public operand negate(operand a) 
            => -a;

        [MethodImpl(Inline)]   
        public operand or(operand a, operand b) 
            => a | b;

        [MethodImpl(Inline)]   
        public operand xor(operand a, operand b) 
            => a ^ b;

        [MethodImpl(Inline)]   
        public operand lshift(operand a, operand shift) 
            => a << shift;

        [MethodImpl(Inline)]   
        public operand flip(operand a) 
            => ~ a;


        [MethodImpl(Inline)]   
        public operand rshift(operand a, operand shift) 
            => a >> shift;

        [MethodImpl(Inline)]   
        public operand pow(operand b, operand exp) 
            => fold(repeat(b,exp), mul);

        [MethodImpl(Inline)]   
        public operand sub(operand x, operand y) 
            => x - y;

        [MethodImpl(Inline)]   
        public operand muladd(operand x, operand y,operand z) 
            => x*y + z;


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
            => (operand)Math.Sqrt(x);
 
        [MethodImpl(Inline)]   
        public operand ceiling(operand x)
            => (operand)Math.Ceiling((double)x);

        [MethodImpl(Inline)]   
        public operand floor(operand x)
            => (operand)Math.Floor((double)x);

        [MethodImpl(Inline)]   
        public operand sin(operand x)
            => (operand)Math.Sin(x);

        [MethodImpl(Inline)]   
        public operand sinh(operand x)
            => (operand)Math.Sinh(x);

        [MethodImpl(Inline)]   
        public operand asin(operand x)
            => (operand)Math.Asin(x);

        [MethodImpl(Inline)]   
        public operand asinh(operand x)
            => (operand)Math.Asinh(x);

        [MethodImpl(Inline)]   
        public operand cos(operand x)
            => (operand)Math.Cos(x);

        [MethodImpl(Inline)]   
        public operand cosh(operand x)
            => (operand)Math.Cosh(x);

        [MethodImpl(Inline)]   
        public operand acos(operand x)
            => (operand)Math.Acos(x);

        [MethodImpl(Inline)]   
        public operand acosh(operand x)
            => (operand)Math.Acosh(x);

        [MethodImpl(Inline)]   
        public operand tan(operand x)
            => (operand)Math.Tan(x);

        [MethodImpl(Inline)]   
        public operand tanh(operand x)
            => (operand)Math.Tanh(x);

        [MethodImpl(Inline)]   
        public operand atan(operand x)
            => (operand)Math.Atan(x);

        [MethodImpl(Inline)]   
        public operand atanh(operand x)
                => (operand)Math.Atanh(x);

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

        public string bitstring(operand src)
            => src.ToBitString();
    }
}
