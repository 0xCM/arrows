//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Test
{
    using System;
    using Z0.Test;
    
    using static zfunc;

    public class AsmAddTest : AsmOpTest<AsmAddTest>
    {        
        public void VerifyAdd()
        {
            VerifyOp(AsmOps.Add<sbyte>(), math.add, SampleSize);
            VerifyOp(AsmOps.Add<byte>(), math.add, SampleSize);
            VerifyOp(AsmOps.Add<short>(), math.add, SampleSize);
            VerifyOp(AsmOps.Add<ushort>(), math.add, SampleSize);
            VerifyOp(AsmOps.Add<int>(), math.add, SampleSize);
            VerifyOp(AsmOps.Add<uint>(), math.add, SampleSize);            
            VerifyOp(AsmOps.Add<long>(), math.add, SampleSize);
            VerifyOp(AsmOps.Add<ulong>(), math.add, SampleSize);
            VerifyOp(AsmOps.Add<float>(), math.add, SampleSize);
            VerifyOp(AsmOps.Add<double>(), math.add, SampleSize);
        }

         
    }


}
