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
        /// Computes the sum of two matrices and stores the result in a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        /// <typeparam name="M">The natural row count type</typeparam>
        /// <typeparam name="N">The natural column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockMatrix<M,N,T> add<M,N,T>(BlockMatrix<M,N,T> A, BlockMatrix<M,N,T> B, ref BlockMatrix<M,N,T> C)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            ginx.add(A.Unsized, B.Unsized, C.Unsized);
            return ref C;
        }

        /// <summary>
        /// Computes the difference of two matrices and stores the result in a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        /// <typeparam name="M">The natural row count type</typeparam>
        /// <typeparam name="N">The natural column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockMatrix<M,N,T> sub<M,N,T>(BlockMatrix<M,N,T> A, BlockMatrix<M,N,T> B, ref BlockMatrix<M,N,T> C)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            ginx.sub(A.Unsized, B.Unsized, C.Unsized);
            return ref C;
        }

        /// <summary>
        /// Computes the bitwise AND of corresponding matrix entries and stores the result in a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        /// <typeparam name="M">The natural row count type</typeparam>
        /// <typeparam name="N">The natural column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockMatrix<M,N,T> and<M,N,T>(BlockMatrix<M,N,T> A, BlockMatrix<M,N,T> B, ref BlockMatrix<M,N,T> C)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            gbits.and(A.Unsized,B.Unsized, C.Unsized);
            return ref C;
        }

    }


}