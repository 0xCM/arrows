//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Globalization;
    using System.Runtime.CompilerServices;

    using static zcore;

    partial class xcore
    {

        // ! primitive -> bits
        // ! ------------------------------------------------------------------

        /// <summary>
        /// Constructs a bit array that reflects the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bit[] ToBits(this sbyte src)
            => primops.bits(src);

        /// <summary>
        /// Constructs a bit array that reflects the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bit[] ToBits(this byte src)
            => primops.bits(src);

        /// <summary>
        /// Constructs a bit array that reflects the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bit[] ToBits(this short src)
            =>primops.bits(src);

        /// <summary>
        /// Constructs a bit array that reflects the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bit[] ToBits(this ushort src)
            =>primops.bits(src);

        /// <summary>
        /// Constructs a bit array that reflects the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bit[] ToBits(this int src)
            =>primops.bits(src);

        /// <summary>
        /// Constructs a bit array that reflects the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bit[] ToBits(this uint src)
            =>primops.bits(src);

        /// <summary>
        /// Constructs a bit array that reflects the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bit[] ToBits(this long src)
            =>primops.bits(src);

        /// <summary>
        /// Constructs a bit array that reflects the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bit[] ToBits(this ulong src)
            =>primops.bits(src);

        /// <summary>
        /// Constructs a bit array that reflects the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bit[] ToBits(this float src)
            =>primops.bits(src);

        /// <summary>
        /// Constructs a bit array that reflects the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bit[] ToBits(this double src)
            =>primops.bits(src);

        /// <summary>
        /// Constructs a bit array that reflects the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bit[] ToBits(this decimal src)
            =>primops.bits(src);


        /// <summary>
        /// Constructs an IEE bitstring from a double
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static string ToIeeeBitString(this double x)
            => lpadZ(apply(Bits.split(x), 
                ieee => append(ieee.sign == Sign.Negative ? "1" : "0",
                            ieee.exponent.ToBitString().format(),
                            ieee.mantissa.ToBitString().format()                        
                    )), primops.bitsize<double>());
 
    }        
}