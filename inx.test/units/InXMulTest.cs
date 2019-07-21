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
        public void VerifyUMul128Powers()
        {
            for(var i=0; i<=63; i++)
            for(var j=0; j<=63; j++)
            {
                var dst = dinx.umul128(1ul << i, 1ul << j, out UInt128 _);
                var bsActual = dst.ToBitString();
                var bsExpect = BitString.FromPow2(i + j);
                Claim.eq(bsExpect.Format2(true), bsActual.Format2(true));                
            }                

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
                    var z = dinx.vumul256(x,y); 

                    var a = x.Extract().Replicate();
                    var b = y.Extract();
                    var c = a.Mul(b).LoadVec256(0);
                    Claim.eq(z,c);                                           
                }
                BlockSamplesEnd(blocks);
            }

            VerifyMul256u64(Pow2.T11);
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
                    Claim.eq(z, dinx.umul64(xi,yi));
                }
                PointSamplesEnd(samples);
            }

            VerifyUMul64(Pow2.T12);
        }
    }

}