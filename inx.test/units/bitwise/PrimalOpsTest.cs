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

    public class PrimalOpsTest : UnitTest<PrimalOpsTest>
    {
        public void VerifyAnd()
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

        public void VerifyOr()
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

        public void VerifyXOr()
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

        public void VerifyFlip()
        {
            var op = OpKind.Flip;
            VerifyOp(op, x => (sbyte) ~x, D.flip<sbyte>());
            VerifyOp(op, x => (byte) ~x, D.flip<byte>());
            VerifyOp(op, x => (short) ~x, D.flip<short>());
            VerifyOp(op, x => (ushort) ~x, D.flip<ushort>());
            VerifyOp(op, x => ~x, D.flip<int>());
            VerifyOp(op, x => ~x, D.flip<uint>());
            VerifyOp(op, x => ~x, D.flip<long>());
            VerifyOp(op, x => ~x, D.flip<ulong>());              
        }

    }

}
