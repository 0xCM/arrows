//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;    

    partial class x86
    {

        [MethodImpl(Inline)]
        public static unsafe m256i _mm256_set_epi32(
            int x7, int x6, int x5, int x4, int x3, int x2, int x1, int x0 )
                => Vec256.define(x7, x6, x5, x4, x3, x2, x1, x0);


    }

}