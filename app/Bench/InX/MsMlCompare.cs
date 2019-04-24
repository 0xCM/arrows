//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using Z0.Testing;
    using Z0.External;

    using static zcore;

    public class AddScalarBench : BinOpBenchmark<float>
    {


        public AddScalarBench(BenchConfig config)
            :base("addScalar",config)
        {

            RawDataSrc = RandomIndex<float>(Settings.Domain<float>(), config.SampleSize);
        }

        float[] RawDataSrc {get;}


        float[] Data()
            => array<float>(RawDataSrc);

        const float ScalarVal = 255.50f;

        public void Validate()
        {
            var r0 = RunBaseline();
            var r1 = RunMSML();
            var r2 = RunVec128();
            var r3 = RunVec128Naive();
            for(var i = 0; i<r1.Length; i++)
            {

                if(r1[i] != r0[i])
                    Claim.fail($"r1[{i}] = {r1[i]} != r0[{i}] = {r0[i]}");

                if(r2[i] != r0[i])
                    Claim.fail($"r2[{i}] = {r2[i]} != r0[{i}] = {r0[i]}");

                if(r3[i] != r0[i])
                    Claim.fail($"r3[{i}] = {r3[i]} != r0[{i}] = {r0[i]}");

            }
        }

        unsafe float[] RunVec128Naive()
        {
            var scalar = Vec128.define(ScalarVal);
            var vecLen = Vec128<float>.Length;
            var src = Data();
            var dst = src;
            fixed(float* pDst = &dst[0])
            {
                float* pDstWalker = pDst;
                for(var i = 0; i< src.Length; i += vecLen, pDstWalker += vecLen)
                {
                    var inVec = Vec128.define(src,i);
                    var outVec = Avx2.Add(inVec,scalar);
                    Avx2.Store(pDstWalker, outVec);

                    //InX.add(inVec,scalar, out Vec128<float> outVec);
                    // for(var j = 0; j < vecLen; j++)
                    //     dst[i + j] = outVec[j];
                }
            }
            return dst;

        }

        float[] RunBaseline()
        {
            var dst = Data();
            for(var i = 0; i < dst.Length; i++)
                dst[i] = dst[i] + ScalarVal;
            return dst;
        }

        float[] RunVec128()
        {
            var dst = Data();
            InXComposites.addScalar(dst,ScalarVal);
            return dst;

        }

        float[] RunMSML()
        {
            
            var dst = Data();
            MsSse.AddScalarU(ScalarVal, dst);
            return dst;
        }

    
        public long Run()
        {
            long msml = 0, v128 = 0;
            // v128 += Measure(() => RunVec128(), "z0/addscalar");
            // msml += Measure(() => RunMSML(), "msml/addscalar");
            // v128 += Measure(() => RunVec128(), "z0/addscalar");
            // msml += Measure(() => RunMSML(), "msml/addscalar");
            // v128 += Measure(() => RunVec128(), "z0/addscalar");
            // msml += Measure(() => RunMSML(), "msml/addscalar");
            // msml += Measure(() => RunMSML(), "msml/addscalar");
            // v128 += Measure(() => RunVec128(), "z0/addscalar");
            // msml += Measure(() => RunMSML(), "msml/addscalar");
            // v128 += Measure(() => RunVec128(), "z0/addscalar");
            // msml += Measure(() => RunMSML(), "msml/addscalar");
            // v128 += Measure(() => RunVec128(), "z0/addscalar");
            // msml += Measure(() => RunMSML(), "msml/addscalar");
            // v128 += Measure(() => RunVec128(), "z0/addscalar");
            trace($"z0: {v128}ms | msml: {msml}ms");
            return v128;
        }

    }

}