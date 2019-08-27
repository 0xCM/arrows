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

    partial class Bits
    {

        /// <summary>
        /// _mm_sllv_epi32, avx2, shift left logical variable:
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> sllv(in Vec128<int> src, in Vec128<uint> control)
            => ShiftLeftLogicalVariable(src, control);

        /// <summary>
        /// _mm_sllv_epi32, avx2, shift left logical variable:
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> sllv(in Vec128<uint> src, in Vec128<uint> control)
            => ShiftLeftLogicalVariable(src, control);

        /// <summary>
        /// _mm_sllv_epi64, avx2, shift left logical variable:
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        [MethodImpl(Inline)]
        public static Vec128<long> sllv(in Vec128<long> src, in Vec128<ulong> control)
            => ShiftLeftLogicalVariable(src, control);

        /// <summary>
        /// _mm_sllv_epi64, avx2, shift left logical variable:
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> sllv(in Vec128<ulong> src, in Vec128<ulong> control)
            => ShiftLeftLogicalVariable(src, control);           

        /// <summary>
        /// mm256_sllv_epi32, avx2, shift left logical variable:
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> sllv(in Vec256<int> src, in Vec256<uint> control)
            => ShiftLeftLogicalVariable(src, control);

        /// <summary>
        /// mm256_sllv_epi32, avx2, shift left logical variable:
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> sllv(in Vec256<uint> src, in Vec256<uint> control)
            => ShiftLeftLogicalVariable(src, control);

        /// <summary>
        /// _mm256_sllv_epi64, avx2, shift left logical variable:
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> sllv(in Vec256<long> src, in Vec256<ulong> control)
            => ShiftLeftLogicalVariable(src, control);

        /// <summary>
        /// _mm256_sllv_epi64, avx2, shift left logical variable:
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> sllv(in Vec256<ulong> src, in Vec256<ulong> control)
            => ShiftLeftLogicalVariable(src, control);  

    }
}