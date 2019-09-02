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
    
    public class t_sub : UnitTest<t_sub>
    {

        public void Sub()
        {
            VerifyOp((x,y) => (sbyte)(x - y), D.sub<sbyte>());
            VerifyOp((x,y) => (byte)(x - y), D.sub<byte>());
            VerifyOp((x,y) => (short)(x - y), D.sub<short>());
            VerifyOp((x,y) => (ushort)(x - y), D.sub<ushort>());
            VerifyOp((x,y) => (x - y), D.sub<int>());
            VerifyOp((x,y) => (x - y), D.sub<uint>());
            VerifyOp((x,y) => (x - y), D.sub<long>());
            VerifyOp((x,y) => (x - y), D.sub<ulong>());
            VerifyOp((x,y) => (x - y), D.sub<float>());
            VerifyOp((x,y) => (x - y), D.sub<double>());              
        }

    }

}