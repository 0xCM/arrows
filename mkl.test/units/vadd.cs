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
    using static Examples;

    public class VAddTest : UnitTest<VAddTest>
    {

        public void vaddF32()
        {
            var lhs = Random.Span<float>(Pow2.T08);
            var rhs = Random.Span<float>(Pow2.T08);
            var dst1 = mkl.vadd(lhs, rhs, span<float>(Pow2.T08));
            var dst2 = lhs.Replicate().Add(rhs);
            Claim.eq(dst1,dst2);
        }

        public void vaddF64()
        {
            var lhs = Random.Span<double>(Pow2.T08);
            var rhs = Random.Span<double>(Pow2.T08);
            var dst1 = mkl.vadd(lhs, rhs, span<double>(Pow2.T08));
            var dst2 = lhs.Replicate().Add(rhs);
            Claim.eq(dst1,dst2);
        }

        OpTimePair vaddF32Perf(int samples, long iterations)
        {
            var lhs1 = Random.Array<float>(samples);
            var rhs1 = Random.Array<float>(samples);
            var dst1 = array<float>(samples);

            var lhs2 = lhs1.Replicate();
            var rhs2 = rhs1.Replicate();
            var dst2 = array<float>(samples);
            
            return measure(iterations, "add/float/primal", "vadd/float/mkl",
            n => {                
                for(var i=0; i<n; i++)
                    gmath.add<float>(lhs1,rhs1,dst1);
            },
            n => {
                for(var i=0; i<n; i++)
                    mkl.vadd(lhs2, rhs2, dst2);
            });   
        }

        OpTimePair vaddF64Perf(int samples, long iterations)
        {
            var lhs1 = Random.Array<double>(samples);
            var rhs1 = Random.Array<double>(samples);
            var dst1 = array<double>(samples);


            var lhs2 = lhs1.Replicate();
            var rhs2 = rhs1.Replicate();
            var dst2 = array<double>(samples);

            return measure(iterations, "add/double/primal", "vadd/double/mkl",
            n => {                
                for(var i=0; i<n; i++)
                    gmath.add<double>(lhs1,rhs1,dst1);
            },
            n => {
                for(var i=0; i<n; i++)
                    mkl.vadd(lhs2,rhs2, dst2);
            });   
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
