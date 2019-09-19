//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static zfunc;

    public class t_exp : MathTest<t_exp>
    {

        const double MinExp = 2.0;
        const double MaxExp = 50.0;

        public void exp_libm_valid()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<double>(MinExp, MaxExp);
                var y = libm.exp(x);
                var z = fmath.exp(x);
                var error = fmath.relerr(y,z).Round(10);
                Claim.zero(error);
            }
        }

        public void exp_libm_bench()
        {
            void worker(double[] src)
            {
                var last = 0.0;
                for(var i=0; i<src.Length; i++)
                    last = libm.exp(src[i]);
            }

            Benchmark(worker,"exp/libm", MinExp, MaxExp);
        }

        public void exp_fmath_bench()
        {
            void worker(double[] src)
            {
                var last = 0.0;
                for(var i=0; i<src.Length; i++)
                    last = fmath.exp(src[i]);
            }

            Benchmark(worker,"exp/fmath", MinExp, MaxExp);
        }

        public void exp_cephes_bench()
        {
            void worker(double[] src)
            {
                var last = 0.0;
                for(var i=0; i<src.Length; i++)
                    last = cephes.exp(src[i]);
            }

            Benchmark(worker,"exp/cephes", MinExp, MaxExp);

        }

    }

}