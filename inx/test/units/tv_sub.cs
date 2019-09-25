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


    public class tv_sub : UnitTest<tv_sub>
    {
        public void sub128()
        {
            sub128_check<sbyte>();
            sub128_check<byte>();
            sub128_check<short>();
            sub128_check<ushort>();
            sub128_check<int>();
            sub128_check<uint>();
            sub128_check<long>();
            sub128_check<ulong>();
            sub128_check<float>();
            sub128_check<double>();
        }

        public void sub256()
        {
            sub256_check<sbyte>();
            sub256_check<byte>();
            sub256_check<short>();
            sub256_check<ushort>();
            sub256_check<int>();
            sub256_check<uint>();
            sub256_check<long>();
            sub256_check<ulong>();
            sub256_check<float>();
            sub256_check<double>();
        }

        public void sub256_batch()
        {
            sub256_batch_check<long>();
            sub256_batch_check<int>();
            sub256_batch_check<byte>();
        }

        void sub128_check<T>(int blocks = 0)
            where T : unmanaged
        {
            TypeCaseStart<T>();
            CpuOpVerify.VerifyBinOp(Random, SampleSize, new Vec128BinOp<T>(ginx.sub), gmath.sub<T>);
            TypeCaseEnd<T>();
        }

        void sub256_check<T>(int blocks = 0)
            where T : unmanaged
        {
            TypeCaseStart<T>();
            CpuOpVerify.VerifyBinOp(Random, SampleSize, new Vector256BinOp<T>(ginx.sub), gmath.sub<T>);
            TypeCaseEnd<T>();
        }

        void sub256_batch_check<T>()
            where T : unmanaged
        {
            TypeCaseStart<T>();
            var lhs = Random.Span256<T>(SampleSize).ReadOnly();
            var rhs = Random.Span256<T>(SampleSize).ReadOnly();
            var dstA = ginx.sub(lhs, rhs, lhs.Replicate());
            var dstB = Span256.AllocBlocks<T>(lhs.BlockCount);
            for(var i = 0; i < dstA.Length; i++)
                dstB[i] = gmath.sub(lhs[i], rhs[i]);
            Claim.yea(dstA.Identical(dstB));
            TypeCaseEnd<T>();
        }
    }

}