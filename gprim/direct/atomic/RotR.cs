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
        public static byte rotr(in byte value, in int offset)
            => (byte)((value >> offset) | (value << (16 - offset)));

        [MethodImpl(Inline)]
        public static ushort rotr(in ushort value, in int offset)
            => (ushort)((value >> offset) | (value << (16 - offset)));

        [MethodImpl(Inline)]
        public static uint rotr(in uint value, in int offset)
            => (value >> offset) | (value << (32 - offset));

        [MethodImpl(Inline)]
        public static ulong rotr(in ulong  value, in int offset)
            => (value >> offset) | (value << (64 - offset));

    }

}