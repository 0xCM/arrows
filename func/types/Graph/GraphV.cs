//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using static zfunc;

    /// <summary>
    /// Defines a directed graph
    /// </summary>
    /// <typeparam name="V">The vertex index type</typeparam>
    public class Graph<V>
        where V : struct
    {
        public static Graph<V> Define(IEnumerable<Vertex<V>> vertices, IEnumerable<Edge<V>> edges)
            => new Graph<V>(vertices.OrderBy(x => x.Index,PrimalInfo.comparer<V>()).ToArray(), edges.ToArray());

        Graph(Vertex<V>[] vertices, Edge<V>[] edges)
        {
            this.vertices = vertices;
            this.edges = edges;            
        }

        readonly Vertex<V>[] vertices;

        readonly Edge<V>[] edges;

        /// <summary>
        /// Looks up a vertex based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        public ref readonly Vertex<V> Vertex(V index)
            => ref vertices[convert<V,ulong>(index)];

        /// <summary>
        /// Looks up a vertex based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        public ref readonly Vertex<V> this[V index]
            => ref Vertex(index);

        /// <summary>
        /// Reveals all vertices covered by the graph
        /// </summary>
        public ReadOnlySpan<Vertex<V>> Vertices
            => vertices;

        /// <summary>
        /// Reveals all edges that connect graph vertices
        /// </summary>
        public ReadOnlySpan<Edge<V>> Edges 
            => edges;

    }



}