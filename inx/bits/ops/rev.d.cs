//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    

    partial class Bits
    {                

        /// <summary>
        /// Reverses the bits in a byte
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        /// <reference>https://graphics.stanford.edu/~seander/bithacks.htm</reference>
        [MethodImpl(Inline)]
        public static byte rev(byte src)
        {
            return (byte)(((src * 0x80200802ul) & 0x0884422110ul) * 0x0101010101ul >> 32);
        }

    }

}