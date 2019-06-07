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
        public static sbyte log2(sbyte src)
            => (sbyte)Math.ILogB(src);

        [MethodImpl(Inline)]
        public static byte log2(byte src)
            => (byte)Math.ILogB(src);

        [MethodImpl(Inline)]
        public static short log2(short src)
            => (short)Math.ILogB(src);

        [MethodImpl(Inline)]
        public static ushort log2(ushort src)
            => (ushort)Math.ILogB(src);

        [MethodImpl(Inline)]
        public static int log2(int src)
            => Math.ILogB(src);

        [MethodImpl(Inline)]
        public static uint log2(uint src)
            => (uint)Math.ILogB(src);

        [MethodImpl(Inline)]
        public static long log2(long src)
            => Math.ILogB(src);

        [MethodImpl(Inline)]
        public static ulong log2(ulong src)
            => (ulong)Math.ILogB(src);

        [MethodImpl(Inline)]
        public static float log2(float src)
            => Math.ILogB(src);

        [MethodImpl(Inline)]
        public static double log2(double src)
            => Math.ILogB(src);

        [MethodImpl(Inline)]
        public static sbyte ln(sbyte src)
            => (sbyte)Math.Log(src);

        [MethodImpl(Inline)]
        public static byte ln(byte src)
            => (byte)Math.Log(src);

        [MethodImpl(Inline)]
        public static short ln(short src)
            => (short)Math.Log(src);

        [MethodImpl(Inline)]
        public static ushort ln(ushort src)
            => (ushort)Math.Log(src);

        [MethodImpl(Inline)]
        public static int ln(int src)
            => (int)Math.Log(src);

        [MethodImpl(Inline)]
        public static uint ln(uint src)
            => (uint)Math.Log(src);

        [MethodImpl(Inline)]
        public static long ln(long src)
            => (long)Math.Log(src);

        [MethodImpl(Inline)]
        public static ulong ln(ulong src)
            => (ulong)Math.Log(src);

        [MethodImpl(Inline)]
        public static float ln(float src)
            => MathF.Log(src);

        [MethodImpl(Inline)]
        public static double ln(double src)
            => Math.Log(src);

        [MethodImpl(Inline)]
        public static sbyte log(sbyte src, sbyte? @base = null)
            => (sbyte)Math.Log(src, @base ?? 10);

        [MethodImpl(Inline)]
        public static byte log(byte src, byte? @base = null)
            => (byte)Math.Log(src, @base ?? 10);

        [MethodImpl(Inline)]
        public static short log(short src, short? @base = null)
            => (short)Math.Log(src, @base ?? 10);

        [MethodImpl(Inline)]
        public static ushort log(ushort src, ushort? @base = null)
            => (ushort)Math.Log(src, @base ?? 10);

        [MethodImpl(Inline)]
        public static int log(int src, int? @base = null)
            => (int)Math.Log(src, @base ?? 10);

        [MethodImpl(Inline)]
        public static uint log(uint src, uint? @base = null)
            => (uint)Math.Log(src, @base ?? 10);

        [MethodImpl(Inline)]
        public static long log(long src, long? @base = null)
            => (long)Math.Log(src, @base ?? 10);

        [MethodImpl(Inline)]
        public static ulong log(ulong src, ulong? @base = null)
            => (ulong)Math.Log(src, @base ?? 10);

        [MethodImpl(Inline)]
        public static float log(float src, float? @base = null)
            => MathF.Log(src, @base ?? 10);

        [MethodImpl(Inline)]
        public static double log(double src, double? @base = null)
            => Math.Log(src, @base ?? 10);

    }

}