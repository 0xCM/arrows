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

    using static As;
    using static AsInX;
    using static dinx;
    using static zfunc;

    public static partial class dinxx
    {
        /// <summary>
        /// Computes the sum of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Add<T>(this Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
                => ginx.add(in lhs,in rhs);

        /// <summary>
        /// Computes the sum of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Add<T>(this Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
                => ginx.add(in lhs,in rhs);

        [MethodImpl(Inline)]
        public static Span128<T> Add<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
                => ginx.add(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span256<T> Add<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
                => ginx.add(lhs,rhs,dst); 
    }
}