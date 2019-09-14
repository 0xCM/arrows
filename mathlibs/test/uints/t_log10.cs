//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;

    using static zfunc;

    public class t_log10 : UnitTest<t_log10>
    {
        protected override int RoundCount
            => Pow2.T10;

        public void log10_libm_validate()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<double>();
                var y = libm.log10(x);
                var z = fmath.log(x);
                var error = fmath.relerr(y,z).Round(10);
                Claim.zero(error);
            }
        }

        public void log10_libm_bench()
        {
            void worker(double[] src)
            {
                var last = 0.0;
                for(var i=0; i<src.Length; i++)
                    last = libm.log10(src[i]);
            }

            Benchmark<double>(worker, "log10/libm");
        }

        public void log10_fmath_bench()
        {
            void worker(double[] src)
            {
                var last = 0.0;
                for(var i=0; i<src.Length; i++)
                    last = fmath.log(src[i]);
            }

            Benchmark<double>(worker,"log10/fmath");
        }

    }

}