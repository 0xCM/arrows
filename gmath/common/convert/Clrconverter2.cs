//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    
    using static mfunc;

    public static class Converters
    {

        #region int8 => X

        [MethodImpl(Inline)]
        public static sbyte convert(sbyte src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        public static byte convert(sbyte src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        public static short convert(sbyte src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        public static ushort convert(sbyte src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        public static int convert(sbyte src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        public static uint convert(sbyte src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        public static long convert(sbyte src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        public static ulong convert(sbyte src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        public static float convert(sbyte src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        public static double convert(sbyte src, out double dst)
            => dst = (double)src;

        #endregion            

        #region uint8 => X

        [MethodImpl(Inline)]
        public static sbyte convert(byte src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        public static byte convert(byte src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        public static short convert(byte src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        public static ushort convert(byte src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        public static int convert(byte src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        public static uint convert(byte src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        public static long convert(byte src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        public static ulong convert(byte src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        public static float convert(byte src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        public static double convert(byte src, out double dst)
            => dst = (double)src;

        #endregion            

        #region int16 => X

        [MethodImpl(Inline)]
        public static sbyte convert(short src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        public static byte convert(short src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        public static short convert(short src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        public static ushort convert(short src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        public static int convert(short src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        public static uint convert(short src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        public static long convert(short src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        public static ulong convert(short src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        public static float convert(short src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        public static double convert(short src, out double dst)
            => dst = (double)src;

        #endregion            

        #region uint16 => X

        [MethodImpl(Inline)]
        public static sbyte convert(ushort src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        public static byte convert(ushort src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        public static short convert(ushort src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        public static ushort convert(ushort src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        public static int convert(ushort src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        public static uint convert(ushort src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        public static long convert(ushort src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        public static ulong convert(ushort src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        public static float convert(ushort src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        public static double convert(ushort src, out double dst)
            => dst = (double)src;

        #endregion            

        #region int32 => X

        [MethodImpl(Inline)]
        public static sbyte convert(int src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        public static byte convert(int src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        public static short convert(int src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        public static ushort convert(int src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        public static int convert(int src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        public static uint convert(int src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        public static long convert(int src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        public static ulong convert(int src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        public static float convert(int src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        public static double convert(int src, out double dst)
            => dst = (double)src;

        #endregion            
 
        #region uint32 => X

        [MethodImpl(Inline)]
        public static sbyte convert(uint src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        public static byte convert(uint src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        public static short convert(uint src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        public static ushort convert(uint src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        public static int convert(uint src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        public static uint convert(uint src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        public static long convert(uint src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        public static ulong convert(uint src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        public static float convert(uint src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        public static double convert(uint src, out double dst)
            => dst = (double)src;

        #endregion            
 
        #region int64 => X

        [MethodImpl(Inline)]
        public static sbyte convert(long src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        public static byte convert(long src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        public static short convert(long src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        public static ushort convert(long src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        public static int convert(long src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        public static uint convert(long src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        public static long convert(long src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        public static ulong convert(long src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        public static float convert(long src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        public static double convert(long src, out double dst)
            => dst = (double)src;

        #endregion            

        #region uint64 => X

        [MethodImpl(Inline)]
        public static sbyte convert(ulong src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        public static byte convert(ulong src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        public static short convert(ulong src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        public static ushort convert(ulong src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        public static int convert(ulong src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        public static uint convert(ulong src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        public static long convert(ulong src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        public static ulong convert(ulong src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        public static float convert(ulong src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        public static double convert(ulong src, out double dst)
            => dst = (double)src;

        #endregion            

        #region float32 => X

        [MethodImpl(Inline)]
        public static sbyte convert(float src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        public static byte convert(float src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        public static short convert(float src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        public static ushort convert(float src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        public static int convert(float src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        public static uint convert(float src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        public static long convert(float src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        public static ulong convert(float src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        public static float convert(float src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        public static double convert(float src, out double dst)
            => dst = (double)src;

        #endregion            

        #region float64 => X

        [MethodImpl(Inline)]
        public static sbyte convert(double src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        public static byte convert(double src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        public static short convert(double src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        public static ushort convert(double src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        public static int convert(double src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        public static uint convert(double src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        public static long convert(double src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        public static ulong convert(double src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        public static float convert(double src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        public static double convert(double src, out double dst)
            => dst = (double)src;

        #endregion            


    }
}