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
    
    public class t_seed : UnitTest<t_seed>
    {

        public void reproduce()
        {

            var s1 = Rng.FixedSeed(54ul);
            var s2 = Rng.FixedSeed(54ul + 8ul);

            var rng1 = Rng.WyHash64(s1).ToPolyrand();
            var rng2 = Rng.WyHash64(s2).ToPolyrand();
            var rng3 = Rng.WyHash64(s1).ToPolyrand();

            var sample1 = rng1.Stream<ulong>().Take(Pow2.T08).ToArray();
            var sample2 = rng2.Stream<ulong>().Take(Pow2.T08).ToArray();
            var sample3 = rng3.Stream<ulong>().Take(Pow2.T08).ToArray();


            for(var i=0; i< Pow2.T08; i++)
                Claim.neq(sample1[i],sample2[i]);


            for(var i=0; i< Pow2.T08; i++)
                Claim.eq(sample1[i],sample3[i]);

        }

        public void stats()
        {
            (ByteSize byteCount, var u8Index) = Rng.FixedSeedStats<byte>();

            (_, int i32Index) = Rng.FixedSeedStats<int>();
            Rng.FixedSeed(i32Index);

            (_, long i64Index) = Rng.FixedSeedStats<long>();
            Rng.FixedSeed(i64Index);

            (_, double f64Index) = Rng.FixedSeedStats<double>();
            Rng.FixedSeed(f64Index);

            (_, float f32Index) = Rng.FixedSeedStats<float>();
            Rng.FixedSeed(f32Index);

            Claim.eq(i32Index, (int)f32Index);
            Claim.eq(i64Index, (long)f64Index);
            Claim.eq(byteCount, u8Index + 2);

        }
    }

}
