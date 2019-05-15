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

    public readonly struct OpMetrics
    {
        public static OpMetrics<T> Define<T>(in OpId<T> OpId, long OpCount, Duration WorkTime, params T[] results)
            where T : struct
                => (OpId, OpCount, WorkTime, results);

        public static OpMetrics Define(long OpCount, Duration WorkTime)
            => (OpCount, WorkTime);

        public static implicit operator OpMetrics((long OpCount, Duration WorkTime) src)
            => new OpMetrics(src.OpCount, src.WorkTime);

        public static implicit operator (long OpCount, Duration WorkTime)(OpMetrics src)
            => (src.OpCount, src.WorkTime);

        public static (long OpCount, Duration WorkTime) Deconstruct(OpMetrics src)
            => (src.OpCount, src.WorkTime);

        public OpMetrics(long OpCount, Duration WorkTime)
        {
            Claim.nonzero(OpCount);
            this.OpCount = OpCount;
            this.WorkTime = WorkTime;
        }
        
        public readonly long OpCount;

        public readonly Duration WorkTime;
    }

    public readonly struct OpMetrics<T>
        where T : struct
    {
        public static OpMetrics<T> Define(in OpId<T> OpId, long OpCount, Duration WorkTime, T[] result)
            => (OpId, OpCount, WorkTime, result);

        public static implicit operator OpMetrics<T>(in (OpId<T> OpId, long OpCount, Duration WorkTime, T[] Result) src)
            => new OpMetrics<T>(src.OpId, src.OpCount, src.WorkTime, src.Result);

        public static implicit operator OpMetrics(in OpMetrics<T> src)
            => (src.OpCount, src.WorkTime);

        public static implicit operator (OpId<T> OpId, long OpCount, Duration WorkTime, T[] Result)(in OpMetrics<T> src)
            => (src.OpId, src.OpCount, src.WorkTime, src.Result);

        public static (OpId<T> OpId, long OpCount, Duration WorkTime, T[] Result) Deconstruct(OpMetrics<T> src)
            => src;

        public OpMetrics(in OpId<T> OpId, long OpCount, Duration WorkTime, T[] Result)
        {
            Claim.nonzero(OpCount);
            this.OpId = OpId;
            this.OpCount = OpCount;
            this.WorkTime = WorkTime;
            this.Result = Result;
        }
        
        public readonly OpId<T> OpId;
        
        public readonly long OpCount;

        public readonly Duration WorkTime;

        public readonly T[] Result;

        public AppMsg Describe()
        {
            var msg = string.Empty;
            msg += OpId.ToString().PadRight(50);
            msg += $" | OpCount = {OpCount}".PadRight(10);
            msg += $" | Duration = {WorkTime.Ticks} ticks = {WorkTime.Ms} ms";
            return AppMsg.Define(msg, SeverityLevel.Info);
        }

    }    
}