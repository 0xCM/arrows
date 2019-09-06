//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;

    using static zfunc;
    using static nfunc;
    
    using Z0.Test;

    public class t_vslinit : UnitTest<t_vslinit>
    {
        public void t_bernoulli()
        {
            var pTarget = 0.7;
            var tolerance = .02;
            var count = Pow2.T12;
            using var src = rng.mt19937(54u);
            
            var sum = 0.0;
            var buffer = samplers.bernoulli(src,pTarget);
            foreach(var point in buffer.TakeSpan(count))
                if(point != 0) 
                    sum++;

            var pActual = sum / ((double)count);
            var radius = closed(pTarget - tolerance, pTarget + tolerance);
            Claim.yea(radius.Contains(pActual));
        }

        public void CreateMt2203Generators()
        {
            var gencount = Pow2.T08;
            var samplesize = Pow2.T16;
            var seeds = Random.Array<uint>(gencount);
            var streams = new MklRng[gencount];
            for(var i=0; i<gencount; i++)
                streams[i] = rng.mt2203(seeds[i], i);
            
            var bufferF64 = new double[samplesize];
            var bufferU32 = new uint[samplesize];
            var bufferI32 = new int[samplesize];
            var ufRange = closed(1.0, 250.0);
            for(var i=0; i<gencount; i++)
            {
                var stream = streams[i];
                sample.uniform(stream, ufRange, bufferF64);
                Dataset.Load(bufferF64,1).Extrema();
                var max = Dataset.Load(bufferF64,1).Max()[0];
                Claim.lteq(max, ufRange.Right);
                Claim.neq(max,0);

                sample.bits(stream, bufferU32);

                sample.bernoulli(stream, .40, bufferI32);
                for(var j=0; j<samplesize; j++)
                    Claim.yea(bufferI32[j] == 0 || bufferI32[j] == 1);

                sample.gaussian(stream, .75, .75, bufferF64);
                sample.laplace(stream, .5, .5, bufferF64);
            }

            for(var i=0; i<gencount; i++)
                streams[i].Dispose();

        }
        
    }
}
