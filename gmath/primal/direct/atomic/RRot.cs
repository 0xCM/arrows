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

    
    using static mfunc;

    partial class math
    {
        [MethodImpl(Inline)]
        public static byte rrot(in byte value, in int offset)
            => (byte)((value >> offset) | (value << (16 - offset)));

        [MethodImpl(Inline)]
        public static ushort rrot(in ushort value, in int offset)
            => (ushort)((value >> offset) | (value << (16 - offset)));

        [MethodImpl(Inline)]
        public static uint rrot(in uint value, in int offset)
            => (value >> offset) | (value << (32 - offset));

        [MethodImpl(Inline)]
        public static ulong rrot(in ulong  value, in int offset)
            => (value >> offset) | (value << (64 - offset));

    }

}