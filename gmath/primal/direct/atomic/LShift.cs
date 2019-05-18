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
        public static sbyte lshift(sbyte lhs, int rhs)
            => (sbyte)(lhs << rhs);

        [MethodImpl(Inline)]
        public static byte lshift(byte lhs, int rhs)
            => (byte)(lhs << rhs);

        [MethodImpl(Inline)]
        public static short lshift(short lhs, int rhs)
            => (short)(lhs << rhs);

        [MethodImpl(Inline)]
        public static ushort lshift(ushort lhs, int rhs)
            => (ushort)(lhs << rhs);

        [MethodImpl(Inline)]
        public static int lshift(int lhs, int rhs)
            => lhs << rhs;

        [MethodImpl(Inline)]
        public static uint lshift(uint lhs, int rhs)
            => lhs << rhs;

        [MethodImpl(Inline)]
        public static long lshift(long lhs, int rhs)
            => lhs << rhs;

        [MethodImpl(Inline)]
        public static ulong lshift(ulong lhs, int rhs)
            => lhs << rhs;

        [MethodImpl(Inline)]
        public static ref sbyte lshift(ref sbyte lhs, int rhs)
        {
            lhs = (sbyte)(lhs << rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte lshift(ref byte lhs, int rhs)
        {
            lhs = (byte)(lhs << rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short lshift(ref short lhs, int rhs)
        {
            lhs = (short)(lhs << rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort lshift(ref ushort lhs, int rhs)
        {
            lhs = (ushort)(lhs << rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int lshift(ref int lhs, int rhs)
        {
            lhs = lhs << rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint lshift(ref uint lhs, int rhs)
        {
            lhs = lhs << rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long lshift(ref long lhs, int rhs)
        {
            lhs = lhs << rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong lshift(ref ulong lhs, int rhs)
        {
            lhs = lhs << rhs;
            return ref lhs;
        }
    }

}