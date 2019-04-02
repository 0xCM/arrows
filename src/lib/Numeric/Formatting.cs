//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Text;
    using Z0;

    using static zcore;

    /// <summary>
    /// Defines extenstions for numeric formatting
    /// </summary>
    public static class FormattingX
    {

        [MethodImpl(Inline)]   
        public static string ToHexString(this BigInteger x)
            => x.ToString("X");

        [MethodImpl(Inline)]   
        public static string ToHexString(this decimal src)
            => apply(Bits.split(src), parts =>
                append(
                    parts.hihi.ToString("X8"),
                    parts.hilo.ToString("X8"),
                    parts.lohi.ToString("X8"),
                    parts.lolo.ToString("X8")
                ));



        [MethodImpl(Inline)]   
        public static string ToBitString(this int src)
            => lpadZ(Convert.ToString(src,2), Int32Ops.BitSize);

        [MethodImpl(Inline)]   
        public static string ToBitString(this long src)
            => lpadZ(Convert.ToString(src,2), Int64Ops.BitSize);

        [MethodImpl(Inline)]   
        public static string ToBitString(this uint src)
            => lpadZ(Convert.ToString(src,2), UInt32Ops.BitSize);


        [MethodImpl(Inline)]   
        public static string ToIeeeBitString(this double x)
            => lpadZ(apply(Bits.split(x), 
                ieee => append(ieee.sign == Sign.Negative ? "1" : "0",
                            ieee.exponent.ToBitString(),
                            ieee.mantissa.ToBitString()                        
                    )), (int)Float64Ops.BitSize);

    }
}