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
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Fma;        
    
    using static As;
    using static zfunc;    

    
    partial class dfp
    {
        /// <summary>
        /// _mm_round_ps:
        /// Round to nearest integer
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> round(in Vec128<float> src)
            => RoundToNearestInteger(src);

        /// <summary>
        /// _mm_round_pd:
        /// Round to nearest integer
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> round(in Vec128<double> src)
            => RoundToNearestInteger(src);

        /// <summary>
        /// _mm_round_ss:
        /// Round towards zero
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> roundz(in Vec128<float> src)
            => RoundToZero(src);

        /// <summary>
        /// _mm_round_sd:
        /// Round towards zero
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> roundz(in Vec128<double> src)
            => RoundToZero(src);

        /// <summary>
        /// _mm256_round_ps:
        /// Round to nearest integer
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> round(in Vec256<float> src)
            => RoundToNearestInteger(src);

        /// <summary>
        /// _mm256_round_pd:
        /// Round to nearest integer
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> round(in Vec256<double> src)
            => RoundToNearestInteger(src);

        /// <summary>
        /// _mm256_round_ps:
        /// Round towards zero
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> roundz(in Vec256<float> src)
            => RoundToZero(src);

        /// <summary>
        /// _mm256_round_pd:
        /// Round towards zero
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> roundz(in Vec256<double> src)
            => RoundToZero(src);
    }
}