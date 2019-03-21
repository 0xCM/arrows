//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    
    using static corefunc;
    using static Traits;
    
    using systype = System.Numerics.BigInteger;
    using opstype = BigIntOps;

    internal readonly struct BigIntOps : InfiniteSignedInt<systype>, TypeClass<opstype,systype>
    {
    
        public static readonly opstype Inhabitant = default;

        public systype zero => 0;

        public systype one => 1;

        public opstype inhabitant 
            => Inhabitant;

        public Func<systype, systype, systype> addition 
            => add;

        public Func<systype, systype, systype> multiplication 
            => mul;

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

        public string bitstring(systype x)
            => x.ToBitString();

        public string hexstring(systype x)
            => x.ToHexString();

        public systype apply(systype lhs, systype rhs)
        {
            throw new NotImplementedException();
        }
    }


}