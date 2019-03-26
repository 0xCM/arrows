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

    using Nat128 = NatSeq<N1,N2,N8>;
    using N127 = NatSeq<N1,N2,N7>;

    internal readonly struct DecimalOps : Currency, 
        TypeClass<opstype,Currency,systype> 
    {
        
        public static readonly opstype Inhabitant = default;
    
        public const systype Zero = 0;

        public const systype One = 1;

        public static readonly Nat128 BitSize = natrep<Nat128>();
        
        public static readonly N127 MaxBitLength = natrep<N127>();

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

        public BitString<N127> bitstring2(systype src)
            => new BitString<N127>(src.ToBitString());
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