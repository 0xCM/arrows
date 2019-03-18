//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Runtime.CompilerServices;

    using Root;

    using static corefunc;

    using C = Core.Contracts;
    using systype = System.Int64;

    partial class MathOps
    {
        readonly struct Int64Ops : C.BoundSignedInt<systype>
        {
        
            public static readonly Int64Ops Inhabitant = default(Int64Ops);

            public systype zero => 0;

            public systype one => 1;

            public systype maxval => systype.MaxValue;

            public systype minval => systype.MaxValue;

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
            public QR<systype> divrem(systype lhs, systype rhs)
                => new QR<systype>(lhs/rhs,lhs%rhs);

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
                => fold(repeat(b,exp), mul); 

            [MethodImpl(Inline)]   
            public systype abs(systype x)
                => Math.Abs(x);

           [MethodImpl(Inline)]   
           public Sign sign(systype x)
                => x switch
                {
                    systype t when t > 0 => Sign.Positive,
                    systype t when t < 0 => Sign.Negative,
                    _                    => Sign.Neutral                    
                };
       }

    }
}