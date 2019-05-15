//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    
    using static zfunc;
    using static mfunc;


    public static class DisableBit
    {
        [MethodImpl(Inline)]
        public static sbyte LoOn(sbyte src)
            => (sbyte)(src & (src - 1));

        [MethodImpl(Inline)]
        public static byte LoOn(byte src)
            => (byte)(src & (src - 1));

        [MethodImpl(Inline)]
        public static short LoOn(short src)
            => (short)(src & (src - 1));

        [MethodImpl(Inline)]
        public static ushort LoOn(ushort src)
            => (ushort)(src & (src - 1));

        [MethodImpl(Inline)]
        public static int LoOn(int src)
            => src & (src - 1);

        [MethodImpl(Inline)]
        public static uint LoOn(uint src)
            => src & (src - 1);

        [MethodImpl(Inline)]
        public static long LoOn(long src)
            => src & (src - 1);

        [MethodImpl(Inline)]
        public static ulong LoOn(ulong src)
            => src & (src - 1);
    }
}