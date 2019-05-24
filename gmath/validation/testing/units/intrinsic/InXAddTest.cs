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
    using static zfunc;


    public class InXAddTest : UnitTest<InXAddTest>
    {
        public void Max1()
        {
            var v1Src = Randomizer.ReadOnlySpan256<int>(1);
            var v2Src = Randomizer.ReadOnlySpan256<int>(1);
            var v4Src = Span256.alloc<int>(1);
            
            var v1 = Vec256.single(v1Src);
            var v2 = Vec256.single(v2Src);
            var v3 = ginx.add(v1, v2);

            for(var i = 0; i< v1.Length(); i++)
                v4Src[i] = v1Src[i]  + v2Src[i];
            var v4 = v4Src.Vector();
            
            Claim.eq(v4,v3);

        }

    }

}