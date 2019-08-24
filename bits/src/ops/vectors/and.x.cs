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
    
    partial class BitsX
    {
        /// <summary>
        /// Computes the bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> And<T>(this Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
                => gbits.and(in lhs,in rhs);

        /// <summary>
        /// Computes the bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> And<T>(this Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
                => gbits.and(in lhs,in rhs);

        [MethodImpl(Inline)]
        public static ref Matrix<M,N,T> And<M,N,T>(this ref Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            gbits.and(lhs.Unsized,rhs.Unsized, lhs.Unsized);
            return ref lhs;
        }
 
    }
}