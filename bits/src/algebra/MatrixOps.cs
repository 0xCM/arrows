//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Text;

    using static zfunc;
    using static nfunc;

    partial class Linear
    {
        /// <summary>
        /// Computes the sum of two matrices and stores the result in the left matrix
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        /// <typeparam name="M">The natural row count type</typeparam>
        /// <typeparam name="N">The natural column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<M,N,T> add<M,N,T>(ref Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            ginx.add(lhs.Unsized, rhs.Unsized, lhs.Unsized);
            return ref lhs;
        }

        /// <summary>
        /// Computes the difference of two matrices and stores the result in the left matrix
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        /// <typeparam name="M">The natural row count type</typeparam>
        /// <typeparam name="N">The natural column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<M,N,T> sub<M,N,T>(ref Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            ginx.sub(lhs.Unsized,rhs.Unsized, lhs.Unsized);
            return ref lhs;
        }


    }


}