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
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M, N, T> define<M,N,T>(Dim<M,N> dim, params T[] src)
            where M : TypeNat, new()
            where N : TypeNat, new()
            where T : Semiring<T>, new()
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
            where T : Semiring<T>, new()
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
            where T : Semiring<T>, new()
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
            where T : Semiring<T>, new()
                => new Matrix<M,N,T>(src);




    }

    partial class Traits
    {

        public interface MatrixOps<M,N,P,T>
                where M : TypeNat, new()
                where N : TypeNat, new()
                where P : TypeNat, new()
                where T : Semiring<T>, new()
        {

            Z0.Matrix<M, P, T> mul(Traits.Matrix<M, N, T> lhs, Traits.Matrix<N, P, T> rhs);

        }

        public interface MatrixOps<M,N,T>
                where M : TypeNat, new()
                where N : TypeNat, new()
                where T : Semiring<T>, new()
        {

            Z0.Matrix<M,N,T> zero();
        
            T cell(Traits.Matrix<M,N,T> src, uint i, uint j);
            
            T cell<I, J>(Traits.Matrix<M,N,T> src)
                where I : TypeNat, new()
                where J : TypeNat, new();            
            
            Z0.Vector<M, T> vector(Traits.Matrix<M, N, T> src, uint j);
        
            IEnumerable<Z0.Covector<N, T>> rows(Traits.Matrix<M, N, T> src);
            
            IEnumerable<Z0.Vector<M, T>> cols(Traits.Matrix<M, N, T> src);

            Z0.Covector<N, T> covector(Traits.Matrix<M, N, T> src, uint i);
            
            Z0.Slice<N, Z0.Covector<N, T>> covectors(Traits.Matrix<M,N,T> src);

            Z0.Matrix<M,N,T> add(Matrix<M, N, T> lhs, Matrix<M, N, T> rhs);
            
            bool eq(Traits.Matrix<M, N, T> lhs, Traits.Matrix<M, N, T> rhs);

            bool neq(Traits.Matrix<M, N, T> lhs, Traits.Matrix<M, N, T> rhs);

            Z0.Vector<M, T> vector<J>(Traits.Matrix<M, N, T> src)
                where J:TypeNat, new();

            Z0.Matrix<N, M, T> tranpose(Traits.Matrix<M,N,T> src);
        }


    }

    public readonly struct MatrixOps<M,N,P,T> : Traits.MatrixOps<M,N,P,T>
            where M : TypeNat, new()
            where N : TypeNat, new()
            where P : TypeNat, new()
            where T : Semiring<T>, new()
    {
        public static readonly MatrixOps<M,N,P,T> Inhabitant = default;

        [MethodImpl(Inline)]
        public Matrix<M, P, T> mul(Traits.Matrix<M, N, T> lhs, Traits.Matrix<N, P, T> rhs)
        {            
            var m = Prove.claim<M>(lhs.dim().i);
            var p = Prove.claim<P>(rhs.dim().j);
            var product = new T[m*p];
            for(var i = 0u; i< m; i++)
                for(var j =0u; j< p; j++)
                    product[i] = Covector.apply(lhs.covector(i), rhs.vector(j));
            return Matrix.define<M,P,T>(product);
        }

    }

    public readonly struct MatrixOps<M,N,T> : Traits.MatrixOps<M,N,T>
            where M : TypeNat, new()
            where N : TypeNat, new()
            where T : Semiring<T>, new()
    {
        static readonly Semiring<T> SR = semiring<T>();
        static readonly Dim<M,N> Dim = default;
        
        public static readonly MatrixOps<M,N,T> Inhabitant = default;
        
        [MethodImpl(Inline)]
        static IEnumerable<T> zeros()
            => repeat(SR.zero, Dim.i * Dim.j);
        
        public static readonly Matrix<M,N,T> Zero = Matrix.define<M,N,T>(zeros());

        [MethodImpl(Inline)]        
        public T cell(Traits.Matrix<M,N,T> src, uint i, uint j)
            => src.data[Dim.i*i + j];

        [MethodImpl(Inline)]
        public T cell<I, J>(Traits.Matrix<M,N,T> src)
            where I : TypeNat, new()
            where J : TypeNat, new()
                => cell(src,natval<I>(), natval<J>());

        [MethodImpl(Inline)]
        public Vector<M, T> vector(Traits.Matrix<M, N, T> src, uint j)
        {            
            var data = src.data;
            var n = (int)Dim.i;
            var col = (int)j;
            var v = new T[n];
            for(var r = 0; r < n; r++)
                v[r] = data[r + col];
            return  Vector.define<M,T>(v);
        }    


        [MethodImpl(Inline)]
        public IEnumerable<Covector<N, T>> rows(Traits.Matrix<M, N, T> src)
        {
            for(var i = 0u; i < Dim.i; i++)
                yield return covector(src, i);
        }

        [MethodImpl(Inline)]
        public IEnumerable<Vector<M, T>> cols(Traits.Matrix<M, N, T> src)
        {
            for(var j =0u; j < Dim.j; j++)
                yield return vector(src,j);
        }

        [MethodImpl(Inline)]
        public Z0.Vector<M, T> vector<J>(Traits.Matrix<M, N, T> src) 
            where J : TypeNat, new()
                => vector(src,natval<J>());

        [MethodImpl(Inline)]
        public Z0.Covector<N, T> covector(Traits.Matrix<M, N, T> src, uint i)
            => covector<N,T>(src.data.Segment(Dim.j*i,Dim.j));  

        [MethodImpl(Inline)]
        public Z0.Matrix<M, N, T> add(Traits.Matrix<M, N, T> lhs, Traits.Matrix<M, N, T> rhs)
            => Matrix.define(dim<M,N>(), zip(lhs.data, rhs.data, (x,y) =>  SR.add(x,y)));

        [MethodImpl(Inline)]
        public bool eq(Traits.Matrix<M, N, T> lhs, Traits.Matrix<M, N, T> rhs)
            => zcore.eq(lhs.data, rhs.data); 

        [MethodImpl(Inline)]
        public bool neq(Traits.Matrix<M, N, T> lhs, Traits.Matrix<M, N, T> rhs)
            => not(eq(lhs,rhs));

        [MethodImpl(Inline)]
        public Z0.Matrix<M,N,T> zero() 
            => Zero;

        [MethodImpl(Inline)]
        public Z0.Matrix<N, M, T> tranpose(Traits.Matrix<M,N,T> src)
            => new Matrix<N,M,T>(src.vectors().data.SelectMany(x => x).ToArray());

        [MethodImpl(Inline)]
        public Z0.Slice<N, Z0.Covector<N, T>> covectors(Traits.Matrix<M,N,T> src)
            => rows(src).ToSlice<N,Z0.Covector<N,T>>();        
   }            

}