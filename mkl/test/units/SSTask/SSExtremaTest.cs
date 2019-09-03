//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl.Test
{
    using System;
    using System.Linq;

    using static zfunc;
    using static nfunc;
    
    using Z0.Test;
    using static Examples;

    public class SSExtremaTest: UnitTest<SSExtremaTest>
    {

        public void VerifyMin()
        {
            var samplesize = Pow2.T14;

            var s1Range = closed(350.0, 1000.0);
            var s1 = Polyrand.Array<double>(samplesize, s1Range);
            var s1Max = Sample.Load(s1).Max()[0];
            Claim.neq(s1Max,0.0);

            var zeroCount = s1.Count(x => x == 0);
            Trace($"Found {zeroCount} zeroes");

        }

        public void VerifySumSimple()
        {
            var src = new double[]{4,8,10};
            var result = Sample.Load(src).Sum()[0];
            Claim.eq(22.0,result);

        }

        public void VerifySum()
        {
            var src = Polyrand.Array<double>(Pow2.T14);
            var expect = src.Sum().Round(4);
            var actual = Sample.Load(src).Sum()[0].Round(4);
            Claim.eq(expect,actual);
        }

        void TimeMean()
        {
            var cycles = Pow2.T12;
            var samples = Pow2.T14;
            var src = Polyrand.Array<long>(samples, closed(-2000L, 2000L));
            var last = 0L;
            var dSrc = src.Convert<double>();

            var sw1 = stopwatch();
            for(var i=0; i<cycles; i++)
                last = (long)Sample.Load(dSrc).Mean()[0];
            var t1 = OpTime.Define(cycles*samples, snapshot(sw1),"mkl");


            var sw2 = stopwatch();
            for(var i=0; i<cycles; i++)
                last = src.Avg();            
            var t2 = OpTime.Define(cycles*samples, snapshot(sw2),"direct");
            TracePerf((t1,t2));
        }
        
        public void VerifyMean()
        {

            var src = Polyrand.Array<long>(Pow2.T14, closed(-2000L, 2000L));
            var expect = src.Avg();
            var actual = (long)Sample.Load(src.Convert<double>()).Mean()[0];
            Claim.eq(expect,actual);


        }

    }

}