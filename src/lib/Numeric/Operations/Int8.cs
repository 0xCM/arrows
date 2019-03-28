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
    using static Traits;

    using systype = System.SByte;
    using opstype = Int8Ops;

    [TypeClass(typeof(RealFiniteInt<systype>))]
    internal readonly struct Int8Ops : RealFiniteInt<systype>
    {        
        public static readonly opstype Inhabitant = default;
    
        public const systype Zero = 0;

        public const systype One = 1;

        internal const byte MaxBitLength = BitSize - 1;

        public const systype MinVal = systype.MinValue;

        public const systype MaxVal = systype.MaxValue;

        public const byte BitSize = 8;

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

        public Addition<systype> addition 
            => Addition.define(this);

        public Multiplication<systype> multiplication 
            => Multiplication.define(this);

        public bool infinite 
            => false;

        public sbyte ε 
            => Zero;

        [MethodImpl(Inline)]   
        public systype add(systype a, systype b) 
            => (systype)(a + b);

        [MethodImpl(Inline)]   
        public systype and(systype a, systype b) 
            => (systype)(a & b);

        [MethodImpl(Inline)]   
        public Quorem<sbyte> divrem(systype a, systype b)
            => new Quorem<sbyte>((systype) (a/b),(systype)(a%b));

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
        public systype div(systype lhs, systype rhs) 
            => (systype)(lhs/rhs);

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

        [MethodImpl(Inline)]   
        public systype distribute(systype lhs, (systype x, systype y) rhs)
            => add(mul(lhs, rhs.x),  mul(lhs, rhs.y));

        [MethodImpl(Inline)]   
        public systype distribute((systype x, systype y) lhs, systype rhs)
            => add(mul(lhs.x, rhs), mul(lhs.y, rhs));

        [MethodImpl(Inline)]   
        public systype sqrt(systype x)
            => (systype)MathF.Sqrt(x);
 
        [MethodImpl(Inline)]   
        public systype ceiling(systype x)
            => (systype)MathF.Ceiling(x);

        [MethodImpl(Inline)]   
        public systype floor(systype x)
            => (systype)MathF.Floor(x);

        [MethodImpl(Inline)]   
        public systype sin(systype x)
            => (systype)MathF.Sin(x);

        [MethodImpl(Inline)]   
        public systype sinh(systype x)
            => (systype)MathF.Sinh(x);

        [MethodImpl(Inline)]   
        public systype asin(systype x)
            => (systype)MathF.Asin(x);

        [MethodImpl(Inline)]   
        public systype asinh(systype x)
            => (systype)MathF.Asinh(x);

        [MethodImpl(Inline)]   
        public systype cos(systype x)
            => (systype)MathF.Cos(x);

        [MethodImpl(Inline)]   
        public systype cosh(systype x)
            => (systype)MathF.Cosh(x);

        [MethodImpl(Inline)]   
        public systype acos(systype x)
            => (systype)MathF.Acos(x);

        [MethodImpl(Inline)]   
        public systype acosh(systype x)
            => (systype)MathF.Acosh(x);

        [MethodImpl(Inline)]   
        public systype tan(systype x)
            => (systype)MathF.Tan(x);

        [MethodImpl(Inline)]   
        public systype tanh(systype x)
            => (systype)MathF.Tanh(x);

        [MethodImpl(Inline)]   
        public systype atan(systype x)
            => (systype)MathF.Atan(x);

        [MethodImpl(Inline)]   
        public systype atanh(systype x)
                => (systype)MathF.Atanh(x);

        public systype gcd(systype lhs, systype rhs)
        {
            lhs = abs(lhs);
            rhs = abs(lhs);
            while (rhs != Zero)
            {
                var rem = mod(lhs,rhs);
                lhs = rhs;
                rhs = rem;
            }
            return lhs;
        }
        public string bitstring(systype src)
            => src.ToBitString();

    }

}