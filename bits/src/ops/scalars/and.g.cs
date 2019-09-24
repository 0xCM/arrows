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
        /// Computes the bitwise AND of two primal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T and<T>(T lhs, T rhs)
            where T : struct
                => gmath.and(lhs,rhs);

        /// <summary>
        /// Computes the bitwise AND of two primal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T and<T>(in T lhs, in T rhs)
            where T : struct
               => gmath.and(lhs, rhs);

        /// <summary>
        /// Computes the bitwise AND of two primal operands and populates a user-suppled 
        /// target with the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T and<T>(in T lhs, in T rhs, ref T dst)
            where T : struct
                => ref gmath.and(in lhs, in rhs, ref dst);

   }    
}