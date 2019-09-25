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
        public static sbyte max(sbyte lhs, sbyte rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static byte max(byte lhs, byte rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static short max(short lhs, short rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static ushort max(ushort lhs, ushort rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static int max(int lhs, int rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static uint max(uint lhs, uint rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static long max(long lhs, long rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static ulong max(ulong lhs, ulong rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static float max(float lhs, float rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static double max(double lhs, double rhs)
            => lhs > rhs ? lhs : rhs;


    }
}