//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Root;

    using static corefunc;

    using C = Core.Contracts;
    using systype = System.Int16;
    partial class MathOps
    {
        readonly struct Int16Ops : C.BoundSignedInt<systype>
        {        

            public static readonly Int16Ops Inhabitant = default(Int16Ops);

            public systype zero => 0;

            public systype one => 0;

            public systype maxval => systype.MaxValue;

            public systype minval => systype.MaxValue;

            [MethodImpl(Inline)]   
            public systype add(systype a, systype b) 
                => (systype)(a + b);

            [MethodImpl(Inline)]   
            public systype and(systype a, systype b) 
                => (systype)(a & b);

            [MethodImpl(Inline)]   
            public QR<short> divrem(systype a, systype b)
                => new QR<short>((systype) (a/b),(systype)(a%b));

            public systype div(systype lhs, systype rhs)
                => (systype)(lhs/rhs);

            [MethodImpl(Inline)]   
            public bool eq(systype lhs, systype rhs) 
                => lhs == rhs;

            [MethodImpl(Inline)]   
            public bool neq(systype lhs, systype rhs) 
                => lhs != rhs;

            [MethodImpl(Inline)]   
            public bool gt(systype a, systype b) 
                => a > b;

            [MethodImpl(Inline)]   
            public bool lt(systype a, systype b) 
                => a < b;

            [MethodImpl(Inline)]   
            public systype mod(systype a, systype b) 
                => (systype)(a % b);

            [MethodImpl(Inline)]   
            public systype mul(systype a, systype b) 
                => (systype)(a * b);

            [MethodImpl(Inline)]   
            public systype negate(systype a) 
                => (systype)(-a);

            [MethodImpl(Inline)]   
            public systype or(systype a, systype b) 
                => (systype)(a | b);

            [MethodImpl(Inline)]   
            public systype xor(systype a, systype b) 
                => (systype)(a ^ b);

            [MethodImpl(Inline)]   
            public systype lshift(systype a, int shift) 
                => (systype)(a << shift);

            [MethodImpl(Inline)]   
            public systype flip(systype a) 
                => (systype)(~ a);

            [MethodImpl(Inline)]   
            public systype rshift(systype a, int shift) 
                => (systype)(a >> shift);

            [MethodImpl(Inline)]   
            public systype pow(systype b, int exp) 
                => fold(repeat(b,exp), mul);

            [MethodImpl(Inline)]   
            public systype sub(systype x, systype y) 
                => (systype)(x - y);

            [MethodImpl(Inline)]   
            public systype muladd(systype x, systype y,systype z) 
                => (systype)(x*y + z);
 
            [MethodImpl(Inline)]   
            public bool lteq(systype lhs, systype rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]   
            public bool gteq(systype lhs, systype rhs)
                => lhs >= rhs;

            [MethodImpl(Inline)]   
            public systype inc(systype x)
                => ++x;

            [MethodImpl(Inline)]   
            public systype dec(systype x)
                => --x;

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