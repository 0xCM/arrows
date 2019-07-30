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
            VerifyOp(AsmNegate.Op<sbyte>(), math.negate, Samples);
            VerifyOp(AsmNegate.Op<byte>(), math.negate, Samples);
            VerifyOp(AsmNegate.Op<short>(), math.negate, Samples);
            VerifyOp(AsmNegate.Op<ushort>(), math.negate, Samples);
            VerifyOp(AsmNegate.Op<int>(), math.negate, Samples);
            VerifyOp(AsmNegate.Op<uint>(), math.negate, Samples);            
            VerifyOp(AsmNegate.Op<long>(), math.negate, Samples);
            VerifyOp(AsmNegate.Op<ulong>(), math.negate, Samples);
            VerifyOp(AsmNegate.Op<float>(), math.negate, Samples);
            VerifyOp(AsmNegate.Op<double>(), math.negate, Samples);
        }

         
    }

}
