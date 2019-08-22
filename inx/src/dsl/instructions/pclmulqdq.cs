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
    using static System.Runtime.Intrinsics.X86.Pclmulqdq;
    
    using static zfunc; 
    using static As;

    partial class x86
    {
        [MethodImpl(Inline)]
        public static __m128i _mm_clmulepi64_si128(__m128i a, __m128i b, byte imm8)
            => CarrylessMultiply(v64u(a), v64u(b), imm8);

    }

}