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
    using System.Numerics;
    
    using static zfunc;    
    
    partial class math
    {
        [MethodImpl(Inline)]
        public static sbyte div(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs / rhs);

        [MethodImpl(Inline)]
        public static byte div(byte lhs, byte rhs)
            => (byte)(lhs / rhs);

        [MethodImpl(Inline)]
        public static short div(short lhs, short rhs)
            => (short)(lhs / rhs);

        [MethodImpl(Inline)]
        public static ushort div(ushort lhs, ushort rhs)
            => (ushort)(lhs / rhs);

        [MethodImpl(Inline)]
        public static int div(int lhs, int rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public static uint div(uint lhs, uint rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public static long div(long lhs, long rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public static ulong div(ulong lhs, ulong rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public static ref sbyte div(ref sbyte lhs, in sbyte rhs)
        {
            lhs = (sbyte)(lhs / rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte div(ref byte lhs, in byte rhs)
        {
            lhs = (byte)(lhs / rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short div(ref short lhs, in short rhs)
        {
            lhs = (short)(lhs / rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort div(ref ushort lhs, in ushort rhs)
        {
            lhs = (ushort)(lhs / rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int div(ref int lhs, in int rhs)
        {
            lhs = lhs / rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint div(ref uint lhs, in uint rhs)
        {
            lhs = lhs / rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long div(ref long lhs, in long rhs)
        {
            lhs = lhs / rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong div(ref ulong lhs, in ulong rhs)
        {
            lhs = lhs / rhs;
            return ref lhs;
        }
   }
}