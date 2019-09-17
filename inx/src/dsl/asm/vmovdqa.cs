//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;

    using static zfunc;
    using static As;
    using static Reg;

    unsafe partial class Asm
    {
        /// <summary>
        /// MOVDQA xmm, m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <remarks>See https://www.felixcloutier.com/x86/movdqa:vmovdqa32:vmovdqa64</remarks>
        [MethodImpl(Inline)]
        public unsafe static ref XMM movdqa(in XMM src, ref XMM dst)
            => ref move(load128(in src.First<ulong>()), ref dst);
        
        /// <summary>
        /// MOVDQA xmm, m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <remarks>See https://www.felixcloutier.com/x86/movdqa:vmovdqa32:vmovdqa64</remarks>
        [MethodImpl(Inline)]
        public unsafe static ref XMEM movdqa(in XMM src, ref XMEM dst)
            => ref move(load128(in src.First<ulong>()), ref dst);

        /// <summary>
        /// VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <remarks>See https://www.felixcloutier.com/x86/movdqa:vmovdqa32:vmovdqa64</remarks>
        [MethodImpl(Inline)]
        public unsafe static ref YMM vmovdqa(in YMM src, ref YMM dst)
            => ref move(load256(in src.First<ulong>()), ref dst);
        
        /// <summary>
        /// VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <remarks>See https://www.felixcloutier.com/x86/movdqa:vmovdqa32:vmovdqa64</remarks>
        [MethodImpl(Inline)]
        public unsafe static ref YMEM vmovdqa(in YMM src, ref YMEM dst)
            => ref move(load256(in src.First<ulong>()), ref dst);

        /// <summary>
        /// __m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        static Vector128<ulong> load128(in ulong src)
            => LoadAlignedVector128(constptr(in src));

        /// <summary>
        /// __m256i _mm256_load_si256 (__m256i const * mem_addr) VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        static Vector256<ulong> load256(in ulong src)
            => LoadAlignedVector256(constptr(in src));

    }

}