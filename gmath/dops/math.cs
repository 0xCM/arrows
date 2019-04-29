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

    using static zcore;

    public static partial class math
    {
        public static void init()
        {
            add(new uint[]{0u},new uint[]{0u}, new uint[1]);
        }


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

        //! sub
        //! -------------------------------------------------------------------

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

        //! mul
        //! -------------------------------------------------------------------

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



        //! div
        //! -------------------------------------------------------------------

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


        //! mod
        //! -------------------------------------------------------------------

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

        //! and
        //! -------------------------------------------------------------------

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

 
        //! or
        //! -------------------------------------------------------------------

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

        //! xor
        //! -------------------------------------------------------------------

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


        //! flip
        //! -------------------------------------------------------------------

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
    }

}