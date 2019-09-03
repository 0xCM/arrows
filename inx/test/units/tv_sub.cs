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

        public void Sub256()
        {
            var blocks = Pow2.T08;
            Sub256<sbyte>(blocks);
            Sub256<byte>(blocks);
            Sub256<short>(blocks);
            Sub256<ushort>(blocks);
            Sub256<int>(blocks);
            Sub256<uint>(blocks);
            Sub256<long>(blocks);
            Sub256<ulong>(blocks);
            Sub256<float>(blocks);
            Sub256<double>(blocks);
        }

        void Sub128<T>(int blocks)
            where T : struct
        {
            TypeCaseStart<T>();
            CpuOpVerify.VerifyBinOp(Polyrand, blocks, new Vec128BinOp<T>(ginx.sub), gmath.sub<T>);
            TypeCaseEnd<T>();
        }

        void Sub256<T>(int blocks)
            where T : struct
        {
            TypeCaseStart<T>();
            CpuOpVerify.VerifyBinOp(Polyrand, blocks, new Vec256BinOp<T>(ginx.sub), gmath.sub<T>);
            TypeCaseEnd<T>();
        }

        void SubSpans256<T>(int len)
            where T : struct
        {
            TypeCaseStart<T>();
            var lhs = Polyrand.Span256<T>(len).ReadOnly();
            var rhs = Polyrand.Span256<T>(len).ReadOnly();
            var dstA = ginx.sub(lhs, rhs, lhs.Replicate());
            var dstB = Span256.AllocBlocks<T>(lhs.BlockCount);
            for(var i = 0; i < dstA.Length; i++)
                dstB[i] = gmath.sub(lhs[i], rhs[i]);
            Claim.yea(dstA.Identical(dstB));
            TypeCaseEnd<T>();
        }


        public void SubSpans256()
        {
            SubSpans256<long>(Pow2.T12);
            SubSpans256<int>(500);
            SubSpans256<byte>(789);
        }

        const int Blocks = Pow2.T08;

        public void Sub128F32()
        {            
            var lhs = Polyrand.Span128<float>(Blocks);
            var rhs = Polyrand.Span128<float>(Blocks);
            var dDst = Span128.AllocBlocks<float>(Blocks);
            var gDst = Span128.AllocBlocks<float>(Blocks);
            Claim.eq(dinxx.Sub(lhs,rhs, dDst), lhs.ReadOnly().Sub(rhs, gDst));
        }

        public void Sub128F64()
        {            
            var lhs = Polyrand.Span128<double>(Blocks);
            var rhs = Polyrand.Span128<double>(Blocks);
            var dDst = Span128.AllocBlocks<double>(Blocks);
            var gDst = Span128.AllocBlocks<double>(Blocks);                
            Claim.eq(dinxx.Sub(lhs, rhs, dDst), lhs.ReadOnly().Sub(rhs, gDst));
        }

    }

}