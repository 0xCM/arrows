//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zcore;
    using static Traits;
    using systype = System.Int64;
    using opstype = Int64Ops;

    internal readonly struct Int64Ops : SignedFiniteRealInt<systype>, 
        TypeClass<opstype,FiniteSignedInt<systype>,systype>
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

        public bool infinite 
            => false;

        public systype ε 
            => Zero;

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

         [MethodImpl(Inline)]   
        public systype sqrt(systype x)
            => (systype)Math.Sqrt(x);
 
        [MethodImpl(Inline)]   
        public systype ceiling(systype x)
            => (systype)Math.Ceiling((double)x);

        [MethodImpl(Inline)]   
        public systype floor(systype x)
            => (systype)Math.Floor((double)x);

        [MethodImpl(Inline)]   
        public systype sin(systype x)
            => (systype)Math.Sin(x);

        [MethodImpl(Inline)]   
        public systype sinh(systype x)
            => (systype)Math.Sinh(x);

        [MethodImpl(Inline)]   
        public systype asin(systype x)
            => (systype)Math.Asin(x);

        [MethodImpl(Inline)]   
        public systype asinh(systype x)
            => (systype)Math.Asinh(x);

        [MethodImpl(Inline)]   
        public systype cos(systype x)
            => (systype)Math.Cos(x);

        [MethodImpl(Inline)]   
        public systype cosh(systype x)
            => (systype)Math.Cosh(x);

        [MethodImpl(Inline)]   
        public systype acos(systype x)
            => (systype)Math.Acos(x);

        [MethodImpl(Inline)]   
        public systype acosh(systype x)
            => (systype)Math.Acosh(x);

        [MethodImpl(Inline)]   
        public systype tan(systype x)
            => (systype)Math.Tan(x);

        [MethodImpl(Inline)]   
        public systype tanh(systype x)
            => (systype)Math.Tanh(x);

        [MethodImpl(Inline)]   
        public systype atan(systype x)
            => (systype)Math.Atan(x);

        [MethodImpl(Inline)]   
        public systype atanh(systype x)
                => (systype)Math.Atanh(x);

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

 
    }
}