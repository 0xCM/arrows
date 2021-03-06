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

    public interface IMetricConfig
    {
        MetricKind Metric {get;}

        int Runs {get;}
        
        int Cycles {get;}

        int Samples {get;}
        
    }

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