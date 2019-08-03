//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using static zfunc;

    /// <summary>
    /// Defines a directed graph parameterized by the vertex index type
    /// </summary>
    /// <typeparam name="V">The vertex index type</typeparam>
    public class Graph<V>
        where V : struct
    {
        /// <summary>
        /// Creates a graph from supplied vertices and edges, sorting the provided vertices according to their index
        /// </summary>
        /// <param name="vertices">The vertices in the graph</param>
        /// <param name="edges">The edges that connect the vertices</param>
        public static Graph<V> Define(IEnumerable<Vertex<V>> vertices, IEnumerable<Edge<V>> edges)
            => new Graph<V>(vertices.OrderBy(x => x.Index,PrimalInfo.comparer<V>()).ToArray(), edges.ToArray());

        /// <summary>
        /// Creates a graph from supplied vertices and edges and assumes the vertices are already appropriately sorted
        /// </summary>
        /// <param name="vertices">The vertices in the graph</param>
        /// <param name="edges">The edges that connect the vertices</param>
        public static Graph<V> Define(Span<Vertex<V>> vertices, IEnumerable<Edge<V>> edges)
            => new Graph<V>(vertices.ToArray(), edges.ToArray());

        [MethodImpl(Inline)]
        static List<V> list(V first)
        {
            var list = new List<V>();
            list.Add(first);
            return list;
        }

        Graph(Vertex<V>[] vertices, Edge<V>[] edges)
        {
            this.vertices = vertices;
            this.edges = edges; 

            for(var i=0; i<edges.Length; i++)
            {
                var edge = edges[i];
                if(SourceIndex.TryGetValue(edge.Source, out List<V> targets))
                    targets.Add(edge.Target);
                else
                    SourceIndex[edge.Source] = list(edge.Target);

                if(TargetIndex.TryGetValue(edge.Target, out List<V> sources))
                    sources.Add(edge.Source);
                else
                    TargetIndex[edge.Target] = list(edge.Source);
            }

        }

        Dictionary<V,List<V>> SourceIndex {get;}
            = new Dictionary<V, List<V>>();

        IDictionary<V,List<V>> TargetIndex {get;}
            = new Dictionary<V, List<V>>();

        readonly Vertex<V>[] vertices;

        readonly Edge<V>[] edges;

        static readonly List<V> EmptyList = new List<V>();
        
        /// <summary>
        /// Retrieves the indices of a targets' source vertices 
        /// </summary>
        /// <param name="source">The source vertex</param>
        public IReadOnlyList<V> Sources(V target)
        {
            if(SourceIndex.TryGetValue(target, out List<V> sources))
                return sources;
            else
                return EmptyList;
        }

        /// <summary>
        /// Retrieves the indices of a sources' target vertices
        /// </summary>
        /// <param name="source">The source vertex</param>
        public IReadOnlyList<V> Targets(V source)
        {
            if(TargetIndex.TryGetValue(source, out List<V> targets))
                return targets;
            else
                return EmptyList;
        }

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
        /// Looks up an edge based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        public ref readonly Edge<V> Edge(uint index)
            => ref edges[index];

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

        /// <summary>
        /// Specifies the edges declared by the graph
        /// </summary>
        public uint EdgeCount
            => (uint)edges.Length;


        /// <summary>
        /// Specifies the number of vertices declared by the graph
        /// </summary>
        public uint VertexCount
            => (uint)vertices.Length;
    }

}