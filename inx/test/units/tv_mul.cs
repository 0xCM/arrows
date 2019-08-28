//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class tv_mul : UnitTest<tv_mul>
    {

        void VerifyUMul128Powers()
        {
            for(var i=0; i<=63; i++)
            for(var j=0; j<=63; j++)
            {
                var product = UMul.mul(1ul << i, 1ul << j, out UInt128 _);
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
                var z = dinx.mul(x,y);
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
                    var z = dinx.mul(x,y); 

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

        void MulF64(int cycles = DefaltCycleCount)
        {
            for(var cycle = 0; cycle < cycles; cycle++)
            {
                var domain = closed((long)Int32.MinValue, (long)Int32.MaxValue);
                var src = Random.Stream(domain).Select(x => (double)x);
                var u = Vec256.Load(src.TakeSpan(4));
                var v = Vec256.Load(src.TakeSpan(4));
                var x = dfp.mul(u,v);
                var y = Vec256.Load(gmath.mul(u.ToSpan(), v.ToSpan(), v.ToSpan().Replicate(true)));
                Claim.eq(x,y);

                var xi = x.ToSpan().Convert<long>();
                var yi = y.ToSpan().Convert<long>();
                Claim.eq(xi,yi);
            }

        }

        public void VerifyMulF64()
        {
            MulF64(Pow2.T08);
        }

        static BitVector64 clmul(BitVector64 lhs, BitVector64 rhs)
        {
            var temp1 = lhs;
            var temp2 = rhs;

            var dst = BitVector64.Zero;            
            var tempB = BitVector64.Zero;

            for(var i=0; i<lhs.Length; i++)
            {
                tempB[i] = temp1[0] & temp2[i];
                for(var j = 1; j <i; j++)
                    tempB[i] = tempB[i] ^ (temp1[j] & temp2[i - j]);
                dst[i] = tempB[i];
            }
            return dst;
        }

        public void VerifyClMul()
        {
            var v1 = Vec128.FromParts(1ul, 3ul);
            var v2 = Vec128.FromParts(2ul, 5ul);

            UInt128 x00 = dinx.clmul(in v1, in v2, ClMulMask.X00);
            UInt128 x01 = dinx.clmul(in v1, in v2, ClMulMask.X01);
            UInt128 x10 = dinx.clmul(in v1, in v2, ClMulMask.X10);
            UInt128 x11 = dinx.clmul(in v1, in v2, ClMulMask.X11);

            var y00 = dinx.clmul(v1[0], v2[0]);
            var y10 = dinx.clmul(v1[0], v2[1]);
            var y01 = dinx.clmul(v1[1], v2[0]);
            var y11 = dinx.clmul(v1[1], v2[1]);

            Claim.eq(x00, y00);
            Claim.eq(x01, y01);
            Claim.eq(x10, y10);
            Claim.eq(x11, y11);
        
        }

    }

}