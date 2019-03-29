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

    using operand = System.Decimal;
    using reify = DecimalOps;
    using Currency = Traits.Currency<decimal>;

    [TypeClass(typeof(reify),typeof(operand))]
    internal readonly struct DecimalOps : Traits.Currency<reify,operand>
    {
        
        public static readonly reify Inhabitant = default;
    
        public const operand Zero = 0;

        public const operand One = 1;

        
        public const operand MinVal = operand.MinValue;            

        public const operand MaxVal = operand.MaxValue;

        public (operand min, operand max)? limits 
            => (MinVal,MaxVal);

        public operand zero 
            => Zero;

        public operand one 
            => One;

        public operand maxval 
            => MinVal;

        public operand minval 
            => MaxVal;

        public reify inhabitant 
            => Inhabitant;

        public Addition<operand> addition 
            => Addition.define(this);

        public Multiplication<operand> multiplication 
            => Multiplication.define(this);

        public bool infinite 
            => false;

        public decimal ε 
            => (decimal)Double.Epsilon;

        public decimal infimum 
            => Decimal.MinValue;

        public decimal supremum 
            => Decimal.MaxValue;

        public operand apply(operand lhs, operand rhs)
            => throw new NotImplementedException();

        [MethodImpl(Inline)]   
        public operand add(operand a, operand b) 
            => a + b;

        [MethodImpl(Inline)]   
        public operand inc(operand x)
            => ++x;

        [MethodImpl(Inline)]   
        public operand dec(operand x)
            => --x;

        [MethodImpl(Inline)]   
        public operand div(operand a, operand b)
            => a/b;

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
        public operand muladd(operand x, operand y, operand z)
            => x*y + z;

        [MethodImpl(Inline)]   
        public operand negate(operand a) 
            => -a;

        public operand pow(operand b, int exp)
        {
            throw new NotImplementedException();
        }

        [MethodImpl(Inline)]   
        public operand sub(operand x, operand y) 
            => x - y;

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
            => operand.Ceiling(x);

        [MethodImpl(Inline)]   
        public operand floor(operand x)
            => operand.Floor(x);


        [MethodImpl(Inline)]   
        public operand abs(operand x)
            => Math.Abs(x);

        [MethodImpl(Inline)]   
        public operand distribute(operand lhs, (operand x, operand y) rhs)
            => lhs * rhs.x + lhs * rhs.y;

        [MethodImpl(Inline)]   
        public operand distribute((operand x, operand y) lhs, operand rhs)
            => lhs.x * rhs + lhs.y * rhs;

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
        public operand sqrt(operand x)
            => (operand)Math.Sqrt((double)x);
 

        [MethodImpl(Inline)]   
        public operand sin(operand x)
            => (operand)Math.Sin((double)x);

        [MethodImpl(Inline)]   
        public operand sinh(operand x)
            => (operand)Math.Sinh((double)x);

        [MethodImpl(Inline)]   
        public operand asin(operand x)
            => (operand)Math.Asin((double)x);

        [MethodImpl(Inline)]   
        public operand asinh(operand x)
            => (operand)Math.Asinh((double)x);

        [MethodImpl(Inline)]   
        public operand cos(operand x)
            => (operand)Math.Cos((double)x);

        [MethodImpl(Inline)]   
        public operand cosh(operand x)
            => (operand)Math.Cosh((double)x);

        [MethodImpl(Inline)]   
        public operand acos(operand x)
            => (operand)Math.Acos((double)x);

        [MethodImpl(Inline)]   
        public operand acosh(operand x)
            => (operand)Math.Acosh((double)x);

        [MethodImpl(Inline)]   
        public operand tan(operand x)
            => (operand)Math.Tan((double)x);

        [MethodImpl(Inline)]   
        public operand tanh(operand x)
            => (operand)Math.Tanh((double)x);

        [MethodImpl(Inline)]   
        public operand atan(operand x)
            => (operand)Math.Atan((double)x);

        [MethodImpl(Inline)]   
        public operand atanh(operand x)
                => (operand)Math.Atanh((double)x);


        [MethodImpl(Inline)]   
        public string bitstring(operand src)
            => src.ToBitString();

        public string hexstring(operand src)
            => src.ToHexString();

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
    }
}
