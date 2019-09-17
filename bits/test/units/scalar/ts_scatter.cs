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
        protected override int CycleCount
            => Pow2.T14;
    
        public void scatter_8x8()
        {
            scatter_check<byte>();
        }

        public void scatter_8x8_bench()
        {
            scatter_bench<byte>();
            scatter_bench_ref<byte>();
        }

        public void scatter_16x16()
        {
            scatter_check<ushort>();
        }

        public void scatter_16x16_bench()
        {
            scatter_bench<ushort>();
            scatter_bench_ref<ushort>();

        }

        public void scatter_32x32()
        {
            scatter_check<uint>();
        }

        public void scatter_32x32_bench()
        {
            scatter_bench<uint>();
            scatter_bench_ref<uint>();
        }

        public void scatter_64x64()
        {
            scatter_check<ulong>();
        }

        public void scatter_64x64_bench()
        {
            scatter_bench<ulong>();
            scatter_bench_ref<ulong>();
        }

        void scatter_bench_ref<T>()
            where T : unmanaged
        {
            var sw = stopwatch(false);
            var opcount = CycleCount * RoundCount;
            var size = bitsize<T>();
            var opname = $"scatter_{size}x{size}_ref";
            for(var i=0; i<opcount; i++)
            {
                var src = Random.Next<T>();
                var mask = Random.Next<T>();
                sw.Start();
                var dst = BitRef.scatter(src,mask);
                sw.Stop();
            }
            
            Collect((opcount,sw,opname));
        }

        void scatter_bench<T>()
            where T : unmanaged
        {
            var sw = stopwatch(false);
            var opcount = CycleCount * RoundCount;
            var size = bitsize<T>();
            var opname = $"scatter_{size}x{size}";
            for(var i=0; i<opcount; i++)
            {
                var src = Random.Next<T>();
                var mask = Random.Next<T>();
                sw.Start();
                var dst = gbits.scatter(src,mask);
                sw.Stop();
            }
            
            Collect((opcount,sw,opname));
        }

        void scatter_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
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