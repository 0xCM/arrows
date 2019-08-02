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
    /// Defines a graph in which data may be associated with each node and edges are weighted
    /// </summary>
    /// <typeparam name="V">The vertex index type</typeparam>
    /// <typeparam name="W">The weight type</typeparam>
    /// <typeparam name="T">The node payload type</typeparam>
    public class Graph<V,W,T>
        where V : struct
        where W : struct
        where T : struct
    {
        public static Graph<V,W,T> Define(IEnumerable<Vertex<V,T>> vertices, IEnumerable<Edge<V,W>> edges)
            => new Graph<V,W,T>(vertices.OrderBy(x => x.Index,PrimalInfo.comparer<V>()).ToArray(), edges.ToArray());

        Graph(Vertex<V,T>[] vertices, Edge<V,W>[] edges)
        {
            this.vertices = vertices;
            this.edges = edges;            
        }

        readonly Vertex<V,T>[] vertices;

        readonly Edge<V,W>[] edges;

        public ReadOnlySpan<Vertex<V,T>> Vertices
            => vertices;

        public ReadOnlySpan<Edge<V,W>> Edges 
            => edges;
    }

}


