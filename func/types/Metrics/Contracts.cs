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

    public delegate IMetrics OpMeasurer(int cycles, int reps);

    /// <summary>
    /// Defines the signature of a function that measures execution time for
    /// a specified number of cycles
    /// </summary>
    /// <param name="cycles">The number of cycles</param>
    /// <param name="reps">The number of reps</param>
    public delegate IMetrics Cycle(int reps);

    public delegate IMetricComparison OpRunner();

    public interface IMetrics
    {
       OpId OpId {get;}
  
       long OpCount {get;}

       Duration WorkTime {get;}

        ReadOnlyMemory<R> Results<R>()
            where R : struct;        
        AppMsg Describe(bool total = false, bool digitcommas = true);

        bool PrimalDirect {get;}
    }

    public interface IMetrics<T> : IMetrics
        where T : struct
    {
        ReadOnlyMemory<T> Results();

    }

    public interface IMetricSummary
    {

        IMetrics Metrics {get;}

        AppMsg Description {get;}

    }

    public interface IMetricComparison
    {
        string LeftTitle {get;}

        AppMsg LeftMsg {get;}
        
        IMetrics LeftMetrics{get;}

        string RightTitle {get;}

        AppMsg RightMsg {get;}

        IMetrics RightMetrics {get;}

        double Ratio {get;}

        MetricComparisonRecord ToRecord();
    }

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


}