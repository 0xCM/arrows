//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    
    using static As;
    
    partial class dinx
    {   
        /// <summary>
        /// __m128i _mm_cmpgt_epi8 (__m128i a, __m128i b) PCMPGTB xmm, xmm/m128
        /// Determines whether component values in the left vector are larger than the
        /// corresponding components in the right vector. When a left value is larger 
        /// than a right value, the corresponding component in the result vector 
        /// will have all bits enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// FOR j := 0 to 15
        /// 	i := j*8
        /// 	dst[i+7:i] := ( a[i+7:i] > b[i+7:i] ) ? 0xFF : 0
        /// ENDFOR    
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> cmpgt(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => CompareGreaterThan(lhs,rhs);


        /// <summary>
        /// Determines whether component values in the left vector are larger than the
        /// corresponding components in the right vector. When a left value is larger 
        /// than a right value, the corresponding component in the result vector 
        /// will have all bits enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec128<short> cmpgt(in Vec128<short> lhs, in Vec128<short> rhs)
            => CompareGreaterThan(lhs,rhs);

        /// <summary>
        /// Determines whether component values in the left vector are larger than the
        /// corresponding components in the right vector. When a left value is larger 
        /// than a right value, the corresponding component in the result vector 
        /// will have all bits enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec128<int> cmpgt(in Vec128<int> lhs, in Vec128<int> rhs)
            => CompareGreaterThan(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_cmpgt_epi8 (__m256i a, __m256i b) VPCMPGTB ymm, ymm, ymm/m256
        /// Determines whether component values in the left vector are larger than the
        /// corresponding components in the right vector. When a left value is larger 
        /// than a right value, the corresponding component in the result vector 
        /// will have all bits enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// FOR j := 0 to 31
        /// 	i := j*8
        /// 	dst[i+7:i] := ( a[i+7:i] > b[i+7:i] ) ? 0xFF : 0
        /// ENDFOR
        /// dst[MAX:256] := 0                
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> cmpgt(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => CompareGreaterThan(lhs,rhs);

        /// <summary>
        /// Determines whether component values in the left vector are larger than the
        /// corresponding components in the right vector. When a left value is larger 
        /// than a right value, the corresponding component in the result vector 
        /// will have all bits enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec256<short> cmpgt(in Vec256<short> lhs, in Vec256<short> rhs)
            => CompareGreaterThan(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_cmpgt_epi32 (__m256i a, __m256i b) VPCMPGTD ymm, ymm, ymm/m256
        /// Determines whether component values in the left vector are larger than the
        /// corresponding components in the right vector. When a left value is larger 
        /// than a right value, the corresponding component in the result vector 
        /// will have all bits enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> cmpgt(in Vec256<int> lhs, in Vec256<int> rhs)
            => CompareGreaterThan(lhs,rhs);

        /// <summary>
        ///  __m256i _mm256_cmpgt_epi64 (__m256i a, __m256i b) VPCMPGTQ ymm, ymm, ymm/m256
        /// Determines whether component values in the left vector are larger than the
        /// corresponding components in the right vector. When a left value is larger 
        /// than a right value, the corresponding component in the result vector 
        /// will have all bits enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// FOR j := 0 to 3
        /// 	i := j*64
        /// 	dst[i+63:i] := ( a[i+63:i] > b[i+63:i] ) ? 0xFFFFFFFFFFFFFFFF : 0
        /// ENDFOR
        /// dst[MAX:256] := 0        
        /// <algorithm>
        [MethodImpl(Inline)]
        public static Vec256<long> cmpgt(in Vec256<long> lhs, in Vec256<long> rhs)
            => CompareGreaterThan(lhs,rhs);
   
    }
}