//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    
    using static zcore;
    using static Traits;
    
    using operand = System.Numerics.BigInteger;
    using reify = BigIntOps;

    [Structure(typeof(reify),typeof(operand))]
    internal readonly struct BigIntOps : Operative.InfiniteSignedInt<operand>
    {
    
        public static readonly reify Inhabitant = default;

        public const bool Signed = true;
                
        public const bool Infinite = true;

        public static readonly NumberInfo<operand> Info = new NumberInfo<operand>((0,0), Signed, 0, 1, 0,Infinite);

        public NumberInfo<operand> numinfo 
            => Info;

        public operand zero 
            => 0;

        public operand one 
            => 1;

        [MethodImpl(Inline)]   
        public reify instance()
            => Inhabitant;

        public reify inhabitant 
            => Inhabitant;

        public bool infinite 
            => true;

        public operand ε 
            => zero;

        public uint bitsize 
            => 0;


        [MethodImpl(Inline)]   
        public operand add(operand lhs, operand rhs) 
            => lhs + rhs;

        [MethodImpl(Inline)]   
        public operand inc(operand x)
            => ++x;

        [MethodImpl(Inline)]   
        public operand sub(operand lhs, operand rhs) 
            => lhs - rhs;

        [MethodImpl(Inline)]   
        public operand dec(operand x)
            => --x;

        [MethodImpl(Inline)]   
        public operand negate(operand x) 
            => -x;

        [MethodImpl(Inline)]   
        public operand mul(operand lhs, operand rhs) 
            => lhs * rhs;

        [MethodImpl(Inline)]   
        public operand muladd(operand x, operand y,operand z) 
            => x*y + z;

        [MethodImpl(Inline)]   
        public operand div(operand lhs, operand rhs)
            => lhs/rhs;

        [MethodImpl(Inline)]   
        public Quorem<operand> divrem(operand lhs, operand rhs)
            => new Quorem<operand>(lhs/rhs,lhs%rhs);

        [MethodImpl(Inline)]   
        public operand mod(operand lhs, operand rhs) 
            => lhs % rhs;

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
        public bool lteq(operand lhs, operand rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]   
        public bool lt(operand lhs, operand rhs) 
            => lhs < rhs;

        [MethodImpl(Inline)]   
        public bool gteq(operand lhs, operand rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]   
        public operand and(operand lhs, operand rhs) 
            => lhs & rhs;

        [MethodImpl(Inline)]   
        public operand or(operand lhs, operand rhs) 
            => lhs | rhs;

        [MethodImpl(Inline)]   
        public operand xor(operand lhs, operand rhs) 
            => lhs ^ rhs;

        [MethodImpl(Inline)]   
        public operand lshift(operand lhs, int rhs) 
            => lhs << rhs;

        [MethodImpl(Inline)]   
        public operand rshift(operand lhs, int rhs) 
            => lhs >> rhs;

        [MethodImpl(Inline)]   
        public operand flip(operand x) 
            => ~ x;


        [MethodImpl(Inline)]   
        public operand pow(operand b, int exp) 
            => fold(repeat(b,(long)exp), mul);

        [MethodImpl(Inline)]   
        public operand abs(operand x)
            => BigInteger.Abs(x);

        [MethodImpl(Inline)]   
        public Sign sign(operand x)
            => x switch
            {
                operand t when x > 0 => Sign.Positive,
                operand t when x < 0 => Sign.Negative,
                _                    => Sign.Neutral                    
            };

        public operand gcd(operand lhs, operand rhs)
            => operand.GreatestCommonDivisor(lhs,rhs);

        [MethodImpl(Inline)]   
        public operand distribute(operand lhs, (operand x, operand y) rhs)
            => lhs * rhs.x + lhs * rhs.y;

        [MethodImpl(Inline)]   
        public operand distribute((operand x, operand y) lhs, operand rhs)
            => lhs.x * rhs + lhs.y * rhs;

        [MethodImpl(Inline)]   
        public operand sqrt(operand x)
            => (operand)Math.Sqrt((double)x);
 
        [MethodImpl(Inline)]   
        public operand ceiling(operand x)
            => (operand)Math.Ceiling((double)x);

        [MethodImpl(Inline)]   
        public operand floor(operand x)
            => (operand)Math.Floor((double)x);

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
        public BitString bitstring(operand x)
            => BitString.define(x);

        [MethodImpl(Inline)]   
        public string hexstring(operand x)
            => x.ToHexString();

    }

}