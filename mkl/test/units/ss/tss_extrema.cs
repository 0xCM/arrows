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
    
    public class t_extrema: UnitTest<t_extrema>
    {

        public void minval()
        {
            var samplesize = Pow2.T14;

            var s1Range = closed(350.0, 1000.0);
            var s1 = Random.Array<double>(samplesize, s1Range);
            var s1Max = Dataset.Load(s1).Max()[0];
            Claim.neq(s1Max,0.0);

            var zeroCount = s1.Count(x => x == 0);
            Trace($"Found {zeroCount} zeroes");
        }

        public void sumvals()
        {
            var src = Random.Array<double>(Pow2.T14);
            var expect = src.Sum().Round(4);
            var actual = Dataset.Load(src).Sum()[0].Round(4);
            Claim.eq(expect,actual);
        }

        public void mean_bench()
        {
            run_mean_bench();
            run_mean_bench();
        }

        void run_mean_bench()
        {
            var cycles = Pow2.T12;
            var samples = Pow2.T14;
            var src = Random.Array<long>(samples, closed(-2000L, 2000L)).Convert<double>();
            var ds = Dataset.Load(src);
            var dst = 0.0;
            var last = 0.0;

            var sw1 = stopwatch();
            for(var i=0; i<cycles; i++)
                last = ds.Mean(ref dst);
            
            var t1 = OpTime.Define(cycles*samples, snapshot(sw1),"mkl-ssmean");

            var sw2 = stopwatch();
            for(var i=0; i<cycles; i++)
                last = src.Avg();     

            var t2 = OpTime.Define(cycles*samples, snapshot(sw2),"direct");
            Collect((t1,t2));

        }
        
        public void mean()
        {
            var src = Random.Array<long>(Pow2.T14, closed(-2000L, 2000L));
            var expect = src.Avg();
            var actual = (long)Dataset.Load(src.Convert<double>()).Mean()[0];
            Claim.eq(expect,actual);
        }
    }

}