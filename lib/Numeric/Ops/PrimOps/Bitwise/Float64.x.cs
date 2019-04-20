//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zcore;

    using target = System.Double;
    using targets = System.Collections.Generic.IReadOnlyList<double>;

    partial class BitwiseX
    {
        /// <summary>
        /// Constructs an IEE bitstring from a double
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static string ToIeeeBitString(this target x)
            => lpadZ(apply(Bits.split(x), 
                ieee => append(ieee.sign == Sign.Negative ? "1" : "0",
                            primops.bitstring(ieee.exponent).format(),
                            primops.bitstring(ieee.mantissa).format()
                    )), primops.bitsize<target>()); 

    }
}