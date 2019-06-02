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
        #region in

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

        #endregion

        #region out

        [MethodImpl(Inline)]
        public static ref sbyte inc(sbyte src, out sbyte dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref byte inc(byte src, out byte dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref short inc(short src, out short dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ushort inc(ushort src, out ushort dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref int inc(int src, out int dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint inc(uint src, out uint dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref long inc(long src, out long dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong inc(ulong src, out ulong dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref float inc(float src, out float dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref double inc(double src, out double dst)
        {
            dst = ++src;
            return ref dst;
        }

        #endregion

        #region io

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

        #endregion

    }
}