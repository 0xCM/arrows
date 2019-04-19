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
    using target = System.Int64;

    public static partial class Bits
    {
        /// <summary>
        /// int => (short, .)
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static int hi32(long src)
            => (int)(src >> 32);

        /// <summary>
        /// int => (., short)
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static int lo32(long src)
            => (int)src;

    

        /// <summary>
        /// long => (int,int)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        [MethodImpl(Inline)]
        public static (int x0, int x1) unpack(target src)
            => (lo32(src), hi32(src));


    }

}