//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using Z0.Test;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    public class t_mrg32k3a : RngTest<t_mrg32k3a>
    {
        public void bench_mrg32k3a_u32()
        {

            Benchmark(RNG.Mrg32k3a());
        }


    }

}