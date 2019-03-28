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

    using systype = System.Decimal;
    using opstype = DecimalOps;
    using Currency = Traits.Currency<decimal>;

    //using N128 = NatSeq<N1,N2,N8>;
    using N127 = NatSeq<N1,N2,N7>;

    [TypeClass(typeof(Traits.FiniteCurrency))]
    internal readonly struct DecimalOps : Traits.FiniteCurrency
    {
        
        public static readonly opstype Inhabitant = default;
    
        public const systype Zero = 0;

        public const systype One = 1;

        //public static readonly N128 BitSize = N128.Nat;
        
        public const systype MinVal = systype.MinValue;            

        public const systype MaxVal = systype.MaxValue;

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

        public Addition<systype> addition 
            => Addition.define(this);

        public Multiplication<systype> multiplication 
            => Multiplication.define(this);

        public bool infinite 
            => false;

        public decimal ε 
            => (decimal)Double.Epsilon;

        public systype apply(systype lhs, systype rhs)
            => throw new NotImplementedException();

        [MethodImpl(Inline)]   
        public systype add(systype a, systype b) 
            => a + b;

        [MethodImpl(Inline)]   
        public systype inc(systype x)
            => ++x;

        [MethodImpl(Inline)]   
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

        [MethodImpl(Inline)]   
        public systype and(systype lhs, systype rhs)
            => (long)lhs & (long)rhs;

        [MethodImpl(Inline)]   
        public systype or(systype lhs, systype rhs)
            => (long)lhs | (long)rhs;

        [MethodImpl(Inline)]   
        public systype xor(systype lhs, systype rhs)
            => (long)lhs ^ (long)rhs;

        [MethodImpl(Inline)]   
        public systype flip(systype x)
            => ~(long)x;

        [MethodImpl(Inline)]   
        public systype lshift(systype lhs, int rhs)
            => (long)lhs << rhs;

        [MethodImpl(Inline)]   
        public systype rshift(systype lhs, int rhs)
            => (long)lhs >> rhs;
                
        [MethodImpl(Inline)]   
        public systype sqrt(systype x)
            => (systype)Math.Sqrt((double)x);
 

        [MethodImpl(Inline)]   
        public systype sin(systype x)
            => (systype)Math.Sin((double)x);

        [MethodImpl(Inline)]   
        public systype sinh(systype x)
            => (systype)Math.Sinh((double)x);

        [MethodImpl(Inline)]   
        public systype asin(systype x)
            => (systype)Math.Asin((double)x);

        [MethodImpl(Inline)]   
        public systype asinh(systype x)
            => (systype)Math.Asinh((double)x);

        [MethodImpl(Inline)]   
        public systype cos(systype x)
            => (systype)Math.Cos((double)x);

        [MethodImpl(Inline)]   
        public systype cosh(systype x)
            => (systype)Math.Cosh((double)x);

        [MethodImpl(Inline)]   
        public systype acos(systype x)
            => (systype)Math.Acos((double)x);

        [MethodImpl(Inline)]   
        public systype acosh(systype x)
            => (systype)Math.Acosh((double)x);

        [MethodImpl(Inline)]   
        public systype tan(systype x)
            => (systype)Math.Tan((double)x);

        [MethodImpl(Inline)]   
        public systype tanh(systype x)
            => (systype)Math.Tanh((double)x);

        [MethodImpl(Inline)]   
        public systype atan(systype x)
            => (systype)Math.Atan((double)x);

        [MethodImpl(Inline)]   
        public systype atanh(systype x)
                => (systype)Math.Atanh((double)x);


        [MethodImpl(Inline)]   
        public string bitstring(systype src)
            => src.ToBitString();

        public string hexstring(systype src)
            => src.ToHexString();

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
