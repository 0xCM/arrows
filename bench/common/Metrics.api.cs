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
        public static Metrics<T> Zero<T>()
            where T : struct
                => Metrics<T>.Zero;

        public static Metrics<T> Capture<T>(in OpId<T> OpId, long OpCount, Duration WorkTime, T[] results)
            where T : struct
                => (OpId, OpCount, WorkTime, results);

        public static Metrics<T> Capture<T>(in OpId<T> OpId, long OpCount, Duration WorkTime, ReadOnlyMemory<T> results)
            where T : struct
                => (OpId, OpCount, WorkTime, results);

        public static Metrics<T> Capture<T>(in OpId<T> OpId, long OpCount, Duration WorkTime, Span<T> results)
            where T : struct
            => new Metrics<T>(OpId, OpCount, WorkTime, results);

        public static Metrics<T> Capture<T>(in OpId<T> OpId, long OpCount, Duration WorkTime, Span128<T> results)
            where T : struct
                => Metrics.Capture(OpId, OpCount, WorkTime, results.Unblock());

        public static Metrics<T> Capture<T>(in OpId<T> OpId, long OpCount, Duration WorkTime, Span256<T> results)
            where T : struct
                => Metrics.Capture(OpId, OpCount, WorkTime, results.Unblock());

        public static Metrics<T> Capture<T>(in OpId<T> OpId, long OpCount, Duration WorkTime, num<T>[] results)
            where T : struct
                => new Metrics<T>(OpId, OpCount, WorkTime, results.Extract());
    }
}