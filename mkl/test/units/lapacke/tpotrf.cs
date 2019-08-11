//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;
    using static nfunc;
    
    using Z0.Test;
    using static Nats;

    public class tpotrf : UnitTest<tpotrf>
    {
        public void PositiveDefinite()
        {
            var notPD = Matrix.Define(new float[]{1,2,2,1}, N2);
            var eval1 = mkl.posdef(notPD);
            Claim.nea(eval1);

            var PD = Matrix.Define(new float[]{2,-1,0,-1,2,-1,0,-1,2}, N3);
            var eval2 = mkl.posdef(PD);
            Claim.yea(eval2);

        }

        public void Case1()
        {
            var A = Matrix.Define(new float[]{4,12,-16,12,37,-43,-16,-43,98}, N3);
            var B = A.Replicate();
            Claim.yea(mkl.potrf(B));            
        }

    }

}