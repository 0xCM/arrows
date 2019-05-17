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

    public static class Metrics
    {
        public static OpMetrics<T> Zero<T>()
            where T : struct
                => OpMetrics<T>.Zero;

        public static OpMetrics<T> Define<T>(in OpId<T> OpId, long OpCount, Duration WorkTime, T[] results)
            where T : struct
                => (OpId, OpCount, WorkTime, results);

        public static OpMetrics<T> Define<T>(in OpId<T> OpId, long OpCount, Duration WorkTime, ReadOnlyMemory<T> results)
            where T : struct
                => (OpId, OpCount, WorkTime, results);

        public static OpMetrics<T> Define<T>(in OpId<T> OpId, long OpCount, Duration WorkTime, Span<T> results)
            where T : struct
            => new OpMetrics<T>(OpId, OpCount, WorkTime, results);

        public static OpMetrics<T> Define<T>(in OpId<T> OpId, long OpCount, Duration WorkTime, Span128<T> results)
            where T : struct
                => Metrics.Define(OpId, OpCount, WorkTime, results.Unblock());

        public static OpMetrics<T> Define<T>(in OpId<T> OpId, long OpCount, Duration WorkTime, Span256<T> results)
            where T : struct
                => Metrics.Define(OpId, OpCount, WorkTime, results.Unblock());

        public static OpMetrics<T> Define<T>(in OpId<T> OpId, long OpCount, Duration WorkTime, num<T>[] results)
            where T : struct
                => new OpMetrics<T>(OpId, OpCount, WorkTime, results.Extract());
    }
}