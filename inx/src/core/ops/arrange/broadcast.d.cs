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
    
    using static zfunc;
    using static As;

    partial class dinx
    {
        ///<intrinsic>__m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, m8</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec256<sbyte> broadcast(in sbyte src, out Vec256<sbyte> dst)
        {
            dst = BroadcastScalarToVector256(refptr(ref asRef(in src)));
            return ref dst;
        }

        ///<intrinsic>__m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, m8</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec256<byte> broadcast(in byte src, out Vec256<byte> dst)
        {
            dst = BroadcastScalarToVector256(refptr(ref asRef(in src)));
            return ref dst;
        }
                        
        ///<intrinsic>__m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, m16</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec256<short> broadcast(in short src, out Vec256<short> dst)
        {
            dst = BroadcastScalarToVector256(refptr(ref asRef(in src)));
            return ref dst;
        }

        ///<intrinsic>__m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, m16</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec256<ushort> broadcast(in ushort src, out Vec256<ushort> dst)
        {
            dst = BroadcastScalarToVector256(refptr(ref asRef(in src)));
            return ref dst;
        }

        ///<intrinsic>__m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, m32</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec256<int> broadcast(in int src, out Vec256<int> dst)
        {
            dst = BroadcastScalarToVector256(refptr(ref asRef(in src)));
            return ref dst;
        }

        ///<intrinsic>__m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, m32</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec256<uint> broadcast(in uint src, out Vec256<uint> dst)
        {
            dst = BroadcastScalarToVector256(refptr(ref asRef(in src)));
            return ref dst;
        }

        ///<intrinsic>__m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, m64</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec256<long> broadcast(in long src, out Vec256<long> dst)
        {
            dst = BroadcastScalarToVector256(refptr(ref asRef(in src)));
            return ref dst;
        }

        ///<intrinsic>__m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, m64</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec256<ulong> broadcast(in ulong src, out Vec256<ulong> dst)
        {
            dst = BroadcastScalarToVector256(refptr(ref asRef(in src)));
            return ref dst;
        }

        ///<intrinsic>__m256 _mm256_broadcast_ss (float const * mem_addr) VBROADCASTSS ymm, m32</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec256<float> broadcast(in float src, out Vec256<float> dst)
        {
            dst = BroadcastScalarToVector256(refptr(ref asRef(in src)));
            return ref dst;
        }

        ///<intrinsic>__m256d _mm256_broadcast_sd (double const * mem_addr) VBROADCASTSD ymm, m64</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec256<double> broadcast(in double src, out Vec256<double> dst)
        {
            dst = BroadcastScalarToVector256(refptr(ref asRef(in src)));
            return ref dst;
        }
 
        ///<intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec128<sbyte> broadcast(in sbyte src, out Vec128<sbyte> dst)
        {
            dst = BroadcastScalarToVector128(refptr(ref asRef(in src)));
            return ref dst;
        }

        ///<intrinsic>__m128i _mm_broadcastb_epi8 (__m128i a) VPBROADCASTB xmm, m8</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec128<byte> broadcast(in byte src, out Vec128<byte> dst)
        {
            dst = BroadcastScalarToVector128(refptr(ref asRef(in src)));
            return ref dst;
        }            

        ///<intrinsic>__m128i _mm_broadcastw_epi16 (__m128i a) VPBROADCASTW xmm, m16</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec128<short> broadcast(in short src, out Vec128<short> dst)
        {
            dst = BroadcastScalarToVector128(refptr(ref asRef(in src)));
            return ref dst;
        }

        ///<intrinsic>__m128i _mm_broadcastw_epi16 (__m128i a) VPBROADCASTW xmm, m16</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec128<ushort> broadcast(in ushort src, out Vec128<ushort> dst)
        {
            dst = BroadcastScalarToVector128(refptr(ref asRef(in src)));
            return ref dst;
        }

        ///<intrinsic>__m128i _mm_broadcastd_epi32 (__m128i a) VPBROADCASTD xmm, m32</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec128<int> broadcast(in int src, out Vec128<int> dst)
        {
            dst = BroadcastScalarToVector128(refptr(ref asRef(in src)));
            return ref dst;
        }

        ///<intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec128<uint> broadcast(in uint src, out Vec128<uint> dst)
        {
            dst = BroadcastScalarToVector128(refptr(ref asRef(in src)));
            return ref dst;
        }

        ///<intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec128<long> broadcast(in long src, out Vec128<long> dst)
        {
            dst = BroadcastScalarToVector128(refptr(ref asRef(in src)));
            return ref dst;
        }

        ///<intrinsic>__m128i _mm_broadcastq_epi64 (__m128i a) VPBROADCASTQ xmm, m64</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec128<ulong> broadcast(in ulong src, out Vec128<ulong> dst)
        {
            dst = BroadcastScalarToVector128(refptr(ref asRef(in src)));
            return ref dst;
        }

        ///<intrinsic>__m128 _mm_broadcast_ss (float const * mem_addr) VBROADCASTSS xmm, m32</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec128<float> broadcast(in float src, out Vec128<float> dst)
        {
            dst = BroadcastScalarToVector128(refptr(ref asRef(in src)));
            return ref dst;
        }

        ///<intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec128<double> broadcast(in double src, out Vec128<double> dst)
        {
            dst = Vec128.FromParts(src,src);
            return ref dst;
        }
    }
}