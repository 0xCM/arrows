//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public static class PrimalDMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericKind.Native, system: NumericSystem.Primal);

        public static MetricConfig Configure(MetricConfig config)
            => config ?? MetricConfig.Default;

        public static int Cycles(MetricConfig config)
            => Configure(config).Cycles;

        public static bool DirectOps(MetricConfig config)
            => Configure(config).DirectOps;
    }

    public static class PrimalGMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericKind.Native, generic:true);

        public static MetricConfig Configure(MetricConfig config)
            => config ?? MetricConfig.Default;

        public static int Cycles(MetricConfig config)
            => Configure(config).Cycles;


    }

    public static class NumGMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericKind.Number, generic: true);

        public static MetricConfig Configure(MetricConfig config)
            => config ?? MetricConfig.Default;

        public static int Cycles(MetricConfig config)
            => Configure(config).Cycles;
    }

    public class MetricConfig
    {
        public static readonly MetricConfig Default 
            = MetricConfig.Define(runs: Pow2.T03, cycles: Pow2.T14, samples: Pow2.T12, dops: true);        

        public static MetricConfig Define(int runs, int cycles, int samples, bool dops)
            => new MetricConfig(runs,cycles,samples, dops);

        public MetricConfig(int Runs, int Cycles, int Samples, bool DirectOps)
        {
            this.Runs = Runs;
            this.Cycles = Cycles;
            this.Samples = Samples;
            this.DirectOps = DirectOps;
        }
        
        public int Runs {get;}
        
        public int Cycles {get;}

        public int Samples {get;}

        public bool DirectOps {get;}
    }



}