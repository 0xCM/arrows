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
        public static ref sbyte rshift(ref sbyte lhs, int rhs)
        {
            lhs = (sbyte)(lhs >> rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte rshift(ref byte lhs, int rhs)
        {
            lhs = (byte)(lhs >> rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short rshift(ref short lhs, int rhs)
        {
            lhs = (short)(lhs >> rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort rshift(ref ushort lhs, int rhs)
        {
            lhs = (ushort)(lhs >> rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int rshift(ref int lhs, int rhs)
        {
            lhs = lhs >> rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint rshift(ref uint lhs, int rhs)
        {
            lhs = lhs >> rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long rshift(ref long lhs, int rhs)
        {
            lhs = lhs >> rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong rshift(ref ulong lhs, int rhs)
        {
            lhs = lhs >> rhs;
            return ref lhs;
        }


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