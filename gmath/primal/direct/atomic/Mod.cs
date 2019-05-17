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
        public static ref sbyte mod(ref sbyte lhs, sbyte rhs)
        {
            lhs = (sbyte)(lhs % rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte mod(ref byte lhs, byte rhs)
        {
            lhs = (byte)(lhs % rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short mod(ref short lhs, short rhs)
        {
            lhs = (short)(lhs % rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort mod(ref ushort lhs, ushort rhs)
        {
            lhs = (ushort)(lhs % rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int mod(ref int lhs, int rhs)
        {
            lhs = lhs % rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint mod(ref uint lhs, uint rhs)
        {
            lhs = lhs % rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long mod(ref long lhs, long rhs)
        {
            lhs = lhs % rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong mod(ref ulong lhs, ulong rhs)
        {
            lhs = lhs % rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref float mod(ref float lhs, float rhs)
        {
            lhs = lhs % rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double mod(ref double lhs, double rhs)
        {
            lhs = lhs % rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static sbyte mod(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs % rhs);

        [MethodImpl(Inline)]
        public static byte mod(byte lhs, byte rhs)
            => (byte)(lhs % rhs);

        [MethodImpl(Inline)]
        public static short mod(short lhs, short rhs)
            => (short)(lhs % rhs);

        [MethodImpl(Inline)]
        public static ushort mod(ushort lhs, ushort rhs)
            => (ushort)(lhs % rhs);

        [MethodImpl(Inline)]
        public static int mod(int lhs, int rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        public static uint mod(uint lhs, uint rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        public static long mod(long lhs, long rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        public static ulong mod(ulong lhs, ulong rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        public static float mod(float lhs, float rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        public static double mod(double lhs, double rhs)
            => lhs % rhs;
    }
}