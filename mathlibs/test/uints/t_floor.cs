//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static zfunc;

    public class t_floor : MathTest<t_floor>
    {

        public void floor64f_cephes_validate()
        {
            var src = Random.Stream<double>();
            for(var i=0; i<SampleSize; i++)
            {
                var x = src.First();
                var y1 = cephes.floor(x);
                var y2 = Math.Floor(x);
                Claim.eq(y1,y2);
            }
        }

        public void floor64f_cephes_bench()
        {
            void worker(double[] src)
            {
                var last = 0.0;
                for(var i=0; i<src.Length; i++)
                    last = cephes.floor(src[i]);
            }

            Benchmark<double>(worker, "floor/cephes");
        }

        public void floor64f_fmath_bench()
        {
            void worker(double[] src)
            {
                var last = 0.0;
                for(var i=0; i<src.Length; i++)
                    last = fmath.floor(src[i]);
            }

            Benchmark<double>(worker, "floor/fmath");
        }


    }

}