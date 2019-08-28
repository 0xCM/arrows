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

    public class t_or : UnitTest<t_or>
    {

        public void PrimalOr()
        {
            var op = OpKind.Or;
            VerifyOp(op, (x,y) => (sbyte)(x | y), D.or<sbyte>());
            VerifyOp(op, (x,y) => (byte)(x | y), D.or<byte>());
            VerifyOp(op, (x,y) => (short)(x | y), D.or<short>());
            VerifyOp(op, (x,y) => (ushort)(x | y), D.or<ushort>());
            VerifyOp(op, (x,y) => (x | y), D.or<int>());
            VerifyOp(op, (x,y) => (x | y), D.or<uint>());
            VerifyOp(op, (x,y) => (x | y), D.or<long>());
            VerifyOp(op, (x,y) => (x | y), D.or<ulong>());
        }

        public void PrimalXOr()
        {
            var op = OpKind.XOr;
            VerifyOp(op, (x,y) => (sbyte)(x ^ y), D.xor<sbyte>());
            VerifyOp(op, (x,y) => (byte)(x ^ y), D.xor<byte>());
            VerifyOp(op, (x,y) => (short)(x ^ y), D.xor<short>());
            VerifyOp(op, (x,y) => (ushort)(x ^ y), D.xor<ushort>());
            VerifyOp(op, (x,y) => (x ^ y), D.xor<int>());
            VerifyOp(op, (x,y) => (x ^ y), D.xor<uint>());
            VerifyOp(op, (x,y) => (x ^ y), D.xor<long>());
            VerifyOp(op, (x,y) => (x ^ y), D.xor<ulong>());              
        }


    }

}
