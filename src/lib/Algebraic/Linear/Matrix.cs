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
        public interface Matrix<M,N,T> : Formattable 
            where M : TypeNat, new()
            where N : TypeNat, new()            
        {
            Z0.Slice<N,Z0.Covector<N,T>> covectors();

            Z0.Slice<M,Z0.Vector<M,T>> vectors();

            Z0.Covector<N,T> covector<I>()
                where I : TypeNat, new(); 

            Z0.Covector<N,T> covector(uint i);

            Z0.Dim<M,N> dim();

            Z0.Vector<M,T> vector<J>()
                where J : TypeNat, new(); 

            Z0.Vector<M,T> vector(uint i);

            T[] data {get;}

            T cell<I,J>()
                where I : TypeNat, new()
                where J : TypeNat, new(); 
            
            T cell(uint i, uint j);
        }


    }

    public readonly struct Matrix<M, N, T> : Traits.Matrix<M, N, T>, Traits.Tranposable<Matrix<N,M,T>>, IEquatable<Matrix<M,N,T>>
        where M : TypeNat, new()
        where N : TypeNat, new()
        where T : Traits.Semiring<T>, new()
    {
        static readonly Dim<M,N> Dim = default;
        
        static readonly MatrixOps<M,N,T> Ops = default;        
        

        [MethodImpl(Inline)]
        public static bool operator == (Matrix<M, N, T> lhs, Matrix<M, N, T> rhs) 
            => Ops.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator != (Matrix<M, N, T> lhs, Matrix<M, N, T> rhs) 
            => Ops.neq(lhs,rhs);

        [MethodImpl(Inline)]
        public static Matrix<M, N, T> operator + (Matrix<M, N, T> lhs, Matrix<M, N, T> rhs) 
            => Ops.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Matrix<M, M, T> operator * (Matrix<M, N, T> lhs, Matrix<N, M, T> rhs)             
            => lhs.mul(rhs);

        readonly T[] data;
        
        readonly uint m;
        
        readonly uint n;

        T[] Traits.Matrix<M, N, T>.data 
            => data;

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
        public Matrix<M, N, T> add( Matrix<M, N, T> rhs) 
            => Ops.add(this,rhs);

        [MethodImpl(Inline)]   
        public Matrix<M, P, T> mul<P>(Matrix<N, P, T> rhs) 
            where P : TypeNat, new()
            => MatrixOps<M,N,P,T>.Inhabitant.mul(this,rhs);

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
            => Slice.define<M, Vector<M, T>>(cols());

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
                => covector(natval<I>());

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

        public string format()
            => rows().Format();

        public override string ToString() 
            => format();

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();
    } 
}