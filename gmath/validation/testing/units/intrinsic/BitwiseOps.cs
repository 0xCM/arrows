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
    
    using static mfunc;


    public class InXBitwiseOps : UnitTest<InXBitwiseOps>
    {
        public void TestAllOn()
        {
            var v1 = Vec128.define(uint.MaxValue, uint.MaxValue, uint.MaxValue, uint.MaxValue);
            Claim.@true(dinx.allOn(v1));

            var v2 = Vec128.define(uint.MaxValue, uint.MaxValue - 1, uint.MaxValue, uint.MaxValue);
            Claim.@false(dinx.allOn(v2));                
        }     

    }


}