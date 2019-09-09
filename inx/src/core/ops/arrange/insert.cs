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
        
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse41.X64;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;
    
    partial class dinx
    {
        /// <summary>
        /// _mm_insert_epi8:
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The 0-based index of the component to overwrite</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> insert(byte src, in Vec128<byte> dst, byte index)        
            => Insert(dst,src,index);

        /// <summary>
        /// _mm_insert_epi8: 
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The 0-based index of the component to overwrite</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> insert(sbyte src, in Vec128<sbyte> dst, byte index)        
            => Insert(dst,src,index);

        /// <summary>
        /// __m128i _mm_insert_epi16 (__m128i a, int i, int immediate) PINSRW xmm, reg/m16, imm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The 0-based index of the component to overwrite</param>
        [MethodImpl(Inline)]
        public static Vec128<short> insert(short src, in Vec128<short> dst, byte index)        
            => Insert(dst,src,index);

        /// <summary>
        /// __m128i _mm_insert_epi16 (__m128i a, int i, int immediate) PINSRW xmm, reg/m16, imm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The 0-based index of the component to overwrite</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> insert(ushort src, in Vec128<ushort> dst, byte index)        
            => Insert(dst,src,index);

        /// <summary>
        /// __m128i _mm_insert_epi32 (__m128i a, int i, const int imm8) PINSRD xmm, reg/m32, xmm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The 0-based index of the component to overwrite</param>
        [MethodImpl(Inline)]
        public static Vec128<int> insert(int src, in Vec128<int> dst, byte index)        
            => Insert(dst,src,index);

        /// <summary>
        /// __m128i _mm_insert_epi32 (__m128i a, int i, const int imm8) PINSRD xmm, reg/m32, xmm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The 0-based index of the component to overwrite</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> insert(uint src, in Vec128<uint> dst, byte index)        
            => Insert(dst,src,index);

        /// <summary>
        /// __m128i _mm_insert_epi64 (__m128i a, __int64 i, const int imm8) PINSRQ xmm, reg/m64,imm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The 0-based index of the component to overwrite</param>
        [MethodImpl(Inline)]
        public static Vec128<long> insert(long src, in Vec128<long> dst, byte index)        
            => Insert(dst,src,index);

        /// <summary>
        /// _mm_insert_epi64:
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The 0-based index of the component to overwrite</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> insert(ulong src, in Vec128<ulong> dst, byte index)        
            => Insert(dst,src,index);

        /// <summary>
        /// _mm256_insertf128_si256: Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> insert(in Vec128<sbyte> src, in Vec256<sbyte> dst, byte index)        
            => InsertVector128(dst,src,index);

        /// <summary>
        /// Overwrites the target vector with two 128-bit source vectors
        /// </summary>
        /// <param name="lo">The vector that will be inserted into the lo 128-bit lane of the target</param>
        /// <param name="hi">The vector that will be inserted into the hi 128-bit lane of the target</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<sbyte> insert(in Vec128<sbyte> lo, in Vec128<sbyte> hi,  ref Vec256<sbyte> dst)        
        {
            dst = InsertVector128(InsertVector128(dst, lo, 0),hi, 1);
            return ref dst;
        }

        /// <summary>
        /// _mm256_insertf128_si256: Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> insert(in Vec128<byte> src, in Vec256<byte> dst, byte index)        
            => InsertVector128(dst,src,index);

        /// <summary>
        /// Overwrites the target vector with two 128-bit source vectors
        /// </summary>
        /// <param name="lo">The vector that will be inserted into the lo 128-bit lane of the target</param>
        /// <param name="hi">The vector that will be inserted into the hi 128-bit lane of the target</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<byte> insert(in Vec128<byte> lo, in Vec128<byte> hi,  ref Vec256<byte> dst)        
        {
            dst = InsertVector128(InsertVector128(dst,lo, 0),hi, 1);
            return ref dst;
        }

        /// <summary>
        /// _mm256_insertf128_si256: Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<short> insert(in Vec128<short> src, in Vec256<short> dst, byte index)        
            => InsertVector128(dst,src,index);

        /// <summary>
        /// Overwrites the target vector with two 128-bit source vectors
        /// </summary>
        /// <param name="lo">The vector that will be inserted into the lo 128-bit lane of the target</param>
        /// <param name="hi">The vector that will be inserted into the hi 128-bit lane of the target</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<short> insert(in Vec128<short> lo, in Vec128<short> hi,  ref Vec256<short> dst)        
        {
            dst = InsertVector128(InsertVector128(dst, lo, 0),hi, 1);
            return ref dst;
        }

        /// <summary>
        /// _mm256_insertf128_si256: Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> insert(in Vec128<ushort> src, in Vec256<ushort> dst, byte index)        
            => InsertVector128(dst,src,index);

        /// <summary>
        /// _mm256_insertf128_si256: Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<int> insert(in Vec128<int> src, in Vec256<int> dst, byte index)        
            => InsertVector128(dst,src,index);

        /// <summary>
        /// _mm256_insertf128_si256: Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> insert(in Vec128<uint> src, in Vec256<uint> dst, byte index)        
            => InsertVector128(dst,src,index);

        /// <summary>
        /// _mm256_insertf128_si256: Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<long> insert(in Vec128<long> src, in Vec256<long> dst, byte index)        
            => InsertVector128(dst,src,index);

        /// <summary>
        /// _mm256_insertf128_si256: Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> insert(in Vec128<ulong> src, in Vec256<ulong> dst, byte index)        
            =>  InsertVector128(dst,src,index);

    }
}