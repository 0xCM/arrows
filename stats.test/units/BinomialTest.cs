//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{        
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Concurrent;

    using static zfunc;
    public class BinomialTest : UnitTest<BinomialTest>
    {
        void SampleBinomial(int samples, int trials, double success)
        {
            var spec = BinomialSpec<int>.Define(trials, success);
            var dist = spec.Distribution(Random);
            var sample = dist.Sample().TakeSpan(samples); 
            var avg = sample.Avg();
            var min = sample.Min();
            var max = sample.Max();
            Trace($"min = {min}, max = {max}");
            
        }

        public void BinomialSample()
        {
            SampleBinomial(Pow2.T11, 50, .5);
            SampleBinomial(Pow2.T11, 50, .5);
            SampleBinomial(Pow2.T11, 50, .5);
        }


    }

}