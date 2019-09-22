//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;

    using static zfunc;

    public class t_signum : UnitTest<t_signum>
    {

        public void signum_8i_check()
        {
            signum_check<sbyte>();

        }

        public void signum_8i_bench()
        {
            signum_bench<sbyte>();
        }

        public void signum_16i_check()
        {
            signum_check<short>();
        }

        public void signum_16i_bench()
        {
            signum_bench<short>();
        }

        public void signum_32i_check()
        {
            signum_check<int>();
        }

        public void signum_32i_bench()
        {
            signum_bench<int>();
        }

        public void signum_64i_check()
        {
            signum_check<long>();
        }

        public void signum_64i_bench()
        {
            signum_bench<long>();
        }

        public void signum_32f_check()
        {
            signum_check<float>();
        }

        public void signum_32f_bench()
        {
            signum_bench<float>();
        }

        public void signum_64f_check()
        {
            signum_check<double>();
        }

        public void signum_64f_bench()
        {
            signum_bench<double>();
        }

        void signum_check<T>()
            where T : unmanaged
        {
            var zero = gmath.zero<T>();
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();
                var expect = gmath.lt(x, zero) ? Sign.Neg : (gmath.gt(x, zero) ? Sign.Pos : Sign.None);
                var actual = gmath.signum(x);
                Claim.eq(expect,actual);
            }

        }

        void signum_bench<T>(SystemCounter subject = default, SystemCounter compare = default)
            where T : unmanaged
        {
            var zero = gmath.zero<T>();
            var last = Sign.None;
            for(var i=0; i<OpCount; i++)
            {
                var x = Random.Next<T>();
                
                subject.Start();
                last = gmath.signum(x);
                subject.Stop();

                compare.Start();
                last = gmath.lt(x, zero) ? Sign.Neg : (gmath.gt(x, zero) ? Sign.Pos : Sign.None);
                compare.Stop();

            }

            Benchmark($"signum_{moniker<T>()}", subject);
            Benchmark($"signum_{moniker<T>()}_cf", compare);

        }

    }

}