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

    public class ts_flip : UnitTest<ts_flip>
    {
        public void flip8i()
        {
            VerifyOp(OpKind.Flip, x => (sbyte) ~x, D.flip<sbyte>());

        }

        public void flip8u()
        {
            VerifyOp(OpKind.Flip, x => (byte) ~x, D.flip<byte>());
            
        }

        public void flip16i()
        {
            VerifyOp(OpKind.Flip, x => (short) ~x, D.flip<short>());
            
        }

        public void flip16u()
        {
            VerifyOp(OpKind.Flip, x => (ushort) ~x, D.flip<ushort>());
            
        }

        public void flip32i()
        {
            VerifyOp(OpKind.Flip, x => ~x, D.flip<int>());

        }

        public void flip32u()
        {
            VerifyOp(OpKind.Flip, x => ~x, D.flip<uint>());

        }

        public void flip64i()
        {
            VerifyOp(OpKind.Flip, x => ~x, D.flip<long>());

        }

        public void flip64u()
        {
            VerifyOp(OpKind.Flip, x => ~x, D.flip<ulong>());              

        }


    }

}
