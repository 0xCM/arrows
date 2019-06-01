//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Metrics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public static class PrimalConfigX
    {
        public static PrimalDConfig Configure(this MetricKind metric, PrimalDConfig config = null)
            => config ?? PrimalDConfig.Default(metric);

        public static PrimalGConfig Configure(this MetricKind metric, PrimalGConfig config = null)
            => config ?? PrimalGConfig.Default(metric);

    }

    public class PrimalDMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericSystem.Primal);

        public const MetricKind Metric = MetricKind.PrimalD;

        public static MetricConfig Configure(PrimalDConfig config)
            => Metric.Configure(config);

        public static bool DirectOps(PrimalDConfig config)
            => Metric.Configure(config).DirectOps;


        public static int Runs(PrimalDConfig config)
            => Metric.Configure(config).Runs;

        public static int Cycles(PrimalDConfig config)
            => Metric.Configure(config).Cycles;

        public static int Samples(PrimalDConfig config)
            => Metric.Configure(config).Samples;
    }

    public class PrimalGMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericSystem.Primal, generic: Genericity.Generic);

        public const MetricKind Metric = MetricKind.PrimalG;

        public static PrimalGConfig Configure(PrimalGConfig config)
            => Metric.Configure(config);

        public static int Runs(PrimalGConfig config)
            => Metric.Configure(config).Runs;

        public static int Cycles(PrimalGConfig config)
            => Metric.Configure(config).Cycles;

        public static int Samples(PrimalGConfig config)
            => Metric.Configure(config).Samples;

        public static bool DirectOps(PrimalGConfig config)
            => Metric.Configure(config).DirectOps;

    }


    public class PrimalDConfig : MetricConfig
    {
        public static PrimalDConfig Default(MetricKind metric) 
            => PrimalDConfig.Define(metric, runs: Pow2.T03, cycles: Pow2.T14, samples: Pow2.T12, dops: true);        

        public static PrimalDConfig Define(MetricKind metric, int runs, int cycles, int samples, bool dops)
            => new PrimalDConfig(metric, runs, cycles, samples, dops);

        public PrimalDConfig(MetricKind Metric, int Runs, int Cycles, int Samples, bool DirectOps = true)
            : base(Metric, Runs, Cycles, Samples, DirectOps)
        {
        
        }
                
    }

    public class PrimalGConfig : MetricConfig
    {
        public static PrimalGConfig Default(MetricKind metric) 
            => PrimalGConfig.Define(metric, runs: Pow2.T03, cycles: Pow2.T14, samples: Pow2.T12, dops: true);        

        public static PrimalGConfig Define(MetricKind metric, int runs, int cycles, int samples, bool dops)
            => new PrimalGConfig(metric, runs, cycles, samples, dops);

        public PrimalGConfig(MetricKind Metric, int Runs, int Cycles, int Samples, bool DirectOps = true)
            : base(Metric, Runs, Cycles, Samples, DirectOps)
        {
        
        }

        public PrimalDConfig ToDirect()
            => new PrimalDConfig(Metric, Runs, Cycles, Samples, DirectOps);

    }

}