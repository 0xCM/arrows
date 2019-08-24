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

    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;
    using static As;

    partial class Bits
    {         
        /// <summary>
        /// _mm256_srai_epi16, avx2, shift right arithmetic:
        /// Applies a rightward arithmetic shift to the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift rightwards</param>
        [MethodImpl(Inline)]
        public static Vec256<short> srai(in Vec256<short> src, byte offset)
            => ShiftRightArithmetic(src, offset);

        /// <summary>
        /// _mm256_srai_epi32, avx2, shift right arithmetic:
        /// Applies a rightward arithmetic shift to the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift rightwards</param>
        [MethodImpl(Inline)]
        public static Vec256<int> srai(in Vec256<int> src, byte offset)
            => ShiftRightArithmetic(src, offset);

        /// <summary>
        /// _mm_srav_epi32, avx2, shift-right variable arithmetic:
        /// Applies a rightward arithmetic shift in each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> srav(in Vec128<int> src, in Vec128<uint> control)
            => ShiftRightArithmeticVariable(src, control);

        /// <summary>
        /// _mm256_srav_epi32, avx2, shift-right variable arithmetic:
        /// Applies a rightward arithmetic shift in each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> srav(in Vec256<int> src, in Vec256<uint> control)
            => ShiftRightArithmeticVariable(src, control);


    }

}