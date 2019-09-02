//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;

    using static zfunc;
    using D = PrimalDelegates;
    
    public class t_add : UnitTest<t_add>
    {
        public void Add()
        {
            VerifyOp((x,y) => (sbyte)(x + y), D.add<sbyte>());
            VerifyOp((x,y) => (byte)(x + y), D.add<byte>());
            VerifyOp((x,y) => (short)(x + y), D.add<short>());
            VerifyOp((x,y) => (ushort)(x + y), D.add<ushort>());
            VerifyOp((x,y) => (x + y), D.add<int>());
            VerifyOp((x,y) => (x + y), D.add<uint>());
            VerifyOp((x,y) => (x + y), D.add<long>());
            VerifyOp((x,y) => (x + y), D.add<ulong>());
            VerifyOp((x,y) => (x + y), D.add<float>());
            VerifyOp((x,y) => (x + y), D.add<double>());              
        }


        public void addi32_fused()
        {
            var lhsSrc = Random.ReadOnlySpan<int>(Pow2.T10);  
            var lhs = lhsSrc.Replicate();
            var rhs = Random.ReadOnlySpan<int>(lhsSrc.Length);
            math.add(lhs, rhs);           

            var expect = span<int>(lhs.Length);
            for(var i =0; i< lhsSrc.Length; i++)
                expect[i] = lhsSrc[i] + rhs[i];
            
            Claim.yea(lhs.Identical(expect));

        }

        public void addi64_fused()
        {
            var lhsSrc = Random.ReadOnlySpan<long>(Pow2.T10);  
            var lhs = lhsSrc.Replicate();
            var rhs = Random.ReadOnlySpan<long>(lhsSrc.Length);
            math.add(lhs,rhs);

            var expect = span<long>(lhs.Length);
            for(var i =0; i< lhsSrc.Length; i++)
                expect[i] = lhsSrc[i] + rhs[i];
            
            Claim.yea(lhs.Identical(expect));
        }
    }

}

