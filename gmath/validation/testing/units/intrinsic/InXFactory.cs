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
    
    public class InXFactoryTest : UnitTest<InXFactoryTest>
    {        

        public void DefineFloat64Vec()
        {
            var src = new double[]{50,25};
            var v1 = Vec128.single(src);
            var v2 = Vec128.load(src,0);
            Claim.eq(v1,v2);
        }

        public void CreateScalars()
        {
            {
                var vec1 = Vec128.single(2,0,3,0);
                var vec2 = Vec128.single(5,0,7,0);
                var expect = Vec128.single(10L,21L);
                var result = Vec128<long>.Zero;
                ginx.mul(vec1, vec2,ref result);
                Claim.eq(expect,result);
            }

            {
                var vec1 = Vec128.single(2,0,3,0);
                var vec2 = Vec128.single(5,0,7,0);                            
                var result = Vec128<long>.Zero;
                ginx.mul(vec1, vec2,ref result);
                var expect =  Vec128.single<long>(vec1.Scalar(0) * vec2.Scalar(0), vec1.Scalar(2) * vec2.Scalar(2));
                Claim.eq(expect, result);                        
            
            }

            {
                var vec1 = Vec128.single(2.0, 3.0, 4.0, 5.0);
                var vec2 = Vec128.single(5.0, 2.0, 8.0, 4.0);
                var expect = Vec128.single(10.0, 6.0, 32.0, 20.0);
                var result = Vec128<double>.Zero;
                ginx.mul(vec1, vec2,ref result);
                Claim.eq(expect,result);
            }
        }

    }
}