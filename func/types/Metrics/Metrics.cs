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
    
    public interface IOpMetric
    {
        Metrics<T> Measure<T>(MetricConfig config, IRandomizer random)    
            where T : struct;
    }


    public interface IBinaryOpMetric
    {
        Metrics<T> Measure<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct;

    }

    public interface IBinaryHetOpMetric
    {
        Metrics<S> Measure<S,T>(ReadOnlySpan<S> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where S : struct
            where T : struct;

    }

    public interface IUnaryOpMetric
    {
        Metrics<T> Measure<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct;

    }


    public interface IUnaryHetOpMetric 
    {
        Metrics<T> Measure<S,T>(ReadOnlySpan<S> src, MetricConfig config = null)
            where S : struct
            where T : struct;

    }

    public interface IUnaryHetOpMetric<T> : IUnaryHetOpMetric
        where T : struct
    {
        Metrics<T> Measure<S>(ReadOnlySpan<S> src, MetricConfig config = null)
            where S : struct;

    }

    public class OpMetricAttribute : Attribute
    {        
        public OpMetricAttribute(MetricKind Metric, OpKind Op)
        {
            this.Metric = Metric;
            this.Op = Op;
        }
        public OpKind Op {get;}

        public MetricKind Metric {get;}        


    }


    public struct Metrics<T> : IMetrics<T>
        where T : struct
    {
        public static readonly Metrics<T> Zero = new Metrics<T>(OpId<T>.Zero, -1, Duration.Zero, new T[]{});
        
        public static implicit operator Metrics<T>(in (OpId<T> OpId, long OpCount, Duration WorkTime, T[] Result) src)
            => new Metrics<T>(src.OpId, src.OpCount, src.WorkTime, src.Result);

        public static implicit operator Metrics<T>(in (OpId<T> OpId, long OpCount, Duration WorkTime, ReadOnlyMemory<T> Result) src)
            => new Metrics<T>(src.OpId, src.OpCount, src.WorkTime, src.Result);

        public static implicit operator (OpId OpId, long OpCount, Duration WorkTime, ReadOnlyMemory<T> Result)(in Metrics<T> src)
            => (src.OpId, src.OpCount, src.WorkTime, src.Result);

        public static Metrics<T> operator +(Metrics<T> lhs, Metrics<T> rhs)
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
                if(lhs.OpId.OpKind != rhs.OpId.OpKind)
                    throw new Exception($"Metrics OpId mismatch: {lhs.OpId} != {rhs.OpId}");
                return new Metrics<T>(lhs.OpId, lhs.OpCount + rhs.OpCount, lhs.WorkTime + rhs.WorkTime, rhs.Result);
            }            
        }
        public Metrics(in OpId OpId, long OpCount, Duration WorkTime, T[] Result)
        {
            require(OpCount != 0, $"Operation count must be nonzero");
            this.OpId = OpId;
            this.OpCount = OpCount;
            this.WorkTime = WorkTime;
            this.Result = Result;
        }

        public Metrics(in OpId OpId, long OpCount, Duration WorkTime, ReadOnlyMemory<T> Result)
        {
            require(OpCount != 0, $"Operation count must be nonzero");
            this.OpId = OpId;
            this.OpCount = OpCount;
            this.WorkTime = WorkTime;
            this.Result = Result;
        }

        public Metrics(in OpId OpId, long OpCount, Duration WorkTime, Span<T> Result)
        {
            require(OpCount != 0, $"Operation count must be nonzero");
            this.OpId = OpId;
            this.OpCount = OpCount;
            this.WorkTime = WorkTime;
            this.Result = Result.ToArray();
        }

        public readonly OpId OpId;
        
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

        OpId IMetrics.OpId 
            => OpId;

        public bool PrimalDirect
            => OpId.NumKind == NumericKind.Native 
            && OpId.Intrinsic == false 
            && OpId.Generic == false;

        public Metrics<S> As<S>()
            where S : struct
                => Unsafe.As<Metrics<T>, Metrics<S>>(ref this);

        ReadOnlyMemory<R> IMetrics.Results<R>() 
            => As<R>().Result;

        public ReadOnlyMemory<T> Results()
            => Result;
    }    
}