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


    public readonly struct Matrix<M, N, T>  : Equatable<Matrix<M,N,T>>
            where M : TypeNat, new()
            where N : TypeNat, new()
            where T : Structure.Semiring<T>, new()
    {
        static readonly Dim<M,N> Dim = default;        
        
        static readonly Operative.MatrixOps<M,N,T> Ops = Matrix.ops<M,N,T>();        
        
        [MethodImpl(Inline)]
        public static bool operator == (Matrix<M, N, T> lhs, Matrix<M, N, T> rhs) 
            => Ops.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator != (Matrix<M, N, T> lhs, Matrix<M, N, T> rhs) 
            => Ops.neq(lhs,rhs);

        [MethodImpl(Inline)]
        public static Matrix<M, N, T> operator + (Matrix<M, N, T> lhs, Matrix<M, N, T> rhs) 
            => Ops.add(lhs, rhs);

        public readonly T[] data;
        

        [MethodImpl(Inline)]
        public Matrix(params T[] src)
        {
            data = src;
            demand(Dim.i * Dim.j == data.Length);
        }

        [MethodImpl(Inline)]
        public Matrix(IEnumerable<T> src)
        {
            data = src.ToArray();
            demand(Dim.i * Dim.j == data.Length);
        }

        [MethodImpl(Inline)]   
        public Matrix<M, N, T> add( Matrix<M, N, T> rhs) 
            => Ops.add(this,rhs);

        [MethodImpl(Inline)]   
        public Matrix<M, P, T> mul<P>(Matrix<N, P, T> rhs) 
            where P : TypeNat, new()
                => multiplier<P>() * rhs;

        [MethodImpl(Inline)]   
        public MatMul<M, N,P, T> multiplier<P>() 
            where P : TypeNat, new()
                => Ops.multiplier<P>(this);
             
        [MethodImpl(Inline)]
        public Dim<M,N> dim()
            => Dim;

        [MethodImpl(Inline)]
        public IEnumerable<Vector<M, T>> cols()
            => Ops.cols(this);

        [MethodImpl(Inline)]
        public IEnumerable<Covector<N, T>> rows()
            => Ops.rows(this);

        [MethodImpl(Inline)]
        public Slice<M,Vector<M, T>> vectors()
            => Ops.vectors(this);

        [MethodImpl(Inline)]
        public Vector<M, T> vector(uint j)
            => Ops.vector(this,j);

        [MethodImpl(Inline)]
        public Vector<M, T> vector<J>() 
            where J : TypeNat, new()
                => Ops.vector<J>(this);

        [MethodImpl(Inline)]
        public Slice<N, Covector<N, T>> covectors()
            => Ops.covectors(this);

        [MethodImpl(Inline)]
        public Covector<N, T> covector<I>() 
            where I : TypeNat, new()
                => Ops.covector<I>(this);

        [MethodImpl(Inline)]
        public Covector<N, T> covector(uint i)
            => Ops.covector(this,i);

        [MethodImpl(Inline)]
        public T cell<I, J>()
            where I : TypeNat, new()
            where J : TypeNat, new()
                => Ops.cell<I,J>(this);

        [MethodImpl(Inline)]
        public T cell(uint i, uint j)
            => Ops.cell(this,i,j);
        
        [MethodImpl(Inline)]
        public Matrix<N, M, T> tranpose()
            => Ops.tranpose(this);

        [MethodImpl(Inline)]
        public bool Equals(Matrix<M,N,T> rhs)
            => Ops.eq(this,rhs);

        [MethodImpl(Inline)]
        public Slice<N,T> row(uint i)
            => Ops.row(this,i);

        [MethodImpl(Inline)]
        public Slice<M,T> col(uint j)
            => Ops.col(this,j);

        /// <summary>
        /// Reinterprets the matrix dimension if the new dimension
        /// can be proved equivalent to the current. Otherwise,
        /// raises an error
        /// </summary>
        /// <typeparam name="I">The new row dimension representation</typeparam>
        /// <typeparam name="J">The new column dimension representation</typeparam>
        [MethodImpl(Inline)]
        public Matrix<I, J, T> reinterpret<I,J>()
            where I : TypeNat, new()
            where J : TypeNat, new()
                => Ops.reinterpret<I,J>(this);

        /// <summary>
        /// Reinterprets the matrix dimension if the new dimension
        /// can be proved equivalent to the current. Otherwise,
        /// raises an error
        /// </summary>
        /// <typeparam name="I">The new row dimension representation</typeparam>
        /// <typeparam name="J">The new column dimension representation</typeparam>
        [MethodImpl(Inline)]
        public Matrix<I, J, T> reinterpret<I,J>(Dim<I,J> equivalent)
            where I : TypeNat, new()
            where J : TypeNat, new()
                => Ops.reinterpret(this, equivalent);

        [MethodImpl(Inline)]
        public void mutate(Func<T,T> f)
            => Ops.mutate(this,f);

        [MethodImpl(Inline)]
        public Matrix<M,N,Y> transform<Y>(Func<T,Y> f)
            where Y : Structure.Semiring<Y>, new()
            => Ops.transform(this,f);
        
        [MethodImpl(Inline)]
        public string format()
            => Ops.format(this);

        public override string ToString() 
            => Ops.format(this);

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();

        public bool eq(Matrix<M, N, T> rhs)
            => Ops.eq(this,rhs);
        public bool neq(Matrix<M, N, T> rhs)
            => Ops.neq(this,rhs);

        bool Equality<Matrix<M, N, T>>.eq(Matrix<M, N, T> lhs, Matrix<M, N, T> rhs)
            => lhs.eq(rhs);
 
        bool Equality<Matrix<M, N, T>>.neq(Matrix<M, N, T> lhs, Matrix<M, N, T> rhs)
            => lhs.neq(rhs);
    } 
}