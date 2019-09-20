//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class ts_blsi : ScalarBitTest<ts_blsi>
    {

        /// <summary>
        /// Illustrates blsi is an identity function over a domain consisting of powers of 2
        /// </summary>
        public void blsi_idpow2()
        {
            for(byte i = 0; i< 64; i++)
                Claim.eq(Pow2.pow(i), gbits.blsi(Pow2.pow(i)));
        }

        public void blsi_8()
            => blsi_check<byte>();

        public void blsi_16()
            => blsi_check<ushort>();

        public void blsi_32()
            => blsi_check<uint>();

        public void blsi_64()
            => blsi_check<ulong>();

        public void blsi_8_bench()
            => blsi_bench<byte>();

        public void blsi_16_bench()
            => blsi_bench<ushort>();

        public void blsi_32_bench()
            => blsi_bench<uint>();

        public void blsi_64_bench()
            => blsi_bench<ulong>();

        public void blsi_64_bench_ref()
        {
            var opname = $"blsi_{bitsize<ulong>()}_ref";
            var opcount = CycleCount * RoundCount;
            var sw = stopwatch(false);
            var last = 0ul;

            for(var i=0; i<opcount; i++)
            {
                var x = Random.Next<ulong>();
                sw.Start();
                last = Bits.blsi(x);
                sw.Stop();
            }
            Collect((opcount, sw, opname));
        }

        void blsi_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<T>();
                var x = gbits.blsi(src);
                var y = gmath.and(src,gmath.negate(src));
                Claim.eq(x,y);
            }
        }

        void blsi_bench<T>()
            where T : unmanaged
        {
            var opname = $"blsi_{bitsize<T>()}";
            var opcount = CycleCount * RoundCount;
            var sw = stopwatch(false);
            var last = default(T);

            for(var i=0; i<opcount; i++)
            {
                var x = Random.Next<T>();
                sw.Start();
                last = gbits.blsi(x);
                sw.Stop();
            }
            Collect((opcount, sw, opname));
        }


    }

}