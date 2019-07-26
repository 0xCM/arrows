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
    using static AsInX;

    partial class ginxs
    {

        /// <summary>
        /// Computes the bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec128<T> Or<T>(in this Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
                => ginx.or(in lhs,in rhs);

        /// <summary>
        /// Computes the bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec256<T> Or<T>(in this Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
                => ginx.or(in lhs,in rhs);

    }

}