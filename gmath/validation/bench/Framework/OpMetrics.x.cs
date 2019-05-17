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
    using static zfunc;

    public static class OpMetricsX
    {
        public static bool NonZeroRight(this OpKind op)
            => op == OpKind.Div || op == OpKind.Mod;

        public static BenchSummary<T> Summarize<T>(this OpMetrics<T> metrics)        
            where T : struct
            => BenchSummary.Define(metrics);

        public static BenchSummary Summarize(this IOpMetrics metrics)        
            => BenchSummary.Define(metrics);

        public static BenchComparison<T> Compare<T>(this OpMetrics<T> lhs, OpMetrics<T> rhs)
            where T : struct
                => BenchComparison.Define(lhs.Summarize(), rhs.Summarize());

        public static BenchComparison Compare(this IOpMetrics lhs, IOpMetrics rhs)        
            => BenchComparison.Define(lhs.Summarize(), rhs.Summarize());

        public static OpMetrics<T> DefineMetrics<T>(this OpId<T> OpId, long OpCount, Duration WorkTime, num<T>[] Results)
            where T : struct
                => Metrics.Define(OpId, OpCount, WorkTime, Results);
        
        public static OpMetrics<T> DefineMetrics<T>(this OpId<T> OpId, long OpCount, Duration WorkTime, T[] Results)
            where T : struct
                => Metrics.Define(OpId, OpCount, WorkTime, Results);

    }

}