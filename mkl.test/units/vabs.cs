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

    public class VAbsTest : UnitTest<VAbsTest>
    {

        public void vabsF32()
        {
            var src = Random.Span<float>(Pow2.T08);
            var dst1 = mkl.vabs(src, src.Replicate().ZeroFill());
            var dst2 = src.Replicate().Abs();
            Claim.eq(dst1,dst2);
        }

        public void vabsF64()
        {
            var src = Random.Span<double>(Pow2.T08);
            var dst1 = mkl.vabs(src, src.Replicate().ZeroFill());
            var dst2 = src.Replicate().Abs();
            Claim.eq(dst1,dst2);
        }

        OpTimePair vabsF32Perf(int samples, long iterations)
        {
            var src = Random.Array<float>(samples);
            var dst1 = array<float>(samples);
            var dst2 = array<float>(samples);
            return measure(iterations, "abs/float/primal", "vabs/float/mkl",
            n => {                
                for(var i=0; i<n; i++)
                    src.Abs(dst1);                    
            },
            n => {
                for(var i=0; i<n; i++)
                    mkl.vabs(src,dst2);
            });   
        }

        OpTimePair vabsF64Perf(int samples, long iterations)
        {
            var src = Random.Array<double>(samples);
            var dst1 = array<double>(samples);
            var dst2 = array<double>(samples);
            return measure(iterations, "abs/double/primal", "vabs/double/mkl",
            n => {                
                for(var i=0; i<n; i++)
                    src.Abs(dst1);                    
            },
            n => {
                for(var i=0; i<n; i++)
                    mkl.vabs(src,dst2);
            });   
        }

        public void vAbsF64Perf()
        {
            var n = Pow2.T08;
            var i = Pow2.T10;
            TracePerf(vabsF64Perf(n, i).Format());
            TracePerf(vabsF32Perf(n, i).Format());
            
        }

    }

}
