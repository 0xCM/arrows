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


    public class tv_negate : UnitTest<tv_negate>
    {

        void Negate128<T>(int blocks)
            where T : struct
        {
            TypeCaseStart<T>();
            InXOpVerify.VerifyUnaryOp(Random, blocks, new Vec128UnaryOp<T>(ginx.negate), gmath.negate<T>);
            TypeCaseEnd<T>();
        }

        void Negate256<T>(int blocks)
            where T : struct
        {
            TypeCaseStart<T>();
            InXOpVerify.VerifyUnaryOp(Random, blocks, new Vec256UnaryOp<T>(ginx.negate), gmath.negate<T>);
            TypeCaseEnd<T>();
        }

        public void Negate128()
        {
            var blocks = Pow2.T08;
            Negate128<sbyte>(blocks);
            Negate128<byte>(blocks);
            Negate128<short>(blocks);
            Negate128<ushort>(blocks);
            Negate128<int>(blocks);
            Negate128<uint>(blocks);
            Negate128<long>(blocks);
            Negate128<ulong>(blocks);
            Negate128<float>(blocks);
            Negate128<double>(blocks);
        }

        public void Negate256()
        {
            var blocks = Pow2.T08;
            Negate256<sbyte>(blocks);
            Negate256<byte>(blocks);
            Negate256<short>(blocks);
            Negate256<ushort>(blocks);
            Negate256<int>(blocks);
            Negate256<uint>(blocks);
            Negate256<long>(blocks);
            Negate256<ulong>(blocks);
            Negate256<float>(blocks);
            Negate256<double>(blocks);
        }

    }

}