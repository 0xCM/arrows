//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    
    
    partial class math
    {
        
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
        public static ref sbyte mod(ref sbyte lhs, in sbyte rhs)
        {
            lhs = (sbyte)(lhs % rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte mod(ref byte lhs, in byte rhs)
        {
            lhs = (byte)(lhs % rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short mod(ref short lhs, in short rhs)
        {
            lhs = (short)(lhs % rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort mod(ref ushort lhs, in ushort rhs)
        {
            lhs = (ushort)(lhs % rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int mod(ref int lhs, in int rhs)
        {
            lhs = lhs % rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint mod(ref uint lhs, in uint rhs)
        {
            lhs = lhs % rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long mod(ref long lhs, in long rhs)
        {
            lhs = lhs % rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong mod(ref ulong lhs, in ulong rhs)
        {
            lhs = lhs % rhs;
            return ref lhs;
        }
    }
}