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

    using BigInteger = System.Numerics.BigInteger;
    using BigIntegers = Index<System.Numerics.BigInteger>;

    partial class PrimOps { partial class Reify {
        
        public readonly partial struct Bitwise : 
            IBitwiseOps<BigInteger> 
        {
            
            [MethodImpl(Inline)]   
            public BigInteger and(BigInteger lhs, BigInteger rhs) 
                => lhs & rhs;

            [MethodImpl(Inline)]   
            public BigIntegers and(BigIntegers lhs, BigIntegers rhs)
                => fuse(lhs,rhs, and, out BigInteger[] dst);

            [MethodImpl(Inline)]   
            public BigInteger or(BigInteger lhs, BigInteger rhs) 
                => lhs | rhs;

            [MethodImpl(Inline)]   
            public BigIntegers or(BigIntegers lhs, BigIntegers rhs)
                => fuse(lhs,rhs, or, out BigInteger[] dst);

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
            public string BitString(BigInteger x)
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
            public byte[] Bytes(BigInteger src)
                => src.ToByteArray();

            [MethodImpl(Inline)]
            public bool TestBit(BigInteger src, int pos)
                => (src & (1 << pos)) != 0;


            [MethodImpl(Inline)]
            public static int countTrailingOff(int src)
                => BitOperations.TrailingZeroCount(src);

            [MethodImpl(Inline)]
            public Bit[] Bits(BigInteger src)
                => throw new NotImplementedException();

            public BigIntegers xor(BigIntegers lhs, BigIntegers rhs)
            {
                throw new NotImplementedException();
            }

            public BigIntegers flip(BigIntegers lhs)
            {
                throw new NotImplementedException();
            }
        }
    }
}}

