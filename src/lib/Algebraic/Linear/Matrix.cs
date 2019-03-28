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
                => Matrix.define<M,N,T>(zip(lhs.cells(), rhs.cells(), (x,y) =>  semiring<T>().add(x,y)));

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


    public readonly struct Matrix<M, N, T> : Traits.Matrix<M, N, T>, Formattable
        where M : TypeNat, new()
        where N : TypeNat, new()
    {
        static readonly Dim<M,N> Dim = default;
        
        readonly T[] data;
        
        readonly uint m;
        
        readonly uint n;

        [MethodImpl(Inline)]
        public Matrix(params T[] src)
        {
            (m, n) = (Dim.i, Dim.j);
            data = src;
            demand(m*n == data.Length);
        }

        [MethodImpl(Inline)]
        public Matrix(IEnumerable<T> src)
        {
            (m, n) = (Dim.i, Dim.j);
            data = src.ToArray();
            demand(m*n == data.Length);
        }

        [MethodImpl(Inline)]
        public Dim<M,N> dim()
            => Dim;

        [MethodImpl(Inline)]
        IEnumerable<Vector<M, T>> cols()
        {
            for(var j =0u; j < n; j++)
                yield return vector(j);
        }

        [MethodImpl(Inline)]
        IEnumerable<Covector<N, T>> rows()
        {
            for(var i = 0u; i < m; i++)
                yield return covector(i);
        }

        [MethodImpl(Inline)]
        public Slice<M,Vector<M, T>> vectors()
            => Slice.define<M, Vector<M, T>>(cols());

        [MethodImpl(Inline)]
        public Vector<M, T> vector(uint j)
        {            
            var v = new T[m];
            for(var r = 0u; r < m; r++)
                v[r] = data[r + j];
            return  Vector.define<M,T>(v);
        }    


        [MethodImpl(Inline)]
        public Vector<M, T> vector<J>() 
            where J : TypeNat, new()
                => vector(natval<J>());

        [MethodImpl(Inline)]
        public Slice<N, Covector<N, T>> covectors()
            => rows().ToSlice<N,Covector<N,T>>();

        [MethodImpl(Inline)]
        public Covector<N, T> covector<I>() 
            where I : TypeNat, new()
                => covector(natval<I>());

        [MethodImpl(Inline)]
        public Covector<N, T> covector(uint i)
            => covector<N,T>(data.Segment(n*i,n));  


        [MethodImpl(Inline)]
        public IReadOnlyList<T> cells()
            => data;

        [MethodImpl(Inline)]
        public T cell<I, J>()
            where I : TypeNat, new()
            where J : TypeNat, new()
                => cell(natval<I>(), natval<J>());

        [MethodImpl(Inline)]
        public T cell(uint i, uint j)
            => data[m*i + j];
        
        [MethodImpl(Inline)]
        public Matrix<N, M, T> tranpose()
            => new Matrix<N,M,T>(vectors().data.SelectMany(x => x).ToArray());

        public string format()
            => rows().Format();

        public override string ToString()
            => format();


    } 
}