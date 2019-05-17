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
        public static sbyte dec(sbyte src)
            => --src;

        [MethodImpl(Inline)]
        public static byte dec(byte src)
            => --src;

        [MethodImpl(Inline)]
        public static short dec(short src)
            => --src;

        [MethodImpl(Inline)]
        public static ushort dec(ushort src)
            => --src;

        [MethodImpl(Inline)]
        public static int dec(int src)
            => --src;

        [MethodImpl(Inline)]
        public static uint dec(uint src)
            => --src;

        [MethodImpl(Inline)]
        public static long dec(long src)
            => --src;

        [MethodImpl(Inline)]
        public static ulong dec(ulong src)
            => --src;

        [MethodImpl(Inline)]
        public static float dec(float src)
            => --src;

        [MethodImpl(Inline)]
        public static double dec(double src)
            => --src;


        [MethodImpl(Inline)]
        public static ref sbyte dec(ref sbyte src)
        {
            src--;
            return ref src;
        }


        [MethodImpl(Inline)]
        public static ref byte dec(ref byte src)
        {
            src--;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short dec(ref short src)
        {
            src--;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort dec(ref ushort src)
        {
            src--;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref int dec(ref int src)
        {
            src--;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint dec(ref uint src)
        {
            src--;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long dec(ref long src)
        {
            src--;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong dec(ref ulong src)
        {
            src--;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref float dec(ref float src)
        {
            src--;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double dec(ref double src)
        {
            src--;
            return ref src;
        }


        [MethodImpl(Inline)]
        public static ref sbyte dec(sbyte src, out sbyte dst)
        {
            dst = --src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref byte dec(byte src, out byte dst)
        {
            dst = --src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref short dec(short src, out short dst)
        {
            dst = --src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ushort dec(ushort src, out ushort dst)
        {
            dst = --src;
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static ref int dec(int src, out int dst)
        {
            dst = --src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint dec(uint src, out uint dst)
        {
            dst = --src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref long dec(long src, out long dst)
        {
            dst = --src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong dec(ulong src, out ulong dst)
        {
            dst = --src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref float dec(float src, out float dst)
        {
            dst = --src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref double dec(double src, out double dst)
        {
            dst = --src;
            return ref dst;
        }

    }


}