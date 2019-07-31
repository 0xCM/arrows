//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Test
{
    using System;
    using Z0.Test;
    
    using static zfunc;

    public class AsmSqrtTest : AsmOpTest<AsmSqrtTest>
    {        
        public void Verify()
        {
            VerifyOp(AsmOps.Sqrt<float>(), math.sqrt, Samples);
            VerifyOp(AsmOps.Add<double>(), math.add, Samples);
        }

         
    }


}
