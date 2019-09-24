//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static zfunc;

    public class t_abs : MathTest<t_abs>
    {

        public void fabs64_cephes_validate()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<double>();
                Claim.eq(src < 0 ? -src : src, fmath.abs(src));
                Claim.eq(fmath.abs(src), cephes.fabs(src));
            }
        }

        public void fabs64_libm_validate()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<double>();
                Claim.eq(src < 0 ? -src : src, fmath.abs(src));
                Claim.eq(fmath.abs(src), libm.fabs(src));
            }
        }

        public void fabs64_cephes_bench()
        {
            void worker(double[] src)
            {
                var last = 0.0;
                for(var i=0; i<src.Length; i++)
                    last = cephes.fabs(src[i]);
            }

            Benchmark<double>(worker, "fabs/cephes");
        }

        public void fabs64_libm_bench()
        {
            void worker(double[] src)
            {
                var last = 0.0;
                for(var i=0; i<src.Length; i++)
                    last = libm.fabs(src[i]);
            }

            Benchmark<double>(worker, "fabs/libm");
        }

        public void fabs64_fmath_bench()
        {
            void worker(double[] src)
            {
                var last = 0.0;
                for(var i=0; i<src.Length; i++)
                    last = fmath.abs(src[i]);
            }

            Benchmark<double>(worker, "fabs/fmath");
        }

    }

}