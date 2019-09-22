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

        /// <summary>
        /// VEX.256.66.0F38.W0 36 /r VPERMD ymm1, ymm2, ymm3/m256
        /// Permute doublewords in ymm3/m256 using indices in ymm2 and store the result in ymm1.
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vpermd(YMM src, YMM control)
            => PermuteVar8x32(vload<uint>(ref src), vload<uint>(ref control));

        /// <summary>
        /// Reifies a permutation of length 8 from its canonical scalar representative 
        /// </summary>
        /// <param name="rep">The representative</param>
        static Perm<N8> ToPerm(Perm8 rep)
        {
            uint data = (uint)rep;
            var dst = Perm<N8>.Alloc();
            for(int i=0, offset = 0; i<dst.Length; i++, offset +=3)
                dst[i] = (int)BitMask.between(in data, offset, offset + 2);
            return dst;
        }
 

        [MethodImpl(Inline)]
        public static YMM vpermd(YMM src, Perm8 spec)
        {
            var perm = ToPerm(spec);
            var subject = vload<int>(ref src);
            var control = ginx.lddqu256(in perm[0]);            
            return YMM.From(PermuteVar8x32(subject, control));                        
        }

    }


}