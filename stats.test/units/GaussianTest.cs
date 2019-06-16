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
    public class GaussianTest : UnitTest<GaussianTest>
    {


        public void Gaussian1()
        {
            var mean = 0;
            var stddev = .04;
            var spec = new GaussianSpec(mean,stddev);
            var dist =  spec.Distribution<double>(Randomizer);
            var samples = Pow2.T16;

            var l1 = dist.SamplesWithin(open(mean - 1.0, mean + 0.0),samples);
            Trace($"left =  {l1.Quotient}");

            var r1 = dist.SamplesWithin(open(mean - 0.0, mean + 1.0),samples);
            Trace($"right =  {r1.Quotient}");

            var l2 = dist.SamplesWithin(open(mean - 2.0, mean + 0.0),samples);
            Trace($"left =  {l2.Quotient}");

            var r2 = dist.SamplesWithin(open(mean - 0.0, mean + 2.0),samples);
            Trace($"right =  {r2.Quotient}");

            var l3 = dist.SamplesWithin(open(mean -3.0, mean + 0),samples);
            Trace($"left =  {l3.Quotient}");

            var r3 = dist.SamplesWithin(open(mean - 0.0, mean + 3.0),samples);
            Trace($"right =  {r3.Quotient}");

            var l4 = dist.SamplesWithin(open(mean -4.0, mean + 0),samples);
            Trace($"left =  {l4.Quotient}");

            var r4 = dist.SamplesWithin(open(mean - 0.0, mean + 4.0),samples);
            Trace($"right =  {r4.Quotient}");


        }
    }

}

