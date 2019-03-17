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
    using systype = System.Decimal;

    partial class MathOps
    {
        readonly struct DecimalOps : C.BoundFractional<systype>
        {
            
            public static readonly DecimalOps Inhabitant = default(DecimalOps);

            public systype zero => 0;

            public systype one => 0;

            public systype maxval => systype.MaxValue;

            public systype minval => systype.MaxValue;
            

            [MethodImpl(Inline)]   
            public systype add(systype a, systype b) 
                => a + b;

            [MethodImpl(Inline)]   
            public systype div(systype a, systype b)
                => a/b;

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
                => a % b;

            [MethodImpl(Inline)]   
            public systype mul(systype a, systype b) 
                => a * b;

            [MethodImpl(Inline)]   
            public systype muladd(systype x, systype y, systype z)
                => x*y + z;

            [MethodImpl(Inline)]   
            public systype negate(systype a) 
                => -a;

            public systype pow(systype b, int exp)
            {
                throw new NotImplementedException();
            }

            [MethodImpl(Inline)]   
            public systype sub(systype x, systype y) 
                => x - y;

            [MethodImpl(Inline)]   
            public bool lteq(systype lhs, systype rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]   
            public bool gteq(systype lhs, systype rhs)
                => lhs >= rhs;

            [MethodImpl(Inline)]   
            public Sign sign(systype x)
                => x switch
                {
                    systype t when t > 0 => Sign.Positive,
                    systype t when t < 0 => Sign.Negative,
                    _                    => Sign.Neutral                    
                };

            [MethodImpl(Inline)]   
            public systype ceiling(systype x)
                => systype.Ceiling(x);
 
            [MethodImpl(Inline)]   
            public systype floor(systype x)
                => systype.Floor(x);
        }

    }
}