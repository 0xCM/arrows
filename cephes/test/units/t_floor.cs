//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;

    using static zfunc;

    public class t_floor : UnitTest<t_floor>
    {
        protected override int CycleCount => Pow2.T08;

        public void floor64f()
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


        public void floor64f_bench_ref()
        {
            var whole = 0.0;
            var sw = stopwatch(false);
            for(var i=0; i< CycleCount*SampleSize; i++)
            {
                var x = Random.Next<double>();
                sw.Start();
                whole = Math.Floor(x);
                sw.Stop();
            }

            Collect((CycleCount*SampleSize, sw, "System.Math.Floor"));
        }

        public void floor64f_bench()
        {
            var whole = 0.0;
            var sw = stopwatch(false);
            for(var i=0; i< CycleCount*SampleSize; i++)
            {
                var x = Random.Next<double>();
                sw.Start();
                whole = cephes.floor(x);
                sw.Stop();
            }
        
            Collect((CycleCount*SampleSize, sw, "cephes/floor"));
        }

    }

}