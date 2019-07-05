//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
 
    using static zfunc;
    using static Constants;
    
    partial class Bits
    {                
        [MethodImpl(Inline)]
        public static void split(ulong src, out uint hi, out uint lo)
        {
            hi = (uint)(src >> 32);
            lo = (uint)src;
        }

        [MethodImpl(Inline)]
        public static void split(uint src, out ushort hi, out ushort lo)
        {
            hi = (ushort)(src >> 32);
            lo = (ushort)src;
        }

        [MethodImpl(Inline)]
        public static void split(ushort src, out byte hi, out byte lo)
        {
            hi = (byte)(src >> 32);
            lo = (byte)src;
        }

    }

}