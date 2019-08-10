//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    
    public class SeedTest : UnitTest<SeedTest>
    {

        public void ReproducibilityTest()
        {

            var s1 = RNG.FixedSeed(54ul);
            var s2 = RNG.FixedSeed(54ul + 8ul);

            var rng1 = RNG.WyHash64(s1);
            var rng2 = RNG.WyHash64(s2);
            var rng3 = RNG.WyHash64(s1);

            var sample1 = rng1.Stream().Take(Pow2.T08).ToArray();
            var sample2 = rng2.Stream().Take(Pow2.T08).ToArray();
            var sample3 = rng3.Stream().Take(Pow2.T08).ToArray();


            for(var i=0; i< Pow2.T08; i++)
                Claim.neq(sample1[i],sample2[i]);


            for(var i=0; i< Pow2.T08; i++)
                Claim.eq(sample1[i],sample3[i]);

        }

        public void SeedStatsTest()
        {
            (ByteSize byteCount, var u8Index) = RNG.FixedSeedStats<byte>();

            (_, int i32Index) = RNG.FixedSeedStats<int>();
            RNG.FixedSeed(i32Index);

            (_, long i64Index) = RNG.FixedSeedStats<long>();
            RNG.FixedSeed(i64Index);

            (_, double f64Index) = RNG.FixedSeedStats<double>();
            RNG.FixedSeed(f64Index);

            (_, float f32Index) = RNG.FixedSeedStats<float>();
            RNG.FixedSeed(f32Index);

            Claim.eq(i32Index, (int)f32Index);
            Claim.eq(i64Index, (long)f64Index);
            Claim.eq(byteCount, u8Index + 2);

        }
    }

}
