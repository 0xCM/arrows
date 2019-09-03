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

        void VerifyAbs64(int cycles = DefaltCycleCount)
        {
            for(var cycle = 0; cycle < cycles; cycle++)
            {
                var x = Polyrand.CpuVec256<long>();            
                var actual = dinx.abs(x);
                var expect = x.Map256(Math.Abs);
                Claim.eq(expect, actual);
            }

            for(var cycle = 0; cycle < cycles; cycle++)
            {
                var x = Polyrand.CpuVec128<long>();            
                var actual = dinx.abs(x);
                var expect = x.Map128(Math.Abs);
                Claim.eq(expect, actual);
            }

        }


        public void Abs64()
        {
            VerifyAbs64();
        }

    }

}