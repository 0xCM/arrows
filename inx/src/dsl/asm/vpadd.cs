//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static zfunc;
    using static IMM;

    partial class Asm
    {

        static Vector256<int> vpadd_ref1(Vector256<int> v1, Vector256<int> v2)
        {
            return Add(v1,v2);
        }

        static Vec256<int> vpadd_ref2(Vec256<int> v1, Vec256<int> v2)
        {
            return Add(v1,v2);
        }

        public static YMM vpadd(YMM ymm0, YMM ymm1)
        {            
            return Add(vload<long>(ref ymm0),vload<long>(ref ymm1));
        }

        public static ref Vector256<long> vpadd(YMM ymm0, YMM ymm1, ref Vector256<long> dst)
        {            
            dst = Add(vload<long>(ref ymm0),vload<long>(ref ymm1));
            return ref dst;
        }




    }

}