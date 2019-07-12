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
    
    using static zfunc;    

    partial class x86
    {
        ///<intrinsic>int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static bool _mm_testz_si128(in __m128i a, in __m128i b)
            => TestZ(v64i(a),v64i(b));        



    }

}