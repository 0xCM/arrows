//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;


    public class tv_abs : UnitTest<tv_abs>
    {

        public void abs64()
        {
            abs64_check();
        }

        void abs64_check(int cycles = DefaltCycleCount)
        {
            for(var cycle = 0; cycle < cycles; cycle++)
            {
                var x = Random.CpuVec256<long>();            
                var actual = dinx.abs(x);
                var expect = x.Map256(Math.Abs);
                Claim.eq(expect, actual);
            }

            for(var cycle = 0; cycle < cycles; cycle++)
            {
                var x = Random.CpuVec128<long>();            
                var actual = dinx.abs(x);
                var expect = x.Map128(Math.Abs);
                Claim.eq(expect, actual);
            }

        }

    }

}