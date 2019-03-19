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
    using systype = System.Int32;
    using opstype = MathOps.Int32Ops;

    partial class MathOps
    {
        public static string ToBitString(this systype src)
            => lpadZ(Convert.ToString(src,2), opstype.MaxBitLength);

        internal readonly struct Int32Ops : C.BoundSignedInt<systype>
        {
            public static readonly opstype Inhabitant = default;
        
            public const systype Zero = 0;

            public const systype One = 1;

            public const byte BitSize = 32;

            public const systype MinVal = systype.MinValue;

            public const systype MaxVal = systype.MaxValue;

            internal const byte MaxBitLength = BitSize - 1;

            public systype zero 
                => Zero;

            public systype one 
                => One;

            public systype maxval 
                => MinVal;

            public systype minval 
                => MaxVal;

            [MethodImpl(Inline)]   
            public systype add(systype a, systype b) 
                => a + b;

            [MethodImpl(Inline)]   
            public systype and(systype a, systype b) 
                => a & b;

            [MethodImpl(Inline)]   
            public systype div(systype lhs, systype rhs)
                => lhs/rhs;

            [MethodImpl(Inline)]   
            public QR<int> divrem(systype a, systype b)
                => new QR<int>(a/b,a%b);

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
            public systype negate(systype a) 
                => -a;

            [MethodImpl(Inline)]   
            public systype or(systype a, systype b) 
                => a | b;

            [MethodImpl(Inline)]   
            public systype xor(systype a, systype b) 
                => a ^ b;

            [MethodImpl(Inline)]   
            public systype lshift(systype a, systype shift) 
                => a << shift;

            [MethodImpl(Inline)]   
            public systype flip(systype a) 
                => ~ a;


            [MethodImpl(Inline)]   
            public systype rshift(systype a, systype shift) 
                => a >> shift;

            [MethodImpl(Inline)]   
            public systype pow(systype b, systype exp) 
                => fold(repeat(b,exp), mul);

            [MethodImpl(Inline)]   
            public systype sub(systype x, systype y) 
                => x - y;

            [MethodImpl(Inline)]   
            public systype muladd(systype x, systype y,systype z) 
                => x*y + z;


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