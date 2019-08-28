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
    using System.Runtime.InteropServices;
    
    using static zfunc;

    partial class xfunc
    {

        [MethodImpl(Inline)]
        public static ref byte PackByte(this ReadOnlySpan<Bit> src, int offset, ref byte dst)
        {
            var lastIndex = Math.Min(7, src.Length - offset);
            for(var i = 0; i<= lastIndex; i++)
                dst ^= (byte) ((byte)src[i + offset] << i); 
            return ref dst;                       
        }


    }

}