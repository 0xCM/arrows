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
    
    using systype = System.Numerics.BigInteger;
    using opstype = BigIntOps;

    [TypeClass(typeof(RealInfiniteInt))]
    internal readonly struct BigIntOps : RealInfiniteInt 
    {
    
        public static readonly opstype Inhabitant = default;


        public systype zero 
            => 0;

        public systype one 
            => 1;


        [MethodImpl(Inline)]   
        public opstype instance()
            => Inhabitant;

        public Addition<systype> addition 
            => Addition.define(this);

        public Multiplication<systype> multiplication 
            => Multiplication.define(this);

        public opstype inhabitant 
            => Inhabitant;

        public bool infinite 
            => true;

        public systype ε 
            => zero;

        [MethodImpl(Inline)]   
        public systype add(systype lhs, systype rhs) 
            => lhs + rhs;

        [MethodImpl(Inline)]   
        public systype inc(systype x)
            => ++x;

        [MethodImpl(Inline)]   
        public systype sub(systype lhs, systype rhs) 
            => lhs - rhs;

        [MethodImpl(Inline)]   
        public systype dec(systype x)
            => --x;

        [MethodImpl(Inline)]   
        public systype negate(systype x) 
            => -x;

        [MethodImpl(Inline)]   
        public systype mul(systype lhs, systype rhs) 
            => lhs * rhs;

        [MethodImpl(Inline)]   
        public systype muladd(systype x, systype y,systype z) 
            => x*y + z;

        [MethodImpl(Inline)]   
        public systype div(systype lhs, systype rhs)
            => lhs/rhs;

        [MethodImpl(Inline)]   
        public Quorem<systype> divrem(systype lhs, systype rhs)
            => new Quorem<systype>(lhs/rhs,lhs%rhs);

        [MethodImpl(Inline)]   
        public systype mod(systype lhs, systype rhs) 
            => lhs % rhs;

        [MethodImpl(Inline)]   
        public bool eq(systype lhs, systype rhs) 
            => lhs == rhs;

        [MethodImpl(Inline)]   
        public bool neq(systype lhs, systype rhs) 
            => lhs != rhs;

        [MethodImpl(Inline)]   
        public bool gt(systype lhs, systype rhs) 
            => lhs > rhs;

        [MethodImpl(Inline)]   
        public bool lteq(systype lhs, systype rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]   
        public bool lt(systype lhs, systype rhs) 
            => lhs < rhs;

        [MethodImpl(Inline)]   
        public bool gteq(systype lhs, systype rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]   
        public systype and(systype lhs, systype rhs) 
            => lhs & rhs;

        [MethodImpl(Inline)]   
        public systype or(systype lhs, systype rhs) 
            => lhs | rhs;

        [MethodImpl(Inline)]   
        public systype xor(systype lhs, systype rhs) 
            => lhs ^ rhs;

        [MethodImpl(Inline)]   
        public systype lshift(systype lhs, int rhs) 
            => lhs << rhs;

        [MethodImpl(Inline)]   
        public systype rshift(systype lhs, int rhs) 
            => lhs >> rhs;

        [MethodImpl(Inline)]   
        public systype flip(systype x) 
            => ~ x;


        [MethodImpl(Inline)]   
        public systype pow(systype b, int exp) 
            => fold(repeat(b,(long)exp), mul);

        [MethodImpl(Inline)]   
        public systype abs(systype x)
            => BigInteger.Abs(x);

        [MethodImpl(Inline)]   
        public Sign sign(systype x)
            => x switch
            {
                systype t when x > 0 => Sign.Positive,
                systype t when x < 0 => Sign.Negative,
                _                    => Sign.Neutral                    
            };

        public systype gcd(systype lhs, systype rhs)
            => systype.GreatestCommonDivisor(lhs,rhs);

        [MethodImpl(Inline)]   
        public systype distribute(systype lhs, (systype x, systype y) rhs)
            => lhs * rhs.x + lhs * rhs.y;

        [MethodImpl(Inline)]   
        public systype distribute((systype x, systype y) lhs, systype rhs)
            => lhs.x * rhs + lhs.y * rhs;

        [MethodImpl(Inline)]   
        public systype sqrt(systype x)
            => (systype)Math.Sqrt((double)x);
 
        [MethodImpl(Inline)]   
        public systype ceiling(systype x)
            => (systype)Math.Ceiling((double)x);

        [MethodImpl(Inline)]   
        public systype floor(systype x)
            => (systype)Math.Floor((double)x);

        [MethodImpl(Inline)]   
        public systype sin(systype x)
            => (systype)Math.Sin((double)x);

        [MethodImpl(Inline)]   
        public systype sinh(systype x)
            => (systype)Math.Sinh((double)x);

        [MethodImpl(Inline)]   
        public systype asin(systype x)
            => (systype)Math.Asin((double)x);

        [MethodImpl(Inline)]   
        public systype asinh(systype x)
            => (systype)Math.Asinh((double)x);

        [MethodImpl(Inline)]   
        public systype cos(systype x)
            => (systype)Math.Cos((double)x);

        [MethodImpl(Inline)]   
        public systype cosh(systype x)
            => (systype)Math.Cosh((double)x);

        [MethodImpl(Inline)]   
        public systype acos(systype x)
            => (systype)Math.Acos((double)x);

        [MethodImpl(Inline)]   
        public systype acosh(systype x)
            => (systype)Math.Acosh((double)x);

        [MethodImpl(Inline)]   
        public systype tan(systype x)
            => (systype)Math.Tan((double)x);

        [MethodImpl(Inline)]   
        public systype tanh(systype x)
            => (systype)Math.Tanh((double)x);

        [MethodImpl(Inline)]   
        public systype atan(systype x)
            => (systype)Math.Atan((double)x);

        [MethodImpl(Inline)]   
        public systype atanh(systype x)
                => (systype)Math.Atanh((double)x);
 
        public string bitstring(systype x)
            => x.ToBitString();

        public string hexstring(systype x)
            => x.ToHexString();

    }

}