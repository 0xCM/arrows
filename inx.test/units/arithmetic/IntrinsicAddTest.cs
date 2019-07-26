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


    public class IntrinsicAddTest : UnitTest<IntrinsicAddTest>
    {
        void Add128<T>(int blocks)
            where T : struct
        {
            TypeCaseStart<T>();
            InXBinOp.Verify(Random, blocks, new Vec128BinOp<T>(ginx.add), gmath.add<T>);
            TypeCaseEnd<T>();
        }

        void Add256<T>(int blocks)
            where T : struct
        {
            TypeCaseStart<T>();
            InXBinOp.Verify(Random, blocks, new Vec256BinOp<T>(ginx.add), gmath.add<T>);
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

        public void Add256()
        {
            var blocks = Pow2.T08;
            Add256<sbyte>(blocks);
            Add256<byte>(blocks);
            Add256<short>(blocks);
            Add256<ushort>(blocks);
            Add256<int>(blocks);
            Add256<uint>(blocks);
            Add256<long>(blocks);
            Add256<ulong>(blocks);
            Add256<float>(blocks);
            Add256<double>(blocks);

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

        public void Sum1()
        {
            var src = Random.Span<short>(Pow2.T05, closed<short>(-250,250));
            var x = src.Sum();
            var y = src.Sum(NumericSystem.Intrinsic);
            Claim.eq(x,y);            
        }

        public void Sum2()
        {
            var src = Random.Span<int>(Pow2.T08, closed<int>(-250,250));
            var x = src.Sum();
            var y = src.Sum(NumericSystem.Intrinsic);
            Claim.eq(x,y);            
        }

        public void Sum3()
        {
            var src = Random.Span<float>(Pow2.T09, closed<float>(-250,250));
            var x = (int)src.Sum();
            var y = (int)src.Sum(NumericSystem.Intrinsic);
            Claim.eq(x,y);            
        }

        public void Sum4()
        {
            var src = Random.Span<double>(Pow2.T09, closed<double>(-250,250));
            var x = src.Sum().Round(2);
            var y = src.Sum(NumericSystem.Intrinsic).Round(2);
            Claim.eq(x,y);            
        }


    }

}