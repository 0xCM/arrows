//-----------------------------------------------------------------------------
// Copymask   :  (c) Chris Moore, 2019
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

    partial class dinx
    {

        /// <summary>
        /// int _mm_testnzc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// IF (a[127:0] AND b[127:0] == 0)
        ///     ZF := 1
        /// ELSE
        ///     ZF := 0
        /// FI
        /// IF ((NOT a[127:0]) AND b[127:0] == 0)
        ///     CF := 1
        /// ELSE
        ///     CF := 0
        /// FI
        /// IF (ZF == 0 && CF == 0)
        ///     dst := 1
        /// ELSE
        ///     dst := 0
        /// FI        
        /// </algorithm>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => TestNotZAndNotC(lhs, rhs);        

        /// <summary>
        /// int _mm_testnzc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => TestNotZAndNotC(lhs, rhs);        

        /// <summary>
        /// int _mm_testnzc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec128<short> lhs, in Vec128<short> rhs)
            => TestNotZAndNotC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testznc(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => TestNotZAndNotC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testznc(in Vec128<int> lhs, in Vec128<int> rhs)
            => TestNotZAndNotC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testznc(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => TestNotZAndNotC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testznc(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => TestNotZAndNotC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testznc(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => TestNotZAndNotC(lhs, rhs);        

        /// <summary>
        /// int _mm256_testnzc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec256<short> lhs, in Vec256<short> rhs)
            => TestNotZAndNotC(lhs, rhs);        

        /// <summary>
        /// int _mm256_testnzc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => TestNotZAndNotC(lhs, rhs);        

        /// <summary>
        /// int _mm256_testnzc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec256<int> lhs, in Vec256<int> rhs)
            => TestNotZAndNotC(lhs, rhs);        

        /// <summary>
        /// int _mm256_testnzc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// IF (a[255:0] AND b[255:0] == 0)
        /// 	ZF := 1
        /// ELSE
        /// 	ZF := 0
        /// FI
        /// IF ((NOT a[255:0]) AND b[255:0] == 0)
        /// 	CF := 1
        /// ELSE
        ///	CF := 0
        /// FI
        /// IF (ZF == 0 && CF == 0)
        /// 	dst := 1
        /// ELSE
        /// 	dst := 0
        /// FI        
        /// </algorithm>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => TestNotZAndNotC(lhs, rhs);        
    }

}