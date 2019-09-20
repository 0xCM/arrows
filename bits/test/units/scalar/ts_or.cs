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

    public class ts_or : ScalarBitTest<ts_or>
    {

        public void scalar_or_8i()
        {
            VerifyOp(OpKind.Or, (x,y) => (sbyte)(x | y), D.or<sbyte>());

        }

        public void scalar_or_8u()
        {
            VerifyOp(OpKind.Or, (x,y) => (byte)(x | y), D.or<byte>());
            
        }

        public void scalar_or_16i()
        {
            VerifyOp(OpKind.Or, (x,y) => (short)(x | y), D.or<short>());
            
        }

        public void scalar_or_16u()
        {
            VerifyOp(OpKind.Or, (x,y) => (ushort)(x | y), D.or<ushort>());
            
        }

        public void scalar_or_32i()
        {
            VerifyOp(OpKind.Or, (x,y) => (x | y), D.or<int>());

        }

        public void scalar_or_32u()
        {
            VerifyOp(OpKind.Or, (x,y) => (x | y), D.or<uint>());

        }

        public void scalar_or_64i()
        {
            VerifyOp(OpKind.Or, (x,y) => (x | y), D.or<long>());

        }

        public void scalar_or_64u()
        {
            VerifyOp(OpKind.Or, (x,y) => (x | y), D.or<ulong>());

        }


        public void scalar_xor()
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
