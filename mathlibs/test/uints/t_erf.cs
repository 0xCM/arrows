//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static zfunc;

    public class t_erf : MathTest<t_erf>
    {

        void erf64f_cephes_validate()
        {
            var src = Random.Stream<double>();
            for(var i=0; i<SampleSize; i++)
            {
                var x = src.First();
                var y = cephes.erf(x);
                var z = libm.erf(x);
                var delta = fmath.relerr(y,z).Round(10);
                Claim.zero(delta);
            }
        }

        void erf64f_cephes_bench()
        {
            void worker(double[] src)
            {
                var last = 0.0;
                for(var i=0; i<src.Length; i++)
                    last = cephes.erf(src[i]);
            }

            Benchmark<double>(worker, "erf/cephes");
        }

        public void erf64f_libm_bench()
        {
            void worker(double[] src)
            {
                var last = 0.0;
                for(var i=0; i<src.Length; i++)
                    last = libm.erf(src[i]);
            }

            Benchmark<double>(worker, "erf/libm");
        }


    }

}