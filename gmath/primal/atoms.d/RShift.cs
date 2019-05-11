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
        public static sbyte rshift(sbyte lhs, int rhs)
            => (sbyte)(lhs >> rhs);

        [MethodImpl(Inline)]
        public static byte rshift(byte lhs, int rhs)
            => (byte)(lhs >> rhs);

        [MethodImpl(Inline)]
        public static short rshift(short lhs, int rhs)
            => (short)(lhs >> rhs);

        [MethodImpl(Inline)]
        public static ushort rshift(ushort lhs, int rhs)
            => (ushort)(lhs >> rhs);

        [MethodImpl(Inline)]
        public static int rshift(int lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        public static uint rshift(uint lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        public static long rshift(long lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        public static ulong rshift(ulong lhs, int rhs)
            => lhs >> rhs;


    }

}