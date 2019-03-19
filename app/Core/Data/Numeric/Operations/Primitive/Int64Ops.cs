//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Runtime.CompilerServices;

    using Root;

    using static corefunc;

    using C = Core.Contracts;
    using systype = System.Int64;
    using opstype = MathOps.Int64Ops;
    
    partial class MathOps
    {
        public static string ToBitString(this systype src)
            => lpadZ(Convert.ToString(src,2), opstype.MaxBitLength);


        internal readonly struct Int64Ops : C.BoundSignedInt<systype>
        {
            public static readonly opstype Inhabitant = default;
        
            public const systype Zero = 0;

            public const systype One = 1;

            public const byte BitSize = 64;

            public const systype MinVal = systype.MinValue;

            public const systype MaxVal = systype.MaxValue;

            internal const byte MaxBitLength = BitSize - 1;

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

            [MethodImpl(Inline)]   
            public systype add(systype lhs, systype rhs) 
                => lhs + rhs;

            [MethodImpl(Inline)]   
            public systype inc(systype x)
                => ++x;

            [MethodImpl(Inline)]   
            public systype sub(systype lhs, systype rhs) 
                => lhs - rhs;

            [MethodImpl(Inline)]   
            public systype dec(systype x)
                => --x;

            [MethodImpl(Inline)]   
            public systype negate(systype x) 
                => -x;

            [MethodImpl(Inline)]   
            public systype mul(systype lhs, systype rhs) 
                => lhs * rhs;

            [MethodImpl(Inline)]   
            public systype muladd(systype x, systype y,systype z) 
                => x*y + z;

            [MethodImpl(Inline)]   
            public systype div(systype lhs, systype rhs)
                => lhs/rhs;

            [MethodImpl(Inline)]   
            public QR<systype> divrem(systype lhs, systype rhs)
                => new QR<systype>(lhs/rhs,lhs%rhs);

            [MethodImpl(Inline)]   
            public systype mod(systype lhs, systype rhs) 
                => lhs % rhs;

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
            public bool lteq(systype lhs, systype rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]   
            public bool lt(systype lhs, systype rhs) 
                => lhs < rhs;

            [MethodImpl(Inline)]   
            public bool gteq(systype lhs, systype rhs)
                => lhs >= rhs;

            [MethodImpl(Inline)]   
            public systype and(systype lhs, systype rhs) 
                => lhs & rhs;

            [MethodImpl(Inline)]   
            public systype or(systype lhs, systype rhs) 
                => lhs | rhs;

            [MethodImpl(Inline)]   
            public systype xor(systype lhs, systype rhs) 
                => lhs ^ rhs;

            [MethodImpl(Inline)]   
            public systype lshift(systype lhs, int rhs) 
                => lhs << rhs;

            [MethodImpl(Inline)]   
            public systype rshift(systype lhs, int rhs) 
                => lhs >> rhs;

            [MethodImpl(Inline)]   
            public systype flip(systype x) 
                => ~ x;

            [MethodImpl(Inline)]   
            public systype pow(systype b, int exp) 
                => fold(repeat(b,exp), mul); 

            [MethodImpl(Inline)]   
            public systype abs(systype x)
                => Math.Abs(x);

            [MethodImpl(Inline)]   
            public Sign sign(systype x)
                => x switch
                {
                    systype t when t > Zero => Sign.Positive,
                    systype t when t < Zero => Sign.Negative,
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