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
    using target = System.SByte;

    public static partial class Bits
    {


        /// <summary>
        /// Constructs a short value from two signed byte values
        /// </summary>
        /// <param name="x0">The low-order bits</param>
        /// <param name="x1">The high-order bits</param>
        [MethodImpl(Inline)]
        public static short pack(sbyte x0, sbyte x1)
            => (short)((int)x1 << 8 | (int)(byte)(x0));


    }

}