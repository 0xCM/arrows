//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using static zcore;
    using static Traits;


    public static class Matrix
    {
        
        [MethodImpl(Inline)]
        public static Matrix<M, P, T> mul<M,N,P,T>(Matrix<N, N, T> lhs, Matrix<N, P, T> rhs)
            where M : TypeNat, new()
            where N : TypeNat, new()
            where P : TypeNat, new()
            where T : Structures.Semiring<T>, new()
        {            
            var m = Prove.claim<M>(rhs.dim().i);
            var p = Prove.claim<P>(rhs.dim().j);
            var product = new T[m*p];
            for(var i = 0u; i< m; i++)
                for(var j =0u; j< p; j++)
                    product[i] = Covector.apply(lhs.covector(i), rhs.vector(j));
            return Matrix.define<M,P,T>(product);
        }

        /// <summary>
        /// Defines a matrix from an array whose elements are in row-major form 
        /// for the matrix under construction
        /// </summary>
        /// <param name="dim">The dimension of the maxtrix; unused, but useful for type inference</param>
        /// <param name="src">The source array</param>
        /// <typeparam name="M">The number of rows</typeparam>
        /// <typeparam name="N">The number of columns</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M, N, T> define<M,N,T>(Dim<M,N> dim, IEnumerable<T> src)
            where M : TypeNat, new()
            where N : TypeNat, new()
            where T : Structures.Semiring<T>, new()
                => new Matrix<M,N,T>(src);

        /// <summary>
        /// Defines a matrix from an array whose elements are in row-major form 
        /// for the matrix under construction
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="M">The number of rows</typeparam>
        /// <typeparam name="N">The number of columns</typeparam>
        /// <typeparam name="T">The cell typee</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M, N, T> define<M,N,T>(params T[] src)
            where M : TypeNat, new()
            where N : TypeNat, new()
            where T : Structures.Semiring<T>, new()
                => new Matrix<M,N,T>(src);


        /// <summary>
        /// Defines a matrix from a sequence whose elements are in row-major form
        /// for the matrix under construction
        /// </summary>
        /// <param name="dim">The dimension of the maxtrix; unused, but useful for type inference</param>
        /// <param name="src">The source array</param>
        /// <typeparam name="M">The number of rows</typeparam>
        /// <typeparam name="N">The number of columns</typeparam>
        /// <typeparam name="T">The cell typee</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M, N, T> define<M,N,T>(Dim<M,N> dim, params T[] src)
            where M : TypeNat, new()
            where N : TypeNat, new()
            where T : Structures.Semiring<T>, new()
                => new Matrix<M,N,T>(src);


        /// <summary>
        /// Defines a matrix from a sequence whose elements are in row-major form
        /// for the matrix under construction
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="M">The number of rows</typeparam>
        /// <typeparam name="N">The number of columns</typeparam>
        /// <typeparam name="T">The cell typee</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M, N, T> define<M,N,T>(IEnumerable<T> src)
            where M : TypeNat, new()
            where N : TypeNat, new()
            where T : Structures.Semiring<T>, new()
                => new Matrix<M,N,T>(src);

        [MethodImpl(Inline)]
        public static Z0.MatrixOps<M,N,T> ops<M,N,T>()
            where M : TypeNat, new()
            where N : TypeNat, new()
            where T : Structures.Semiring<T>, new()
                => Z0.MatrixOps<M,N,T>.Inhabitant;


        [MethodImpl(Inline)]
        public static Z0.MatrixOps<M,N,T> ops<M,N,T>(Dim<M,N> dim, T exeplar)
            where M : TypeNat, new()
            where N : TypeNat, new()
            where T : Structures.Semiring<T>, new()
                => Z0.MatrixOps<M,N,T>.Inhabitant;
    }
}