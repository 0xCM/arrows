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

    public class VAbsTest : UnitTest<VAbsTest>
    {

        public void vAbsF32()
        {
            var src = Random.GenericVector<float>(Pow2.T08);
            var dst1 = src.Replicate(true);
            mkl.abs(src, ref dst1);
            var dst2 = src.Replicate();
            gmath.abs(src,dst2.Unblocked);
            Claim.yea(dst1 == dst2);
        }

        public void vAbsF64()
        {
            var src = Random.GenericVector<double>(Pow2.T08);
            var dst1 = src.Replicate(true);
            mkl.abs(src, ref dst1);
            var dst2 = src.Replicate();
            gmath.abs(src,dst2.Unblocked);
            Claim.yea(dst1 == dst2);
        }



    }

}
