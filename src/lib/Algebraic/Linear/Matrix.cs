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
        public interface Matrix<M,N,T> : Tranposable<Z0.Matrix<N,M,T>>
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

            T cell<I,J>()
                where I : TypeNat, new()
                where J : TypeNat, new(); 
            
            T cell(uint i, uint j);
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