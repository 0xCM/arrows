//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public class ts_scatter : UnitTest<ts_scatter>
    {        
        protected override int SampleSize
            => Pow2.T08;
    
        public void scatter8u()
        {
            scatter_check<byte>();
        }

        public void scatter8u_bench()
        {
            Collect(scatter_bench<byte>(true));
            Collect(scatter_bench<byte>(false));
        }

        public void scatter16u()
        {
            scatter_check<ushort>();
        }

        public void scatter16u_bench()
        {
            Collect(scatter_bench<ushort>(true));
            Collect(scatter_bench<ushort>(false));
        }

        public void scatter32u()
        {
            scatter_check<uint>();
        }

        public void scatter32u_bench()
        {
            Collect(scatter_bench<uint>(true));
            Collect(scatter_bench<uint>(false));
        }

        public void scatter64u()
        {
            scatter_check<ulong>();
        }

        public void scatter64u_bench()
        {
            Collect(scatter_bench<ulong>(true));
            Collect(scatter_bench<ulong>(false));
        }
        
        OpTime scatter_bench<T>(bool reference)
            where T : unmanaged
        {

            OpTime refbench()        
            {
                var sw = stopwatch(false);
                for(var i=0; i<SampleSize; i++)
                {
                    var src = Random.Next<T>();
                    var mask = Random.Next<T>();
                    sw.Start();
                    var dst = BitRef.scatter(src,mask);
                    sw.Stop();
                }
                return OpTime.Define<T>(SampleSize, sw, $"scatter-ref");
            }

            OpTime opbench()
            {
                var sw = stopwatch(false);
                for(var i=0; i<SampleSize; i++)
                {
                    var src = Random.Next<T>();
                    var mask = Random.Next<T>();
                    sw.Start();
                    var dst = gbits.scatter(src,mask);
                    sw.Stop();
                }
                return OpTime.Define<T>(SampleSize, sw, $"scatter");        

            }

            if(reference)
                return refbench();
            else
                return opbench();


        }

        void scatter_check<T>(int samples = DefaultSampleSize)
            where T : unmanaged
        {
            for(var i=0; i<samples; i++)
            {
                var src = Random.Next<T>();
                var mask = Random.Next<T>();
                    var s1 = BitRef.scatter(src,mask);
                    var s2 = gbits.scatter(src,mask);
                Claim.eq(s1,s2);
            }
        }

    }
}