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
    using Z0.Mkl;
    
    using static zfunc;

    /// <summary>
    /// These tests verify whether the collector is working properly, in part,
    /// by sampling random sources that are known to be good
    /// </summary>
    public class t_collector : UnitTest<t_collector>
    {
        protected override int RoundCount
            => Pow2.T03;
        
        protected override int CycleCount
            => Pow2.T04;

        public void summarize_i32()
        {            
            using var src = rng.mrg32K31(Seed32.Seed00);
            var sampler = samplers.uniform(src,-100, 100);
            var summary = Collector.Create();
            
            Span<double> trend = stackalloc double[RoundCount];
            for(var round = 0; round < trend.Length; round++)
            {
                for(var i =0; i<CycleCount; i++)
                    summary += sampler.Next(SampleSize);
                
                trend[round] = Math.Abs(summary.Mean.Round(4));
            }
            var seq = ScalarSeq.From(trend);
            var tol = 1.0;
            Claim.lt(seq.Last, tol);
            
        }
    }

}