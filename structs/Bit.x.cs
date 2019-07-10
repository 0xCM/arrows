//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public static class BitX
    {
        /// <summary>
        /// Converts a bool value to a bit value
        /// </summary>
        /// <param name="src">The source value to convert</param>
        [MethodImpl(Inline)]
        public static Bit ToBit(this bool src)
            => src;
    }

}