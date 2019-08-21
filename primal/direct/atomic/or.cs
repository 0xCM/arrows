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
        public static sbyte or(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs | rhs);
            
        [MethodImpl(Inline)]
        public static byte or(byte lhs, byte rhs)
            => (byte)(lhs | rhs);

        [MethodImpl(Inline)]
        public static short or(short lhs, short rhs)
            => (short)(lhs | rhs);

        [MethodImpl(Inline)]
        public static ushort or(ushort lhs, ushort rhs)
            => (ushort)(lhs | rhs);


        [MethodImpl(Inline)]
        public static int or(int lhs, int rhs)
            => lhs | rhs;

        [MethodImpl(Inline)]
        public static uint or(uint lhs, uint rhs)
            => lhs | rhs;

        [MethodImpl(Inline)]
        public static long or(long lhs, long rhs)
            => lhs | rhs;

        [MethodImpl(Inline)]
        public static ulong or(ulong lhs, ulong rhs)
            => lhs | rhs;

        [MethodImpl(Inline)]
        public static float or(float lhs, float rhs)
            => BitConverter.Int32BitsToSingle(lhs.ToBits() | rhs.ToBits());

        [MethodImpl(Inline)]
        public static double or(double lhs, double rhs)
            => BitConverter.Int64BitsToDouble(lhs.ToBits() | rhs.ToBits());         
 
        [MethodImpl(Inline)]
        public static ref sbyte or(ref sbyte lhs, sbyte rhs)
        {
            lhs = (sbyte)(lhs | rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte or(ref byte lhs, byte rhs)
        {
            lhs = (byte)(lhs | rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short or(ref short lhs, short rhs)
        {
            lhs = (short)(lhs | rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort or(ref ushort lhs, ushort rhs)
        {
            lhs = (ushort)(lhs | rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int or(ref int lhs, int rhs)
        {
            lhs = lhs | rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint or(ref uint lhs, uint rhs)
        {
            lhs = lhs | rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long or(ref long lhs, long rhs)
        {
            lhs = lhs | rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong or(ref ulong lhs, ulong rhs)
        {
            lhs = lhs | rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref float or(ref float lhs, float rhs)
        {
            lhs = or(lhs,rhs);
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static ref double or(ref double lhs, double rhs)
        {
            lhs = or(lhs,rhs);
            return ref lhs;
        }

 
    }
}