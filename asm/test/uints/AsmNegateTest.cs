//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Test
{
    using System;
    using Z0.Test;
    
    using static zfunc;

    public class AsmNegateTest : AsmOpTest<AsmNegateTest>
    {        
        public void VerifyNegate()
        {
            VerifyOp(AsmOps.Negate<sbyte>(), math.negate, Samples);
            VerifyOp(AsmOps.Negate<byte>(), math.negate, Samples);
            VerifyOp(AsmOps.Negate<short>(), math.negate, Samples);
            VerifyOp(AsmOps.Negate<ushort>(), math.negate, Samples);
            VerifyOp(AsmOps.Negate<int>(), math.negate, Samples);
            VerifyOp(AsmOps.Negate<uint>(), math.negate, Samples);            
            VerifyOp(AsmOps.Negate<long>(), math.negate, Samples);
            VerifyOp(AsmOps.Negate<ulong>(), math.negate, Samples);
            VerifyOp(AsmOps.Negate<float>(), math.negate, Samples);
            VerifyOp(AsmOps.Negate<double>(), math.negate, Samples);
        }

         
    }

}
