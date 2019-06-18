//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    

    partial class x86
    {
        [MethodImpl(Inline)]
        public static bool _mm_testz_si128(in m128i lhs, in m128i rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool _mm_testz_ps(in m128 lhs, in m128 rhs)
            => TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool _mm_testz_pd(in m128d lhs, in m128d rhs)
            => TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool _mm256_testz_si256(in m256i lhs, in m256i rhs)
            => TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool _mm256_testz_ps(in m256 lhs, in m256 rhs)
            => TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool _mm256_testz_pd(in m256d lhs, in m256d rhs)
            => TestZ(lhs, rhs);        
    }
}