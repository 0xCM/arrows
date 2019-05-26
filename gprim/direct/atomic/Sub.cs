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
        public static sbyte sub(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs - rhs);

        [MethodImpl(Inline)]
        public static byte sub(byte lhs, byte rhs)
            => (byte)(lhs - rhs);

        [MethodImpl(Inline)]
        public static short sub(short lhs, short rhs)
            => (short)(lhs - rhs);

        [MethodImpl(Inline)]
        public static ushort sub(ushort lhs, ushort rhs)
            => (ushort)(lhs - rhs);

        [MethodImpl(Inline)]
        public static int sub(int lhs, int rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public static uint sub(uint lhs, uint rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public static long sub(long lhs, long rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public static ulong sub(ulong lhs, ulong rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public static float sub(float lhs, float rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public static double sub(double lhs, double rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public static ref sbyte sub(ref sbyte lhs, sbyte rhs)
        {
            lhs = (sbyte)(lhs - rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte sub(ref byte lhs, byte rhs)
        {
            lhs = (byte)(lhs - rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short sub(ref short lhs, short rhs)
        {
            lhs = (short)(lhs - rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort sub(ref ushort lhs, ushort rhs)
        {
            lhs = (ushort)(lhs - rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int sub(ref int lhs, int rhs)
        {
            lhs = lhs - rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint sub(ref uint lhs, uint rhs)
        {
            lhs = lhs - rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long sub(ref long lhs, long rhs)
        {
            lhs = lhs - rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong sub(ref ulong lhs, ulong rhs)
        {
            lhs = lhs - rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref float sub(ref float lhs, float rhs)
        {
            lhs = lhs - rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double sub(ref double lhs, double rhs)
        {
            lhs = lhs - rhs;
            return ref lhs;
        }
    }
}