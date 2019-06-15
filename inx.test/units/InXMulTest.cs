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


    public class InXMulTest : UnitTest<InXMulTest>
    {

        public void Mul128()
        {
            //Test case comes from https://docs.microsoft.com/et-ee/cpp/intrinsics/umul128?view=vs-2019
            var lhs = 0x0ffffffffffffffful;
            var rhs = 0xf0000000ul;
            dinx.mul(lhs,rhs, out UInt128 dst);
            Claim.eq("0xeffffffffffffff10000000", dst.ToHexString());

        }

    }

}