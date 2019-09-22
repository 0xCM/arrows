//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static zfunc;
    using static Reg;
    
    partial class Asm
    {
        /// <summary>
        /// __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm1, xmm2/m64
        /// Zero extend 8 packed 8-bit integers in the low 8 bytes of xmm2/m64 to 8 packed 16-bit integers in xmm1.
        /// </summary>
        /// <param name="a">The source operand operand</param>
        /// <remarks>See https://www.felixcloutier.com/x86/pmovzx</remarks>
        [MethodImpl(Inline)]
        public static XMM pmovzxbw(XMM a)        
            => ConvertToVector128Int16(vload<byte>(ref a));

        [MethodImpl(Inline)]
        public static Vector128<short> pmovzxbw_ref(Vector128<byte> a)        
            => ConvertToVector128Int16(a);

        /// <summary>
        /// __m128i _mm_cvtepu8_epi32 (__m128i a) PMOVZXBD xmm1, xmm2/m32
        /// Zero extend 4 packed 8-bit integers in the low 4 bytes of xmm2/m32 to 4 packed 32-bit integers in xmm1.
        /// </summary>
        /// <param name="a">The source operand operand</param>
        /// <reference>https://www.felixcloutier.com/x86/pmovzx</reference>
        /// <remarks>Codegen OK</remarks>            
        [MethodImpl(Inline)]
        public static XMM pmovzxbd(XMM a)        
            => ConvertToVector128Int32(vload<byte>(ref a));

        //Codegen OK
        [MethodImpl(Inline)]
        static ref XMM pmovzxbd_out_xmm(XMM a, out XMM dst)        
        {
            dst = ConvertToVector128Int32(vload<byte>(ref a));
            return ref dst;
        }

        //Codegen OK
        [MethodImpl(Inline)]
        static ref Vector128<int> pmovzxbd_out_vec(XMM a, out Vector128<int> dst)        
        {
            dst = ConvertToVector128Int32(vload<byte>(ref a));
            return ref dst;
        }

        //Codegen OK
        [MethodImpl(Inline)]
        static Vector128<int> pmovzxbd_ref(Vector128<byte> a)        
            => ConvertToVector128Int32(a);

        /// <summary>
        /// __m128i _mm_cvtepu8_epi64 (__m128i a) PMOVZXBQ xmm1, xmm2/m16
        /// Zero extend 2 packed 8-bit integers in the low 2 bytes of xmm2/m16 to 2 packed 64-bit integers in xmm1.
        /// </summary>
        /// <param name="a">The source operand operand</param>
        /// <remarks>See https://www.felixcloutier.com/x86/pmovzx</remarks>
        [MethodImpl(Inline)]
        public static XMM pmovzxbq(XMM a)        
            => ConvertToVector128Int64(vload<byte>(ref a));

        /// <summary>
        /// __m128i _mm_cvtepu16_epi32 (__m128i a) PMOVZXWD xmm1, xmm2/m64
        /// Zero extend 4 packed 16-bit integers in the low 8 bytes of xmm2/m64 to 4 packed 32-bit integers in xmm1.
        /// </summary>
        /// <param name="a">The source operand operand</param>
        /// <remarks>See https://www.felixcloutier.com/x86/pmovzx</remarks>
        [MethodImpl(Inline)]
        public static XMM pmovzxwd(XMM a)        
            => ConvertToVector128Int32(vload<ushort>(ref a));

        /// <summary>
        /// __m128i _mm_cvtepu16_epi64 (__m128i a) PMOVZXWQ xmm1, xmm2/m32
        /// Zero extend 2 packed 16-bit integers in the low 4 bytes of xmm2/m32 to 2 packed 64-bit integers in xmm1.
        /// </summary>
        /// <param name="a">The source operand operand</param>
        /// <remarks>See https://www.felixcloutier.com/x86/pmovzx</remarks>
        [MethodImpl(Inline)]
        public static XMM pmovzxwq(XMM a)        
            => ConvertToVector128Int64(vload<ushort>(ref a));

        /// <summary>
        /// __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm1, xmm2/m64
        /// Zero extend 2 packed 32-bit integers in the low 8 bytes of xmm2/m64 to 2 packed 64-bit integers in xmm1.
        /// </summary>
        /// <param name="a">The source operand operand</param>
        /// <remarks>See https://www.felixcloutier.com/x86/pmovzx</remarks>
        [MethodImpl(Inline)]
        public static XMM pmovzxdq(XMM a)        
            => ConvertToVector128Int64(vload<uint>(ref a));

        /// <summary>
        /// __m128i _mm_cvtepu8_epi32 (__m128i a) PMOVZXBD xmm1, xmm2/m32
        /// Zero extend 4 packed 8-bit integers in the low 4 bytes of xmm2/m32 to 4 packed 32-bit integers in xmm1.
        /// </summary>
        /// <param name="a">The source operand operand</param>
        /// <remarks>See https://www.felixcloutier.com/x86/pmovzx</remarks>
        [MethodImpl(Inline)]
        public static XMM pmovzxbd32(XMM a)        
            => ConvertToVector128Int32(vload<byte>(ref a));
      
        /// <summary>
        /// __m128i _mm_cvtepu8_epi64 (__m128i a) PMOVZXBQ xmm1, xmm2/m16
        /// Zero extend 2 packed 8-bit integers in the low 2 bytes of xmm2/m16 to 2 packed 64-bit integers in xmm1.
        /// </summary>
        /// <param name="a">The source operand operand</param>
        /// <remarks>See https://www.felixcloutier.com/x86/pmovzx</remarks>
        [MethodImpl(Inline)]
        public static XMM pmovzxbq64(XMM a)        
            => ConvertToVector128Int64(vload<byte>(ref a));

        /// <summary>
        /// __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm1, xmm2/m64
        /// Zero extend 8 packed 8-bit integers in the low 8 bytes of xmm2/m64 to 8 packed 16-bit integers in xmm1.
        /// </summary>
        /// <param name="a">The source operand operand</param>
        /// <remarks>See https://www.felixcloutier.com/x86/pmovzx</remarks>
        [MethodImpl(Inline)]
        public static XMM pmovzxbw16(XMM a)        
            => ConvertToVector128Int16(vload<byte>(ref a));
    }
}