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
        
        [MethodImpl(Inline)]
        public static YMM vpaddq(YMM ymm0, YMM ymm1)
        {            
            return Add(vload<ulong>(ref ymm0),vload<ulong>(ref ymm1));
        }

        [MethodImpl(Inline)]
        public static YMM<long> vpaddq(YMM<long> ymm0, YMM<long> ymm1)        
            => Add(ymm0,ymm1);

        [MethodImpl(Inline)]
        public static YMM<ulong> vpaddq(YMM<ulong> ymm0, YMM<ulong> ymm1)        
            => Add(ymm0,ymm1);

        [MethodImpl(Inline)]
        public static ref YMM<long> vpaddq(YMM ymm0, YMM ymm1, ref YMM<long> dst)
        {
            dst = Add(vload<long>(ref ymm0),vload<long>(ref ymm1));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref YMM<ulong> vpaddq(YMM ymm0, YMM ymm1, ref YMM<ulong> dst)
        {
            dst = Add(vload<ulong>(ref ymm0),vload<ulong>(ref ymm1));
            return ref dst;
        }

    }

}