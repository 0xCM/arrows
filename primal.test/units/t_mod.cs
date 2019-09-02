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

    public class t_mod : UnitTest<t_mod>
    {
        public void mod()
        {
            VerifyOp((x,y) => (sbyte)(x % y), D.mod<sbyte>(),true);
            VerifyOp((x,y) => (byte)(x % y), D.mod<byte>(),true);
            VerifyOp((x,y) => (short)(x % y), D.mod<short>());
            VerifyOp((x,y) => (ushort)(x % y), D.mod<ushort>(),true);
            VerifyOp((x,y) => (x % y), D.mod<int>(),true);
            VerifyOp((x,y) => (x % y), D.mod<uint>(),true);
            VerifyOp((x,y) => (x % y), D.mod<long>(),true);
            VerifyOp((x,y) => (x % y), D.mod<ulong>(),true);
            VerifyOp((x,y) => (x % y), D.mod<float>(),true);
            VerifyOp((x,y) => (x % y), D.mod<double>(),true);
              
        }


    }

}
