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

    public class VDivTest : UnitTest<VDivTest>
    {

        public void vDivTest()
        {
            var x = 20f;
            var y = 4.5f;
            var z = mkl.div(x,y);
            Trace($"{x} div {y} = {z}");
        }

    }

}
