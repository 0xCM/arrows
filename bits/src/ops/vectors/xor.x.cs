//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;
    using static As;
    
    partial class BitsX
    {
        /// <summary>
        /// Computes the bitwise xor of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec128<T> XOr<T>(this Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
                => gbits.xor(in lhs,in rhs);

        /// <summary>
        /// Computes the bitwise xor of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec256<T> XOr<T>(this Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
                => gbits.xor(in lhs,in rhs);
        
        [MethodImpl(Inline)]
        public static ref BlockVector<T> XOr<T>(ref BlockVector<T> lhs, BlockVector<T> rhs)
            where T : struct
        {
            gbits.xor(lhs.Unblocked, rhs.Unblocked);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref BlockMatrix<M,N,T> XOr<M,N,T>(this ref BlockMatrix<M,N,T> lhs, BlockMatrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            gbits.xor(lhs.Unblocked, rhs.Unblocked);
            return ref lhs;
        }
         
  }
}