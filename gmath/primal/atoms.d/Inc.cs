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
        public static ref sbyte inc(ref sbyte src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref byte inc(ref byte src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short inc(ref short src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort inc(ref ushort src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref int inc(ref int src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint inc(ref uint src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long inc(ref long src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong inc(ref ulong src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref float inc(ref float src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double inc(ref double src)
        {
            src++;
            return ref src;
        }
 
        [MethodImpl(Inline)]
        public static sbyte inc(sbyte src)
            => ++src;

        [MethodImpl(Inline)]
        public static byte inc(byte src)
            => ++src;

        [MethodImpl(Inline)]
        public static short inc(short src)
            => ++src;

        [MethodImpl(Inline)]
        public static ushort inc(ushort src)
            => ++src;

        [MethodImpl(Inline)]
        public static int inc(int src)
            => ++src;

        [MethodImpl(Inline)]
        public static uint inc(uint src)
            => ++src;

        [MethodImpl(Inline)]
        public static long inc(long src)
            => ++src;

        [MethodImpl(Inline)]
        public static ulong inc(ulong src)
            => ++src;

        [MethodImpl(Inline)]
        public static float inc(float src)
            => ++src;

        [MethodImpl(Inline)]
        public static double inc(double src)
            => ++src;
    }
}