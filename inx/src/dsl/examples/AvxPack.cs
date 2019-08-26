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
        
    using static zfunc;    
    using static x86;

    /// <summary>
    /// Port of a few functions from https://github.com/lemire/simdcomp
    /// </summary>
    public static class AvxPack
    {
        [MethodImpl(Inline)]
        static ref uint add(ref byte src, int offset)            
            => ref Unsafe.As<byte,uint>(ref Unsafe.Add(ref src, offset));

        [MethodImpl(Inline)]
        static ref uint add(ref uint src, int offset)
            => ref add(ref Unsafe.As<uint,byte>(ref src), offset);

        public static readonly __m256i shuf 
            = _mm256_setr_epi8(0, 1, 1, 2, 1, 2, 2, 3, 1, 2, 2, 3, 2, 3, 3, 4, 0, 1, 1, 2, 1, 2, 2, 3, 1, 2, 2, 3, 2, 3, 3, 4);

        public static Span<uint> pack(N1 width, Span<uint> src)
        {
            Span<uint> dst = new uint[8];
            pack(width, ref src[0], ref dst[0]);
            return dst;
        }

        public static void pack(N1 width, ref uint src, ref uint dst)     
        {
            // we are going to pack 256 1-bit values, touching 1 256-bit words, using 16 bytes
            // we are going to touch 1 256-bit word
            __m256i w0 = default;
            w0 = _mm256_lddqu_si256(ref add(ref src, 0));
            w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 1));
            w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 2)), 2));
            w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 3)), 3));
            w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 4)), 4));
            w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 5)), 5));
            w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 6)), 6));
            w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 7)), 7));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 0));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 1));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 2));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 3));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 4));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 5));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 6));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 7));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 0));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 1));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 2));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 3));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 4));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 5));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 6));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 7));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 0));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 1));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 2));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 3));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 4));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 5));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 6));
            // w0 = _mm256_or_si256(w0, _mm256_slli_epi32(_mm256_lddqu_si256(ref add(ref src, 1)), 7)); 
             _mm256_storeu_si256(ref dst, w0);            
        }


    }

}