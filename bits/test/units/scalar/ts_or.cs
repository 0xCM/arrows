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

    public class ts_or : UnitTest<ts_or>
    {

        public void or8i()
        {
            VerifyOp(OpKind.Or, (x,y) => (sbyte)(x | y), D.or<sbyte>());

        }

        public void or8u()
        {
            VerifyOp(OpKind.Or, (x,y) => (byte)(x | y), D.or<byte>());
            
        }

        public void or16i()
        {
            VerifyOp(OpKind.Or, (x,y) => (short)(x | y), D.or<short>());
            
        }

        public void or16u()
        {
            VerifyOp(OpKind.Or, (x,y) => (ushort)(x | y), D.or<ushort>());
            
        }

        public void or32i()
        {
            VerifyOp(OpKind.Or, (x,y) => (x | y), D.or<int>());

        }

        public void or32u()
        {
            VerifyOp(OpKind.Or, (x,y) => (x | y), D.or<uint>());

        }

        public void or64i()
        {
            VerifyOp(OpKind.Or, (x,y) => (x | y), D.or<long>());

        }

        public void or64u()
        {
            VerifyOp(OpKind.Or, (x,y) => (x | y), D.or<ulong>());

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
