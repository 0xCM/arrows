//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;
    using target = System.Decimal;

    public static partial class Bits
    {

        /// <summary>
        /// Partitions the bits of a decimal as a sequence of four integers
        /// </summary>
        /// <param name="x0">The source bits [0 .. 31]</param>
        /// <param name="x1">The source bits [32 .. 63]</param>
        /// <param name="x2">The source bits [64 .. 97]</param>
        /// <param name="x3">The source bits [98 .. 127]</param>
        [MethodImpl(Inline)]
        public static (int x0, int x1, int x2, int x3) split(decimal src)
            => apply(Decimal.GetBits(src), x => (x[0],x[1],x[2],x[3]));


    }

}