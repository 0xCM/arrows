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
    
    using static zfunc;
    using static As;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<sbyte> src, ref sbyte dst)
            => Store(refptr(ref dst), src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<byte> src, ref byte dst)
            => Store(refptr(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<short> src, ref short dst)
            => Store(refptr(ref dst), src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ushort> src, ref ushort dst)
            => Store(refptr(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<int> src, ref int dst)
            => Store(refptr(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<uint> src, ref uint dst)
            => Store(refptr(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<long> src, ref long dst)
            => Store(refptr(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ulong> src, ref ulong dst)
            => Store(refptr(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<float> src, ref float dst)
            => Store(refptr(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<double> src, ref double dst)
            => Store(refptr(ref dst), src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<sbyte> src, ref sbyte dst)
            => Store(refptr(ref dst), src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<byte> src, ref byte dst)
            => Store(refptr(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<short> src, ref short dst)
            => Store(refptr(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<ushort> src, ref ushort dst)
            => Store(refptr(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<int> src, ref int dst)
            => Store(refptr(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<uint> src, ref uint dst)
            => Store(refptr(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<long> src, ref long dst)
            => Store(refptr(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<ulong> src, ref ulong dst)
            => Store(refptr(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<float> src, ref float dst)
            => Store(refptr(ref dst),src);            
 
        ///<intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<double> src, ref double dst)
            => Store(refptr(ref dst),src);            
 
        // ///<intrinsic></intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector128<sbyte> src, ref sbyte dst)
        //     => Store(refptr(ref dst), src);            

        // ///<intrinsic></intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector128<byte> src, ref byte dst)
        //     => Store(refptr(ref dst),src);            

        // ///<intrinsic></intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector128<short> src, ref short dst)
        //     => Store(refptr(ref dst), src);            

        // ///<intrinsic></intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector128<ushort> src, ref ushort dst)
        //     => Store(refptr(ref dst),src);            

        // ///<intrinsic></intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector128<int> src, ref int dst)
        //     => Store(refptr(ref dst),src);            

        // ///<intrinsic></intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector128<uint> src, ref uint dst)
        //     => Store(refptr(ref dst),src);            

        // ///<intrinsic></intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector128<long> src, ref long dst)
        //     => Store(refptr(ref dst),src);            

        // ///<intrinsic>void _mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm</intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector128<ulong> src, ref ulong dst)
        //     => Store(refptr(ref dst), src);            

        // ///<intrinsic></intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector128<float> src, ref float dst)
        //     => Store(refptr(ref dst),src);            

        // ///<intrinsic></intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector128<double> src, ref double dst)
        //     => Store(refptr(ref dst), src);            

        // ///<intrinsic></intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector256<sbyte> src, ref sbyte dst)
        //     => Store(refptr(ref dst), src);            

        // ///<intrinsic></intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector256<byte> src, ref byte dst)
        //     => Store(refptr(ref dst),src);            

        // ///<intrinsic></intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector256<short> src, ref short dst)
        //     => Store(refptr(ref dst),src);            

        // ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector256<ushort> src, ref ushort dst)
        //     => Store(refptr(ref dst),src);            

        // ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector256<int> src, ref int dst)
        //     => Store(refptr(ref dst),src);            

        // ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector256<uint> src, ref uint dst)
        //     => Store(refptr(ref dst),src);            

        // ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector256<ulong> src, ref ulong dst)
        //     => Store(refptr(ref dst),src);            

        // ///<intrinsic>void _mm256_storeu_ps (float * mem_addr, __m256 a) MOVUPS m256, ymm</intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector256<float> src, ref float dst)
        //     => Store(refptr(ref dst),src);            

        // ///<intrinsic>void _mm256_storeu_pd (double * mem_addr, __m256d a) MOVUPD m256, ymm</intrinsic>
        // [MethodImpl(Inline)]
        // public static unsafe void store(in Vector256<double> src, ref double dst)
        //     => Store(refptr(ref dst),src);            

    }

}