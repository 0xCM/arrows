//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{

    using System;
    using System.Runtime.CompilerServices;
    using static x86;
    using static zfunc;

    using MKL_DC_XMMTYPE = __m128d ;
    using MKL_DC_YMMTYPE = __m256d ;

    /// <summary>
    /// MKL Direct Blas
    /// </summary>
    public static class DBLAS
    {
        [MethodImpl(Inline)]
        public static __m256d MKL_DC_XOR_YMM(in __m256d a, in __m256d b) 
            => _mm256_xor_pd(a,b);

        [MethodImpl(Inline)]
        public static void MKL_DC_SETZERO_YMM()
             => _mm256_setzero_pd();

        // [MethodImpl(Inline)]
        // public static void MKL_DC_LOAD_XMM_S()
        //     => _mm_load_sd();
        
        // [MethodImpl(Inline)]
        // public static void MKL_DC_STORE_XMM_S()
        //     => _mm_store_sd();

        [MethodImpl(Inline)]
        public static __m256d MKL_DC_BCAST_YMM(ref double mem_addr) 
            => _mm256_broadcast_sd(ref mem_addr);

        [MethodImpl(Inline)]
        public static __m256d MKL_DC_LOAD_YMM(ref double mem_addr)
            => _mm256_loadu_pd(ref mem_addr);
        
        [MethodImpl(Inline)]
        public static void MKL_DC_STORE_YMM(ref double mem_addr, in __m256d src) 
            => _mm256_storeu_pd(ref mem_addr,src);

        [MethodImpl(Inline)]
        public static __m256d MKL_DC_ADD_YMM(in __m256d a, in __m256d b) 
            => _mm256_add_pd(in a,in b);
        
        [MethodImpl(Inline)]
        public static __m256d MKL_DC_MUL_YMM(in __m256d a, in __m256d b) 
            => _mm256_mul_pd(in a,in b);
        
        [MethodImpl(Inline)]
        public static void MKL_DC_MASKLOAD_YMM(ref double mem_addr, in __m256d mask) 
            => _mm256_maskload_pd(ref mem_addr, in mask);

        [MethodImpl(Inline)]
        public static void MKL_DC_MASKSTORE_YMM(ref double mem_addr, in __m256d a, in __m256d b)
            => _mm256_maskstore_pd(ref mem_addr, in a, in b);

        [MethodImpl(Inline)]
        public static void MKL_DC_HADD_YMM(in __m256d a, in __m256d b)
            => _mm256_hadd_pd(in a, in b);
        
        [MethodImpl(Inline)]
        public static void MKL_DC_PERM2F128_YMM(in __m256d a, in __m256d b, byte imm8)
            => _mm256_permute2f128_pd(in a, in b, imm8);
        
        [MethodImpl(Inline)]
        public static __m256d MKL_DC_UNPACKHI_YMM(in __m256d a, in __m256d b)
            => _mm256_unpackhi_pd(in a, in b);

        [MethodImpl(Inline)]
        public static __m256d MKL_DC_UNPACKLO_YMM(in __m256d a, in __m256d b)
            => _mm256_unpacklo_pd(in a, in b);

        [MethodImpl(Inline)]
        public static __m128d MKL_DC_CAST_YMM_TO_XMM(in __m256d a)
            => _mm256_castpd256_pd128(a);

        [MethodImpl(Inline)]
        public static __m256d MKL_DC_CAST_XMM_TO_YMM(in __m128d a)
            => _mm256_castpd128_pd256(a);

        [MethodImpl(Inline)]
        public static __m128d MKL_DC_XOR_XMM(in __m128d a, in __m128d b)
            => _mm_xor_pd(in a,in b);
        
        [MethodImpl(Inline)]
        public static __m128d MKL_DC_SETZERO_XMM()
            => _mm_setzero_pd();
        
        [MethodImpl(Inline)]
        public static __m128d MKL_DC_LOAD_XMM(ref double mem_addr)
            => _mm_loadu_pd(ref mem_addr);
        
        [MethodImpl(Inline)]
        public static void MKL_DC_STORE_XMM(ref double mem_addr, in __m128d src)
            => _mm_storeu_pd(ref mem_addr, in src);
        
        [MethodImpl(Inline)]
        public static __m128d MKL_DC_ADD_XMM(in __m128d a, in __m128d b) 
            => _mm_add_pd(a,b);
        
        [MethodImpl(Inline)]
        public static __m128d MKL_DC_MUL_XMM(in __m128d a, in __m128d b)
            => _mm_mul_pd(a,b);
        
        [MethodImpl(Inline)]
        public static __m128d MKL_DC_LOADDUP_XMM(ref double mem_addr) 
            => _mm_loaddup_pd(ref mem_addr);
        
        [MethodImpl(Inline)]
        public static void MKL_DC_ADD_XMM_S(in __m128d a, in __m128d b)
            => _mm_add_sd(a,b);
        
        [MethodImpl(Inline)]
        public static void MKL_DC_MUL_XMM_S(in __m128d a, in __m128d b) 
            => _mm_mul_sd(a, b);

        [MethodImpl(Inline)]
        public static __m128d MKL_DC_UNPACKHI_XMM(in __m128d a, in __m128d b) 
            => _mm_unpackhi_pd(in a, in b);
        
        [MethodImpl(Inline)]
        public static __m128d MKL_DC_UNPACKLO_XMM(in __m128d a, in __m128d b)
            => _mm_unpacklo_pd(in a, in b);

        [MethodImpl(Inline)]
        public static ref __m256d MKL_DC_MUL_ADD_YMM(__m256d ymm_a, __m256d ymm_b, ref __m256d ymm_c)  
        {
            ymm_c = _mm256_fmadd_pd(ymm_a, ymm_b, ymm_c); 
            return ref ymm_c;
        }

        [MethodImpl(Inline)]
        public static ref __m128d MKL_DC_MUL_ADD_XMM_S(__m128d xmm_a, __m128d xmm_b, ref __m128d xmm_c)  
        {
            xmm_c = _mm_fmadd_pd(xmm_a, xmm_b, xmm_c); 
            return ref xmm_c;
        }


        [MethodImpl(Inline)]
        public static void MKL_DC_VEC_TRANSPOSE_YMM(ref __m256d x1, ref __m256d x2, ref __m256d x3, ref __m256d x4)
        {
            var tmp1 = _mm256_unpacklo_pd(x1, x2);             
            var tmp2 = _mm256_unpackhi_pd(x1, x2);             
            var tmp3 = _mm256_unpacklo_pd(x3, x4);             
            var tmp4 = _mm256_unpackhi_pd(x3, x4);             
            x1 = _mm256_permute2f128_pd(tmp1, tmp3, 0b_10_00_00);
            x2 = _mm256_permute2f128_pd(tmp2, tmp4, 0b_10_00_00);
            x3 = _mm256_permute2f128_pd(tmp1, tmp3, 0b_11_00_01);
            x4 = _mm256_permute2f128_pd(tmp2, tmp4, 0b_11_00_01);
        }

        [MethodImpl(Inline)]
        static void MKL_DC_VEC_TRANSPOSE_XMM(out __m128d out1, out __m128d out2, in __m128d in1, in __m128d in2)
        {
            out1 = _mm_unpacklo_pd(in1, in2);       
            out2 = _mm_unpackhi_pd(in1, in2);       
        }


    }
}

