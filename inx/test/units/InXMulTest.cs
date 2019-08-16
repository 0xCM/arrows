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

    public class InXMulTest : UnitTest<InXMulTest>
    {

        void VerifyUMul128Powers()
        {
            for(var i=0; i<=63; i++)
            for(var j=0; j<=63; j++)
            {
                var product = dinx.umul128(1ul << i, 1ul << j, out UInt128 _);
                var bsExpect = BitString.FromPow2(i + j); 
                var bsActual = product.ToBitString();
                Trace($"{product.Format()}");
                Claim.eq(bsExpect,bsActual);                
            }                

        }
        
        OpTime BenchmarkMul256u64(int cycles)
        {
            var sw = stopwatch(false);
            var domain = closed(0ul, UInt32.MaxValue);            
            var counter = 0;
            for(var i=0; i< cycles; i++)
            {
                var x = Random.CpuVec256(domain);
                var y = Random.CpuVec256(domain);
                sw.Start();
                var z = InxOps.mul(x,y);
                sw.Stop();
                counter += 4;
            }

            return (counter, snapshot(sw),"mul256u64:benchmark");
        }

        OpTime BaselineMul256u64(int cycles)
        {
            var sw = stopwatch(false);
            var domain = closed(0ul, UInt32.MaxValue);            
            var counter = 0;
            for(var i=0; i< cycles; i++)
            {
                var x = Random.Span(4, domain);
                var y = Random.Span(4, domain);
                sw.Start();
                var z = x.Mul(y);
                sw.Stop();
                counter += 4;
            }

            return (counter, snapshot(sw),"mul256u64:baseline");
        
        }

        public void RunBenchmarkMul256u64()
        {
            var cycles = Pow2.T16;
            TracePerf(BaselineMul256u64(cycles));
            TracePerf(BenchmarkMul256u64(cycles));
        }
        
        public void VerifyMul256u64()
        {
            void VerifyMul256u64(int blocks)
            {
                BlockSamplesStart(blocks);
                var domain = closed(0ul, UInt32.MaxValue);
                var lhs = Random.Span256<ulong>(blocks, domain);
                var rhs = Random.Span256<ulong>(blocks, domain);
                for(var block=0; block<blocks; block++)
                {
                    var x = lhs.LoadVec256(block);
                    var y = rhs.LoadVec256(block);
                    var z = InxOps.mul(x,y); 

                    var a = x.ToSpan().Replicate();
                    var b = y.ToSpan();
                    var c = a.Mul(b).LoadVec256(0);
                    Claim.eq(z,c);                                           
                }
                BlockSamplesEnd(blocks);
            }

            VerifyMul256u64(DefaltCycleCount);
        }


        public void VerifyUMul64()
        {
            void VerifyUMul64(int samples)
            {
                PointSamplesStart(samples);
                var x = Random.Span<uint>(samples);
                var y = Random.Span<uint>(samples);
                for(var i=0; i< samples; i++)
                {
                    var xi = x[i];
                    var yi = y[i];
                    var z = (ulong)xi * (ulong)yi;
                    Claim.eq(z, UMul.mul(xi,yi));
                }
                PointSamplesEnd(samples);
            }

            VerifyUMul64(Pow2.T12);
        }
    }

}