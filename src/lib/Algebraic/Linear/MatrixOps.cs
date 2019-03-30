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

    partial class Traits
    {
        public interface MatrixOps<M,N,T>
                where M : TypeNat, new()
                where N : TypeNat, new()
                where T : Semiring<T>, new()
        {

            Matrix<M,N,T> zero();

            Dim<M,N> dim();
        
            Z0.Slice<N,T> row(Matrix<M, N, T> src, uint i);

            Z0.Slice<M,T> col(Matrix<M,N,T> src, uint j);

            T cell(Matrix<M,N,T> src, uint i, uint j);
            
            T cell<I, J>(Matrix<M,N,T> src)
                where I : TypeNat, new()
                where J : TypeNat, new();            
            
            Vector<M, T> vector(Matrix<M, N, T> src, uint j);
        
            Covector<N, T> covector(Matrix<M, N, T> src, uint i);

            Vector<M, T> vector<J>(Matrix<M, N, T> src)
                where J:TypeNat, new();

            Covector<N, T> covector<I>(Matrix<M, N, T> src) 
                where I : TypeNat, new();

            Z0.Slice<M,Vector<M, T>> vectors(Matrix<M, N, T> src);
            
            Z0.Slice<N, Covector<N, T>> covectors(Matrix<M,N,T> src);


            IEnumerable<Covector<N, T>> rows(Matrix<M, N, T> src);
            
            IEnumerable<Vector<M, T>> cols(Matrix<M, N, T> src);

            Matrix<M,N,T> add(Matrix<M, N, T> lhs, Matrix<M, N, T> rhs);
            
            bool eq(Matrix<M, N, T> lhs, Matrix<M, N, T> rhs);

            bool neq(Matrix<M, N, T> lhs, Matrix<M, N, T> rhs);

     
            Matrix<N, M, T> tranpose(Matrix<M,N,T> src);

            MatMul<M, N, P, T> multiplier<P>(Matrix<M,N,T> src)
                where P : TypeNat, new();

            string format(Matrix<M,N,T> src);

            Matrix<Z0.Prior<M>, Z0.Prior<N>,T> delete(Matrix<M,N,T> src, uint rowix, uint colix);

            Matrix<I,J,T> submatrix<I,J>(Matrix<M,N,T> src, Dim<I,J> newdim, (uint r, uint c) origin)
                where I : TypeNat, new()
                where J : TypeNat, new();

            Matrix<I, J, T> reinterpret<I,J>(Matrix<M,N,T> src)
                where I : TypeNat, new()
                where J : TypeNat, new();

            Matrix<I, J, T> reinterpret<I,J>(Matrix<M,N,T> src, Dim<I,J> equivalent)
                where I : TypeNat, new()
                where J : TypeNat, new();

            Matrix<M,N,Y> transform<Y>(Matrix<M,N,T> src, Func<T,Y> f)
                        where Y : Semiring<Y>, new();

            void mutate(Matrix<M,N,T> src, Func<T,T> f);
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
        public T cell(Matrix<M,N,T> src, uint i, uint j)
            => src.data[Dim.i*i + j];

        [MethodImpl(Inline)]
        public Dim<M,N> dim()
            => Dim;

        [MethodImpl(Inline)]
        public T cell<I, J>(Matrix<M,N,T> src)
            where I : TypeNat, new()
            where J : TypeNat, new()
                => cell(src,natval<I>(), natval<J>());

        [MethodImpl(Inline)]
        public Z0.Slice<M,T> col(Matrix<M,N,T> src, uint j)
        {
            var data = src.data;
            var n = Dim.i;
            var col = (int)j;
            var v = new T[n];
            for(var r = 0; r < n; r++)
                v[r] = data[r + col];
            return Slice.define<M,T>(data);
        }

        [MethodImpl(Inline)]        
        public Vector<M, T> vector(Matrix<M, N, T> src, uint j)
            => col(src,j);


        [MethodImpl(Inline)]
        public IEnumerable<Covector<N, T>> rows(Matrix<M, N, T> src)
        {
            for(var i = 0u; i < Dim.i; i++)
                yield return covector(src, i);
        }

        [MethodImpl(Inline)]
        public IEnumerable<Vector<M, T>> cols(Matrix<M, N, T> src)
        {
            for(var j =0u; j < Dim.j; j++)
                yield return vector(src,j);
        }

        [MethodImpl(Inline)]
        public Z0.Slice<M,Vector<M, T>> vectors(Matrix<M, N, T> src)
            => Slice.define<M, Vector<M, T>>(cols(src));

        [MethodImpl(Inline)]
        public Vector<M, T> vector<J>(Matrix<M, N, T> src) 
            where J : TypeNat, new()
                => vector(src,natval<J>());

        [MethodImpl(Inline)]
        public Z0.Slice<N,T> row(Matrix<M, N, T> src, uint i)
            => Slice.define<N,T>(src.data.Segment(Dim.j*i,Dim.j));

        [MethodImpl(Inline)]
        public Covector<N, T> covector(Matrix<M, N, T> src, uint i)
            => row(src, i);

        [MethodImpl(Inline)]
        public Matrix<M, N, T> add(Matrix<M, N, T> lhs, Matrix<M, N, T> rhs)
            => Matrix.define(dim<M,N>(), zip(lhs.data, rhs.data, (x,y) =>  SR.add(x,y)));

        [MethodImpl(Inline)]
        public bool eq(Matrix<M, N, T> lhs, Matrix<M, N, T> rhs)
            => zcore.eq(lhs.data, rhs.data); 

        [MethodImpl(Inline)]
        public bool neq(Matrix<M, N, T> lhs, Matrix<M, N, T> rhs)
            => not(eq(lhs,rhs));

        [MethodImpl(Inline)]
        public Covector<N, T> covector<I>(Matrix<M, N, T> src) 
            where I : TypeNat, new()
                => covector(src,natval<I>());

        [MethodImpl(Inline)]
        public Matrix<M,N,T> zero() 
            => Zero;

        [MethodImpl(Inline)]
        public Matrix<N, M, T> tranpose(Matrix<M,N,T> src)
            => new Matrix<N,M,T>(src.vectors().data.SelectMany(x => x).ToArray());

        [MethodImpl(Inline)]
        public Z0.Slice<N, Covector<N, T>> covectors(Matrix<M,N,T> src)
            => rows(src).ToSlice<N,Covector<N,T>>();        

        [MethodImpl(Inline)]   
        public MatMul<M, N,P, T> multiplier<P>(Matrix<M,N,T> src) 
            where P : TypeNat, new()
                => new MatMul<M,N,P,T>(src);

        [MethodImpl(Inline)]   
        public string format(Matrix<M,N,T> src)
            => rows(src).Format();

        public Matrix<Prior<M>, Prior<N>,T> delete(Matrix<M,N,T> src, uint rowix, uint colix)
        {            
            var dstdim = dim<Prior<M>, Prior<N>>();
            var dstmem = new T[dstdim.volume()];
            var curidx = 0;            
            for(var i = 0u; i< Dim.i; i++)
            {
                if(i != rowix)
                    for(var j =0u; j<Dim.j; j++)                    
                        if(j != colix)
                            dstmem[curidx++] = src.cell(i,j);            
            }
            return Matrix.define(dstdim, dstmem);

        }

        public Matrix<I,J,T> submatrix<I,J>(Matrix<M,N,T> src, Dim<I,J> dstdim, (uint r, uint c) origin)
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

        /// <summary>
        /// Reinterprets the matrix dimension if the new dimension
        /// can be proved equivalent to the current. Otherwise,
        /// raises an error
        /// </summary>
        /// <typeparam name="I">The new row dimension representation</typeparam>
        /// <typeparam name="J">The new column dimension representation</typeparam>
        [MethodImpl(Inline)]
        public Matrix<I, J, T> reinterpret<I,J>(Matrix<M,N,T> src)
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
        public Matrix<I, J, T> reinterpret<I,J>(Matrix<M,N,T> src, Dim<I,J> equivalent)
            where I : TypeNat, new()
            where J : TypeNat, new()
        {
            Prove.equal<I,J>();
            return new Matrix<I, J, T>(src.data);
        }

        [MethodImpl(Inline)]
        public void mutate(Matrix<M,N,T> src, Func<T,T> f)
        {
            var data = src.data;
            for(var k = 0; k< data.Length; k++)
                data[k] = f(data[k]);
        }

        [MethodImpl(Inline)]
        public Matrix<M,N,Y> transform<Y>(Matrix<M,N,T> src, Func<T,Y> f)
            where Y : Semiring<Y>, new()
        {                
            var data = src.data;
            var dst = new Y[data.Length];
            for(var k = 0; k< data.Length; k++)
                dst[k] = f(data[k]);
            return new Matrix<M,N,Y>(dst);
        }

     }            
}