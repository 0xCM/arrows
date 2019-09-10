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
            add128_check<sbyte>();
            add128_check<byte>();
            add128_check<short>();
            add128_check<ushort>();
            add128_check<int>();
            add128_check<uint>();
            add128_check<long>();
            add128_check<ulong>();
            add128_check<float>();
            add128_check<double>();
        }

        public void add256()
        {
            add256_check<sbyte>();
            add256_check<byte>();
            add256_check<short>();
            add256_check<ushort>();
            add256_check<int>();
            add256_check<uint>();
            add256_check<long>();
            add256_check<ulong>();
            add256_check<float>();
            add256_check<double>();

        }

        void add128_check<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            CpuOpVerify.VerifyBinOp(Random, SampleSize, new Vec128BinOp<T>(ginx.add), gmath.add<T>);
            TypeCaseEnd<T>();
        }

        void add256_check<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            CpuOpVerify.VerifyBinOp(Random, SampleSize, new Vec256BinOp<T>(ginx.add), gmath.add<T>);
            TypeCaseEnd<T>();
        }

    }

}