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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static zfunc;
    using static Reg;
    using static As;

    partial class Asm
    {

        [MethodImpl(Inline)]
        public static YMM vpermd(YMM src, YMM control)
            => PermuteVar8x32(vload<uint>(ref src), vload<uint>(ref control));


        [MethodImpl(Inline)]
        public static YMM<uint> vpermd(YMM<uint> ymm0, Perm8 spec)
        {
            var control = vload<uint>(ref spec);
            return PermuteVar8x32(ymm0, control);
        }

        [MethodImpl(Inline)]
        public static YMM vpermd(YMM src, Perm8 spec)
        {
            var control = vload<uint>(ref spec);
            var subject = vload<uint>(ref src);
            return PermuteVar8x32(subject, control);
        }


    }


}