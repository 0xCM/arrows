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


    public class InXSpanOps : UnitTest<InXSpanOps>
    {
        const int Blocks = Pow2.T08;


        public void V128F32()
        {            
            var lhs = Random.Span128<float>(Blocks);
            var rhs = Random.Span128<float>(Blocks);
            var dDst = Span128.alloc<float>(Blocks);
            var gDst = Span128.alloc<float>(Blocks);
            Claim.eq(dinxx.Sub(lhs,rhs, dDst), ginxs.Sub(lhs,rhs, gDst));
        }

        public void V128F64()
        {            
            var lhs = Random.Span128<double>(Blocks);
            var rhs = Random.Span128<double>(Blocks);
            var dDst = Span128.alloc<double>(Blocks);
            var gDst = Span128.alloc<double>(Blocks);                
            Claim.eq(dinxx.Sub(lhs, rhs, dDst), ginxs.Sub(lhs,rhs, gDst));
        }

    }

}