//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Text;
    using static zcore;


    using static Operative;

    partial class PrimOps { partial class Reify {
        
        public readonly partial struct Bitwise : 
            Bitwise<BigInteger> 
        {
            
            [MethodImpl(Inline)]   
            public BigInteger and(BigInteger lhs, BigInteger rhs) 
                => lhs & rhs;

            [MethodImpl(Inline)]   
            public BigInteger or(BigInteger lhs, BigInteger rhs) 
                => lhs | rhs;

            [MethodImpl(Inline)]   
            public BigInteger xor(BigInteger lhs, BigInteger rhs) 
                => lhs ^ rhs;

            [MethodImpl(Inline)]   
            public BigInteger lshift(BigInteger lhs, int rhs) 
                => lhs << rhs;

            [MethodImpl(Inline)]   
            public BigInteger rshift(BigInteger lhs, int rhs) 
                => lhs >> rhs;

            [MethodImpl(Inline)]   
            public BigInteger flip(BigInteger x) 
                => ~ x;

            /// <summary>
            /// Renders a number as a base-2 formatted string
            /// <remarks>
            /// Taken from https://stackoverflow.com/questions/14048476/biginteger-to-hex-decimal-octal-binary-strings
            /// </remarks>
            public string bitchars(BigInteger x)
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

                return base2.ToString().Substring(1);
            }


            [MethodImpl(Inline)]   
            public BitString bitstring(BigInteger src) 
                => BitString.define(Bits.parse(bitchars(src)));

            /// <summary>
            /// Interprets the source as an array of bytes
            /// </summary>
            /// <param name="src">The soruce value</param>
            [MethodImpl(Inline)]
            public byte[] bytes(BigInteger src)
                => src.ToByteArray();


            /// <summary>
            /// Determines whether a position-specified bit in the source is on
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public bool testbit(BigInteger src, int pos)
                => (src & (1 << pos)) != 0;

            [MethodImpl(Inline)]
            public bit[] bits(BigInteger src)
                => throw new NotImplementedException();

            /// <summary>
            /// Counts the number of trailing zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countTrailingOff(int src)
                => BitOperations.TrailingZeroCount(src);


        }
    }
}}

