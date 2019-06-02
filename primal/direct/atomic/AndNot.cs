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
        public static sbyte andnot(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs &~ rhs);

        [MethodImpl(Inline)]
        public static byte andnot(byte lhs, byte rhs)
            => (byte)(lhs &~ rhs);

        [MethodImpl(Inline)]
        public static short andnot(short lhs, short rhs)
            => (short)(lhs &~ rhs);

        [MethodImpl(Inline)]
        public static ushort andnot(ushort lhs, ushort rhs)
            => (ushort)(lhs &~ rhs);

        [MethodImpl(Inline)]
        public static int andnot(int lhs, int rhs)
            => lhs &~ rhs;

        [MethodImpl(Inline)]
        public static uint andnot(uint lhs, uint rhs)
            => lhs &~ rhs;

        [MethodImpl(Inline)]
        public static long andnot(long lhs, long rhs)
            => lhs &~ rhs;

        [MethodImpl(Inline)]
        public static ulong andnot(ulong lhs, ulong rhs)
            => lhs &~ rhs;



    }

}