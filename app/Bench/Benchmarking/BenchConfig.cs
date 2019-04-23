//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using System.IO;
    using System.Runtime.CompilerServices;

    public class BenchConfig
    {
        public static readonly BenchConfig Default = new BenchConfig();

        public BenchConfig(int? Cycles = null, int? Reps = null, int? SampleSize = null)
        {
            this.Cycles = Cycles ?? Settings.Cycles();
            this.Reps = Reps ?? Settings.Reps();
            this.SampleSize = SampleSize ?? Settings.SampleSize();
        }

        public int Cycles {get;}

        public int Reps {get;}

        public int SampleSize {get;}
 
        public override string ToString() 
            => $"Cycles = {Cycles} | Reps = {Reps} | SampleSize = {SampleSize}";
    }


}