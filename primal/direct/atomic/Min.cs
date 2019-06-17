//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    
    
    partial class math
    {
        [MethodImpl(Inline)]
        public static sbyte min(sbyte lhs, sbyte rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static byte min(byte lhs, byte rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static short min(short lhs, short rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static ushort min(ushort lhs, ushort rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static int min(int lhs, int rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static uint min(uint lhs, uint rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static long min(long lhs, long rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static ulong min(ulong lhs, ulong rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static float min(float lhs, float rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static double min(double lhs, double rhs)
            => lhs < rhs ? lhs : rhs;

    }
}