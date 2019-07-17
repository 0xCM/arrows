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

    using static zfunc;
    using static As;

    partial class dinxx
    {
        /// <summary>
        /// Calculates the 64-bit product of two 32-bit integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong UMul64(this uint lhs, uint rhs)
            => dinx.umul64(lhs,rhs);

        /// <summary>
        /// Calculates the 128-bit product of two 64-bit integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static UInt128 UMul128(this ulong lhs, ulong rhs)
            => dinx.umul128(lhs,rhs, out UInt128 _);

        [MethodImpl(Inline)]
        public static ref UInt128 UMul128(this ulong lhs, ulong rhs, out UInt128 dst)
        {
            dinx.umul128(lhs,rhs, out dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ulong UMulLo(this ulong lhs, ulong rhs)
            => dinx.umulLo(lhs,rhs);

        [MethodImpl(Inline)]
        public static ulong UMulHi(this ulong lhs, ulong rhs)
            => dinx.umulHi(lhs,rhs);

        [MethodImpl(Inline)]
        public static UInt128 ShiftRW(this in UInt128 src, byte offset)
            => dinx.shiftrw(src.ToVec128(), offset).ToUInt128();

        [MethodImpl(Inline)]
        public static UInt128 ShiftLW(this in UInt128 src, byte offset)
            => dinx.shiftlw(src.ToVec128(), offset).ToUInt128();
    }
}