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
        public static sbyte shiftr(sbyte lhs, int rhs)
            => (sbyte)(lhs >> rhs);

        [MethodImpl(Inline)]
        public static byte shiftr(byte lhs, int rhs)
            => (byte)(lhs >> rhs);

        [MethodImpl(Inline)]
        public static short shiftr(short lhs, int rhs)
            => (short)(lhs >> rhs);

        [MethodImpl(Inline)]
        public static ushort shiftr(ushort lhs, int rhs)
            => (ushort)(lhs >> rhs);

        [MethodImpl(Inline)]
        public static int shiftr(int lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        public static uint shiftr(uint lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        public static long shiftr(long lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        public static ulong shiftr(ulong lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        public static ref sbyte shiftr(ref sbyte lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte shiftr(ref byte lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short shiftr(ref short lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort shiftr(ref ushort lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int shiftr(ref int lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint shiftr(ref uint lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long shiftr(ref long lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong shiftr(ref ulong lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }
    }
}