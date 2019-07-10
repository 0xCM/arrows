//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    
    partial class Bits
    {                

        [MethodImpl(Inline)]
        public static uint bitmap(in uint src, in byte srcOffset, in byte len, in uint dst, in byte dstOffset)
        {
             return (extract(src, srcOffset, len) << dstOffset) | dst;
        }

        [MethodImpl(Inline)]
        public static byte shufflespec(byte x3, byte x2, byte x1, byte x0)
            => (byte)((x3 << 6) | (x2 << 4) | (x1 << 2) | x0);
    }

}