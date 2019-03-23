//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Runtime.CompilerServices;

    using static corefunc;
    using static Traits;
    using systype = System.Int64;
    using opstype = Int64Ops;

    internal readonly struct Int64Ops : FiniteSignedInt<systype>, 
        TypeClass<opstype,systype,FiniteSignedInt<systype>>
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

        public Addition<systype> addition 
            => Addition.define(this);

        public Multiplication<systype> multiplication 
            => Multiplication.define(this);

        public systype apply(systype lhs, systype rhs)
            => throw new NotImplementedException();

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
        public Quorem<systype> divrem(systype lhs, systype rhs)
            => new Quorem<systype>(lhs/rhs,lhs%rhs);

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


    partial class Operations
    {

        public static string ToBitString(this systype src)
            => lpadZ(Convert.ToString(src,2), opstype.MaxBitLength);

    }
}