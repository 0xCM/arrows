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
    /// <remarks>For terminology consult, for example, https://xlinux.nist.gov/dads/<remarks>
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

        /// <summary>
        /// Correlates sources with their targets
        /// </summary>
        Dictionary<V,List<V>> SourceIndex {get;}
            = new Dictionary<V, List<V>>();

        /// <summary>
        /// Correlates targets with their sources
        /// </summary>
        IDictionary<V,List<V>> TargetIndex {get;}
            = new Dictionary<V, List<V>>();

        readonly Vertex<V>[] vertices;

        readonly Edge<V>[] edges;

        static readonly List<V> EmptyList = new List<V>();
        
        /// <summary>
        /// Retrieves the indices of a targets' source vertices 
        /// </summary>
        /// <param name="source">The source vertex</param>
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
        public ref readonly Vertex<V> Vertex(V index)
            => ref vertices[convert<V,ulong>(index)];

        /// <summary>
        /// Looks up a vertex based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        public ref readonly Vertex<V> this[V index]
        {
            [MethodImpl(Inline)]
            get => ref Vertex(index);
        }

        /// <summary>
        /// Looks up an edge based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        [MethodImpl(Inline)]
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

        /// <summary>
        /// Computes the in-degree of a vertex; i.e. the count of incoming vertices
        /// </summary>
        /// <param name="target">The target vector</param>
        [MethodImpl(Inline)]
        public uint InDegree(V target)
            => (uint)Sources(target).Count;

        /// <summary>
        /// Computes the out-degree of a vertex; i.e. the count of outgoing vertices
        /// </summary>
        /// <param name="source">The source vector</param>
        [MethodImpl(Inline)]
        public uint OutDegree(V source)
            => (uint)Targets(source).Count;
        
        /// <summary>
        /// Determines whether a vertex is disconnected from the graph
        /// </summary>
        /// <param name="vertex">The vertext to test</param>
        [MethodImpl(Inline)]
        public bool IsIsolated(V vertex)
            => InDegree(vertex) == 0 && OutDegree(vertex) == 0;

        /// <summary>
        /// Determines whether the vertex is a sink, i.e. has no outgoing edges
        /// </summary>
        /// <param name="vertex">The vertex to test</param>
        /// <remarks>An isolated node in this context is not considered to be a 
        /// sink (or source) so "degenerate" sinks are excluded
        /// </remarks>
        [MethodImpl(Inline)]
        public bool IsSink(V vertex)
            => OutDegree(vertex) == 0 && InDegree(vertex) != 0;

        /// <summary>
        /// Determines whether the vertex is a source, i.e. has only outgoing edges
        /// </summary>
        /// <param name="vertex">The vertex to test</param>
        /// <remarks>An isolated node in this context is not considered to be a 
        /// sink (or source) so "degenerate" sources are excluded
        /// </remarks>
        [MethodImpl(Inline)]
        public bool IsSource(V vertex)
            => OutDegree(vertex) != 0 && InDegree(vertex) == 0;

        /// <summary>
        /// Traverses the graph until a sink is reached, a cycle is  detected, 
        /// or an optionally-specified vertex is reached
        /// </summary>
        /// <param name="v0">The start vertex</param>
        /// <param name="traversed">The traversal action</param>
        /// <param name="vEnd">An optional endpoint</param>
        public void Traverse(V v0, Action<V> traversed, V vEnd = default)
        {
            foreach(var target in Targets(v0))
            {
                traversed(target);

                if(target.Equals(v0) || target.Equals(vEnd)) 
                    break;                
                                
                Traverse(target, traversed, v0);
            }
        }

        /// <summary>
        /// Computes the path from a source vertex to a sink, a specified endpoint or when a cycle is detected
        /// </summary>
        /// <param name="v0">The start vertex</param>
        /// <param name="vEnd">An optional endpoint</param>
        /// <returns></returns>
        public IEnumerable<V> Path(V v0,  V vEnd = default)
        {
            foreach(var target in Targets(v0))
            {
                
                yield return target;
                
                if(target.Equals(v0) || target.Equals(vEnd)) 
                    break;                
                
                foreach(var subnode in Path(target,  v0))
                    yield return subnode;
            }
        }

    }

}