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

    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;    
    using static System.Runtime.Intrinsics.X86.Sse41;
     
    using static zfunc;

    partial class dinx
    {
        
        [MethodImpl(Inline)]
        public static Vec128<short> convert(in Vec128<sbyte> src, out Vec128<short> dst)
            => dst = ConvertToVector128Int16(src);
        
        [MethodImpl(Inline)]
        public static Vec128<int> convert(in Vec128<sbyte> src, out Vec128<int> dst)
            => dst = ConvertToVector128Int32(src);

        [MethodImpl(Inline)]
        public static Vec128<long> convert(in Vec128<sbyte> src, out Vec128<long> dst)
            => dst = ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec128<short> convert(in Vec128<byte> src, out Vec128<short> dst)
            =>  dst =ConvertToVector128Int16(src);

        /// <intrinsic>__m128i _mm_cvtepu8_epi32 (__m128i a) PMOVZXBD xmm, xmm/m32</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<int> convert(in Vec128<byte> src, out Vec128<int> dst)
            => dst = ConvertToVector128Int32(src);

        /// <intrinsic>__m128i _mm_cvtepu8_epi64 (__m128i a) PMOVZXBQ xmm, xmm/m16</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<long> convert(in Vec128<byte> src, out Vec128<long> dst)
            => dst = ConvertToVector128Int64(src);

        /// <intrinsic>__m128i _mm_cvtepi16_epi32 (__m128i a) PMOVSXWD xmm, xmm/m64</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<int> convert(in  Vec128<short> src, out Vec128<int> dst)
            => dst = ConvertToVector128Int32(src);

        [MethodImpl(Inline)]
        public static Vec128<long> convert(in Vec128<short> src, out Vec128<long> dst)
            => dst = ConvertToVector128Int64(src);

        //__m128i _mm_cvtepu16_epi32 (__m128i a) PMOVZXWD xmm, xmm/m64
        [MethodImpl(Inline)]
        public static Vec128<int> convert(in Vec128<ushort> src, out Vec128<int> dst)
            => dst = ConvertToVector128Int32(src);

        [MethodImpl(Inline)]
        public static Vec128<long> convert(in Vec128<ushort> src, out Vec128<long> dst)
            => dst = ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec128<long> convert(in Vec128<int> src, out Vec128<long> dst)
            => dst = ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec128<long> convert(in Vec128<uint> src, out Vec128<long> dst)
            => dst = ConvertToVector128Int64(src);

        /// <intrinsic>__m256i _mm256_cvtepi8_epi16 (__m128i a) VPMOVSXBW ymm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<short> convert(in Vec128<sbyte> src, out Vec256<short> dst)
            => dst = ConvertToVector256Int16(src);

        [MethodImpl(Inline)]
        public static Vec256<int> convert(in Vec128<sbyte> src, out Vec256<int> dst)
            => dst = ConvertToVector256Int32(src);

        [MethodImpl(Inline)]
        public static Vec256<long> convert(in Vec128<sbyte> src, out Vec256<long> dst)
            => dst = ConvertToVector256Int64(src);

        [MethodImpl(Inline)]
        public static Vec256<short> convert(in Vec128<byte> src, out Vec256<short> dst)
            =>  dst = ConvertToVector256Int16(src);

        [MethodImpl(Inline)]
        public static Vec256<int> convert(in Vec128<byte> src, out Vec256<int> dst)
            =>  dst = ConvertToVector256Int32(src);

        [MethodImpl(Inline)]
        public static Vec256<long> convert(in Vec128<byte> src, out Vec256<long> dst)
            =>  dst =ConvertToVector256Int64(src);
    
        
        /// <summary>
        /// Projects each 16-bit source component onto the corresponding 32-bit component in the target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <intrinsic>__m256i _mm256_cvtepi16_epi32 (__m128i a) VPMOVSXWD ymm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<int> convert(in Vec128<short> src, out Vec256<int> dst)
            => dst = ConvertToVector256Int32(src);

        /// <summary>
        /// Projects each 32-bit source component onto the corresponding 64-bit component in the target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <intrinsic>__m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<long> convert(in Vec128<int> src, out Vec256<long> dst)
            => dst = ConvertToVector256Int64(src);

        [MethodImpl(Inline)]
        public static Vec256<long> convert(in Vec128<short> src, out Vec256<long> dst)
            => dst = ConvertToVector256Int64(src);

        [MethodImpl(Inline)]
        public static Vec256<int> convert(in Vec128<ushort> src, out Vec256<int> dst)
            => dst = ConvertToVector256Int32(src);

        [MethodImpl(Inline)]
        public static Vec256<long> convert(in Vec128<ushort> src, out Vec256<long> dst)
            => dst = ConvertToVector256Int64(src);


        [MethodImpl(Inline)]
        public static Vec256<long> convert(in Vec128<uint> src, out Vec256<long> dst)
            => dst = ConvertToVector256Int64(src);
    }
}