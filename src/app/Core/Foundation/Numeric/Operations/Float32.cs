//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static corefunc;
    using static Traits;

    using systype = System.Single;
    using opstype = Float32Ops;
    using SysMath = System.MathF;
    
    internal readonly struct Float32Ops : FiniteFloat<systype>, 
        TypeClass<opstype,FiniteFloat<systype>,systype>
    {
    
        public static readonly opstype Inhabitant = default;
    
        public const systype Zero = 0;

        public const systype One = 1;

        public const byte BitSize = 32;

        public const systype MinVal = systype.MinValue;            

        public const systype MaxVal = systype.MaxValue;

        public const systype Epsilon = systype.Epsilon;

        public opstype inhabitant 
            => Inhabitant;

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

        public Func<systype, systype, systype> addition 
            => add;

        public Func<systype, systype, systype> multiplication 
            => mul;

        public systype apply(systype lhs, systype rhs)
            => throw new NotImplementedException();

        [MethodImpl(Inline)]   
        public systype inc(systype x)
            => ++x;

        [MethodImpl(Inline)]   
        public systype dec(systype x)
            => --x;

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
            => SysMath.FusedMultiplyAdd(x,y,z);

        [MethodImpl(Inline)]   
        public systype negate(systype x) 
            => -x;

        [MethodImpl(Inline)]   
        public systype pow(systype b, int exp) 
            => SysMath.Pow(b,exp);

        [MethodImpl(Inline)]   
        public systype acos(systype x)
            => SysMath.Acos(x);

        [MethodImpl(Inline)]   
        public systype acosh(systype x)
            => SysMath.Acosh(x);

        [MethodImpl(Inline)]   
        public systype asin(systype x)
            => SysMath.Asin(x);

        [MethodImpl(Inline)]   
        public systype asinh(systype x)
            => SysMath.Asinh(x);

        [MethodImpl(Inline)]   
        public systype atan(systype x)
            => SysMath.Atan(x);

        [MethodImpl(Inline)]   
        public systype atanh(systype x)
            => SysMath.Atanh(x);

        [MethodImpl(Inline)]   
        public systype cos(systype x)
            => SysMath.Cos(x);

        [MethodImpl(Inline)]   
        public systype cosh(systype x)
            => SysMath.Cosh(x);

        [MethodImpl(Inline)]   
        public systype sin(systype x)
            => SysMath.Sin(x);

        [MethodImpl(Inline)]   
        public systype sinh(systype x)
            => SysMath.Sinh(x);
        
        [MethodImpl(Inline)]   
        public systype tan(systype x)
            => SysMath.Tan(x);

        [MethodImpl(Inline)]   
        public systype tanh(systype x)
            => SysMath.Tanh(x);

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
            => SysMath.Ceiling(x);

        [MethodImpl(Inline)]   
        public systype floor(systype x)
            => SysMath.Floor(x);

        [MethodImpl(Inline)]   
        public systype sqrt(systype x)
            => SysMath.Sqrt(x);


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

        [MethodImpl(Inline)]   
        public systype abs(systype x)
            => SysMath.Abs(x);

        [MethodImpl(Inline)]   
        public systype distribute(systype lhs, (systype x, systype y) rhs)
            => lhs * rhs.x + lhs * rhs.y;

        [MethodImpl(Inline)]   
        public systype distribute((systype x, systype y) lhs, systype rhs)
            => lhs.x * rhs + lhs.y * rhs;

        public string bitstring(float x)
        {
            throw new NotImplementedException();
        }

        public systype gcd(systype lhs, systype rhs)
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
        public Quorem<systype> divrem(systype lhs, systype rhs)
            => new Quorem<systype>(lhs/rhs,lhs%rhs);

    }


}