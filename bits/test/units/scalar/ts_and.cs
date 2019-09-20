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

    public class ts_and : ScalarBitTest<ts_and>
    {


        public void scalar_and()
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