//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class AsmNegateTest : AsmOpTest<AsmNegateTest>
    {        
        public void VerifyNegate()
        {
            VerifyOp(AsmOps.Negate<sbyte>(), math.negate, SampleSize);
            VerifyOp(AsmOps.Negate<byte>(), math.negate, SampleSize);
            VerifyOp(AsmOps.Negate<short>(), math.negate, SampleSize);
            VerifyOp(AsmOps.Negate<ushort>(), math.negate, SampleSize);
            VerifyOp(AsmOps.Negate<int>(), math.negate, SampleSize);
            VerifyOp(AsmOps.Negate<uint>(), math.negate, SampleSize);            
            VerifyOp(AsmOps.Negate<long>(), math.negate, SampleSize);
            VerifyOp(AsmOps.Negate<ulong>(), math.negate, SampleSize);
            VerifyOp(AsmOps.Negate<float>(), math.negate, SampleSize);
            VerifyOp(AsmOps.Negate<double>(), math.negate, SampleSize);
        }

         
    }

}
