//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static zfunc;

    public class AsmSqrtTest : AsmOpTest<AsmSqrtTest>
    {        
        public void Verify()
        {
            VerifyOp(AsmOps.Sqrt<float>(), fmath.sqrt, SampleSize);
            VerifyOp(AsmOps.Add<double>(), math.add, SampleSize);
        }

         
    }


}
