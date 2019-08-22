//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zfunc;
    using static Z0.As;
    using static Z0.AsIn;

    partial class xfunc
    {

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector128<sbyte> src, ref sbyte dst)
            => Store(refptr(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector128<byte> src, ref byte dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector128<short> src, ref short dst)
            => Store(refptr(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector128<ushort> src, ref ushort dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector128<int> src, ref int dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector128<uint> src, ref uint dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector128<long> src, ref long dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector128<ulong> src, ref ulong dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector128<float> src, ref float dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector128<double> src, ref double dst)
            => Store(refptr(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector256<sbyte> src, ref sbyte dst)
            => Store(refptr(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector256<byte> src, ref byte dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector256<short> src, ref short dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector256<ushort> src, ref ushort dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector256<int> src, ref int dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector256<uint> src, ref uint dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector256<long> src, ref long dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector256<ulong> src, ref ulong dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_ps (float * mem_addr, __m256 a) MOVUPS m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector256<float> src, ref float dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_pd (double * mem_addr, __m256d a) MOVUPD m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vector256<double> src, ref double dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec128<sbyte> src, ref sbyte dst)
            => Store(refptr(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec128<byte> src, ref byte dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec128<short> src, ref short dst)
            => Store(refptr(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec128<ushort> src, ref ushort dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec128<int> src, ref int dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec128<uint> src, ref uint dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec128<long> src, ref long dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec128<ulong> src, ref ulong dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec128<float> src, ref float dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec128<double> src, ref double dst)
            => Store(refptr(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec256<sbyte> src, ref sbyte dst)
            => Store(refptr(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec256<byte> src, ref byte dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec256<short> src, ref short dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec256<ushort> src, ref ushort dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec256<int> src, ref int dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec256<uint> src, ref uint dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec256<long> src, ref long dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec256<ulong> src, ref ulong dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_ps (float * mem_addr, __m256 a) MOVUPS m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec256<float> src, ref float dst)
            => Store(refptr(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_pd (double * mem_addr, __m256d a) MOVUPD m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo(this Vec256<double> src, ref double dst)
            => Store(refptr(ref dst),src);                


    }    
}
