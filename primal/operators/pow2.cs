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
        public static bool isPow2(sbyte src)
            => (src & (src - 1)) == 0;

        [MethodImpl(Inline)]
        public static bool isPow2(byte src)
            => (src & (src - 1)) == 0;

        [MethodImpl(Inline)]
        public static bool isPow2(short src)
            => (src & (src - 1)) == 0;

        [MethodImpl(Inline)]
        public static bool isPow2(ushort src)
            => (src & (src - 1)) == 0;

        [MethodImpl(Inline)]
        public static bool isPow2(int src)
            => (src & (src - 1)) == 0;

        [MethodImpl(Inline)]
        public static bool isPow2(uint src)
            => (src & (src - 1)) == 0;

        [MethodImpl(Inline)]
        public static bool isPow2(long src)
            => (src & (src - 1)) == 0;

        [MethodImpl(Inline)]
        public static bool isPow2(ulong src)
            => (src & (src - 1)) == 0;
    }
}
