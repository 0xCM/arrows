//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    

    partial class dinx
    {

        /// <summary>
        /// __m128i _mm_cmplt_epi8 (__m128i a, __m128i b) PCMPGTB xmm, xmm/m128
        /// Determines whether the left vector components are less than the right vector components
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> cmplt(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => CompareLessThan(lhs,rhs);

        /// <summary>
        /// __m128i _mm_cmplt_epi16 (__m128i a, __m128i b) PCMPGTW xmm, xmm/m128
        /// Determines whether the left vector components are less than the right vector components
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<short> cmplt(in Vec128<short> lhs, in Vec128<short> rhs)
            => CompareLessThan(lhs,rhs);

        /// <summary>
        /// __m128i _mm_cmplt_epi32 (__m128i a, __m128i b) PCMPGTD xmm, xmm/m128
        /// Determines whether the left vector components are less than the right vector components
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> cmplt(in Vec128<int> lhs, in Vec128<int> rhs)
            => CompareLessThan(lhs,rhs);
 
        [MethodImpl(Inline)]
        public static Vec256<sbyte> cmplt(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => CompareGreaterThan(rhs,lhs);

        [MethodImpl(Inline)]
        public static Vec256<short> cmplt(in Vec256<short> lhs, in Vec256<short> rhs)
            => CompareGreaterThan(rhs,lhs);

        [MethodImpl(Inline)]
        public static Vec256<int> cmplt(in Vec256<int> lhs, in Vec256<int> rhs)
            => CompareGreaterThan(rhs,lhs);

        [MethodImpl(Inline)]
        public static Vec256<long> cmplt(in Vec256<long> lhs, in Vec256<long> rhs)
            => CompareGreaterThan(rhs,lhs);
    }

}