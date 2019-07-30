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
            VerifyOp(AsmAdd.Op<sbyte>(), math.add, Samples);
            VerifyOp(AsmAdd.Op<byte>(), math.add, Samples);
            VerifyOp(AsmAdd.Op<short>(), math.add, Samples);
            VerifyOp(AsmAdd.Op<ushort>(), math.add, Samples);
            VerifyOp(AsmAdd.Op<int>(), math.add, Samples);
            VerifyOp(AsmAdd.Op<uint>(), math.add, Samples);            
            VerifyOp(AsmAdd.Op<long>(), math.add, Samples);
            VerifyOp(AsmAdd.Op<ulong>(), math.add, Samples);
            VerifyOp(AsmAdd.Op<float>(), math.add, Samples);
            VerifyOp(AsmAdd.Op<double>(), math.add, Samples);
        }

         
    }


}
