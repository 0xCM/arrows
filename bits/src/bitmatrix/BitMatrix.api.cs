//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static class BitMatrix
    {
        /// <summary>
        /// Allocates a zero-filled n-square matrix
        /// </summary>
        /// <typeparam name="N">The square dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> Alloc<N,T>(N n = default, T rep = default)
            where N : ITypeNat, new()
            where T : struct
                => BitMatrix<N,T>.Alloc();
        
        /// <summary>
        /// Allocates a zero-filled mxn bitmatrix
        /// </summary>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Alloc<M,N,T>(M m = default, N n = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => BitMatrix<M,N,T>.Alloc();

        /// <summary>
        /// Loads an n-square bitmatrix from a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The matrix order</param>
        /// <typeparam name="N">The matrix order type</typeparam>
        /// <typeparam name="T">The matrix cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> Load<N,T>(ReadOnlySpan<T> src, N n = default)        
            where N : ITypeNat, new()
            where T : struct
                => new BitMatrix<N,T>(src); 

        /// <summary>
        /// Loads an n-square bitmatrix from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The matrix order</param>
        /// <typeparam name="N">The matrix order type</typeparam>
        /// <typeparam name="T">The matrix cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> Load<N,T>(Span<T> src, N n = default)        
            where N : ITypeNat, new()
            where T : struct
                => new BitMatrix<N,T>(src); 

        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Load<M,N,T>(ReadOnlySpan<T> src, M m = default, N n = default)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new BitMatrix<M,N,T>(src); 

        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Load<M,N,T>(Span<T> src, M m = default, N n = default)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new BitMatrix<M,N,T>(src); 

        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Load<M,N,T>(M m = default, N n = default, params T[] src)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new BitMatrix<M,N,T>(src); 

        /// <summary>
        /// Allocates a one-filled mxn matrix
        /// </summary>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Ones<M,N,T>(M m = default, N n = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => BitMatrix<M,N,T>.Ones();

        /// <summary>
        /// Allocates a one-filled N-square matrix
        /// </summary>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> Ones<N,T>(N n = default)
            where N : ITypeNat, new()
            where T : struct
                => BitMatrix<N,T>.Ones();

        /// <summary>
        /// Allocates an N-square identity matrix
        /// </summary>
        /// <typeparam name="N">The column/row dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static BitMatrix<N,T> Identity<N,T>(N n = default, T rep = default)
            where N : ITypeNat, new()
            where T : struct
                => BitMatrix<N,T>.Identity();

        /// <summary>
        /// Constructs a graph from an adjacency bitmatrix of natural dimension
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dim">The dimension of the matrix</param>
        /// <param name="v">An arbitrary value to help type inference</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        /// <typeparam name="N">The dimension type</typeparam>
        /// <typeparam name="T">The source matrix element type</typeparam>
        internal static Graph<V> ToGraph<V,N,T>(BitMatrix<N,N,T> src, N dim = default, V v = default)
            where N : ITypeNat, new()
            where V : struct
            where T : struct
        {
            var n = (int)dim.value;
            var nodes = Graph.Vertices<V>(n);
            var edges = new List<Edge<V>>();
            for(var row = 0; row < n; row++)
            for(var col = 0; col < n; col++)
                if(src[row,col])
                    edges.Add(Graph.Connect(nodes[row], nodes[col]));
            return Graph.Define(nodes, edges);
        }

    }

}