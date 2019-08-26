namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
        
    using static zfunc;    
    using static x86;

    /// <summary>
    /// Port of https://stackoverflow.com/questions/16822757/sse-integer-division
    /// </summary>
    public static class AvxDiv
    {
        public static __m256i _mm256_div_epi16(in __m256i a_epi16, in __m256i b_epi16)
        {
            __m256 two = _mm256_set1_ps(2.00000051757f);
            
            // Convert to two 32-bit integers
            __m256i a_hi_epi32       = _mm256_srai_epi32(a_epi16, 16);
            __m256i a_lo_epi32_shift = _mm256_slli_epi32(a_epi16, 16);
            __m256i a_lo_epi32       = _mm256_srai_epi32(a_lo_epi32_shift, 16); 
            __m256i b_hi_epi32       = _mm256_srai_epi32(b_epi16, 16); 
            __m256i b_lo_epi32_shift = _mm256_slli_epi32(b_epi16, 16);    
            __m256i b_lo_epi32       = _mm256_srai_epi32(b_lo_epi32_shift, 16); 
        
            // Convert to 32-bit floats
            __m256 a_hi = _mm256_cvtepi32_ps(a_hi_epi32);
            __m256 a_lo = _mm256_cvtepi32_ps(a_lo_epi32);
            __m256 b_hi = _mm256_cvtepi32_ps(b_hi_epi32);
            __m256 b_lo = _mm256_cvtepi32_ps(b_lo_epi32);                                         

            // Calculate the reciprocal
            __m256 b_hi_rcp = _mm256_rcp_ps(b_hi);
            __m256 b_lo_rcp = _mm256_rcp_ps(b_lo);

            // Calculate the inverse
            __m256 b_hi_inv_1 = _mm256_fnmadd_ps(b_hi_rcp, b_hi, two);
            __m256 b_lo_inv_1 = _mm256_fnmadd_ps(b_lo_rcp, b_lo, two);

            // Compensate for the loss
            __m256 b_hi_rcp_1 = _mm256_mul_ps(b_hi_rcp, b_hi_inv_1);
            __m256 b_lo_rcp_1 = _mm256_mul_ps(b_lo_rcp, b_lo_inv_1);

            // Perform the division by multiplication
            __m256 hi = _mm256_mul_ps(a_hi, b_hi_rcp_1);
            __m256 lo = _mm256_mul_ps(a_lo, b_lo_rcp_1);


            // Convert back to integers
            __m256i hi_epi32 = _mm256_cvttps_epi32(hi);
            __m256i lo_epi32 = _mm256_cvttps_epi32(lo);

            __m256i hi_epi32_shift = _mm256_slli_epi32(hi_epi32, 16);
            return _mm256_blend_epi16(lo_epi32, hi_epi32_shift, 0xAA);
        }
    }
}

