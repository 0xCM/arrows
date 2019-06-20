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
    /// Partial port of Lemire's avx2 SIMD algorithm for PCG
    /// </summary>
    /// <remarks>
    /// See https://github.com/lemire/simdpcg
    /// </remarks>
    public static class simdpcg32
    {
        static readonly m256i M0 = _mm256_set1_epi64x((0x5851f42d4c957f2dul) & 0xffffffffu);
        
        static readonly m256i M1 = _mm256_set1_epi64x(0x5851f42d4c957f2dul >> 32);
        
        static readonly m256i LoMask = _mm256_set1_epi64x(0x00000000ffffffff);
                
        static readonly m256i LoShift = _mm256_set_epi32(7, 7, 7, 7, 6, 4, 2, 0);
        
        static readonly m256i HiShift = _mm256_set_epi32(6, 4, 2, 0, 7, 7, 7, 7);
        
        static readonly m256i I32 = _mm256_set1_epi32(32);


        public class Pcg32Avx
        {
            m256i stateV1;

            m256i stateV2;

            m256i incV1 = default;

            m256i incV2 = default;  

            m256i step()
            {
                (var s0, var s1) = (stateV1, stateV2);


                /* Improve high bits using xorshift step */
                var s0s = _mm256_srli_epi64(s0, 18);
                var s1s = _mm256_srli_epi64(s1, 18);

                var s0x = _mm256_xor_si256(s0s, s0);
                var s1x = _mm256_xor_si256(s1s, s1);

                var s0xs = _mm256_srli_epi64(s0x, 27);
                var s1xs = _mm256_srli_epi64(s1x, 27);

                var xors0 = _mm256_and_si256(LoMask, s0xs);
                var xors1 = _mm256_and_si256(LoMask, s1xs);
            
                // Use high bits to choose a bit-level rotation
                var rot0 = _mm256_srli_epi64(s0, 59);
                var rot1 = _mm256_srli_epi64(s1, 59);        

                /* 64 bit multiplication using 32 bit partial products */
                
                //extract lo and hi words
                var s0_l = _mm256_and_si256(s0, LoMask);
                var s0_h = _mm256_srli_epi64(s0, 32);
                
                //multiply
                var m0_lh = _mm256_mul_epu32(s0_l, M1);
                var m0_hl = _mm256_mul_epu32(s0_h, M0);
                var m0_ll = _mm256_mul_epu32(s0_l, M0);

                //extract lo and hi words
                var s1_l = _mm256_and_si256(s1, LoMask);
                var s1_h = _mm256_srli_epi64(s1, 32);
                
                //multiply
                var m1_lh = _mm256_mul_epu32(s1_l, M1);
                var m1_hl = _mm256_mul_epu32(s1_h, M0);
                var m1_ll = _mm256_mul_epu32(s1_l, M0);

                var m0h = _mm256_add_epi64(m0_hl, m0_lh);
                var m1h = _mm256_add_epi64(m1_hl, m1_lh);

                var m0hs = _mm256_slli_epi64(m0h, 32);
                var m1hs = _mm256_slli_epi64(m1h, 32);

                var s0n = _mm256_add_epi64(m0hs, m0_ll);
                var s1n = _mm256_add_epi64(m1hs, m1_ll);

                /* Assemble lower 32 bits, will be merged into one 256 bit vector below */
                xors0 = _mm256_permutevar8x32_epi32(xors0, LoShift);
                xors1 = _mm256_permutevar8x32_epi32(xors1, HiShift);
                
                rot0 = _mm256_permutevar8x32_epi32(rot0, LoShift);
                rot1 = _mm256_permutevar8x32_epi32(rot1, HiShift);

                var xors = _mm256_or_si256(xors0, xors1);
                var rot = _mm256_or_si256(rot0, rot1);
                            

                stateV1 = _mm256_add_epi64(s0n, incV1);
                stateV2 = _mm256_add_epi64(s1n, incV2);

                /* Finally, rotate and return the result */
                var result =
                    _mm256_or_si256(_mm256_srlv_epi32(xors, rot),
                                    _mm256_sllv_epi32(xors, _mm256_sub_epi32(I32, rot)));

                return result;                        
                
            }


        }


        public class avx2_pcg32_random_t 
        {
            // RNG state.  All values are possible.
            public m256i[] state = new m256i[2]; 
            // Controls which RNG sequence (stream) is selected. Must *always* be odd.
            public m256i[] inc = new m256i[2];   
            // set to _mm256_set1_epi64x(UINT64_C(0x5851f42d4c957f2dULL) & 0xffffffffu);
            public m256i pcg32_mult_l; 
                    
            // set to _mm256_set1_epi64x(UINT64_C(0x5851f42d4c957f2dULL) >> 32);                    
            public m256i pcg32_mult_h; 

        } 

        public class avx256_pcg32_random_t 
        {
            // (8x64bits) RNG state.  All values are possible.
            public m256i state; 
            
            // (8x64bits)Controls which RNG sequences (stream) is selected. Must *always* be odd. You probably want distinct sequences
            public m256i inc;   

            // set to _mm256_set1_epi64x(UINT64_C(0x5851f42d4c957f2d) & 0xffffffff)
            public m256i pcg32_mult_l; 

            // set to _mm256_set1_epi64x(UINT64_C(0x5851f42d4c957f2d) >> 32)
            public m256i pcg32_mult_h; 

        } 

        static m256i step(avx2_pcg32_random_t rng)
        {
            (var s0, var s1) = (rng.state[0], rng.state[1]);

             /* Extract low and high words for partial products below */
            m256i s0_l = _mm256_and_si256(s0, LoMask);
            m256i s0_h = _mm256_srli_epi64(s0, 32);
            m256i s1_l = _mm256_and_si256(s1, LoMask);
            m256i s1_h = _mm256_srli_epi64(s1, 32);

            /* Improve high bits using xorshift step */
            m256i s0s = _mm256_srli_epi64(s0, 18);
            m256i s1s = _mm256_srli_epi64(s1, 18);

            m256i s0x = _mm256_xor_si256(s0s, s0);
            m256i s1x = _mm256_xor_si256(s1s, s1);

            m256i s0xs = _mm256_srli_epi64(s0x, 27);
            m256i s1xs = _mm256_srli_epi64(s1x, 27);

            m256i xors0 = _mm256_and_si256(LoMask, s0xs);
            m256i xors1 = _mm256_and_si256(LoMask, s1xs);
        
            // Use high bits to choose a bit-level rotation
            m256i rot0 = _mm256_srli_epi64(s0, 59);
            m256i rot1 = _mm256_srli_epi64(s1, 59);        

            /* 64 bit multiplication using 32 bit partial products :( */
            m256i m0_hl = _mm256_mul_epu32(s0_h, rng.pcg32_mult_l);
            m256i m1_hl = _mm256_mul_epu32(s1_h, rng.pcg32_mult_l);
            m256i m0_lh = _mm256_mul_epu32(s0_l, rng.pcg32_mult_h);
            m256i m1_lh = _mm256_mul_epu32(s1_l, rng.pcg32_mult_h);

            /* Assemble lower 32 bits, will be merged into one 256 bit vector below */
            xors0 = _mm256_permutevar8x32_epi32(xors0, LoShift);
            rot0 = _mm256_permutevar8x32_epi32(rot0, LoShift);
            xors1 = _mm256_permutevar8x32_epi32(xors1, HiShift);
            rot1 = _mm256_permutevar8x32_epi32(rot1, HiShift);

            /* Continue with partial products */
            m256i m0_ll = _mm256_mul_epu32(s0_l, rng.pcg32_mult_l);
            m256i m1_ll = _mm256_mul_epu32(s1_l, rng.pcg32_mult_l);

            m256i m0h = _mm256_add_epi64(m0_hl, m0_lh);
            m256i m1h = _mm256_add_epi64(m1_hl, m1_lh);

            m256i m0hs = _mm256_slli_epi64(m0h, 32);
            m256i m1hs = _mm256_slli_epi64(m1h, 32);

            m256i s0n = _mm256_add_epi64(m0hs, m0_ll);
            m256i s1n = _mm256_add_epi64(m1hs, m1_ll);

            m256i xors = _mm256_or_si256(xors0, xors1);
            m256i rot = _mm256_or_si256(rot0, rot1);
                        

            rng.state[0] = _mm256_add_epi64(s0n, rng.inc[0]);
            rng.state[1] = _mm256_add_epi64(s1n, rng.inc[1]);

            /* Finally, rotate and return the result */
            m256i result =
                _mm256_or_si256(_mm256_srlv_epi32(xors, rot),
                                _mm256_sllv_epi32(xors, _mm256_sub_epi32(I32, rot)));

            return result;                        
            
        }

        static m256i hacked_mm256_mullo_epi64(m256i x, m256i ml, m256i mh) 
        {
            m256i xl = _mm256_and_si256(x, _mm256_set1_epi64x(0x00000000fffffffful));
            m256i xh = _mm256_srli_epi64(x, 32);
            m256i hl = _mm256_slli_epi64(_mm256_mul_epu32(xh, ml), 32);
            m256i lh = _mm256_slli_epi64(_mm256_mul_epu32(xl, mh), 32);
            m256i ll = _mm256_mul_epu32(xl, ml);
            return _mm256_add_epi64(ll, _mm256_add_epi64(hl, lh));
        }

        static m256i hacked_mm256_rorv_epi32(m256i x, m256i r) 
        {
            return _mm256_or_si256(
                _mm256_sllv_epi32(x, _mm256_sub_epi32(_mm256_set1_epi32(32), r)),
                _mm256_srlv_epi32(x, r));
        }

        static m128i avx256_pcg32_random_r(avx256_pcg32_random_t rng) 
        {
            m256i oldstate = rng.state;
            rng.state = _mm256_add_epi64(hacked_mm256_mullo_epi64(rng.state, rng.pcg32_mult_l, rng.pcg32_mult_h), rng.inc);
            m256i xorshifted = _mm256_srli_epi64(
                _mm256_xor_si256(_mm256_srli_epi64(oldstate, 18), oldstate), 27);
            m256i rot = _mm256_srli_epi64(oldstate, 59);
            return _mm256_castsi256_si128(
                _mm256_permutevar8x32_epi32(hacked_mm256_rorv_epi32(xorshifted, rot),
                                            _mm256_set_epi32(7, 7, 7, 7, 6, 4, 2, 0)));
        }

    }

}