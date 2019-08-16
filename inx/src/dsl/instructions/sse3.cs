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
    using static System.Runtime.Intrinsics.X86.Sse3;
    
    using static zfunc;    
    using static As;

    partial class x86
    {
        ///<intrinsic>__m128d _mm_addsub_pd (__m128d a, __m128d b) ADDSUBPD xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128d _mm_addsub_pd(__m128d a, __m128d b)
            => AddSubtract(a,b);
        
        ///<intrinsic>__m128 _mm_addsub_ps (__m128 a, __m128 b) ADDSUBPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_addsub_ps(__m128 a, __m128 b)
            => AddSubtract(a,b);
        
        ///<intrinsic>__m128d _mm_hadd_pd (__m128d a, __m128d b) HADDPD xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128d _mm_hadd_pd(__m128d a, __m128d b)
            => HorizontalAdd(a,b);
        
        ///<intrinsic>__m128 _mm_hadd_ps (__m128 a, __m128 b) HADDPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_hadd_ps(__m128 a, __m128 b)
            => HorizontalAdd(a,b);
        
        ///<intrinsic>__m128d _mm_hsub_pd (__m128d a, __m128d b) HSUBPD xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128d _mm_hsub_pd(__m128d a, __m128d b)
            => HorizontalSubtract(a,b);
        
        ///<intrinsic>__m128 _mm_hsub_ps (__m128 a, __m128 b) HSUBPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_hsub_ps(__m128 a, __m128 b)
            => HorizontalSubtract(a,b);
        
        ///<intrinsic>__m128d _mm_loaddup_pd (double const* mem_addr) MOVDDUP xmm, m64</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m128d _mm_loaddup_pd(ref double mem_addr)
            => LoadAndDuplicateToVector128(refptr(ref mem_addr));
        
        ///<intrinsic>__m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_lddqu_si128(ref ulong mem_addr)
            => LoadDquVector128(refptr(ref mem_addr));

        ///<intrinsic>__m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_lddqu_si128(ref uint mem_addr)
            => LoadDquVector128(refptr(ref mem_addr));

        ///<intrinsic>__m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_lddqu_si128(ref ushort mem_addr)
            => LoadDquVector128(refptr(ref mem_addr));

        ///<intrinsic>__m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_lddqu_si128(ref long mem_addr)
            => LoadDquVector128(refptr(ref mem_addr));

        ///<intrinsic>__m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_lddqu_si128(ref short mem_addr)
            => LoadDquVector128(refptr(ref mem_addr));

        ///<intrinsic>__m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_lddqu_si128(ref byte mem_addr)
            => LoadDquVector128(refptr(ref mem_addr));

        ///<intrinsic>__m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_lddqu_si128(ref sbyte mem_addr)
            => LoadDquVector128(refptr(ref mem_addr));

        ///<intrinsic>__m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_lddqu_si128(ref int mem_addr)
            => LoadDquVector128(refptr(ref mem_addr));

        ///<intrinsic>__m128d _mm_movedup_pd (__m128d a) MOVDDUP xmm, xmm/m64</intrinsic>
        [MethodImpl(Inline)]
        public static __m128d _mm_movedup_pd(__m128d a)
            => MoveAndDuplicate(a);

        ///<intrinsic>__m128 _mm_movehdup_ps (__m128 a) MOVSHDUP xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_movehdup_ps(__m128 a)
            => MoveHighAndDuplicate(a);

        ///<intrinsic>__m128 _mm_moveldup_ps (__m128 a) MOVSLDUP xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_moveldup_ps(__m128 a)
            => MoveLowAndDuplicate(a);

    }

}