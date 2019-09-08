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

    partial class Asm
    {

        /// <summary>
        /// VEX.256.66.0F38.W0 36 /r VPERMD ymm1, ymm2, ymm3/m256
        /// Permute doublewords in ymm3/m256 using indices in ymm2 and store the result in ymm1.
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        [MethodImpl(Inline)]
        public static YMM vpermd(in YMM src, in YMM control)
            => PermuteVar8x32(vec<uint>(in src), vec<uint>(in control));

        [MethodImpl(Inline)]
        public static YMM vpermd(in YMM src, Perm8 spec)
        {
            var perm = spec.ToPerm();
            var control = YMM.Load(ref perm[0]);
            return vpermd(in src, in control);                        
        }

    }


}