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
    public class t_binomial : UnitTest<t_binomial>
    {
        public void sample_set()
        {
            SampleBinomial(50, .5);
            SampleBinomial(50, .5);
            SampleBinomial(50, .5);
        }

        void SampleBinomial(int trials, double success, bool trace = false)
        {
            var spec = BinomialSpec<int>.Define(trials, success);
            var dist = spec.Distribution(Random);
            var sample = dist.Sample().TakeSpan(SampleSize); 
            var avg = sample.Avg();
            var min = sample.Min();
            var max = sample.Max();
            
            if(trace)
                Trace($"min = {min}, max = {max}");            
        }

    }

}