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

    using Aligned = Span128;

    public partial class Vec128DirectBench : BenchContext<MetricKind>
    {   

        static readonly BenchConfig Config0 = new BenchConfig(Cycles: Pow2.T12, Reps: 1, SampleSize: Pow2.T11, AnnounceRate: Pow2.T11);        

        public static Vec128DirectBench Create(IRandomizer random, BenchConfig config = null)
            => new Vec128DirectBench(random, config ?? Config0);
        
        Vec128DirectBench(IRandomizer random, BenchConfig config)
            : base(MetricKind.Vec128, random, config)
        {

            // LeftSamples = Span128Sampler.Sample(random, config.SampleSize);   
            // RightSamples = Span128Sampler.Sample(random, config.SampleSize);            
        }



    }


}