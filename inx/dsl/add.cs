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
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;    

    partial class x86
    {
        [MethodImpl(Inline)]
        public static m128i _mm_add_epi8(m128i a, m128i b)
            => Add(v8i(a), v8i(b));

        [MethodImpl(Inline)]
        public static m128i _mm_add_epi16(m128i a, m128i b)
            => Add(v16i(a), v16i(b));

        [MethodImpl(Inline)]
        public static m128i _mm_add_epi32(m128i a, m128i b)
            => Add(v32i(a), v32i(b));

        [MethodImpl(Inline)]
        public static m128i _mm_add_epi64(m128i a, m128i b)
            => Add(v32i(a), v32i(b));

        [MethodImpl(Inline)]
        public static m256i _mm_add_epi8(m256i a, m256i b)
            => Add(v8i(a), v8i(b));

        [MethodImpl(Inline)]
        public static m256i _mm_add_epi16(m256i a, m256i b)
            => Add(v16i(a), v16i(b));

        [MethodImpl(Inline)]
        public static m256i _mm_add_epi32(m256i a, m256i b)
            => Add(v32i(a), v32i(b));

        [MethodImpl(Inline)]
        public static m256i _mm_add_epi64(m256i a, m256i b)
            => Add(v32i(a), v32i(b));
    }

}