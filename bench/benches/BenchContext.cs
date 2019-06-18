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

    using static zfunc;


    public abstract class BenchContext : Context
    {
        public BenchContext(IRandomSource random)
            : base(random ?? Z0.XOrStarStar256.define(Seed256.BenchSeed))
        {
            
        }

    }

    public abstract class BenchContext<T> : BenchContext
        where T : MetricConfig
    {
        public BenchContext(T config, IRandomSource random)
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

        public new IRandomSource Random
            => base.Random;

    }

}