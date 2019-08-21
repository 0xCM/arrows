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


    public class SpanOpTest : UnitTest<SpanOpTest>
    {
        const int Blocks = Pow2.T08;

        public void V128F32()
        {            
            var lhs = Random.Span128<float>(Blocks);
            var rhs = Random.Span128<float>(Blocks);
            var dDst = Span128.AllocBlocks<float>(Blocks);
            var gDst = Span128.AllocBlocks<float>(Blocks);
            Claim.eq(dinxx.Sub(lhs,rhs, dDst), lhs.ReadOnly().Sub(rhs, gDst));
        }

        public void V128F64()
        {            
            var lhs = Random.Span128<double>(Blocks);
            var rhs = Random.Span128<double>(Blocks);
            var dDst = Span128.AllocBlocks<double>(Blocks);
            var gDst = Span128.AllocBlocks<double>(Blocks);                
            Claim.eq(dinxx.Sub(lhs, rhs, dDst), lhs.ReadOnly().Sub(rhs, gDst));
        }

    }

}