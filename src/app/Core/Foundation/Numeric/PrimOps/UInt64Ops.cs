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
    
    using systype = System.UInt64;
    using opstype = Operations.UInt64Ops;

    partial class Operations
    {
        public static string ToBitString(this systype src)
            => map(Bits.split(src), 
                    parts => parts.hi.ToBitString() 
                           + parts.lo.ToBitString());

        internal readonly struct UInt64Ops : FiniteNatural<opstype,systype>, Singleton<opstype>
        {
            public static readonly opstype Inhabitant = default;
        
            public const systype Zero = 0;

            public const systype One = 1;

            public const byte BitSize = 64;

            public const systype MinVal = systype.MinValue;

            public const systype MaxVal = systype.MaxValue;

            internal const byte MaxBitLength = BitSize - 1;

            public opstype inhabitant 
                => Inhabitant;

            public systype zero 
            {
                [MethodImpl(Inline)]   
                get{return Zero;}
            }

            public systype one
            {
                [MethodImpl(Inline)]   
                get{return One;}
            }

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
                => a + b;

            [MethodImpl(Inline)]   
            public systype inc(systype x)
                => ++x;

            [MethodImpl(Inline)]   
            public systype sub(systype x, systype y) 
                => x - y;

            [MethodImpl(Inline)]   
            public systype dec(systype x)
                => --x;

            [MethodImpl(Inline)]   
            public systype and(systype a, systype b) 
                => a & b;

            [MethodImpl(Inline)]   
            public ulong div(systype a, systype b)
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
            public systype negate(systype a) 
                => a;

            [MethodImpl(Inline)]   
            public systype or(systype a, systype b) 
                => a | b;

            [MethodImpl(Inline)]   
            public systype xor(systype a, systype b) 
                => a ^ b;

            [MethodImpl(Inline)]   
            public systype lshift(systype lhs, int rhs) 
                => lhs << rhs;

            [MethodImpl(Inline)]   
            public systype flip(systype x) 
                => ~ x;

            [MethodImpl(Inline)]   
            public systype rshift(systype lhs, int rhs) 
                => lhs >> rhs;

            [MethodImpl(Inline)]   
            public systype pow(systype b, int exp) 
                => fold(repeat(b,(long)exp), mul);

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
            public Quorem<systype> divrem(systype lhs, systype rhs)
                => Quorem.define(lhs/rhs, lhs % rhs);
 
            [MethodImpl(Inline)]   
             public systype abs(systype x)
                => x;
 
            [MethodImpl(Inline)]   
            public Sign sign(systype x)
                => x == 0 ? Sign.Neutral : Sign.Positive;
 
            [MethodImpl(Inline)]   
            public systype distribute(systype lhs, (systype x, systype y) rhs)
                => add(mul(lhs, rhs.x),  mul(lhs, rhs.y));

            [MethodImpl(Inline)]   
            public systype distribute((systype x, systype y) lhs, systype rhs)
                => add(mul(lhs.x, rhs), mul(lhs.y, rhs));

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

            public string bitstring(systype src)
                => src.ToBitString();

       }

    }
}