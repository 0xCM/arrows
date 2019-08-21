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


    public class AbsTest : UnitTest<AbsTest>
    {

        void VerifyAbs64(int cycles = DefaltCycleCount)
        {
            for(var cycle = 0; cycle < cycles; cycle++)
            {
                var x = Random.CpuVec256<long>();            
                var actual = dinx.abs(x);
                var expect = x.Map(math.abs);
                Claim.eq(actual,expect);
            }
        }


        public void Abs64()
        {
            VerifyAbs64();

        }


    }

}