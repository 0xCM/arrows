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

        public static long addT(sbyte[] lhs, sbyte[] rhs, sbyte[] dst)
        {
            var sw = stopwatch();
            math.add(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long addT(byte[] lhs, byte[] rhs, byte[] dst)
        {
            var sw = stopwatch();
            math.add(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long addT(short[] lhs, short[] rhs, short[] dst)
        {
            var sw = stopwatch();
            math.add(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long addT(ushort[] lhs, ushort[] rhs, ushort[] dst)
        {
            var sw = stopwatch();
            math.add(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long addT(int[] lhs, int[] rhs, int[] dst)
        {
            var sw = stopwatch();
            math.add(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long addT(uint[] lhs, uint[] rhs, uint[] dst)
        {
            var sw = stopwatch();
            math.add(lhs,rhs, dst);
            return elapsed(sw);
        }


        public static long addT(long[] lhs, long[] rhs, long[] dst)
        {
            var sw = stopwatch();
            math.add(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long addT(ulong[] lhs, ulong[] rhs, ulong[] dst)
        {
            var sw = stopwatch();
            math.add(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long addT(float[] lhs, float[] rhs, float[] dst)
        {
            var sw = stopwatch();
            math.add(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long addT(double[] lhs, double[] rhs, double[] dst)
        {
            var sw = stopwatch();
            math.add(lhs,rhs, dst);
            return elapsed(sw);
        }

        #endregion
 
        #region sub

        //! sub
        //! -------------------------------------------------------------------

        public static long subT(sbyte[] lhs, sbyte[] rhs, sbyte[] dst)
        {
            var sw = stopwatch();
            math.sub(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long subT(byte[] lhs, byte[] rhs, byte[] dst)
        {
            var sw = stopwatch();
            math.sub(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long subT(short[] lhs, short[] rhs, short[] dst)
        {
            var sw = stopwatch();
            math.sub(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long subT(ushort[] lhs, ushort[] rhs, ushort[] dst)
        {
            var sw = stopwatch();
            math.sub(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long subT(int[] lhs, int[] rhs, int[] dst)
        {
            var sw = stopwatch();
            math.sub(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long subT(uint[] lhs, uint[] rhs, uint[] dst)
        {
            var sw = stopwatch();
            math.sub(lhs,rhs, dst);
            return elapsed(sw);
        }


        public static long subT(long[] lhs, long[] rhs, long[] dst)
        {
            var sw = stopwatch();
            math.sub(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long subT(ulong[] lhs, ulong[] rhs, ulong[] dst)
        {
            var sw = stopwatch();
            math.sub(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long subT(float[] lhs, float[] rhs, float[] dst)
        {
            var sw = stopwatch();
            math.sub(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long subT(double[] lhs, double[] rhs, double[] dst)
        {
            var sw = stopwatch();
            math.sub(lhs,rhs, dst);
            return elapsed(sw);
        }

        #endregion
 
        #region mul

        //! mul
        //! -------------------------------------------------------------------

        public static long mulT(sbyte[] lhs, sbyte[] rhs, sbyte[] dst)
        {
            var sw = stopwatch();
            math.mul(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long mulT(byte[] lhs, byte[] rhs, byte[] dst)
        {
            var sw = stopwatch();
            math.mul(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long mulT(short[] lhs, short[] rhs, short[] dst)
        {
            var sw = stopwatch();
            math.mul(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long mulT(ushort[] lhs, ushort[] rhs, ushort[] dst)
        {
            var sw = stopwatch();
            math.mul(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long mulT(int[] lhs, int[] rhs, int[] dst)
        {
            var sw = stopwatch();
            math.mul(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long mulT(uint[] lhs, uint[] rhs, uint[] dst)
        {
            var sw = stopwatch();
            math.mul(lhs,rhs, dst);
            return elapsed(sw);
        }


        public static long mulT(long[] lhs, long[] rhs, long[] dst)
        {
            var sw = stopwatch();
            math.mul(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long mulT(ulong[] lhs, ulong[] rhs, ulong[] dst)
        {
            var sw = stopwatch();
            math.mul(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long mulT(float[] lhs, float[] rhs, float[] dst)
        {
            var sw = stopwatch();
            math.mul(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long mulT(double[] lhs, double[] rhs, double[] dst)
        {
            var sw = stopwatch();
            math.mul(lhs,rhs, dst);
            return elapsed(sw);
        }

        #endregion

        #region div

        //! div
        //! -------------------------------------------------------------------

        public static long divT(sbyte[] lhs, sbyte[] rhs, sbyte[] dst)
        {
            var sw = stopwatch();
            math.div(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long divT(byte[] lhs, byte[] rhs, byte[] dst)
        {
            var sw = stopwatch();
            math.div(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long divT(short[] lhs, short[] rhs, short[] dst)
        {
            var sw = stopwatch();
            math.div(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long divT(ushort[] lhs, ushort[] rhs, ushort[] dst)
        {
            var sw = stopwatch();
            math.div(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long divT(int[] lhs, int[] rhs, int[] dst)
        {
            var sw = stopwatch();
            math.div(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long divT(uint[] lhs, uint[] rhs, uint[] dst)
        {
            var sw = stopwatch();
            math.div(lhs,rhs, dst);
            return elapsed(sw);
        }


        public static long divT(long[] lhs, long[] rhs, long[] dst)
        {
            var sw = stopwatch();
            math.div(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long divT(ulong[] lhs, ulong[] rhs, ulong[] dst)
        {
            var sw = stopwatch();
            math.div(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long divT(float[] lhs, float[] rhs, float[] dst)
        {
            var sw = stopwatch();
            math.div(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long divT(double[] lhs, double[] rhs, double[] dst)
        {
            var sw = stopwatch();
            math.div(lhs,rhs, dst);
            return elapsed(sw);
        }

        #endregion

        #region mod
        
        //! mod
        //! -------------------------------------------------------------------

        public static long modT(sbyte[] lhs, sbyte[] rhs, sbyte[] dst)
        {
            var sw = stopwatch();
            math.mod(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long modT(byte[] lhs, byte[] rhs, byte[] dst)
        {
            var sw = stopwatch();
            math.mod(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long modT(short[] lhs, short[] rhs, short[] dst)
        {
            var sw = stopwatch();
            math.mod(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long modT(ushort[] lhs, ushort[] rhs, ushort[] dst)
        {
            var sw = stopwatch();
            math.mod(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long modT(int[] lhs, int[] rhs, int[] dst)
        {
            var sw = stopwatch();
            math.mod(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long modT(uint[] lhs, uint[] rhs, uint[] dst)
        {
            var sw = stopwatch();
            math.mod(lhs,rhs, dst);
            return elapsed(sw);
        }


        public static long modT(long[] lhs, long[] rhs, long[] dst)
        {
            var sw = stopwatch();
            math.mod(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long modT(ulong[] lhs, ulong[] rhs, ulong[] dst)
        {
            var sw = stopwatch();
            math.mod(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long modT(float[] lhs, float[] rhs, float[] dst)
        {
            var sw = stopwatch();
            math.mod(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long modT(double[] lhs, double[] rhs, double[] dst)
        {
            var sw = stopwatch();
            math.mod(lhs,rhs, dst);
            return elapsed(sw);
        }

        #endregion

        #region eq
        
        //! eq
        //! -------------------------------------------------------------------

        public static long eqT(sbyte[] lhs, sbyte[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.eq(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long eqT(byte[] lhs, byte[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.eq(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long eqT(short[] lhs, short[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.eq(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long eqT(ushort[] lhs, ushort[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.eq(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long eqT(int[] lhs, int[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.eq(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long eqT(uint[] lhs, uint[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.eq(lhs,rhs, dst);
            return elapsed(sw);
        }


        public static long eqT(long[] lhs, long[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.eq(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long eqT(ulong[] lhs, ulong[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.eq(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long eqT(float[] lhs, float[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.eq(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long eqT(double[] lhs, double[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.eq(lhs,rhs, dst);
            return elapsed(sw);
        }

        #endregion

        #region neq
        
        //! neq
        //! -------------------------------------------------------------------

        public static long neqT(sbyte[] lhs, sbyte[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.neq(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long neqT(byte[] lhs, byte[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.neq(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long neqT(short[] lhs, short[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.neq(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long neqT(ushort[] lhs, ushort[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.neq(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long neqT(int[] lhs, int[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.neq(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long neqT(uint[] lhs, uint[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.neq(lhs,rhs, dst);
            return elapsed(sw);
        }


        public static long neqT(long[] lhs, long[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.neq(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long neqT(ulong[] lhs, ulong[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.neq(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long neqT(float[] lhs, float[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.neq(lhs,rhs, dst);
            return elapsed(sw);
        }

        public static long neqT(double[] lhs, double[] rhs, bool[] dst)
        {
            var sw = stopwatch();
            math.neq(lhs,rhs, dst);
            return elapsed(sw);
        }

        #endregion
 
    }
}