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

    public class vslChi2 : UnitTest<vslChi2>
    {

        public void Test1()
        {
            using(var stream = mkl.gSfmt19937(1))
            {
                
                var buffer = new float[Pow2.T04];
                var sample = mkl.chi2(stream, 4, buffer);

            }
        }

    }

}