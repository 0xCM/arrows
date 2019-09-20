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

        public void scalar_xor_8i()
        {
            VerifyOp(OpKind.XOr, (x,y) => (sbyte)(x ^ y), D.xor<sbyte>());

        }

        public void scalar_xor_8u()
        {
            VerifyOp(OpKind.XOr, (x,y) => (byte)(x ^ y), D.xor<byte>());
            
        }

        public void scalar_xor_16i()
        {
            VerifyOp(OpKind.XOr, (x,y) => (short)(x ^ y), D.xor<short>());
        }

        public void scalar_xor_16u()
        {
            VerifyOp(OpKind.XOr, (x,y) => (ushort)(x ^ y), D.xor<ushort>());            
        }

        public void scalar_xor_32i()
        {
            VerifyOp(OpKind.XOr, (x,y) => (x ^ y), D.xor<int>());
        }

        public void scalar_xor_32u()
        {
            VerifyOp(OpKind.XOr, (x,y) => (x ^ y), D.xor<uint>());

        }

        public void scalar_xor_64i()
        {
            VerifyOp(OpKind.XOr, (x,y) => (x ^ y), D.xor<long>());
        }

        public void scalar_xor_64u()
        {
            VerifyOp(OpKind.XOr, (x,y) => (x ^ y), D.xor<ulong>());              
        }

    }

}
