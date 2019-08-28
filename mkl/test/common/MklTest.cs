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
        protected Vector<T> RVec<T>(int? len = null, T rep = default)
            where T : struct
                => Random.GenericVec<T>(len ?? DefaultVectorLength);

        [MethodImpl(Inline)]
        protected Vector<N,T> RVec<N,T>(N len = default, T rep = default)
            where N : ITypeNat, new()
            where T : struct
                => Random.NatVec<N,T>();

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
        protected Matrix<M,N,T> RMat<M,N,T>(Interval<T>? domain = null, M m = default, N n = default)
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
        protected Matrix<N,T> RMat<N,T>(Interval<T>? domain = null, N n = default)
            where T : struct
            where N : ITypeNat, new()
                => Random.Matrix<N,T>(domain);

        [MethodImpl(Inline)]
        protected Vector<float> RVecF32(int len, int? min = null, int? max = null)
            => Random.GenericVec<int,float>(len, closed(min ?? -25, max ?? 25));


        [MethodImpl(Inline)]
        protected Vector<double> RVecF64(int len, long? min = null, long? max = null)
            => Random.GenericVec<long,double>(len, closed(min ?? -25L, max ?? 25L));


        [MethodImpl(Inline)]
        protected Vector<float> RVecF32<N>(N len = default, int? min = null, int? max = null)
            where N : ITypeNat, new()
                => Random.NatVec<N,int,float>(closed(min ?? -25, max ?? 25));


        [MethodImpl(Inline)]
        protected Vector<double> RVecF64<N>(N len = default, long? min = null, long? max = null)
            where N : ITypeNat, new()
                => Random.NatVec<N,long,double>(closed(min ?? -25L, max ?? 25L));


        [MethodImpl(Inline)]
        protected Matrix<N,float> RMatF32<N,S,T>(N n = default, int? min = null, int? max = null)
            where T : struct
            where S : struct
            where N : ITypeNat, new()
                => Random.Matrix<N,int, float>(closed(min ?? -25, max ?? 25));

        [MethodImpl(Inline)]
        protected Matrix<N,double> RMatF64<N,S,T>(N n = default, long? min = null, long? max = null)
            where T : struct
            where S : struct
            where N : ITypeNat, new()
                => Random.Matrix<N,long, double>(closed(min ?? -25L, max ?? 25L));


        [MethodImpl(Inline)]
        protected Matrix<M,N,float> RMatF32<M,N,S,T>(N n = default, int? min = null, int? max = null)
            where T : struct
            where S : struct
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => Random.Matrix<M,N,int, float>(closed(min ?? -25, max ?? 25));


        [MethodImpl(Inline)]
        protected Matrix<M,N,double> RMatF64<M,N,S,T>(N n = default, long? min = null, long? max = null)
            where T : struct
            where S : struct
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => Random.Matrix<M,N,long, double>(closed(min ?? -25L, max ?? 25L));

    }


}