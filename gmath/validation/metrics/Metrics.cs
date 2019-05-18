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
    
    public struct OpMetrics<T> : IOpMetrics
        where T : struct
    {
        public static readonly OpMetrics<T> Zero = new OpMetrics<T>(OpId<T>.Zero, -1, Duration.Zero, new T[]{});
        
        public static implicit operator OpMetrics<T>(in (OpId<T> OpId, long OpCount, Duration WorkTime, T[] Result) src)
            => new OpMetrics<T>(src.OpId, src.OpCount, src.WorkTime, src.Result);

        public static implicit operator OpMetrics<T>(in (OpId<T> OpId, long OpCount, Duration WorkTime, ReadOnlyMemory<T> Result) src)
            => new OpMetrics<T>(src.OpId, src.OpCount, src.WorkTime, src.Result);

        public static implicit operator (OpId<T> OpId, long OpCount, Duration WorkTime, ReadOnlyMemory<T> Result)(in OpMetrics<T> src)
            => (src.OpId, src.OpCount, src.WorkTime, src.Result);

        public static OpMetrics<T> operator +(OpMetrics<T> lhs, OpMetrics<T> rhs)
        {
            if(lhs.NonZero && !rhs.NonZero)
                return lhs;
            else if(!lhs.NonZero && rhs.NonZero)
                return rhs;
            else if(!lhs.NonZero && !rhs.NonZero)
                return lhs;
            else 
            {
                if(lhs.Result.Length != rhs.Result.Length)
                    throw new Exception($"Metrics Result Length mismatch: {lhs.Result.Length} != {rhs.Result.Length}");
                if(lhs.OpId != rhs.OpId)
                    throw new Exception($"Metrics OpId mismatch: {lhs.OpId} != {rhs.OpId}");
                return new OpMetrics<T>(lhs.OpId, lhs.OpCount + rhs.OpCount, lhs.WorkTime + rhs.WorkTime, rhs.Result);
            }            
        }
        public OpMetrics(in OpId<T> OpId, long OpCount, Duration WorkTime, T[] Result)
        {
            Claim.nonzero(OpCount);
            this.OpId = OpId;
            this.OpCount = OpCount;
            this.WorkTime = WorkTime;
            this.Result = Result;
        }

        public OpMetrics(in OpId<T> OpId, long OpCount, Duration WorkTime, ReadOnlyMemory<T> Result)
        {
            Claim.nonzero(OpCount);
            this.OpId = OpId;
            this.OpCount = OpCount;
            this.WorkTime = WorkTime;
            this.Result = Result;
        }

        public OpMetrics(in OpId<T> OpId, long OpCount, Duration WorkTime, Span<T> Result)
        {
            Claim.nonzero(OpCount);
            this.OpId = OpId;
            this.OpCount = OpCount;
            this.WorkTime = WorkTime;
            this.Result = Result.ToArray();
        }

        public readonly OpId<T> OpId;
        
        public long OpCount {get;}

        public Duration WorkTime {get;}

        public ReadOnlyMemory<T> Result {get;}

        public AppMsg Describe(bool total = false, bool digitcommas = true)
        {
            var msg = string.Empty;
            msg += OpId.ToString().PadRight(50);
            msg += $" | OpCount = {OpCount.ToString(digitcommas ? "#,#" : string.Empty).PadRight(14)}";
            msg += $" | Duration = {WorkTime.Ms} ms";
            if(total)
                msg += " (total)";
            return AppMsg.Define(msg, SeverityLevel.Info);
        }

        public bool NonZero
            => OpId.NonZero;

        OpId IOpMetrics.OpId 
            => OpId;

        public bool PrimalDirect
            => OpId.NumKind == NumericKind.Native 
            && OpId.Intrinsic == false 
            && OpId.Generic == false;

        public OpMetrics<S> As<S>()
            where S : struct
                => Unsafe.As<OpMetrics<T>, OpMetrics<S>>(ref this);

        ReadOnlyMemory<R> IOpMetrics.Results<R>() 
            => As<R>().Result;
    }    
}