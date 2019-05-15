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

    using static zfunc;
    using static nfunc;


    public readonly struct Matrix<M, N, T>
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
    {
        static readonly Dim<M,N> Dim = default;        
            
        public readonly T[] data;
        

        [MethodImpl(Inline)]
        public Matrix(params T[] src)
        {
            data = src;
            demand(Dim.i * Dim.j == (ulong)data.Length);
        }


        [MethodImpl(Inline)]
        public Matrix(IEnumerable<T> src)
        {
            data = src.ToArray();
            demand(Dim.i * Dim.j == (ulong)data.Length);
        }

        [MethodImpl(Inline)]
        public Matrix(IEnumerable<Vector<M,T>> src)
        {
            data = src.Select(x => x.unwrap()).SelectMany(x => x).ToArray();
            demand(Dim.i * Dim.j == (ulong)data.Length);
        }

        [MethodImpl(Inline)]
        public Matrix(IEnumerable<Covector<N,T>> src)
        {
            data = src.Select(x => x.unwrap()).SelectMany(x => x).ToArray();
            demand(Dim.i * Dim.j == (ulong)data.Length);
        }

        
        [MethodImpl(Inline)]
        public Dim<M,N> dim()
            => Dim;

        [MethodImpl(Inline)]
        public Slice<N,Vector<M, T>> vectors()
            => MatrixOps<M,N>.vectors(this);

        [MethodImpl(Inline)]
        public Vector<M, T> vector(uint j)
            => MatrixOps<M,N>.vector(this,j);

        [MethodImpl(Inline)]
        public Covector<N, T> covector(uint i)
            => MatrixOps<M,N>.covector(this,i);


        [MethodImpl(Inline)]
        public T cell(uint i, uint j)
            => MatrixOps<M,N>.cell(this,i,j);
        

        public T this[uint i, uint j]
        {
            
            [MethodImpl(Inline)]
            get
            {
                return MatrixOps<M,N>.cell(this,i,j);
            }
        }

        
        [MethodImpl(Inline)]
        public Slice<N,T> row(uint i)
            => MatrixOps<M,N>.row(this,i);

        [MethodImpl(Inline)]
        public Slice<M,T> col(uint j)
            => MatrixOps<M,N>.col(this,j);


        [MethodImpl(Inline)]
        public string format()
            => MatrixOps<M,N>.format(this);


        public override string ToString() 
            => format();
    } 
}