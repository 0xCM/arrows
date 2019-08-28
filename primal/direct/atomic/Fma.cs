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
    using System.Numerics;
    
    using static zfunc;    
    

    partial class math
    {
        [MethodImpl(Inline)]
        public static sbyte fma(sbyte x, sbyte y, sbyte z)
            => (sbyte)(x*y + z);

        [MethodImpl(Inline)]
        public static byte fma(byte x, byte y, byte z)
            => (byte)(x*y + z);

        [MethodImpl(Inline)]
        public static short fma(short x, short y, short z)
            => (short)(x*y + z);

        [MethodImpl(Inline)]
        public static ushort fma(ushort x, ushort y, ushort z)
            => (ushort)(x*y + z);

        [MethodImpl(Inline)]
        public static int fma(int x, int y, int z)
            => x*y + z;

        [MethodImpl(Inline)]
        public static uint fma(uint x, uint y, uint z)
            => x*y + z;

        [MethodImpl(Inline)]
        public static long fma(long x, long y, long z)
            => x*y + z;

        [MethodImpl(Inline)]
        public static ulong fma(ulong x, ulong y, ulong z)
            => x*y + z;  
    }

}