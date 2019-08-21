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
    
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse41.X64;
    using static System.Runtime.Intrinsics.X86.Sse42.X64;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;

    partial class dinx
    {
        /// <summary>
        /// _mm_extract_epi8:
        /// Extracts the value from a source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline)]
        public static byte extract(in Vec128<byte> src, byte pos)
            => Extract(src,pos);

        /// <summary>
        /// _mm_extract_epi8:
        /// Extracts the value from a source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline)]
        public static uint extract(in Vec128<ushort> src, byte pos)
            => Extract(src,pos);

        /// <summary>
        /// _mm_extract_epi32:
        /// Extracts the value from a source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline)]
        public static int extract(in Vec128<int> src, byte pos)
            => Extract(src,pos);

        /// <summary>
        /// _mm_extract_epi32:
        /// Extracts the value from a source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline)]
        public static uint extract(in Vec128<uint> src, byte pos)
            => Extract(src,pos);

        /// <summary>
        /// _mm_extract_epi64
        /// Extracts the value from a source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline)]
        public static long extract(in Vec128<long> src, byte pos)
            => Extract(src,pos);

        /// <summary>
        /// _mm_extract_epi64:
        /// Extracts the value from a source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline)]
        public static ulong extract(in Vec128<ulong> src, byte pos)
            => Extract(src,pos);

        /// <summary>
        /// _mm_extract_ps:
        /// Extracts the value from a source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline)]
        public static float extract(in Vec128<float> src, byte pos)
            => Extract(src,pos);

        /// <summary>
        /// _mm256_extractf128_si256:
        /// Extracts either the lo (pos = 0) or hi (pos = 1) 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> extract128(in Vec256<sbyte> src, byte pos)
            => ExtractVector128(src, pos);

        /// <summary>
        /// _mm256_extractf128_si256:
        /// Extracts either the lo (pos = 0) or hi (pos = 1) 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> extract128(in Vec256<byte> src, byte pos)
            => ExtractVector128(src, pos);

        /// <summary>
        /// _mm256_extractf128_si256:
        /// Extracts either the lo (pos = 0) or hi (pos = 1) 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<short> extract128(in Vec256<short> src, byte pos)
            => ExtractVector128(src, pos);

        /// <summary>
        /// _mm256_extractf128_si256:
        /// Extracts either the lo (pos = 0) or hi (pos = 1) 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> extract128(in Vec256<ushort> src, byte pos)
            => ExtractVector128(src, pos);

        /// <summary>
        /// _mm256_extractf128_si256:
        /// Extracts either the lo (pos = 0) or hi (pos = 1) 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<int> extract128(in Vec256<int> src, byte pos)
            => ExtractVector128(src, pos);

        /// <summary>
        /// _mm256_extractf128_si256:
        /// Extracts either the lo (pos = 0) or hi (pos = 1) 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> extract128(in Vec256<uint> src, byte pos)
            => ExtractVector128(src, pos);

        /// <summary>
        /// _mm256_extractf128_si256:
        /// Extracts either the lo (pos = 0) or hi (pos = 1) 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<long> extract128(in Vec256<long> src, byte pos)
            => ExtractVector128(src, pos);

        /// <summary>
        /// _mm256_extractf128_si256:
        /// Extracts either the lo (pos = 0) or hi (pos = 1) 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> extract128(in Vec256<ulong> src, byte pos)
            => ExtractVector128(src, pos);

        /// <summary>
        /// _mm256_extractf128_ps:
        /// Extracts either the lo (pos = 0) or hi (pos = 1) 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<float> extract128(in Vec256<float> src, byte pos)
            => ExtractVector128(src, pos);

        /// <summary>
        /// _mm256_extractf128_pd:
        /// Extracts either the lo (pos = 0) or hi (pos = 1) 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<double> extract128(in Vec256<double> src, byte pos)
            => ExtractVector128(src, pos);

    }
}