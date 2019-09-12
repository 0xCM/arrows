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

    public class t_geev : UnitTest<t_geev>
    {
        public void test1()
        {

            var A = Random.BlockMatrix<N5,double>();
            var eigen = mkl.geev<N5>(A);
            Claim.eq(5,eigen.Values.Length);
                    
        }

    }

}