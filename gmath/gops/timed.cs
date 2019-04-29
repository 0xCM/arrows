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
    using static mathops;


    partial class gmath
    {
        public static long applyT<T>(OpKind op, T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gmath.apply(op,lhs,rhs,dst);
            return elapsed(sw);
        }

        public static long applyT<T>(OpKind op, T[] src,  T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gmath.apply(op,src, dst);
            return elapsed(sw);
        }

        public static long addT<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gmath.add(lhs,rhs,dst);
            return elapsed(sw);
        }

        public static long subT<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gmath.sub(lhs,rhs,dst);
            return elapsed(sw);
        }

        public static long mulT<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gmath.mul(lhs,rhs,dst);
            return elapsed(sw);
        }

        public static long divT<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gmath.mul(lhs,rhs,dst);
            return elapsed(sw);
        }

        public static long modT<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gmath.mul(lhs,rhs,dst);
            return elapsed(sw);
        }

    }

}