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

    
    using static global::mfunc;


    sealed class SubTest : UnitTest<SubTest>
    {
        const int Blocks = Pow2.T08;

        public void V128F32()
        {            
            var lhs = Randomizer.Span128<float>(Blocks);
            var rhs = Randomizer.Span128<float>(Blocks);
            var dDst = Span128.blockalloc<float>(Blocks);
            var gDst = Span128.blockalloc<float>(Blocks);
            Claim.eq(dinx.sub(lhs,rhs, ref dDst), ginx.sub(lhs,rhs, gDst));
        }

        public void V128F64()
        {            
            var lhs = Randomizer.Span128<double>(Blocks);
            var rhs = Randomizer.Span128<double>(Blocks);
            var dDst = Span128.blockalloc<double>(Blocks);
            var gDst = Span128.blockalloc<double>(Blocks);
                
            Claim.eq(dinx.sub(lhs,rhs, ref dDst), ginx.sub(lhs,rhs, gDst));
        }

    }

}