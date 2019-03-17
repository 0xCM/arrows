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
    using systype = System.Single;
    

    partial class MathOps
    {
        
        readonly struct Float32Ops : C.BoundFloat<systype>
        {
        
            public static readonly Float32Ops Inhabitant = default(Float32Ops);

            public systype zero => 0;

            public systype one => 0;

            public systype maxval => systype.MaxValue;

            public systype minval => systype.MaxValue;

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
            public bool lt(systype lhs, systype rhs) 
                => lhs < rhs;

            [MethodImpl(Inline)]   
            public bool lteq(systype lhs, systype rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]   
            public bool gteq(systype lhs, systype rhs)
                => lhs >= rhs;

            [MethodImpl(Inline)]   
            public systype mod(systype lhs, systype rhs) 
                => lhs % rhs;

            [MethodImpl(Inline)]   
            public systype add(systype lhs, systype rhs) 
                => lhs + rhs;

            [MethodImpl(Inline)]   
            public systype sub(systype lhs, systype rhs) 
                => lhs - rhs;

            [MethodImpl(Inline)]   
            public systype mul(systype lhs, systype rhs) 
                => lhs * rhs;

            [MethodImpl(Inline)]   
            public systype div(systype lhs, systype rhs)
                => lhs / rhs;

            [MethodImpl(Inline)]   
            public systype muladd(systype x, systype y, systype z)
                => MathF.FusedMultiplyAdd(x,y,z);

            [MethodImpl(Inline)]   
            public systype negate(systype x) 
                => -x;

            [MethodImpl(Inline)]   
            public systype pow(systype b, int exp) 
                => MathF.Pow(b,exp);

            [MethodImpl(Inline)]   
            public systype acos(systype x)
                => MathF.Acos(x);

            [MethodImpl(Inline)]   
            public systype acosh(systype x)
                => MathF.Acosh(x);

            [MethodImpl(Inline)]   
            public systype asin(systype x)
                => MathF.Asin(x);

            [MethodImpl(Inline)]   
            public systype asinh(systype x)
                => MathF.Asinh(x);

            [MethodImpl(Inline)]   
            public systype atan(systype x)
                => MathF.Atan(x);

            [MethodImpl(Inline)]   
            public systype atanh(systype x)
                => MathF.Atanh(x);

            [MethodImpl(Inline)]   
            public systype cos(systype x)
                => MathF.Cos(x);

            [MethodImpl(Inline)]   
            public systype cosh(systype x)
                => MathF.Cosh(x);

            [MethodImpl(Inline)]   
            public systype sin(systype x)
                => MathF.Sin(x);

            [MethodImpl(Inline)]   
            public systype sinh(systype x)
                => MathF.Sinh(x);
            
            [MethodImpl(Inline)]   
            public systype tan(systype x)
                => MathF.Tan(x);

            [MethodImpl(Inline)]   
            public systype tanh(systype x)
                => MathF.Tanh(x);
 
            [MethodImpl(Inline)]   
            public Sign sign(systype x)
                => x switch
                {
                    systype t when t > 0 => Sign.Positive,
                    systype t when t < 0 => Sign.Negative,
                    _                    => Sign.Neutral                    
                };

            public systype ceiling(systype x)
                => MathF.Ceiling(x);

            public systype floor(systype x)
                => MathF.Floor(x);

            public IEnumerable<systype> partition(systype min, systype max, systype width)
            {
                var current = min;
                width = width != 0 ? width : systype.Epsilon;
                while(current <= max)
                {
                    yield return current;
                    current += width;
                }
            
            }
        }
    }
}