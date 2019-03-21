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
    
    using static corefunc;
    using static Class;
    
    using systype = System.Numerics.BigInteger;
    using opstype = BigIntOps;

    public static class BigIntX
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
    }


}