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

    partial class math
    {

        #region add

        //! add
        //! -------------------------------------------------------------------

        public static void add(sbyte[] lhs, sbyte[] rhs, sbyte[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = add(lhs[i], rhs[i]);
        }


        public static void add(byte[] lhs, byte[] rhs, byte[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = add(lhs[i], rhs[i]);
        }

        public static void add(short[] lhs, short[] rhs, short[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = add(lhs[i], rhs[i]);
        }

        public static void add(ushort[] lhs, ushort[] rhs, ushort[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = add(lhs[i], rhs[i]);
        }

        public static void add(int[] lhs, int[] rhs, int[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = add(lhs[i], rhs[i]);
        }

        public static void add(uint[] lhs, uint[] rhs, uint[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = add(lhs[i], rhs[i]);
        }

        public static void add(long[] lhs, long[] rhs, long[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = add(lhs[i], rhs[i]);
        }

        public static void add(ulong[] lhs, ulong[] rhs, ulong[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = add(lhs[i], rhs[i]);
        }

        public static void add(float[] lhs, float[] rhs, float[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = add(lhs[i], rhs[i]);
        }

        public static void add(double[] lhs, double[] rhs, double[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = add(lhs[i], rhs[i]);
        }

        #endregion

        #region sub
        //! sub
        //! -------------------------------------------------------------------

        public static void sub(sbyte[] lhs, sbyte[] rhs, sbyte[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        public static void sub(byte[] lhs, byte[] rhs, byte[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        public static void sub(short[] lhs, short[] rhs, short[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        public static void sub(ushort[] lhs, ushort[] rhs, ushort[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        public static void sub(int[] lhs, int[] rhs, int[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        public static void sub(uint[] lhs, uint[] rhs, uint[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        public static void sub(long[] lhs, long[] rhs, long[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        public static void sub(ulong[] lhs, ulong[] rhs, ulong[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        public static void sub(float[] lhs, float[] rhs, float[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        public static void sub(double[] lhs, double[] rhs, double[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }
        #endregion

        #region mul

        //! mul
        //! -------------------------------------------------------------------

        public static void mul(sbyte[] lhs, sbyte[] rhs, sbyte[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mul(lhs[i], rhs[i]);
        }

        public static void mul(byte[] lhs, byte[] rhs, byte[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mul(lhs[i], rhs[i]);
        }

        public static void mul(short[] lhs, short[] rhs, short[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mul(lhs[i], rhs[i]);
        }

        public static void mul(ushort[] lhs, ushort[] rhs, ushort[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mul(lhs[i], rhs[i]);
        }

        public static void mul(int[] lhs, int[] rhs, int[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mul(lhs[i], rhs[i]);
        }

        public static void mul(uint[] lhs, uint[] rhs, uint[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mul(lhs[i], rhs[i]);
        }

        public static void mul(long[] lhs, long[] rhs, long[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mul(lhs[i], rhs[i]);
        }

        public static void mul(ulong[] lhs, ulong[] rhs, ulong[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mul(lhs[i], rhs[i]);
        }

        public static void mul(float[] lhs, float[] rhs, float[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mul(lhs[i], rhs[i]);
        }

        public static void mul(double[] lhs, double[] rhs, double[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mul(lhs[i], rhs[i]);
        }
        
        #endregion

        #region div

        //! div
        //! -------------------------------------------------------------------


        public static void div(sbyte[] lhs, sbyte[] rhs, sbyte[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        public static void div(byte[] lhs, byte[] rhs, byte[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        public static void div(short[] lhs, short[] rhs, short[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        public static void div(ushort[] lhs, ushort[] rhs, ushort[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        public static void div(int[] lhs, int[] rhs, int[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        public static void div(uint[] lhs, uint[] rhs, uint[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        public static void div(long[] lhs, long[] rhs, long[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        public static void div(ulong[] lhs, ulong[] rhs, ulong[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        public static void div(float[] lhs, float[] rhs, float[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        public static void div(double[] lhs, double[] rhs, double[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        #endregion

        #region mod

        //! mod
        //! -------------------------------------------------------------------

        public static void mod(sbyte[] lhs, sbyte[] rhs, sbyte[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static void mod(byte[] lhs, byte[] rhs, byte[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static void mod(short[] lhs, short[] rhs, short[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static void mod(ushort[] lhs, ushort[] rhs, ushort[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static void mod(int[] lhs, int[] rhs, int[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static void mod(uint[] lhs, uint[] rhs, uint[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static void mod(long[] lhs, long[] rhs, long[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static void mod(ulong[] lhs, ulong[] rhs, ulong[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static void mod(float[] lhs, float[] rhs, float[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static void mod(double[] lhs, double[] rhs, double[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        #endregion

        #region and

        //! and
        //! -------------------------------------------------------------------

        public static void and(sbyte[] lhs, sbyte[] rhs, sbyte[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = and(lhs[i], rhs[i]);
        }

        public static void and(byte[] lhs, byte[] rhs, byte[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = and(lhs[i], rhs[i]);
        }

        public static void and(short[] lhs, short[] rhs, short[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = and(lhs[i], rhs[i]);
        }

        public static void and(ushort[] lhs, ushort[] rhs, ushort[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = and(lhs[i], rhs[i]);
        }

        public static void and(int[] lhs, int[] rhs, int[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = and(lhs[i], rhs[i]);
        }

        public static void and(uint[] lhs, uint[] rhs, uint[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = and(lhs[i], rhs[i]);
        }

        public static void and(long[] lhs, long[] rhs, long[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = and(lhs[i], rhs[i]);
        }

        public static void and(ulong[] lhs, ulong[] rhs, ulong[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = and(lhs[i], rhs[i]);
        }
        
        #endregion

        #region or

        //! or
        //! -------------------------------------------------------------------

        public static void or(sbyte[] lhs, sbyte[] rhs, sbyte[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = or(lhs[i], rhs[i]);
        }

        public static void or(byte[] lhs, byte[] rhs, byte[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = or(lhs[i], rhs[i]);
        }

        public static void or(short[] lhs, short[] rhs, short[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = or(lhs[i], rhs[i]);
        }

        public static void or(ushort[] lhs, ushort[] rhs, ushort[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = or(lhs[i], rhs[i]);
        }

        public static void or(int[] lhs, int[] rhs, int[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = or(lhs[i], rhs[i]);
        }

        public static void or(uint[] lhs, uint[] rhs, uint[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = or(lhs[i], rhs[i]);
        }

        public static void or(long[] lhs, long[] rhs, long[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = or(lhs[i], rhs[i]);
        }

        public static void or(ulong[] lhs, ulong[] rhs, ulong[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = or(lhs[i], rhs[i]);
        }
        
        #endregion

        #region xor

        //! xor
        //! -------------------------------------------------------------------

        public static void xor(sbyte[] lhs, sbyte[] rhs, sbyte[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = xor(lhs[i], rhs[i]);
        }

        public static void xor(byte[] lhs, byte[] rhs, byte[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = xor(lhs[i], rhs[i]);
        }

        public static void xor(short[] lhs, short[] rhs, short[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = xor(lhs[i], rhs[i]);
        }

        public static void xor(ushort[] lhs, ushort[] rhs, ushort[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = xor(lhs[i], rhs[i]);
        }

        public static void xor(int[] lhs, int[] rhs, int[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = xor(lhs[i], rhs[i]);
        }

        public static void xor(uint[] lhs, uint[] rhs, uint[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = xor(lhs[i], rhs[i]);
        }

        public static void xor(long[] lhs, long[] rhs, long[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = xor(lhs[i], rhs[i]);
        }

        public static void xor(ulong[] lhs, ulong[] rhs, ulong[] dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = xor(lhs[i], rhs[i]);
        }
        
        #endregion

    }

}