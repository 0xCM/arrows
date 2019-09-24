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

        [MethodImpl(Inline)]
        public static float and(float lhs, float rhs)
            => BitConverter.Int32BitsToSingle(lhs.ToBits() & rhs.ToBits());

        [MethodImpl(Inline)]
        public static double and(double lhs, double rhs)
            => BitConverter.Int64BitsToDouble(lhs.ToBits() & rhs.ToBits());

        [MethodImpl(Inline)]
        public static ref sbyte and(in sbyte lhs, in sbyte rhs, ref sbyte dst)
        {
            dst = (sbyte)(lhs & rhs);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref byte and(in byte lhs, in byte rhs, ref byte dst)
        {
            dst = (byte)(lhs & rhs);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref short and(in short lhs, in short rhs, ref short dst)
        {
            dst = (short)(lhs & rhs);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ushort and(in ushort lhs, in ushort rhs, ref ushort dst)
        {
            dst = (ushort)(lhs & rhs);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref int and(in int lhs, in int rhs, ref int dst)
        {
            dst = lhs & rhs;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint and(in uint lhs, in uint rhs, ref uint dst)
        {
            dst = lhs & rhs;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref long and(in long lhs, in long rhs, ref long dst)
        {
            dst = lhs & rhs;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong and(in ulong lhs, in ulong rhs, ref ulong dst)
        {
            dst = lhs & rhs;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref float and(in float lhs, in float rhs, ref float dst)
        {
            dst = BitConverter.Int32BitsToSingle(lhs.ToBits() & rhs.ToBits());
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref double and(in double lhs, in double rhs, ref double dst)
        {
            dst = BitConverter.Int64BitsToDouble(lhs.ToBits() & rhs.ToBits());
            return ref dst;
        }
            

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
        public static ref float and(ref float lhs, float rhs)
        {
            lhs = and(lhs,rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double and(ref double lhs, double rhs)
        {
            lhs = and(lhs,rhs);
            return ref lhs;
        }


   }

}