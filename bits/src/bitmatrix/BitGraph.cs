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

    public static class BitGraph
    {
        [MethodImpl(Inline)]
        internal static Memory<T> ToMemory<T>(this Span<T> src)
            => src.ToArray();

        [MethodImpl(Inline)]
        internal static Memory<T> ToMemory<T>(this ReadOnlySpan<T> src)
            => src.ToArray();

        /// <summary>
        /// Constructs an 8-node graph via the adjacency matrix interpretation
        /// </summary>
        public static Graph<byte> FromMatrix(BitMatrix8 src)
            => BitGraph.FromMatrix<byte,N8,byte>(new BitMatrix<N8,N8,byte>(src.Data));            

        /// <summary>
        /// Constructs a graph from an adjacency bitmatrix of natural dimension
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dim">The dimension of the matrix</param>
        /// <param name="v">An arbitrary value to help type inference</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        /// <typeparam name="N">The dimension type</typeparam>
        /// <typeparam name="T">The source matrix element type</typeparam>
        internal static Graph<V> FromMatrix<V,N,T>(BitMatrix<N,N,T> src, N dim = default, V v = default)
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
