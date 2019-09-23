//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static zfunc;

    public class tasm_sqrt : AsmOpTest<tasm_sqrt>
    {        
        public void Verify()
        {
            VerifyOp(AsmOps.Sqrt<float>(), fmath.sqrt, SampleSize);
            VerifyOp(AsmOps.Add<double>(), fmath.fadd, SampleSize);
        }

         
    }


}
