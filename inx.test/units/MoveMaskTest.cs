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


    public class MoveMaskTest : UnitTest<InXSumTest>
    {


        public void Case1()
        {
            var src = Random.Vec128<byte>();
            var result = dinx.movemask(in src);
            var expect = 0;
            for(var pos=0; pos< src.Length(); pos++)
                if(gbits.hibit(src[pos]))
                    gbits.enable(ref expect, pos) ;                    
            Claim.eq(expect, result);

        }


    }

}