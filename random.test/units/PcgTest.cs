//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    public class PcgTest : UnitTest<PcgTest>
    {
        public void RetreatTest()
        {
            var rng = RNG.Pcg32(Seed64.Seed00);
            var sample1 = rng.Stream().TakeSpan(5).FormatList();
            rng.Retreat(5);
            var sample2 = rng.Stream().TakeSpan(5).FormatList();

            Claim.eq(sample1,sample2);

        }

        public void IndexTest()
        {
            var seed = Seed64.Seed00;
            var index = Seed64.Seed10;
            var pcg0 = Pcg32.Define(seed, index += 2);
            var pcg1 = Pcg32.Define(seed, index += 2);
            var pcg2 = Pcg32.Define(seed, index += 2);
            var pcg3 = Pcg32.Define(seed, index += 2);
            var sampleSize = Pow2.T08;

            var s0 = pcg0.TakeSet(sampleSize);
            var s1 = pcg1.TakeSet(sampleSize);
            var s2 = pcg2.TakeSet(sampleSize);
            var s3 = pcg3.TakeSet(sampleSize);


            s1.IntersectWith(s2);            
            s2.IntersectWith(s3);

            Claim.lt(s1.Count + s2.Count, 10);
        }
    }
}