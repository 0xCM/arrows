//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static corefunc;

    using static Class;
    using systype = System.Double;
    using opstype = Float64Ops;
    using SysMath = System.Math;

    public static class Float64X
    {
        public static string ToBitString(this systype x)
            => lpadZ(map(Bits.split(x), 
                ieee => concat(ieee.sign == Sign.Negative ? "1" : "0",
                            ieee.exponent.ToBitString(),
                            ieee.mantissa.ToBitString()
                            
                    )), opstype.MaxBitLength);

    }

}