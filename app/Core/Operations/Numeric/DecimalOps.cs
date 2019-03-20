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
    using static Class;

    using C = Core.Contracts;
    using systype = System.Decimal;
    using opstype = Operations.DecimalOps;

    partial class Operations
    {
        public static string ToHexString(this systype src)
            => map(Bits.split(src), parts =>
                concat(
                    parts.hihi.ToString("X8"),
                    parts.hilo.ToString("X8"),
                    parts.lohi.ToString("X8"),
                    parts.lolo.ToString("X8")
                ));


        public static string ToBitString(this systype src)
            => map(Bits.split(src), parts =>
                concat(
                    parts.hihi.ToBitString(),
                    parts.hilo.ToBitString(),
                    parts.lohi.ToBitString(),
                    parts.lolo.ToBitString()
                ));

        internal readonly struct DecimalOps : Currency<opstype,systype> 
        {
            
            public static readonly opstype Inhabitant = default;
        
            public const systype Zero = 0;

            public const systype One = 1;

            public const byte BitSize = 128;

            public const systype MinVal = systype.MinValue;            

            public const systype MaxVal = systype.MaxValue;

            const byte MaxBitLength = BitSize - 1;

            public systype zero 
                => Zero;

            public systype one 
                => One;

            public systype maxval 
                => MinVal;

            public systype minval 
                => MaxVal;

            public opstype inhabitant 
                => Inhabitant;

            [MethodImpl(Inline)]   
            public systype add(systype a, systype b) 
                => a + b;

            public systype inc(systype x)
                => ++x;

            public systype dec(systype x)
                => --x;

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

            [MethodImpl(Inline)]   
            public systype abs(systype x)
                => Math.Abs(x);

            [MethodImpl(Inline)]   
            public systype distribute(systype lhs, (systype x, systype y) rhs)
                => lhs * rhs.x + lhs * rhs.y;

            [MethodImpl(Inline)]   
            public systype distribute((systype x, systype y) lhs, systype rhs)
                => lhs.x * rhs + lhs.y * rhs;

            public string bitstring(systype src)
                => src.ToBitString();

            public string hexstring(systype src)
                => src.ToHexString();

        }

    }
}