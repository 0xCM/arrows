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
    }


}