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


    public class VAddTest : MklTest<VAddTest>
    {

        public void vaddF32()
        {
            var lhs = RandomVector<float>();
            var rhs = RandomVector<float>();
            var dst1 = Vector.Alloc<float>(lhs.Length);
            mkl.add(lhs,rhs, ref dst1);
            
            var dst2 = lhs.Replicate(true);
            gmath.add(lhs,rhs, dst2.Unblocked);
            Claim.yea(dst1 == dst2);
        }

        public void vaddF64()
        {
            var lhs = RandomVector<double>();
            var rhs = RandomVector<double>();
            var dst1 = Vector.Alloc<double>(lhs.Length);
            mkl.add(lhs,rhs,ref dst1);
            
            var dst2 = lhs.Replicate(true);
            gmath.add(lhs, rhs, dst2.Unblocked);
            Claim.yea(dst1 == dst2);
        }


        OpTimePair vaddF32Perf(int samples, long cycles)
        {
            var lhs1 = RandomVector<float>(samples);
            var rhs1 = RandomVector<float>(samples);
            var dst1 = Vector.Alloc<float>(samples);

            var lhs2 = lhs1.Replicate();
            var rhs2 = rhs1.Replicate();
            var dst2 = dst1.Replicate(true);

            var sw1 = stopwatch();
            for(var i=0; i<cycles; i++)
                gmath.add(lhs1,rhs1, dst1.Unblocked);
            var time1 = OpTime.Define(cycles, snapshot(sw1), "gmath");


            var sw2 = stopwatch();
            for(var i=0; i<cycles; i++)
                mkl.add(lhs2, rhs2, ref dst2);
            var time2 = OpTime.Define(cycles, snapshot(sw2), "mkl");
            
            return (time1,time2);
            
        }

        OpTimePair vaddF64Perf(int samples, long cycles)
        {
            var lhs1 = RandomVector<double>(samples);
            var rhs1 = RandomVector<double>(samples);
            var dst1 = Vector.Alloc<double>(samples);


            var sw1 = stopwatch();
            for(var i=0; i<cycles; i++)
                gmath.add(lhs1,rhs1,dst1.Unblocked);
            var time1 = OpTime.Define(cycles, snapshot(sw1), "gmath");


            var lhs2 = lhs1.Replicate();
            var rhs2 = rhs1.Replicate();
            var dst2 = dst1.Replicate(true);

            var sw2 = stopwatch();
            for(var i=0; i<cycles; i++)
                mkl.add(lhs2, rhs2,ref dst2);
            var time2 = OpTime.Define(cycles, snapshot(sw2), "mkl");
            
            return (time1,time2);
        }

        public void vAddF64Perf()
        {
            var n = Pow2.T08;
            var i = Pow2.T12;
            TracePerf(vaddF64Perf(n, i).Format());
            TracePerf(vaddF32Perf(n, i).Format());
            
        }

    }

}
