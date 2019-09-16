//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class BitMatrix
    {

        /// <summary>
        /// Computes the bitwise compliement of entries in the source matrix and stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The target matrix</param>
        /// <typeparam name="N">The col dimension type</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<N,T> flip<N,T>(in BitMatrix<N,T> A, ref BitMatrix<N,T> B)        
            where N : ITypeNat, new()
            where T : unmanaged
        {
            gbits.flip(A.Data, B.Data);
            return ref B;
        }

        /// <summary>
        /// Computes the bitwise compliement of entries in the source matrix and stores the
        /// result to a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The target matrix</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The col dimension type</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<M,N,T> flip<M,N,T>(in BitMatrix<M,N,T> A, ref BitMatrix<M,N,T> B)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            gbits.flip(A.Data,B.Data);
            return ref B;
        }

    }

}