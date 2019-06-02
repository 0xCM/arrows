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
        public static sbyte shiftl(sbyte lhs, int rhs)
            => (sbyte)(lhs << rhs);

        [MethodImpl(Inline)]
        public static byte shiftl(byte lhs, int rhs)
            => (byte)(lhs << rhs);

        [MethodImpl(Inline)]
        public static short shiftl(short lhs, int rhs)
            => (short)(lhs << rhs);

        [MethodImpl(Inline)]
        public static ushort shiftl(ushort lhs, int rhs)
            => (ushort)(lhs << rhs);

        [MethodImpl(Inline)]
        public static int shiftl(int lhs, int rhs)
            => lhs << rhs;

        [MethodImpl(Inline)]
        public static uint shiftl(uint lhs, int rhs)
            => lhs << rhs;

        [MethodImpl(Inline)]
        public static long shiftl(long lhs, int rhs)
            => lhs << rhs;

        [MethodImpl(Inline)]
        public static ulong shiftl(ulong lhs, int rhs)
            => lhs << rhs;

        [MethodImpl(Inline)]
        public static ref sbyte shiftl(ref sbyte lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte shiftl(ref byte lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short shiftl(ref short lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort shiftl(ref ushort lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int shiftl(ref int lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint shiftl(ref uint lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long shiftl(ref long lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong shiftl(ref ulong lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }
    }

}