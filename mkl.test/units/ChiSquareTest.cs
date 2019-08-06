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

    public class ChiSquareTest : UnitTest<ChiSquareTest>
    {

        public void Test1()
        {
            using(var stream = mkl.stream(BRNG.SFMT19937, 1))
            {
                
                var buffer = new float[Pow2.T04];
                var sample = mkl.chi2(stream, 4, buffer);
                Trace(sample.SampleData.Span.Format());

                Claim.eq(BRNG.SFMT19937, mkl.brng(stream));

            }
        }

    }

}