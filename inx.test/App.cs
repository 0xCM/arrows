//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{        
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    public class App : TestApp<App>
    {            

        // protected override void RunTests()
        // {
        //     var srcA = items(1,2,3,4,5,6,7,8).ToSpan().ReadOnly();
        //     var srcB = items(8,7,6,5,4,3,2,1).ToSpan().ReadOnly();
        //     var vA = m256i.FromParts(srcA);
        //     var vB = m256i.FromParts(srcB);
        //     var vC = x86._mm_add_epi32(vA, vB);

        //     var a = vA.Part<int>(3);
        //     var b = vB.Part<int>(3);
        //     var c = vC.Part<int>(3);            

        //     print($"{a} + {b} = {c}");

        //     Span<int> aParts = stackalloc int[8];
        //     x86._mm256_storeu_si256(ref aParts[0], in vA);
        //     print($"vA = {aParts.Format()}");
            

        // }

        public static void Main(params string[] args)
            => Run(args);
    }
}