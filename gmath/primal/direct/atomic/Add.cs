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
        public static sbyte add(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs + rhs);

        [MethodImpl(Inline)]
        public static byte add(byte lhs, byte rhs)
            => (byte)(lhs + rhs);

        [MethodImpl(Inline)]
        public static short add(short lhs, short rhs)
            => (short)(lhs + rhs);

        [MethodImpl(Inline)]
        public static ushort add(ushort lhs, ushort rhs)
            => (ushort)(lhs + rhs);

        [MethodImpl(Inline)]
        public static int add(int lhs, int rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public static uint add(uint lhs, uint rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public static long add(long lhs, long rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public static ulong add(ulong lhs, ulong rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public static float add(float lhs, float rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public static double add(double lhs, double rhs)
            => lhs + rhs;
 
        [MethodImpl(Inline)]
        public static ref sbyte add(ref sbyte lhs, sbyte rhs)
        {
            lhs = (sbyte)(lhs + rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte add(ref byte lhs, byte rhs)
        {
            lhs = (byte)(lhs + rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short add(ref short lhs, short rhs)
        {
            lhs = (short)(lhs + rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort add(ref ushort lhs, ushort rhs)
        {
            lhs = (ushort)(lhs + rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int add(ref int lhs, int rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint add(ref uint lhs, uint rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long add(ref long lhs, long rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong add(ref ulong lhs, ulong rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref float add(ref float lhs, float rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double add(ref double lhs, double rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

         [MethodImpl(Inline)]
        public static sbyte add(sbyte lhs, sbyte rhs, out sbyte dst)
            => dst = (sbyte)(lhs + rhs);

        [MethodImpl(Inline)]
        public static byte add(byte lhs, byte rhs, out byte dst)
            => dst = (byte)(lhs + rhs);

        [MethodImpl(Inline)]
        public static short add(short lhs, short rhs, out short dst)
            => dst = (short)(lhs + rhs);

        [MethodImpl(Inline)]
        public static ushort add(ushort lhs, ushort rhs, out ushort dst)
            => dst = (ushort)(lhs + rhs);

        [MethodImpl(Inline)]
        public static int add(int lhs, int rhs, out int dst)
            => dst = lhs + rhs;

        [MethodImpl(Inline)]
        public static uint add(uint lhs, uint rhs, out uint dst)
            => dst = lhs + rhs;

        [MethodImpl(Inline)]
        public static long add(long lhs, long rhs, out long dst)
            => dst = lhs + rhs;

        [MethodImpl(Inline)]
        public static ulong add(ulong lhs, ulong rhs, out ulong dst)
            => dst = lhs + rhs;

        [MethodImpl(Inline)]
        public static float add(float lhs, float rhs, out float dst)
            => dst = lhs + rhs;

        [MethodImpl(Inline)]
        public static double add(double lhs, double rhs, out double dst)
            => dst = lhs + rhs;
    }

}