//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;
    using static nfunc;
    
    public class t_dot : t_mkl<t_dot>
    {

        public void dot32f()
        {
            for(var i=0; i< DefaltCycleCount; i++)
            {
                var x = RVecF32(DefaultSampleSize);
                var y = RVecF32(DefaultSampleSize);
                
                var result = mkl.dot(x,y);
                var expect = Linear.dot(x,y);
                Claim.eq(result,expect);
            }
        }

        public void dot32fn()
        {
            for(var i=0; i< DefaltCycleCount; i++)
            {
                var x = RVecF32(DefaultSampleNat);
                var y = RVecF32(DefaultSampleNat);
                
                var result = mkl.dot(x,y);
                var expect = Linear.dot(x,y);
                Claim.eq(result,expect);
            }
        }

        public void dot64f()
        {
            for(var i=0; i< DefaltCycleCount; i++)
            {
                var x = RVecF64(DefaultSampleSize);
                var y = RVecF64(DefaultSampleSize);
                
                var result = mkl.dot(x,y);
                var expect = Linear.dot(x,y);
                Claim.eq(result,expect);
            }
        }

        public void dot64fn()
        {
            for(var i=0; i< DefaltCycleCount; i++)
            {
                var x = RVecF64(DefaultSampleNat);
                var y = RVecF64(DefaultSampleNat);
                
                var result = mkl.dot(x,y);
                var expect = Linear.dot(x,y);
                Claim.eq(result,expect);
            }
        }
    }
}