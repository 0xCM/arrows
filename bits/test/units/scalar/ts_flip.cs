//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using D = BitwiseDelegates;

    public class ts_flip : ScalarBitTest<ts_flip>
    {
        public void scalar_flip_8i()
        {
            VerifyOp(OpKind.Flip, x => (sbyte) ~x, D.flip<sbyte>());

        }

        public void scalar_flip_8u()
        {
            VerifyOp(OpKind.Flip, x => (byte) ~x, D.flip<byte>());            
        }

        public void scalar_flip_16i()
        {
            VerifyOp(OpKind.Flip, x => (short) ~x, D.flip<short>());            
        }

        public void scalar_flip_16u()
        {
            VerifyOp(OpKind.Flip, x => (ushort) ~x, D.flip<ushort>());            
        }

        public void scalar_flip_32i()
        {
            VerifyOp(OpKind.Flip, x => ~x, D.flip<int>());
        }

        public void scalar_flip_32u()
        {
            VerifyOp(OpKind.Flip, x => ~x, D.flip<uint>());
        }

        public void scalar_flip_64i()
        {
            VerifyOp(OpKind.Flip, x => ~x, D.flip<long>());
        }

        public void scalar_flip_64u()
        {
            VerifyOp(OpKind.Flip, x => ~x, D.flip<ulong>());              
        }
    }
}
