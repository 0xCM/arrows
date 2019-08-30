//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Bmi2;
    using static System.Runtime.Intrinsics.X86.Bmi2.X64;
 
    using static zfunc;
    using static As;

    partial class dinx
    {                
        /// <summary>
        /// Produces a 16-bit product from two 8-bit operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static ushort mulx(byte a, byte b)
            => (ushort)MultiplyNoFlags(a,b);

        /// <summary>
        /// Produces a 32-bit product from two 16-bit operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static uint mulx(ushort a, ushort b)
            => MultiplyNoFlags(a,b);

        /// <summary>
        /// unsigned int _mulx_u32 (unsigned int a, unsigned int b, unsigned int* hi) MULX r32a, r32b, reg/m32
        /// Produces a 64-bit product from two 32-bit operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <param name="lo">The lo 32 bits of the result</param>
        /// <param name="hi">The hi 32 bits of the result</param>
        [MethodImpl(Inline)]
        public static unsafe void mulx(uint a, uint b, ref uint lo, ref uint hi)
            => hi = MultiplyNoFlags(a, b, refptr(ref lo));

        /// <summary>
        /// unsigned __int64 _mulx_u64 (unsigned __int64 a, unsigned __int64 b, unsigned __int64* hi) MULX r64a, r64b, reg/m64
        /// Produces a 128-bit product from two 64-bit operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <param name="lo">The lo 64 bits of the result</param>
        /// <param name="hi">The hi 64 bits of the result</param>
        [MethodImpl(Inline)]
        public static unsafe void mulx(ulong a, ulong b, ref ulong lo, ref ulong hi)
            => hi = MultiplyNoFlags(a, b, refptr(ref lo));

    }

}
