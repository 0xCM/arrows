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
    public class App : TestApp<App>
    {            

        public void IndexTest()
        {
            var seed = Seed64.Seed00;
            var index = Pcg64.DefaultIndex;
            var pcg0 = Pcg64.Define(seed, index += 2);
            var pcg1 = Pcg64.Define(seed, index += 2);
            var pcg2 = Pcg64.Define(seed, index += 2);
            var pcg3 = Pcg64.Define(seed, index += 2);
            var sampleSize = Pow2.T08;

            var s0 = pcg0.TakeSet(sampleSize);
            var s1 = pcg1.TakeSet(sampleSize);
            var s2 = pcg2.TakeSet(sampleSize);
            var s3 = pcg3.TakeSet(sampleSize);


            s1.IntersectWith(s2);            
            s2.IntersectWith(s3);

            print((s1.Count + s2.Count).ToString());


        }
        protected override void RunTests()
        {
            var rng = Pcg.Rng64(Seed64.Seed00);
            var sample1 = rng.Stream().TakeSpan(5).Format();
            print(sample1);
            rng.Retreat(5);
            var sample2 = rng.Stream().TakeSpan(5).Format();
            print(sample2);


        }
        public static void Main(params string[] args)
            => Run(args);
    }
}