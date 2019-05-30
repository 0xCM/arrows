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


    public static class NumGMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericSystem.Primal, numKind : NumericKind.NumG, generic: Genericity.Generic);

        public const MetricKind Metric = MetricKind.NumG;

        public static int Cycles(NumGConfig config)
            => Metric.Configure(config).Cycles;


    }

    public class NumGConfig : MetricConfig
    {
        public static NumGConfig Default(MetricKind metric) 
            => NumGConfig.Define(metric, runs: Pow2.T03, cycles: Pow2.T14, samples: Pow2.T12, dops: true);        

        public static NumGConfig Define(MetricKind metric, int runs, int cycles, int samples, bool dops)
            => new NumGConfig(metric, runs, cycles, samples, dops);

        public NumGConfig(MetricKind Metric, int Runs, int Cycles, int Samples, bool DirectOps = true)
            : base(Metric, Runs, Cycles, Samples, DirectOps)
        {
        
        }

        public PrimalDConfig ToPrimalD()
            => new PrimalDConfig(Metric, Runs, Cycles, Samples, DirectOps);
                
    }

}