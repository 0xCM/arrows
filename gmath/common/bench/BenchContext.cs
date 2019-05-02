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

    using static zcore;

    public abstract class BenchContext : Context
    {
        public BenchContext(BenchConfig Config, IRandomizer Randomizer)
            : base(Randomizer)
        {
            this.Config = Config;
        }

        public BenchConfig Config {get;}
    
        protected AppMsg ConfigStats
            => AppMsg.Define($"Cycles = {Config.Cycles}, Reps = {Config.Reps}, Ops = {Config.Cycles * Config.Reps}", SeverityLevel.Info);


        protected void print(BenchComparison comparison)
        {
            zcore.print(comparison.LeftBench.Description);
            zcore.print(comparison.RightBench.Description);
            zcore.print(comparison.CalcDelta().Description);

        }

    }



}