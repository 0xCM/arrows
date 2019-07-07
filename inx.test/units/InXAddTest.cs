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


    public class InXAddTest : UnitTest<InXAddTest>
    {
        void Add128<T>(int blocks)
            where T : struct
        {
            TypeCaseStart<T>();
            InXBinOp.Verify(Random, blocks, new Vec128BinOp<T>(ginx.add), gmath.add<T>);
            TypeCaseEnd<T>();
        }

        void Sub128<T>(int blocks)
            where T : struct
        {
            TypeCaseStart<T>();
            InXBinOp.Verify(Random, blocks, new Vec128BinOp<T>(ginx.sub), gmath.sub<T>);
            TypeCaseEnd<T>();
        }

        public void Add128()
        {

            var blocks = Pow2.T08;
            Add128<sbyte>(blocks);
            Add128<byte>(blocks);
            Add128<short>(blocks);
            Add128<ushort>(blocks);
            Add128<int>(blocks);
            Add128<uint>(blocks);
            Add128<long>(blocks);
            Add128<ulong>(blocks);
            Add128<float>(blocks);
            Add128<double>(blocks);

        }

        public void Sub128()
        {
            var blocks = Pow2.T08;
            Sub128<sbyte>(blocks);
            Sub128<byte>(blocks);
            Sub128<short>(blocks);
            Sub128<ushort>(blocks);
            Sub128<int>(blocks);
            Sub128<uint>(blocks);
            Sub128<long>(blocks);
            Sub128<ulong>(blocks);
            Sub128<float>(blocks);
            Sub128<double>(blocks);

        }

    }

}