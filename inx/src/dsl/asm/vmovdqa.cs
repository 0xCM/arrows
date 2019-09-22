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
        public unsafe static ref XMM movdqa(XMM src, ref XMM dst)
        {
            dst = vload<ulong>(ref src);
            return ref dst;
        }
        
        /// <summary>
        /// MOVDQA xmm, m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <remarks>See https://www.felixcloutier.com/x86/movdqa:vmovdqa32:vmovdqa64</remarks>
        [MethodImpl(Inline)]
        public unsafe static ref XMEM movdqa(XMM src, ref XMEM dst)
        {
            dst = vload<ulong>(ref src);
            return ref dst;
        }

        /// <summary>
        /// VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <remarks>See https://www.felixcloutier.com/x86/movdqa:vmovdqa32:vmovdqa64</remarks>
        [MethodImpl(Inline)]
        public unsafe static ref YMM vmovdqa(YMM src, ref YMM dst)
        {
            dst = vload<ulong>(ref src);
            return ref dst;
        }
        
        /// <summary>
        /// VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <remarks>See https://www.felixcloutier.com/x86/movdqa:vmovdqa32:vmovdqa64</remarks>
        [MethodImpl(Inline)]
        public unsafe static ref YMEM vmovdqa(YMM src, ref YMEM dst)
        {
            dst = vload<ulong>(ref src);
            return ref dst;
        }


    }

}