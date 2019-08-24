//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
    
    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;
 
    using static zfunc;
    
    public static partial class Bits
    {                
        /// <summary>
        /// _andn_u32
        /// Computes the bitwise and of the left operand and the complement of the right operand
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static byte andn(in byte lhs, in byte rhs) 
            => (byte)AndNot(lhs,rhs);

        /// <summary>
        /// _andn_u32
        /// Computes the bitwise and of the left operand and the complement of the right operand
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ushort andn(in ushort lhs, in ushort rhs)
            => (ushort)AndNot(lhs,rhs);

        /// <summary>
        /// _andn_u32
        /// Computes the bitwise and of the left operand and the complement of the right operand
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static uint andn(in uint lhs, in uint rhs)
            => AndNot(lhs,rhs);

        /// <summary>
        /// _andn_u64
        /// Computes the bitwise and of the left operand and the complement of the right operand
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong andn(in ulong lhs, in ulong rhs)
            => AndNot(lhs,rhs);
    }

}