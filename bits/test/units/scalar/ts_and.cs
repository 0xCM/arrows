//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;
    using D = BitwiseDelegates;

    public class ts_and : UnitTest<ts_and>
    {


        public void PrimalAnd()
        {
            var op = OpKind.And;
            VerifyOp(op, (x,y) => (sbyte)(x & y), D.and<sbyte>());
            VerifyOp(op, (x,y) => (byte)(x & y), D.and<byte>());
            VerifyOp(op, (x,y) => (short)(x & y), D.and<short>());
            VerifyOp(op, (x,y) => (ushort)(x & y), D.and<ushort>());
            VerifyOp(op, (x,y) => (x & y), D.and<int>());
            VerifyOp(op, (x,y) => (x & y), D.and<uint>());
            VerifyOp(op, (x,y) => (x & y), D.and<long>());
            VerifyOp(op, (x,y) => (x & y), D.and<ulong>());
        }


    }

}