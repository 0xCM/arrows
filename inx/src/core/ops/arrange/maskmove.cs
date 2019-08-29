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
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;
    using static As;

    partial class dinx
    {
        /// <summary>
        /// _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        /// </summary>
        /// <param name="src"></param>
        /// <param name="mask"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static unsafe void maskmove(in Vec128<sbyte> src, in Vec128<sbyte> mask, ref sbyte dst)
            => MaskMove(src,mask,refptr(ref dst));

        /// <summary>
        /// _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        /// Conditionally stores components from the source vector into memory per the supplied mask
        /// where the hi bit of each corresponding mask component determines whether source component data
        /// is written. If the hi bit is on, component content is written, otherwise it is not
        /// </summary>
        /// <param name="src"></param>
        /// <param name="mask"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static unsafe void maskmove(in Vec128<byte> src, in Vec128<byte> mask, ref byte dst)
            =>  MaskMove(src,mask,refptr(ref dst));


    }

}