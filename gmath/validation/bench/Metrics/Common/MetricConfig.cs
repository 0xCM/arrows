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
    using static mfunc;

    public class MetricConfig
    {
        public static readonly MetricConfig Default 
            = MetricConfig.Define(runs: Pow2.T03, cycles: Pow2.T14, samples: Pow2.T12, dops: true);        

        public static MetricConfig Define(int runs, int cycles, int samples, bool dops)
            => new MetricConfig(runs,cycles,samples, dops);

        public MetricConfig(int Runs, int Cycles, int Samples, bool UseMath)
        {
            this.Runs = Runs;
            this.Cycles = Cycles;
            this.Samples = Samples;
            this.DirectOps = this.DirectOps;
        }
        
        public int Runs {get;}
        
        public int Cycles {get;}

        public int Samples {get;}

        public bool DirectOps {get;}
    }

}