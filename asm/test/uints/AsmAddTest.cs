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
            VerifyOp(AsmOps.Add<sbyte>(), math.add, Samples);
            VerifyOp(AsmOps.Add<byte>(), math.add, Samples);
            VerifyOp(AsmOps.Add<short>(), math.add, Samples);
            VerifyOp(AsmOps.Add<ushort>(), math.add, Samples);
            VerifyOp(AsmOps.Add<int>(), math.add, Samples);
            VerifyOp(AsmOps.Add<uint>(), math.add, Samples);            
            VerifyOp(AsmOps.Add<long>(), math.add, Samples);
            VerifyOp(AsmOps.Add<ulong>(), math.add, Samples);
            VerifyOp(AsmOps.Add<float>(), math.add, Samples);
            VerifyOp(AsmOps.Add<double>(), math.add, Samples);
        }

         
    }


}
