//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    using Z0.Metrics;

    using static zfunc;


    public abstract class MetricContext : Context
    {
        public MetricContext(IRandomizer random)
            : base(random ?? Z0.Randomizer.define(RandSeeds.BenchSeed))
        {
            Random = Randomizer;
        }

        public IRandomizer Random {get;}
    }

    public abstract class MetricContext<T> : MetricContext
        where T : MetricConfig
    {
        public MetricContext(T config, IRandomizer random)
            : base(random)
        {

            this.Config = config;
        }

        public T Config {get;}

        public MetricKind Metric
            => Config.Metric;

        public int Runs
            => Config.Runs;

        public int Cycles
            => Config.Cycles;

        public int Samples
            => Config.Samples;

    }

}