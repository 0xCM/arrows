//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl.Test
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;
    
    using Z0.Test;

    public abstract class MklTest<U> : UnitTest<U>
        where U : MklTest<U>
    {

        const int DefaultVectorLength = Pow2.T08;

        [MethodImpl(Inline)]
        protected Vector<T> RandomVector<T>(int? len = null)
            where T : struct
                => Random.GenericVector<T>(len ?? DefaultVectorLength);

        [MethodImpl(Inline)]
        protected Vector<N,T> RandomVector<N,T>(N len = default, T rep = default)
            where N : ITypeNat, new()
            where T : struct
                => Random.NatVector<N,T>();

        /// <summary>
        /// Produces a random matrix of natural dimension
        /// </summary>
        /// <param name="m">The row cound</param>
        /// <param name="n">The column count</param>
        /// <param name="rep">A representative scalar value</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        protected Matrix<M,N,T> RandomMatrix<M,N,T>(Interval<T>? domain = null, M m = default, N n = default)
            where T : struct
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => Random.Matrix<M,N,T>(domain);

        /// <summary>
        /// Produces a square random matrix of natural order
        /// </summary>
        /// <param name="n">The square matrix order</param>
        /// <param name="rep">A representative scalar value</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        protected Matrix<N,T> RandomMatrix<N,T>(Interval<T>? domain = null, N n = default)
            where T : struct
            where N : ITypeNat, new()
                => Random.Matrix<N,T>(domain);

    }


}