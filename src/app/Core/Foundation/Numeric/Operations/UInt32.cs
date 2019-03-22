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
    using systype = System.UInt32;
    using opstype = UInt32Ops;
    
    internal readonly struct UInt32Ops : FiniteNatural<systype>, 
        TypeClass<opstype,systype,FiniteNatural<systype>>
    {
        public static readonly opstype Inhabitant = default;
    
        public const systype Zero = 0;

        public const systype One = 1;

        public const byte BitSize = 32;

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
        public systype and(systype a, systype b) 
            => a & b;

        [MethodImpl(Inline)]   
        public systype div(systype lhs, systype rhs)
            => lhs/rhs;

        [MethodImpl(Inline)]   
        public Quorem<uint> divrem(systype a, systype b)
            => new Quorem<uint>(a/b,a%b);

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
        public systype lshift(systype a, int shift) 
            => a << shift;

        [MethodImpl(Inline)]   
        public systype flip(systype a) 
            => ~ a;

        [MethodImpl(Inline)]   
        public systype rshift(systype a, int shift) 
            => a >> shift;

        [MethodImpl(Inline)]   
        public systype pow(systype b, int exp) 
            => fold(repeat(b,(long)exp), mul);

        [MethodImpl(Inline)]   
        public systype sub(systype x, systype y) 
            => x - y;

        [MethodImpl(Inline)]   
        public systype dec(systype x)
            => --x;

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
        public systype abs(systype x)
            => x;

        [MethodImpl(Inline)]   
        public Sign sign(systype x)
            => x == Zero ? Sign.Neutral : Sign.Positive;

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
