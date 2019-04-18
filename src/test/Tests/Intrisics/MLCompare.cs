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
        
        public void Warmup()
        {
            var r0 = RunBaseline();
            var r1 = RunMSML();
            var r2 = RunVec128();
            for(var i = 0; i<r1.Length; i++)
            {
                if(r1[i] != r0[i])
                    Claim.fail($"Divergence from baseline, r1{i} = {r1[i]} != r0[{i}] = {r0[i]}");

                // if(r2[i] != r0[i])
                //     Claim.fail($"Divergence from baseline, r2{i} = {r2[i]} != r0[{i}] = {r0[i]}");

            }
        }

        [Repeat(10)]
        public float[] RunBaseline()
        {
            var data = DataSrc.ToArray();
            Span<float> dst = new Span<float>(data);
            for(var i = 0; i < dst.Length; i++)
                dst[i] = dst[i] + 255.50f;
            return data;
        }

        [Repeat(10)]
        public float[] RunVec128()
        {
            var src = DataSrc.ToArray();
            //var dst = array<float>(src.Length);
            var scalar = Num128.define(255.50f);
            for(var i = 0; i< src.Length; i += 4)
            {
                var inVec = Vec128.define(src.ToSpan128(i));
                var outVec = InX.add(inVec,scalar);
            }
            return src;

        }

        [Repeat(10)]
        public float[] RunMSML()
        {
            var data = DataSrc.ToArray();
            Span<float> dst = new Span<float>(data);
            Testing.MSML.AddScalarU(255.50f, dst);
            return data;

        }

    }

}