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

    using C = Core.Contracts;
    using systype = System.Decimal;
    using opstype = DecimalOps;

    public static class DecimalX
    {
        public static string ToHexString(this systype src)
            => map(Bits.split(src), parts =>
                concat(
                    parts.hihi.ToString("X8"),
                    parts.hilo.ToString("X8"),
                    parts.lohi.ToString("X8"),
                    parts.lolo.ToString("X8")
                ));


        public static string ToBitString(this systype src)
            => map(Bits.split(src), parts =>
                concat(
                    parts.hihi.ToBitString(),
                    parts.hilo.ToBitString(),
                    parts.lohi.ToBitString(),
                    parts.lolo.ToBitString()
                ));
    }

}