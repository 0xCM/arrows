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
    

    partial class math
    {
        [MethodImpl(Inline)]
        public static byte rotl(in byte src, in int offset)
            => (byte)((src << offset) | (src >> (8 - offset)));

        [MethodImpl(Inline)]
        public static ushort rotl(in ushort src, in int offset)
            => (ushort)((src << offset) | (src >> (16 - offset)));

        [MethodImpl(Inline)]
        public static uint rotl(in uint src, in int offset)
            => (src << offset) | (src >> (32 - offset));

        [MethodImpl(Inline)]
        public static ulong rotl(in ulong src, in int offset)
            => (src << offset) | (src >> (64 - offset));
    }
}