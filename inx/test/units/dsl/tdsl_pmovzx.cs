//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class tdsl_pmovzx : UnitTest<tdsl_pmovzx>
    {

        public void dsl_pmovzxbw()
        {
            var src = Random.Xmm<byte>();
            var dst = Asm.pmovzxbw(in src);
            for(var i=0; i<8; i++)
                Claim.eq(src.uint8(i), dst.uint16(i));                           
        }


    }

}