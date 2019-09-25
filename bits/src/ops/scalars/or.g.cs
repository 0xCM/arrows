//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {
        /// <summary>
        /// Computes the bitwise OR of two primal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T or<T>(T lhs, T rhs)
            where T : unmanaged
                => gmath.or(lhs,rhs);

        [MethodImpl(Inline)]
        public static  T or<T>(in T lhs, in T rhs)
            where T : unmanaged
                => gmath.or(lhs, rhs);

        /// <summary>
        /// Computes the bitwise OR of two primal operands and stores the result in a third operand
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">The target operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T or<T>(in T lhs, in T rhs, ref T dst)
            where T : unmanaged
        {
            dst = gmath.or(lhs,rhs);
            return ref dst;
        }
                

    }
}