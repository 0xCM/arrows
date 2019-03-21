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
    using static Class;

    using systype = System.SByte;
    using opstype = Operations.Int8Ops;

    partial class Operations
    {
        public static string ToBitString(this systype src)
                => lpadZ(Convert.ToString(src,2), opstype.MaxBitLength);

        internal readonly struct Int8Ops : FiniteSignedInt<opstype,systype>
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

            public Func<systype, systype, systype> addition 
                => add;

            public Func<systype, systype, systype> multiplication 
                => mul;

            public systype apply(systype lhs, systype rhs)
                => throw new NotImplementedException();

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
}