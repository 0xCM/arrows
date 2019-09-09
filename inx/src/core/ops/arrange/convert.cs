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
     
    using static As;
    using static zfunc;

    partial class dinx
    {
        
        /// <summary>
        /// __m128i _mm_cvtepi8_epi16 (__m128i a) PMOVSXBW xmm, xmm/m64
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ref Vec128<short> convert(in Vec128<sbyte> src, out Vec128<short> dst)
        {
            dst = ConvertToVector128Int16(src);
            return ref dst;
        }
        
        /// <summary>
        /// __m128i _mm_cvtepi8_epi32 (__m128i a) PMOVSXBD xmm, xmm/m32
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ref Vec128<int> convert(in Vec128<sbyte> src, out Vec128<int> dst)
        {
            dst = ConvertToVector128Int32(src);
            return ref dst;
        }
        
        /// <summary>
        /// __m128i _mm_cvtepi8_epi64 (__m128i a) PMOVSXBQ xmm, xmm/m16
        /// Sign-extends packed 8-bit integers in the low 8 bytes of the source vector to packed 
        /// 64-bit integers in the target vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec128<long> convert(in Vec128<sbyte> src, out Vec128<long> dst)
        {
            dst = ConvertToVector128Int64(src);
            return ref dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm, xmm/m64
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ref Vec128<short> convert(in Vec128<byte> src, out Vec128<short> dst)
        {
            dst = ConvertToVector128Int16(src);
            return ref dst;
        }

            
        /// <summary>
        /// __m128i _mm_cvtepu8_epi32 (__m128i a) PMOVZXBD xmm, xmm/m32
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <returns></returns>
        /*
        FOR j := 0 to 3
            i := 32*j
            k := 8*j
            dst[i+31:i] := ZeroExtend(a[k+7:k])
        ENDFOR        
         */
        [MethodImpl(Inline)]
        public static ref Vec128<int> convert(in Vec128<byte> src, out Vec128<int> dst)
        {
            dst = ConvertToVector128Int32(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<uint> convert(in Vec128<byte> src, out Vec128<uint> dst)
        {
            dst = convert(in src, out Vec128<int> _).As<uint>();   
            return ref dst;            
        }

        /// <summary>
        /// __m128i _mm_cvtepi32_epi64 (__m128i a) PMOVSXDQ xmm, xmm/m64
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ref Vec128<long> convert(in Vec128<byte> src, out Vec128<long> dst)
        {
            dst = ConvertToVector128Int64(src);
            return ref dst;
        }

        /// <summary>__m128i _mm_cvtepi16_epi32 (__m128i a) PMOVSXWD xmm, xmm/m64</summary>
        [MethodImpl(Inline)]
        public static Vec128<int> convert(in  Vec128<short> src, out Vec128<int> dst)
            => dst = ConvertToVector128Int32(src);

        /// <summary></summary>
        [MethodImpl(Inline)]
        public static ref Vec128<long> convert(in Vec128<short> src, out Vec128<long> dst)
        {
            dst = ConvertToVector128Int64(src);
            return ref dst;
        }

        /// <summary> __m128i _mm_cvtepu16_epi32 (__m128i a) PMOVZXWD xmm, xmm/m64 </summary>
        [MethodImpl(Inline)]
        public static ref Vec128<int> convert(in Vec128<ushort> src, out Vec128<int> dst)
        {
            dst = ConvertToVector128Int32(src);
            return ref dst;
        }

        /// <summary></summary>
        [MethodImpl(Inline)]
        public static ref Vec128<long> convert(in Vec128<ushort> src, out Vec128<long> dst)
        {
           dst = ConvertToVector128Int64(src);
           return ref dst;
        }

        /// <summary>__m128i _mm_cvtepi32_epi64 (__m128i a) PMOVSXDQ xmm, xmm/m64</summary>
        [MethodImpl(Inline)]
        public static ref Vec128<long> convert(in Vec128<int> src, out Vec128<long> dst)
        {
           dst = ConvertToVector128Int64(src);
           return ref dst;
        }

        /// <summary> __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm, xmm/m64</summary>
        [MethodImpl(Inline)]
        public static ref Vec128<long> convert(in Vec128<uint> src, out Vec128<long> dst)
        {
           dst = ConvertToVector128Int64(src);
           return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<ulong> convert(in Vec128<uint> src, out Vec128<ulong> dst)
        {
            dst = convert(in src, out Vec128<long> _).As<ulong>();
            return ref dst;
        }

        /// <summary>
        /// Sign-extends packed 8-bit integers in the source vector to packed 16-bit integers in the target vector  
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <summary>__m256i _mm256_cvtepi8_epi16 (__m128i a) VPMOVSXBW ymm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static ref Vec256<short> convert(in Vec128<sbyte> src, out Vec256<short> dst)
        {
            dst = ConvertToVector256Int16(src);
            return ref dst;
        }

        /// <summary>
        /// Sign-extends packed 8-bit integers in the source vector to packed 32-bit integers in the target vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<int> convert(in Vec128<sbyte> src, out Vec256<int> dst)
        {
            dst = ConvertToVector256Int32(src);
            return ref dst;
        }

        /// <summary>__m256i _mm256_cvtepi8_epi64 (__m128i a) VPMOVSXBQ ymm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static ref Vec256<long> convert(in Vec128<sbyte> src, out Vec256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return ref dst;
        }
        
        /// <summary>
        /// Zero extends packed unsigned 8-bit integers in the source vector to packed 16-bit integers in the target vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <summary>__m256i _mm256_cvtepu8_epi16 (__m128i a) </summary>
        [MethodImpl(Inline)]
        public static ref Vec256<short> convert(in Vec128<byte> src, out Vec256<short> dst)
        {
            dst = ConvertToVector256Int16(src);
            return ref dst;
        }

        /// <summary>
        /// Zero extends packed unsigned 8-bit integers in the source vector to packed 32-bit integers in the target vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <summary>__m256i _mm256_cvtepu8_epi32 (__m128i a) </summary>
        [MethodImpl(Inline)]
        public static ref Vec256<int> convert(in Vec128<byte> src, out Vec256<int> dst)
        {
            dst = ConvertToVector256Int32(src);
            return ref dst;
        }

        /// <summary>
        /// Zero-extends packed unsigned 8-bit integers in the source vector to packed 64-bit integers in the target vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <summary>__m256i _mm256_cvtepu8_epi64 (__m128i a) </summary>
        [MethodImpl(Inline)]
        public static ref Vec256<long> convert(in Vec128<byte> src, out Vec256<long> dst)
        {
            dst =ConvertToVector256Int64(src);
            return ref dst;
        }

        /// <summary>
        /// Sign-extends packed 16-bit integers in the source vector to packed 32-bit integers in the target vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<int> convert(in Vec128<short> src, out Vec256<int> dst)
        {
            dst = ConvertToVector256Int32(src);
            return ref dst;
        }

        /// <summary>
        /// Sign-extends packed 32-bit integers in the source vector to packed 32-bit integers in the target vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <summary>__m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static ref Vec256<long> convert(in Vec128<int> src, out Vec256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return ref dst;
        }

        /// <summary>
        /// Sign-extends packed 16-bit integers in the source vector to packed 64-bit integers in the target vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <summary>__m256i _mm256_cvtepi16_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static ref Vec256<long> convert(in Vec128<short> src, out Vec256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return ref dst;
        }

        /// <summary>
        /// Zero-extends packed unsigned 16-bit integers in the source vector to packed 32-bit integers in the target vector  
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<int> convert(in Vec128<ushort> src, out Vec256<int> dst)
        {
            dst = ConvertToVector256Int32(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec256<int> convert(ref ushort src, out Vec256<int> dst)
        {
            dst = ConvertToVector256Int32(refptr(ref src));
            return ref dst;
        }

        /// <summary>
        /// Zero-extends packed unsigned 16-bit integers in the source vector to packed 64-bit integers in the target vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<long> convert(in Vec128<ushort> src, out Vec256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec256<long> convert(ref ushort src, out Vec256<long> dst)
        {
            dst = ConvertToVector256Int64(refptr(ref src));
            return ref dst;
        }

        /// <summary>
        /// Zero-extends packed unsigned 32-bit integers in the source vector to packed 64-bit integers in the target vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<long> convert(in Vec128<uint> src, out Vec256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec256<long> convert(ref uint src, out Vec256<long> dst)
        {
            dst = ConvertToVector256Int64(refptr(ref src));
            return ref dst;
        }
    }
}