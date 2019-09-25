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
        public static sbyte mul(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs * rhs);

        [MethodImpl(Inline)]
        public static byte mul(byte lhs, byte rhs)
            => (byte)(lhs * rhs);

        [MethodImpl(Inline)]
        public static short mul(short lhs, short rhs)
            => (short)(lhs * rhs);

        [MethodImpl(Inline)]
        public static ushort mul(ushort lhs, ushort rhs)
            => (ushort)(lhs * rhs);

        [MethodImpl(Inline)]
        public static int mul(int lhs, int rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public static uint mul(uint lhs, uint rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public static long mul(long lhs, long rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public static ulong mul(ulong lhs, ulong rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public static ref sbyte mul(ref sbyte lhs, sbyte rhs)
        {
            lhs = (sbyte)(lhs * rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte mul(ref byte lhs, byte rhs)
        {
            lhs = (byte)(lhs * rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short mul(ref short lhs, short rhs)
        {
            lhs = (short)(lhs * rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort mul(ref ushort lhs, ushort rhs)
        {
            lhs = (ushort)(lhs * rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int mul(ref int lhs, int rhs)
        {
            lhs = lhs * rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint mul(ref uint lhs, uint rhs)
        {
            lhs = lhs * rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long mul(ref long lhs, long rhs)
        {
            lhs = lhs * rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong mul(ref ulong lhs, ulong rhs)
        {
            lhs = lhs * rhs;
            return ref lhs;
        }
    }
}