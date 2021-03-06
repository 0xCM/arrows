//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
    public class tv_create : UnitTest<tv_create>
    {        

        public void CreateScalars()
        {
            {
                var vec1 = Vec128.FromParts(2,0,3,0);
                var vec2 = Vec128.FromParts(5,0,7,0);
                var expect = Vec128.FromParts(10L,21L);
                var result = Vec128<long>.Zero;
                result = dinx.mul(vec1,vec2);
                Claim.eq(expect,result);
            }

            {
                var vec1 = Vec128.FromParts(2,0,3,0);
                var vec2 = Vec128.FromParts(5,0,7,0);                            
                var result = Vec128<long>.Zero;
                result = dinx.mul(vec1,vec2);
                var expect =  Vec128.FromParts(vec1.ToScalar128(0) * vec2.ToScalar128(0), vec1.ToScalar128(2) * vec2.ToScalar128(2));
                Claim.eq(expect, result);                        
            
            }

            {
                var vec1 = Vec128.FromParts(2.0f, 3.0f, 4.0f, 5.0f);
                var vec2 = Vec128.FromParts(5.0f, 2.0f, 8.0f, 4.0f);
                var expect = Vec128.FromParts(10.0f, 6.0f, 32.0f, 20.0f);
                var result = Vec128<float>.Zero;
                result = dfp.fmul(vec1,vec2);
                Claim.eq(expect,result);
            }
        }

    }
}