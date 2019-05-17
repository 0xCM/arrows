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
        public static ref sbyte and(ref sbyte lhs, sbyte rhs)
        {
            lhs = (sbyte)(lhs & rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte and(ref byte lhs, byte rhs)
        {
            lhs = (byte)(lhs & rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short and(ref short lhs, short rhs)
        {
            lhs = (short)(lhs & rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort and(ref ushort lhs, ushort rhs)
        {
            lhs = (ushort)(lhs & rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int and(ref int lhs, int rhs)
        {
            lhs = lhs & rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint and(ref uint lhs, uint rhs)
        {
            lhs = lhs & rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long and(ref long lhs, long rhs)
        {
            lhs = lhs & rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong and(ref ulong lhs, ulong rhs)
        {
            lhs = lhs & rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static sbyte and(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs & rhs);

        [MethodImpl(Inline)]
        public static byte and(byte lhs, byte rhs)
            => (byte)(lhs & rhs);

        [MethodImpl(Inline)]
        public static short and(short lhs, short rhs)
            => (short)(lhs & rhs);

        [MethodImpl(Inline)]
        public static ushort and(ushort lhs, ushort rhs)
            => (ushort)(lhs & rhs);

        [MethodImpl(Inline)]
        public static int and(int lhs, int rhs)
            => lhs & rhs;

        [MethodImpl(Inline)]
        public static uint and(uint lhs, uint rhs)
            => lhs & rhs;

        [MethodImpl(Inline)]
        public static long and(long lhs, long rhs)
            => lhs & rhs;

        [MethodImpl(Inline)]
        public static ulong and(ulong lhs, ulong rhs)
            => lhs & rhs;

   }

}