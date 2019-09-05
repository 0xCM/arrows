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

    public class tv_add : UnitTest<tv_add>
    {

        public void add128()
        {
            Add128<sbyte>();
            Add128<byte>();
            Add128<short>();
            Add128<ushort>();
            Add128<int>();
            Add128<uint>();
            Add128<long>();
            Add128<ulong>();
            Add128<float>();
            Add128<double>();
        }

        public void add256()
        {
            Add256<sbyte>();
            Add256<byte>();
            Add256<short>();
            Add256<ushort>();
            Add256<int>();
            Add256<uint>();
            Add256<long>();
            Add256<ulong>();
            Add256<float>();
            Add256<double>();

        }

        void Add128<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            CpuOpVerify.VerifyBinOp(Random, SampleSize, new Vec128BinOp<T>(ginx.add), gmath.add<T>);
            TypeCaseEnd<T>();
        }

        void Add256<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            CpuOpVerify.VerifyBinOp(Random, SampleSize, new Vec256BinOp<T>(ginx.add), gmath.add<T>);
            TypeCaseEnd<T>();
        }

    }

}