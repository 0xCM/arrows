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
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;
    using static Span256;
    using static Span128;
    using static As;
    using static AsInX;

    partial class BitsX
    {

        [MethodImpl(Inline)]
        public static Span128<S> ShiftL<S,T>(this ReadOnlySpan128<S> lhs, ReadOnlySpan128<T> shifts, Span128<S> dst)
            where S : struct
            where T : struct
                => gbits.shiftl(lhs,shifts,dst);

        [MethodImpl(Inline)]
        public static Span256<T> ShiftL<S,T>(this ReadOnlySpan256<T> lhs,  ReadOnlySpan256<S> shifts, Span256<T> dst)
            where T : struct
            where S : struct
                => gbits.shiftl(lhs,shifts,dst);

        /// <summary>
        /// Left-Shifts each element in the source by a unform value and stores the reult in the target
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="count">The number of bits to shift left</param>
        /// <param name="dst">The target operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> ShiftL<T>(this ReadOnlySpan128<T> src, byte count, Span128<T> dst)
            where T : struct
                => gbits.shiftl(src,count,dst);


        /// <summary>
        /// Left-Shifts each element in the source by a unform value and stores the reult in the target
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="count">The number of bits to shift left</param>
        /// <param name="dst">The target operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> ShiftL<T>(this ReadOnlySpan256<T> src, byte count, Span256<T> dst)
            where T : struct
                => gbits.shiftl(src,count,dst);


         [MethodImpl(Inline)]
        public static UInt128 ShiftRW(this UInt128 src, byte offset)
            => Bits.shiftrw(src.ToVec128(), offset).ToUInt128();

        [MethodImpl(Inline)]
        public static UInt128 ShiftLW(this UInt128 src, byte offset)
            => Bits.shiftlw(src.ToVec128(), offset).ToUInt128();

    }
}