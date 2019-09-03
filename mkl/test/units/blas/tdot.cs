//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;
    using static nfunc;
    
    using Z0.Test;

    public class tdot : MklTest<tdot>
    {

        public void TVecF32()
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

        public void TVecF32N()
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

        public void TVecF64()
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

        public void TVecF64N()
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