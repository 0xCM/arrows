//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl.Test
{
    using System;
    using System.Linq;

    using static zfunc;
    using static nfunc;
    
    using Z0.Test;

    public class tvml_mul : t_mkl<tvml_mul>
    {
        public void vMulF32()
        {
            var lhs = RVec<float>();
            var rhs = RVec<float>();
            var dst1 = Vector.Alloc<float>(lhs.Length);
            mkl.mul(lhs,rhs, ref dst1);
            
            var dst2 = lhs.Replicate(true);
            gmath.mul(lhs,rhs, dst2.Unblocked);
            Claim.yea(dst1 == dst2);
        }

        public void vMulF64()
        {
            var lhs = Random.NatVec<N256,double>();
            var rhs = Random.NatVec<N256,double>();
            var dst1 = Vector.Alloc<N256,double>();
            mkl.mul(lhs,rhs, ref dst1);
            
            var dst2 = lhs.Replicate(true);
            gmath.mul(lhs.Unsized,rhs.Unsized, dst2.Unsized);
            Claim.yea(dst1 == dst2);
        }

        OpTimePair vMulPerf(int samples, long cycles)
        {
            var lhs1 = RVec<double>(samples);
            var rhs1 = RVec<double>(samples);
            var dst1 = Vector.Alloc<double>(samples);


            var sw1 = stopwatch();
            for(var i=0; i<cycles; i++)
                gmath.mul(lhs1,rhs1, dst1.Unblocked);
            var time1 = OpTime.Define(cycles, snapshot(sw1), "gmath");


            var lhs2 = lhs1.Replicate();
            var rhs2 = rhs1.Replicate();
            var dst2 = dst1.Replicate(true);

            var sw2 = stopwatch();
            for(var i=0; i<cycles; i++)
                mkl.mul(lhs2, rhs2, ref dst2);
            var time2 = OpTime.Define(cycles, snapshot(sw2), "mkl");
            
            return (time1,time2);
        }


        public void vMulPerf1()
        {
            var n = Pow2.T08;
            var i = Pow2.T12;
            TracePerf(vMulPerf(n, i).Format());
            
        }

        public void vMulPerf2()
        {
            var n = Pow2.T08;
            var i = Pow2.T12;
            TracePerf(vMulPerf(n, i).Format());
            
        }

    }

}