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


    public static class MatrixOps<M,N>
        where M : TypeNat, new()
        where N : TypeNat, new()
    {
        public static readonly Dim<M,N> dim = Dim.define<M,N>();

        [MethodImpl(Inline)]
        static Operative.Semiring<T> SR<T>()
            where T : Operative.Semiring<T>, new()
                => new T();


        [MethodImpl(Inline)]
        static IEnumerable<T> zeros<T>()
            where T : Operative.Semiring<T>, new()
                => repeat(SR<T>().zero, dim<M,N>().i * dim<M,N>().j);

        [MethodImpl(Inline)]
        public static Matrix<M,N,T> zero<T>()
            where T : Operative.Semiring<T>, new()
                => Matrix.define<M,N,T>(zeros<T>());

        [MethodImpl(Inline)]
        public static Z0.Slice<M,T> col<T>(Matrix<M,N,T> src, uint j)
        {
            var d = dim<M,N>();
            var data = src.data;
            var n = d.i;
            var col = (int)j;
            var v = new T[n];
            for(var r = 0u; r < n; r++)
                v[r] = data[r + col];
            return Slice.define<M,T>(data);
        }

        [MethodImpl(Inline)]        
        public static Z0.Slice<M,T> col<T>(Matrix<M,N,T> src, ulong j)
            => col(src,(uint)j);

        [MethodImpl(Inline)]
        public static IEnumerable<Vector<M, T>> cols<T>(Matrix<M, N, T> src)
        {
            for(var j =0u; j < dim.j; j++)
                yield return vector(src,j);
        }

        [MethodImpl(Inline)]
        public static Z0.Slice<N,T> row<T>(Matrix<M, N, T> src, uint i)
            => Slice.define<N,T>(src.data.Segment(dim.j*i,dim.j));

        [MethodImpl(Inline)]
        public static IEnumerable<Covector<N, T>> rows<T>(Matrix<M, N, T> src)
        {
            for(var i = 0u; i < dim.i; i++)
                yield return covector(src, i);
        }


        [MethodImpl(Inline)]        
        public static T cell<T>(Matrix<M,N,T> src, uint i, uint j)
            => src.data[dim.i*i + j];

        [MethodImpl(Inline)]        
        public static T cell<T>(Matrix<M,N,T> src, ulong i, ulong j)
            => src.data[dim.i*i + j];

        [MethodImpl(Inline)]
        public static T cell<I,J,T>(Matrix<M,N,T> src)
            where I : TypeNat, new()
            where J : TypeNat, new()
                => cell(src,natui<I>(), natui<J>());

        [MethodImpl(Inline)]        
        public static Vector<M, T> vector<T>(Matrix<M, N, T> src, ulong j)
            => col(src,(uint)j);

        [MethodImpl(Inline)]        
        public static Vector<M, T> vector<T>(Matrix<M, N, T> src, uint j)
            => col(src,j);

        [MethodImpl(Inline)]
        public static Vector<M, T> vector<J,T>(Matrix<M, N, T> src) 
            where J : TypeNat, new()
                => vector(src,natval<J>());


        [MethodImpl(Inline)]
        public static Covector<N, T> covector<T>(Matrix<M, N, T> src, uint i)
            => row(src, i);

        [MethodImpl(Inline)]
        public static Covector<N, T> covector<T>(Matrix<M, N, T> src, ulong i)
            => row(src, (uint)i);

        [MethodImpl(Inline)]
        public static Covector<N, T> covector<I,T>(Matrix<M, N, T> src) 
            where I : TypeNat, new()
                => covector(src,natval<I>());


        [MethodImpl(Inline)]
        public static Z0.Slice<M,Vector<M, T>> vectors<T>(Matrix<M, N, T> src)
            => Slice.define<M, Vector<M, T>>(cols(src));


        [MethodImpl(Inline)]
        public static Z0.Slice<N, Covector<N, T>> covectors<T>(Matrix<M,N,T> src)
            => rows(src).Freeze<N,Covector<N,T>>();        


        [MethodImpl(Inline)]   
        public static string format<T>(Matrix<M,N,T> src)
            => rows(src).Format();


        [MethodImpl(Inline)]
        public static bool eq<T>(Matrix<M, N, T> lhs, Matrix<M, N, T> rhs)
            where T : Operative.Semiring<T>, new()
        {
            var sr = SR<T>();
            for(var i = 0u; i< dim.i; i++)                
                for(var j = 0u; j < dim.j; j++)
                    if(sr.neq(lhs[i,j], rhs[i,j]))
                        return(false);
            return true;
        }

        public static Matrix<Prior<M>, Prior<N>,T> delete<T>(Matrix<M,N,T> src, uint rowix, uint colix)
        {            
            var dstdim = dim<Prior<M>, Prior<N>>();
            var dstmem = new T[dstdim.volume()];
            var curidx = 0;            
            for(var i = 0u; i< dim.i; i++)
            {
                if(i != rowix)
                    for(var j =0u; j<dim.j; j++)                    
                        if(j != colix)
                            dstmem[curidx++] = src.cell(i,j);            
            }
            return Matrix.define(dstdim, dstmem);

        }

        [MethodImpl(Inline)]
        public static Matrix<N, M, T> tranpose<T>(Matrix<M,N,T> src)
            => new Matrix<N,M,T>(src.vectors().data.SelectMany(x => x).ToArray());

        public static Matrix<I,J,T> submatrix<I,J,T>(Matrix<M,N,T> src, Dim<I,J> dstdim, (uint r, uint c) origin)
            where I : TypeNat, new()
            where J : TypeNat, new()
        {            
            var  dst = new T[dstdim.volume()];
            var curidx = 0;
            for(var i = origin.r; i < (origin.r + dstdim.i); i++)
                for(var j = origin.c; j < (origin.c + dstdim.j); j++)
                    dst[curidx++] = src.cell(i,j);

            return Matrix.define(dstdim, dst);        
        }

        [MethodImpl(Inline)]
        public static void update<T>(Matrix<M,N,T> src, Func<T,T> f)
        {
            var data = src.data;
            for(var k = 0; k< data.Length; k++)
                data[k] = f(data[k]);
        }

        [MethodImpl(Inline)]
        public static Matrix<M,N,Y> transform<T,Y>(Matrix<M,N,T> src, Func<T,Y> f)
        {                
            var data = src.data;
            var dst = new Y[data.Length];
            for(var k = 0; k< data.Length; k++)
                dst[k] = f(data[k]);
            return new Matrix<M,N,Y>(dst);
        }

        /// <summary>
        /// Reinterprets the matrix dimension if the new dimension
        /// can be proved equivalent to the current. Otherwise,
        /// raises an error
        /// </summary>
        /// <typeparam name="I">The new row dimension representation</typeparam>
        /// <typeparam name="J">The new column dimension representation</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<I, J, T> reinterpret<I,J,T>(Matrix<M,N,T> src)
            where I : TypeNat, new()
            where J : TypeNat, new()
        {
            Prove.equal<I,J>();
            return new Matrix<I, J, T>(src.data);        
        }

        /// <summary>
        /// Reinterprets the matrix dimension if the new dimension
        /// can be proved equivalent to the current. Otherwise,
        /// raises an error
        /// </summary>
        /// <typeparam name="I">The new row dimension representation</typeparam>
        /// <typeparam name="J">The new column dimension representation</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<I, J, T> reinterpret<I,J,T>(Matrix<M,N,T> src, Dim<I,J> equivalent)
            where I : TypeNat, new()
            where J : TypeNat, new()
        {
            Prove.equal<I,J>();
            return new Matrix<I, J, T>(src.data);
        }

        [MethodImpl(Inline)]
        public static Matrix<M, N, T> add<T>(Matrix<M, N, T> lhs, Matrix<M, N, T> rhs)
            where T : Operative.Semiring<T>, new()
            {
                var sr = new T();
                return Matrix.define<M,N,T>(fuse(lhs.data, rhs.data, sr.add));
            }

    }

    public static class Matrix
    {

        /// <summary>
        /// Constructs the zero matrix of natural dimension m x n
        /// </summary>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M,N,T> zero<M,N,T>()
            where M : TypeNat, new()
            where N : TypeNat, new()
            where T : Operative.Semiring<T>, new()
                => MatrixOps<M,N>.zero<T>();
       
        /// <summary>
        /// Naieve matrix multiplication
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        /// <typeparam name="M">The number of rows in the left matix</typeparam>
        /// <typeparam name="N">The number of columns in the left matrix and the number of rows in the right matrix</typeparam>
        /// <typeparam name="P">The number of columns in the right matrix</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M, P, T> mul<M,N,P,T>(Matrix<N, N, T> lhs, Matrix<N, P, T> rhs)
            where M : TypeNat, new()
            where N : TypeNat, new()
            where P : TypeNat, new()
            where T : Operative.Semiring<T>, new()
        {            
            var m = Prove.claim<M>(rhs.dim().i);
            var p = Prove.claim<P>(rhs.dim().j);
            var product = new T[m*p];
            for(var i = 0u; i< m; i++)
                for(var j =0u; j< p; j++)
                    product[i] = Covector.apply(lhs.covector(i), rhs.vector(j));
            return Matrix.define<M,P,T>(product);
        }


        [MethodImpl(Inline)]
        public static Z0.Slice<N,T> row<M,N,T>(Matrix<M, N, T> src, uint i)
                where M : TypeNat, new()
                where N : TypeNat, new()
                    => Slice.define<N,T>(src.data.Segment(natval<N>()*i, natval<N>()));

        [MethodImpl(Inline)]
        public static Matrix<I,J,T> submatrix<M,N,I,J,T>(Matrix<M,N,T> src, Dim<I,J> dstdim, (uint r, uint c) origin)
            where M : TypeNat, new()
            where N : TypeNat, new()
            where I : TypeNat, new()
            where J : TypeNat, new()
                => MatrixOps<M,N>.submatrix(src,dstdim,origin);

        /// <summary>
        /// Removes an identied row and comum from the source matrix and returns the new matrix
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="rowix">The index of the row to delete</param>
        /// <param name="colix">he index of the column to delete</param>
        /// <typeparam name="M">The number of rows</typeparam>
        /// <typeparam name="N">The number of columns</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<Prior<M>, Prior<N>,T> delete<M,N,T>(Matrix<M,N,T> src, uint rowix, uint colix)
            where M : TypeNat, new()
            where N : TypeNat, new()
                => MatrixOps<M,N>.delete(src,rowix,colix);

        /// <summary>
        /// Modifies the matrix in place by appying a function to each cell
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="f">The function to apply to each cell</param>
        /// <typeparam name="M">The number of rows</typeparam>
        /// <typeparam name="N">The number of columns</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void update<M,N,T>(Matrix<M,N,T> src, Func<T,T> f)
            where M : TypeNat, new()
            where N : TypeNat, new()
                => MatrixOps<M,N>.update(src,f);

        public static Matrix<M,N,Y> transform<M,N,T,Y>(Matrix<M,N,T> src, Func<T,Y> f)
            where M : TypeNat, new()
            where N : TypeNat, new()
                => MatrixOps<M,N>.transform(src,f);

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
        public static Matrix<M, N, T> define<M,N,T>(Dim<M,N> dim, params T[] src)
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


    }
}