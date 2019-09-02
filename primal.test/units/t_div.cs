//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;

    using static zfunc;

    using D = PrimalDelegates;

    public class t_div : UnitTest<t_div>
    {
        public void div()
        {
            VerifyOp((x,y) => (sbyte)(x / y), D.div<sbyte>(),true);
            VerifyOp((x,y) => (byte)(x / y), D.div<byte>(),true);
            VerifyOp((x,y) => (short)(x / y), D.div<short>());
            VerifyOp((x,y) => (ushort)(x / y), D.div<ushort>(),true);
            VerifyOp((x,y) => (x / y), D.div<int>(),true);
            VerifyOp((x,y) => (x / y), D.div<uint>(),true);
            VerifyOp((x,y) => (x / y), D.div<long>(),true);
            VerifyOp((x,y) => (x / y), D.div<ulong>(),true);
            VerifyOp((x,y) => (x / y), D.div<float>(),true);
            VerifyOp((x,y) => (x / y), D.div<double>(),true);
        }

    }

}