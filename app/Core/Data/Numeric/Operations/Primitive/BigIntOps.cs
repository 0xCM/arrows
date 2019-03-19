//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    
    using Root;

    using static corefunc;
    
    using C = Core.Contracts;
    using systype = System.Numerics.BigInteger;
    using optype = MathOps.BigIntOps;

    partial class MathOps
    {
        public static string ToHexString(this systype x)
            => x.ToString("X");


        /// <summary>
        /// Represents the source value as a sequence of base-2 integers
        /// <remarks>
        /// Taken from https://stackoverflow.com/questions/14048476/biginteger-to-hex-decimal-octal-binary-strings
        /// </remarks>
        public static string ToBitString(this systype x)
        {
            var bytes = x.ToByteArray();
            var idx = bytes.Length - 1;

            // Create a StringBuilder having appropriate capacity.
            var base2 = new StringBuilder(bytes.Length * 8);

            // Convert first byte to binary.
            var binary = Convert.ToString(bytes[idx], 2);

            // Ensure leading zero exists if value is positive.
            if (binary[0] != '0' && x.Sign == 1)
                base2.Append('0');

            // Append binary string to StringBuilder.
            base2.Append(binary);

            // Convert remaining bytes adding leading zeros.
            for (idx--; idx >= 0; idx--)
                base2.Append(Convert.ToString(bytes[idx], 2).PadLeft(8, '0'));

            return base2.ToString();

        }

        internal readonly struct BigIntOps : C.SignedInt<systype>
        {
        
            public static readonly optype Inhabitant = default;

            public systype zero => 0;

            public systype one => 1;

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
                => fold(repeat(b,(long)exp), mul);

           [MethodImpl(Inline)]   
            public systype abs(systype x)
                => BigInteger.Abs(x);

            [MethodImpl(Inline)]   
            public Sign sign(systype x)
                => x switch
                {
                    systype t when x > 0 => Sign.Positive,
                    systype t when x < 0 => Sign.Negative,
                    _                    => Sign.Neutral                    
                };

            public systype gcd(systype lhs, systype rhs)
                => systype.GreatestCommonDivisor(lhs,rhs);

            public string bitstring(systype x)
                => x.ToBitString();
 
            public string hexstring(systype x)
                => x.ToHexString();
            
               
        }
    }

}