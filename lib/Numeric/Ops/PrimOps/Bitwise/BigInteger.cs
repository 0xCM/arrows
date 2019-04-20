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

    using target = System.Numerics.BigInteger;
    using targets = Index<System.Numerics.BigInteger>;

    partial class PrimOps { partial class Reify {
        
        public readonly partial struct Bitwise : 
            Bitwise<target> 
        {
            
            [MethodImpl(Inline)]   
            public target and(target lhs, target rhs) 
                => lhs & rhs;

            [MethodImpl(Inline)]   
            public targets and(targets lhs, targets rhs)
                => fuse(lhs,rhs, and, out target[] dst);

            [MethodImpl(Inline)]   
            public target or(target lhs, target rhs) 
                => lhs | rhs;

            [MethodImpl(Inline)]   
            public targets or(targets lhs, targets rhs)
                => fuse(lhs,rhs, or, out target[] dst);

            [MethodImpl(Inline)]   
            public target xor(target lhs, target rhs) 
                => lhs ^ rhs;

            [MethodImpl(Inline)]   
            public target lshift(target lhs, int rhs) 
                => lhs << rhs;

            [MethodImpl(Inline)]   
            public target rshift(target lhs, int rhs) 
                => lhs >> rhs;

            [MethodImpl(Inline)]   
            public target flip(target x) 
                => ~ x;

            /// <summary>
            /// Renders a number as a base-2 formatted string
            /// <remarks>
            /// Taken from https://stackoverflow.com/questions/14048476/biginteger-to-hex-decimal-octal-binary-strings
            /// </remarks>
            public string bitchars(target x)
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
            public BitString bitstring(target src) 
                => BitString.define(bit.parse(bitchars(src)));

            [MethodImpl(Inline)]
            public byte[] bytes(target src)
                => src.ToByteArray();

            [MethodImpl(Inline)]
            public bool testbit(target src, int pos)
                => (src & (1 << pos)) != 0;


            [MethodImpl(Inline)]
            public static int countTrailingOff(int src)
                => BitOperations.TrailingZeroCount(src);

            [MethodImpl(Inline)]
            public bit[] bits(target src)
                => throw new NotImplementedException();

            public targets xor(targets lhs, targets rhs)
            {
                throw new NotImplementedException();
            }

            public targets flip(targets lhs)
            {
                throw new NotImplementedException();
            }
        }
    }
}}

