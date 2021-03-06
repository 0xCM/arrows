//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;
    
    using Z0.Test;

    public abstract class t_mkl<U> : UnitTest<U>
        where U : t_mkl<U>
    {
        const int DefaultVectorLength = Pow2.T08;

        [MethodImpl(Inline)]
        protected BlockVector<T> RVec<T>(int? len = null, T rep = default)
            where T : struct
                => Random.BlockVec<T>(len ?? DefaultVectorLength);

        [MethodImpl(Inline)]
        protected BlockVector<N,T> RVec<N,T>(N len = default, T rep = default)
            where N : ITypeNat, new()
            where T : struct
                => Random.BlockVec<N,T>();

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
        protected BlockMatrix<M,N,T> RMat<M,N,T>(Interval<T>? domain = null, M m = default, N n = default)
            where T : struct
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => Random.BlockMatrix<M,N,T>(domain);

        [MethodImpl(Inline)]
        protected BlockVector<float> RVecF32(int len, int? min = null, int? max = null)
            => Random.BlockVec<int,float>(len, closed(min ?? -25, max ?? 25));

        [MethodImpl(Inline)]
        protected BlockVector<double> RVecF64(int len, long? min = null, long? max = null)
            => Random.BlockVec<long,double>(len, closed(min ?? -25L, max ?? 25L));

        [MethodImpl(Inline)]
        protected BlockVector<float> RVecF32<N>(N len = default, int? min = null, int? max = null)
            where N : ITypeNat, new()
                => Random.BlockVec<N,int,float>(closed(min ?? -25, max ?? 25));

        [MethodImpl(Inline)]
        protected BlockVector<double> RVecF64<N>(N len = default, long? min = null, long? max = null)
            where N : ITypeNat, new()
                => Random.BlockVec<N,long,double>(closed(min ?? -25L, max ?? 25L));
    }
}