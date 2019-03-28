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
        
        /// <summary>
        /// Defines a matrix from an array whose elements are in row-major form 
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
        public static Matrix<M, N, T> define<M,N,T>(Dim<M,N> dim, IEnumerable<T> src)
            where M : TypeNat, new()
            where N : TypeNat, new()
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
                => new Matrix<M,N,T>(src);

        [MethodImpl(Inline)]
        public static Matrix<M, N, T> add<M,N,T>(Matrix<M, N, T> lhs, Matrix<M, N, T> rhs)
            where M : TypeNat, new()
            where N : TypeNat, new()
            where T : Semiring<T>, new()
                => Matrix.define(dim<M,N>(), zip(lhs.cells(), rhs.cells(), (x,y) =>  semiring<T>().add(x,y)));

        [MethodImpl(Inline)]
        public static bool eq<M,N,T>(Matrix<M, N, T> lhs, Matrix<M, N, T> rhs)
            where M : TypeNat, new()
            where N : TypeNat, new()
            where T : Equatable<T>
                => zcore.eq(lhs.cells(), rhs.cells()); 

        [MethodImpl(Inline)]
        public static bool neq<M,N,T>(Matrix<M, N, T> lhs, Matrix<M, N, T> rhs)
            where M : TypeNat, new()
            where N : TypeNat, new()
            where T : Equatable<T>
                => not(eq(lhs,rhs));

        [MethodImpl(Inline)]
        public static Matrix<M,N,T> zero<M,N,T>() 
            where M : TypeNat, new()
            where N : TypeNat, new()
            where T : Semiring<T>, new()
                => Matrix.define<M,N,T>(repeat(semiring<T>().zero, natval<M>() * natval<N>()));

        [MethodImpl(Inline)]
        public static Matrix<M, P, T> mul<M,N,P,T>(Traits.Matrix<M, N, T> lhs, Traits.Matrix<N, P, T> rhs)
            where M : TypeNat, new()
            where N : TypeNat, new()
            where P : TypeNat, new()
            where T : Semiring<T>, new()
        {            
            var m = Nat.claim<M>(lhs.dim().i);
            var p = Nat.claim<P>(rhs.dim().j);
            var product = new T[m*p];
            for(var i = 0u; i< m; i++)
                for(var j =0u; j< p; j++)
                    product[i] = Covector.apply(lhs.covector(i), rhs.vector(j));
            return Matrix.define<M,P,T>(product);
        }
    }


}