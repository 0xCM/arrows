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

    public static partial class math
    {

        #region add

        [MethodImpl(Inline)]
        public static sbyte add(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs + rhs);

        [MethodImpl(Inline)]
        public static byte add(byte lhs, byte rhs)
            => (byte)(lhs + rhs);

        [MethodImpl(Inline)]
        public static short add(short lhs, short rhs)
            => (short)(lhs + rhs);

        [MethodImpl(Inline)]
        public static ushort add(ushort lhs, ushort rhs)
            => (ushort)(lhs + rhs);

        [MethodImpl(Inline)]
        public static int add(int lhs, int rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public static uint add(uint lhs, uint rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public static long add(long lhs, long rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public static ulong add(ulong lhs, ulong rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public static float add(float lhs, float rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public static double add(double lhs, double rhs)
            => lhs + rhs;


        #endregion

        #region sub

        [MethodImpl(Inline)]
        public static sbyte sub(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs - rhs);

        [MethodImpl(Inline)]
        public static byte sub(byte lhs, byte rhs)
            => (byte)(lhs - rhs);

        [MethodImpl(Inline)]
        public static short sub(short lhs, short rhs)
            => (short)(lhs - rhs);

        [MethodImpl(Inline)]
        public static ushort sub(ushort lhs, ushort rhs)
            => (ushort)(lhs - rhs);

        [MethodImpl(Inline)]
        public static int sub(int lhs, int rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public static uint sub(uint lhs, uint rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public static long sub(long lhs, long rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public static ulong sub(ulong lhs, ulong rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public static float sub(float lhs, float rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public static double sub(double lhs, double rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public static void sub(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }


        [MethodImpl(Inline)]
        public static void sub(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void sub(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void sub(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void sub(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void sub(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void sub(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void sub(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void sub(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void sub(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }


        #endregion

        #region mul


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
        public static float mul(float lhs, float rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public static double mul(double lhs, double rhs)
            => lhs * rhs;


        #endregion

        #region div

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
        public static float div(float lhs, float rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public static double div(double lhs, double rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public static void div(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }


        [MethodImpl(Inline)]
        public static void div(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void div(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void div(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void div(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void div(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void div(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void div(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void div(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void div(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        #endregion div

        #region mod


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
        public static float mod(float lhs, float rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        public static double mod(double lhs, double rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        public static void mod(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }


        [MethodImpl(Inline)]
        public static void mod(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void mod(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void mod(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void mod(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void mod(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void mod(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void mod(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void mod(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void mod(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }


        #endregion

        #region and


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
        public static void and(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = and(lhs[i], rhs[i]);
        }


        [MethodImpl(Inline)]
        public static void and(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = and(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void and(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = and(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void and(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = and(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void and(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = and(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void and(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = and(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void and(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = and(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void and(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = and(lhs[i], rhs[i]);
        }


        #endregion
        
        #region or


        [MethodImpl(Inline)]
        public static sbyte or(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs | rhs);

        [MethodImpl(Inline)]
        public static sbyte or(sbyte x1, sbyte x2, params sbyte[] more)
        {
            var result = or(x1,x2);
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }
            

        [MethodImpl(Inline)]
        public static byte or(byte lhs, byte rhs)
            => (byte)(lhs | rhs);

        [MethodImpl(Inline)]
        public static byte or(byte x1, byte x2, params byte[] more)
        {
            var result = or(x1,x2);
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

        [MethodImpl(Inline)]
        public static short or(short lhs, short rhs)
            => (short)(lhs | rhs);


        [MethodImpl(Inline)]
        public static short or(short x1, short x2, params short[] more)
        {
            var result = or(x1,x2);
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

        [MethodImpl(Inline)]
        public static ushort or(ushort lhs, ushort rhs)
            => (ushort)(lhs | rhs);


        [MethodImpl(Inline)]
        public static ushort or(ushort x1, ushort x2, params ushort[] more)
        {
            var result = or(x1,x2);
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

        [MethodImpl(Inline)]
        public static int or(int lhs, int rhs)
            => lhs | rhs;

        [MethodImpl(Inline)]
        public static int or(int x1, int x2, params int[] more)
        {
            var result = or(x1,x2);
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

        [MethodImpl(Inline)]
        public static uint or(uint lhs, uint rhs)
            => lhs | rhs;

        [MethodImpl(Inline)]
        public static uint or(uint x1, uint x2, params uint[] more)
        {
            var result = or(x1,x2);
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

        [MethodImpl(Inline)]
        public static long or(long lhs, long rhs)
            => lhs | rhs;

        [MethodImpl(Inline)]
        public static long or(long x1, long x2, params long[] more)
        {
            var result = or(x1,x2);
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

        [MethodImpl(Inline)]
        public static ulong or(ulong lhs, ulong rhs)
            => lhs | rhs;

        [MethodImpl(Inline)]
        public static ulong or(ulong x1, ulong x2, params ulong[] more)
        {
            var result = or(x1,x2);
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }


        [MethodImpl(Inline)]
        public static void or(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
        }


        [MethodImpl(Inline)]
        public static void or(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void or(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void or(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void or(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void or(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void or(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void or(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
        }

        #endregion
        
        #region xor


        [MethodImpl(Inline)]
        public static sbyte xor(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public static byte xor(byte lhs, byte rhs)
            => (byte)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public static short xor(short lhs, short rhs)
            => (short)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public static ushort xor(ushort lhs, ushort rhs)
            => (ushort)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public static int xor(int lhs, int rhs)
            => lhs ^ rhs;

        [MethodImpl(Inline)]
        public static uint xor(uint lhs, uint rhs)
            => lhs ^ rhs;

        [MethodImpl(Inline)]
        public static long xor(long lhs, long rhs)
            => lhs ^ rhs;

        [MethodImpl(Inline)]
        public static ulong xor(ulong lhs, ulong rhs)
            => lhs ^ rhs;

        [MethodImpl(Inline)]
        public static void xor(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = xor(lhs[i], rhs[i]);
        }


        [MethodImpl(Inline)]
        public static void xor(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = xor(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void xor(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = xor(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void xor(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = xor(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void xor(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = xor(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void xor(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = xor(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void xor(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = xor(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void xor(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = xor(lhs[i], rhs[i]);
        }

        #endregion

        #region flip

        [MethodImpl(Inline)]
        public static sbyte flip(sbyte src)
            => (sbyte)(~ src);

        [MethodImpl(Inline)]
        public static byte flip(byte src)
            => (byte)(~ src);

        [MethodImpl(Inline)]
        public static short flip(short src)
            => (short)(~ src);

        [MethodImpl(Inline)]
        public static ushort flip(ushort src)
            => (ushort)(~ src);

        [MethodImpl(Inline)]
        public static int flip(int src)
            => ~ src;

        [MethodImpl(Inline)]
        public static uint flip(uint src)
            => ~ src;

        [MethodImpl(Inline)]
        public static long flip(long src)
            => ~ src;

        [MethodImpl(Inline)]
        public static ulong flip(ulong src)
            => ~ src;
    
        [MethodImpl(Inline)]
        public static void flip(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = flip(src[i]);
        }

        [MethodImpl(Inline)]
        public static ref Span<sbyte> flip(ref Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = flip(io[i]);
            return ref io;
        }

        [MethodImpl(Inline)]
        public static void flip(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = flip(src[i]);
        }

        [MethodImpl(Inline)]
        public static ref Span<byte> flip(ref Span<byte> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = flip(io[i]);
            return ref io;
        }

        [MethodImpl(Inline)]
        public static void flip(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = flip(src[i]);
        }


        [MethodImpl(Inline)]
        public static ref Span<short> flip(ref Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = flip(io[i]);
            return ref io;
        }



        [MethodImpl(Inline)]
        public static void flip(ReadOnlySpan<ushort> src, Span<ushort> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = flip(src[i]);
        }


        [MethodImpl(Inline)]
        public static ref Span<ushort> flip(ref Span<ushort> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = flip(io[i]);
            return ref io;
        }

        [MethodImpl(Inline)]
        public static void flip(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = flip(src[i]);
        }

        [MethodImpl(Inline)]
        public static ref Span<int> flip(ref Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = flip(io[i]);
            return ref io;
        }

        [MethodImpl(Inline)]
        public static void flip(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = flip(src[i]);
        }

        [MethodImpl(Inline)]
        public static ref Span<uint> flip(ref Span<uint> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = flip(io[i]);
            return ref io;
        }


        [MethodImpl(Inline)]
        public static void flip(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = flip(src[i]);
        }

        [MethodImpl(Inline)]
        public static ref Span<long> flip(ref Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = flip(io[i]);
            return ref io;
        }


        [MethodImpl(Inline)]
        public static void flip(ReadOnlySpan<ulong> src, Span<ulong> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = flip(src[i]);
        }

        [MethodImpl(Inline)]
        public static ref Span<ulong> flip(ref Span<ulong> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = flip(io[i]);
            return ref io;
        }


        #endregion

        #region lshift

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

        #endregion

        #region rshift

        [MethodImpl(Inline)]
        public static sbyte rshift(sbyte lhs, int rhs)
            => (sbyte)(lhs >> rhs);

        [MethodImpl(Inline)]
        public static byte rshift(byte lhs, int rhs)
            => (byte)(lhs >> rhs);

        [MethodImpl(Inline)]
        public static short rshift(short lhs, int rhs)
            => (short)(lhs >> rhs);

        [MethodImpl(Inline)]
        public static ushort rshift(ushort lhs, int rhs)
            => (ushort)(lhs >> rhs);

        [MethodImpl(Inline)]
        public static int rshift(int lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        public static uint rshift(uint lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        public static long rshift(long lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        public static ulong rshift(ulong lhs, int rhs)
            => lhs >> rhs;

        #endregion

        #region negate

        [MethodImpl(Inline)]
        public static sbyte negate(sbyte src)
            => (sbyte)(- src);


        [MethodImpl(Inline)]
        public static short negate(short src)
            => (short)(- src);

        [MethodImpl(Inline)]
        public static int negate(int src)
            => -src;


        [MethodImpl(Inline)]
        public static long negate(long src)
            => -src;

        [MethodImpl(Inline)]
        public static float negate(float src)
            => -src;


        [MethodImpl(Inline)]
        public static double negate(double src)
            => -src;


        [MethodImpl(Inline)]
        public static void negate(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        [MethodImpl(Inline)]
        public static ref Span<sbyte> negate(ref Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = negate(io[i]);
            return ref io;
        }


        [MethodImpl(Inline)]
        public static void negate(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }


        [MethodImpl(Inline)]
        public static ref Span<short> negate(ref Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = negate(io[i]);
            return ref io;
        }


        [MethodImpl(Inline)]
        public static void negate(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        [MethodImpl(Inline)]
        public static ref Span<int> negate(ref Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = negate(io[i]);
            return ref io;
        }

        [MethodImpl(Inline)]
        public static void negate(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        [MethodImpl(Inline)]
        public static ref Span<long> negate(ref Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = negate(io[i]);
            return ref io;
        }

        [MethodImpl(Inline)]
        public static void negate(ReadOnlySpan<float> src, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        [MethodImpl(Inline)]
        public static ref Span<float> negate(ref Span<float> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = negate(io[i]);
            return ref io;
        }


        [MethodImpl(Inline)]
        public static void negate(ReadOnlySpan<double> src, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }


        [MethodImpl(Inline)]
        public static ref Span<double> negate(ref Span<double> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = negate(io[i]);
            return ref io;
        }

        #endregion

        #region eq

        //! eq
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static bool eq(sbyte lhs, sbyte rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(byte lhs, byte rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(short lhs, short rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(ushort lhs, ushort rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(int lhs, int rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(uint lhs, uint rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(long lhs, long rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(ulong lhs, ulong rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(float lhs, float rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(double lhs, double rhs)
            => lhs == rhs;

        #endregion

        #region neq

        //! neq
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static bool neq(sbyte lhs, sbyte rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(byte lhs, byte rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(short lhs, short rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(ushort lhs, ushort rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(int lhs, int rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(uint lhs, uint rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(long lhs, long rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(ulong lhs, ulong rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(float lhs, float rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(double lhs, double rhs)
            => lhs != rhs;

        #endregion

        #region gt


        [MethodImpl(Inline)]
        public static bool gt(sbyte lhs, sbyte rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(byte lhs, byte rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(short lhs, short rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(ushort lhs, ushort rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(int lhs, int rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(uint lhs, uint rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(long lhs, long rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(ulong lhs, ulong rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(float lhs, float rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(double lhs, double rhs)
            => lhs > rhs;

        #endregion

        #region gteq

        [MethodImpl(Inline)]
        public static bool gteq(sbyte lhs, sbyte rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(byte lhs, byte rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(short lhs, short rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(ushort lhs, ushort rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(int lhs, int rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(uint lhs, uint rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(long lhs, long rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(ulong lhs, ulong rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(float lhs, float rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(double lhs, double rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static void gteq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void gteq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void gteq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void gteq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void gteq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void gteq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
        }

 
        #endregion

        #region lt

        //! lt
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static bool lt(sbyte lhs, sbyte rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(byte lhs, byte rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(short lhs, short rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(ushort lhs, ushort rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(int lhs, int rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(uint lhs, uint rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(long lhs, long rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(ulong lhs, ulong rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(float lhs, float rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(double lhs, double rhs)
            => lhs < rhs;

        #endregion

        #region pow

        //! pow
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static sbyte pow(sbyte src, uint exp)
        {
            var result = 1;
            for(var i = 1; i< exp; i++)
                result = result*i;
            return (sbyte)result;
        }

        [MethodImpl(Inline)]
        public static byte pow(byte src, uint exp)
        {
            var result = 1;
            for(var i = 1; i< exp; i++)
                result = result*i;
            return (byte)result;
        }

        [MethodImpl(Inline)]
        public static short pow(short src, uint exp)
        {
            var result = 1;
            for(var i = 1; i< exp; i++)
                result = result*i;
            return (short)result;
        }

        [MethodImpl(Inline)]
        public static ushort pow(ushort src, uint exp)
        {
            var result = 1;
            for(var i = 1; i< exp; i++)
                result = result*i;
            return (ushort)result;
        }

        [MethodImpl(Inline)]
        public static int pow(int src, uint exp)
        {
            var result = 1;
            for(var i = 1; i< exp; i++)
                result = result*i;
            return result;
        }

        [MethodImpl(Inline)]
        public static uint pow(uint src, uint exp)
        {
            var result = 1u;
            for(var i = 1u; i< exp; i++)
                result = result*i;
            return result;
        }

        [MethodImpl(Inline)]
        public static long pow(long src, uint exp)
        {
            var result = 1L;
            for(var i = 1u; i< exp; i++)
                result = result*i;
            return result;
        }

        [MethodImpl(Inline)]
        public static ulong pow(ulong src, uint exp)
        {
            var result = 1ul;
            for(var i = 1u; i< exp; i++)
                result = result*i;
            return result;
        }

        [MethodImpl(Inline)]
        public static float pow(float src, uint exp)
            => MathF.Pow(src,exp);

        [MethodImpl(Inline)]
        public static double pow(double src, uint exp)
            => Math.Pow(src,exp);

        [MethodImpl(Inline)]
        public static float pow(float src, float exp)
            => MathF.Pow(src,exp);

        [MethodImpl(Inline)]
        public static double pow(double src, double exp)
            => Math.Pow(src,exp);

        #endregion

        #region max

        [MethodImpl(Inline)]
        public static sbyte max(params sbyte[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static byte max(params byte[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static short max(params short[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static ushort max(params ushort[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static int max(params int[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static uint max(params uint[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static long max(params long[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static ulong max(params ulong[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static float max(params float[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static double max(params double[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        #endregion
    }

}