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
        public void clmul128()
        {

            for(var i=0; i<DefaultSampleSize; i++)
            {
                var v1 = Random.CpuVec128<ulong>(UInt32.MinValue, UInt32.MaxValue);
                var v2 = Random.CpuVec128<ulong>(UInt32.MinValue, UInt32.MaxValue);
                

                UInt128 x00 = dinx.clmul(in v1, in v2, ClMulMask.X00);
                UInt128 x01 = dinx.clmul(in v1, in v2, ClMulMask.X01);
                UInt128 x10 = dinx.clmul(in v1, in v2, ClMulMask.X10);
                UInt128 x11 = dinx.clmul(in v1, in v2, ClMulMask.X11);

                var y00 = dinx.clmul(v1[0], v2[0]);
                Claim.eq(x00, y00);
                Claim.eq(x00, Bits.clmul_ref(v1[0], v2[0]));

                var y01 = dinx.clmul(v1[1], v2[0]);
                Claim.eq(x01, y01);
                Claim.eq(x01, Bits.clmul_ref(v1[1], v2[0]));

                var y10 = dinx.clmul(v1[0], v2[1]);
                Claim.eq(x10, y10);
                Claim.eq(x10, Bits.clmul_ref(v1[0],v2[1]));

                var y11 = dinx.clmul(v1[1], v2[1]);
                Claim.eq(x11, y11);
                Claim.eq(x11, Bits.clmul_ref(v1[1], v2[1]));
            }
        
        }

        public void mulnew()
        {
            var v1 = Random.CpuVec128<int>();
            var v2 = Random.CpuVec128<int>();
            // var v3 = dinx.insert(v1, Vec256<int>.Zero,0);
            // var v4 = dinx.insert(v2, Vec256<int>.Zero,0);
            var v3 = Vec256.FromParts(1,0,2,0,3,0,4,0);
            var v4 = Vec256.FromParts(5,0,6,0,7,0,8,0);
            var v5 = dinx.mul(v3,v4);
            Trace(() => v3);
            Trace(() => v4);
            Trace(() => v5);

            // var lhs = v1.ToSpan();
            // var rhs = v2.ToSpan();
            // var dst = new long[4];
            // for(var i=0; i<dst.Length; i++)
            //     dst[i] = ((long)lhs[i]) * ((long)rhs[i]);
            
            // var v4 = Vec256.Load(dst);
            // Claim.eq(v3,v4);
        }

        public void mul256_f64()
        {
            mul256f64_check();
        }
        
        public void mul256_u64()
        {
            void VerifyMul256u64(int blocks)
            {
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
            }

            VerifyMul256u64(DefaltCycleCount);
        }

        public void mul256u64_bench()
        {
            Collect(BaselineMul256u64());
            Collect(BenchmarkMul256u64());
        }

        public void umul64()
        {
            void VerifyUMul64(int samples)
            {
                var x = Random.Span<uint>(samples);
                var y = Random.Span<uint>(samples);
                for(var i=0; i< samples; i++)
                {
                    var xi = x[i];
                    var yi = y[i];
                    var z = (ulong)xi * (ulong)yi;
                    Claim.eq(z, UMul.mul(xi,yi));
                }
            }

            VerifyUMul64(Pow2.T12);
        }

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
        
        OpTime BenchmarkMul256u64()
        {
            var sw = stopwatch(false);
            var domain = closed(0ul, UInt32.MaxValue);            
            var counter = 0;
            for(var i=0; i< SampleSize; i++)
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

        OpTime BaselineMul256u64()
        {
            var sw = stopwatch(false);
            var domain = closed(0ul, UInt32.MaxValue);            
            var counter = 0;
            for(var i=0; i< SampleSize; i++)
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

        void mul256f64_check(int cycles = DefaltCycleCount)
        {
            for(var cycle = 0; cycle < cycles; cycle++)
            {
                var domain = closed((long)Int32.MinValue, (long)Int32.MaxValue);
                var src = Random.Stream(domain).Select(x => (double)x);
                var u = Vec256.Load(src.TakeSpan(4));
                var v = Vec256.Load(src.TakeSpan(4));
                var x = dfp.fmul(u,v);
                var y = Vec256.Load(mathspan.mul(u.ToSpan(), v.ToSpan(), v.ToSpan().Replicate(true)));
                Claim.eq(x,y);

                var xi = x.ToSpan().Convert<long>();
                var yi = y.ToSpan().Convert<long>();
                Claim.eq(xi,yi);
            }
        } 
    }
}