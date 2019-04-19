//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InXTests
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

    using static zcore;

    using P = Paths;

    [DisplayName(Path)]
    public class MLCompare : InXTest<MLCompare,float>
    {

        public const string Path = P.InX128 + P.perf + "mlcompare/";

        public MLCompare()
            : base("+=")
        {

            DataSrc = RandList(Pow2.T22);
        }

        IReadOnlyList<float> DataSrc {get;}
        

        const float ScalarVal = 255.50f;

        public void Validate()
        {
            var r0 = RunBaseline();
            var r1 = RunMSML();
            var r2 = RunVec128MSML();
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

        [Repeat(10)]
        public float[] RunBaseline()
        {
            var data = DataSrc.ToArray();
            Span<float> dst = new Span<float>(data);
            for(var i = 0; i < dst.Length; i++)
                dst[i] = dst[i] + ScalarVal;
            return data;
        }

        [Repeat(10)]
        public float[] RunVec128Naive()
        {
            var src = DataSrc.ToArray();
            var scalar = Vec128.define(ScalarVal);
            var vecLen = Vec128<float>.Length;
            var dst = new float[src.Length];
            for(var i = 0; i< src.Length; i += vecLen)
            {
                var inVec = Vec128.define(src.ToSpan128(i));
                var outVec = InX.add(inVec,scalar);
                for(var j = 0; j < vecLen; j++)
                    dst[i + j] = outVec[j];
            }
            return dst;

        }

        [Repeat(10)]
        public float[] RunMSML()
        {
            var data = DataSrc.ToArray();
            Span<float> dst = new Span<float>(data);
            Testing.MSML.AddScalarU(ScalarVal, dst);
            return data;

        }

        [Repeat(10)]
        public float[] RunVec128MSML()
        {
            var data = DataSrc.ToArray();
            Span<float> dst = new Span<float>(data);
            InXComposites.addScalar(dst,ScalarVal);
            return data;

        }

    }

}