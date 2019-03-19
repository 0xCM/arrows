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
    using systype = System.Double;
    using opstype = MathOps.Float64Ops;

    partial class MathOps
    {
        public static string ToBitString(this systype x)
            => lpadZ(map(Bits.split(x), 
                ieee => concat(ieee.sign == Sign.Negative ? "1" : "0",
                            ieee.exponent.ToBitString(),
                            ieee.mantissa.ToBitString()
                            
                    )), opstype.MaxBitLength);

        internal readonly struct Float64Ops : C.BoundFloat<systype>
        {        
            public static readonly opstype Inhabitant = default;
        
            public const systype Zero = 0;

            public const systype One = 1;

            public const byte BitSize = 64;

            internal const byte MaxBitLength = BitSize - 1;

            public const systype MinVal = systype.MinValue;            

            public const systype MaxVal = systype.MaxValue;

            public const systype Epsilon = systype.Epsilon;

            public systype zero 
                => Zero;

            public systype one 
                => One;

            public systype maxval 
                => MinVal;

            public systype minval 
                => MaxVal;

            public systype ε
                => Epsilon;

            public systype inc(systype x)
                => ++x;

            public systype dec(systype x)
                => --x;

            [MethodImpl(Inline)]   
            public systype add(systype a, systype b) 
                => a + b;

            [MethodImpl(Inline)]   
            public systype div(systype a, systype b)
                => a / b;

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
                => Math.FusedMultiplyAdd(x,y,z);

            [MethodImpl(Inline)]   
            public systype negate(systype a) 
                => -a;

            [MethodImpl(Inline)]   
            public systype pow(systype b, int exp) 
                => Math.Pow(b,exp);

            [MethodImpl(Inline)]   
            public systype sub(systype x, systype y) 
                => x - y;

            [MethodImpl(Inline)]   
            public systype acos(systype x)
                => Math.Acos(x);

            [MethodImpl(Inline)]   
            public systype acosh(systype x)
                => Math.Acosh(x);

            [MethodImpl(Inline)]   
            public systype asin(systype x)
                => Math.Asin(x);

            [MethodImpl(Inline)]   
            public systype asinh(systype x)
                => Math.Asinh(x);

            [MethodImpl(Inline)]   
            public systype atan(systype x)
                => Math.Atan(x);

            [MethodImpl(Inline)]   
            public systype atanh(systype x)
                => Math.Atanh(x);

            [MethodImpl(Inline)]   
            public systype cos(systype x)
                => Math.Cos(x);

            [MethodImpl(Inline)]   
            public systype cosh(systype x)
                => Math.Cosh(x);

            [MethodImpl(Inline)]   
            public systype sin(systype x)
                => Math.Sin(x);

            [MethodImpl(Inline)]   
            public systype sinh(systype x)
                => Math.Sinh(x);
            
            [MethodImpl(Inline)]   
            public systype tan(systype x)
                => Math.Tan(x);

            [MethodImpl(Inline)]   
            public systype tanh(systype x)
                => Math.Tanh(x);
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

            public systype ceiling(systype x)
                => Math.Ceiling(x);

            public systype floor(systype x)
                => Math.Floor(x);

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

            public systype abs(systype x)
                => Math.Abs(x);

            public string bitstring(double x)
                => x.ToBitString();
        }

    }
}