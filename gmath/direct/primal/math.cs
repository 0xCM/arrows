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

        #region add

        //! add
        //! -------------------------------------------------------------------

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

        #endregion

        #region mul

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

        #endregion

        #region div

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

        #endregion div

        #region mod

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

        #endregion

        #region and

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

        #endregion
        
        #region or

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

        #endregion
        
        #region xor

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

        #endregion

        #region flip

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

        #region  neq

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
    }

}