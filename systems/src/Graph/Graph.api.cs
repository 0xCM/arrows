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
    /// Defines the primary API surface for manipulated graphs
    /// and related elements
    /// </summary>
    public static class Graph
    {
        /// <summary>
        /// Constructs a graph from an adjacency matrix of natural dimension
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dim">The dimension of the matrix</param>
        /// <param name="v">An arbitrary value to help type inference</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        /// <typeparam name="N">The dimension type</typeparam>
        /// <typeparam name="T">The source matrix element type</typeparam>
        public static Graph<V> FromAdjacenyMatrix<V,N,T>(BitMatrix<N,N,T> src, N dim = default, V v = default)
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

        /// <summary>
        /// Constructs an 8-node graph from an 8x8 adjacency matrix
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> FromAdjacenyMatrix(in BitMatrix8 src)
            => FromAdjacenyMatrix<byte,N8,byte>(new BitMatrix<N8,N8,byte>(src.Bytes()));            

        /// <summary>
        /// Constructs a 16-node graph from an 16x16 adjacency matrix
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> FromAdjacenyMatrix(in BitMatrix16 src)
            => FromAdjacenyMatrix<byte,N16,byte>(new BitMatrix<N16,N16,byte>(src.Bytes()));            

        /// <summary>
        /// Constructs a 32-node graph from an 32x32 adjacency matrix
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> FromAdjacenyMatrix(in BitMatrix32 src)
            => FromAdjacenyMatrix<byte,N32,byte>(new BitMatrix<N32,N32,byte>(src.Bytes()));            

        /// <summary>
        /// Constructs a 64-node graph from an 64x64 adjacency matrix
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> FromAdjacenyMatrix(in BitMatrix64 src)
            => FromAdjacenyMatrix<byte,N64,byte>(new BitMatrix<N64,N64,byte>(src.Bytes()));            

        /// <summary>
        /// Creates a graph from supplied vertices and edges
        /// </summary>
        /// <param name="vertices">The vertices in the graph</param>
        /// <param name="edges">The edges that connect the vertices</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        [MethodImpl(Inline)]    
        public static Graph<V,T> Define<V,T>(IEnumerable<Vertex<V,T>> vertices, IEnumerable<Edge<V>> edges)
            where V : struct
            where T : struct
                => Graph<V,T>.Define(vertices,edges);

        /// <summary>
        /// Creates a graph from supplied vertices and edges
        /// </summary>
        /// <param name="vertices">The vertices in the graph</param>
        /// <param name="edges">The edges that connect the vertices</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        [MethodImpl(Inline)]    
        public static Graph<V,T> Define<V,T>(Span<Vertex<V,T>> vertices, IEnumerable<Edge<V>> edges)
            where V : struct
            where T : struct
                => Graph<V,T>.Define(vertices,edges);

        /// <summary>
        /// Creates a graph from supplied vertices and edges
        /// </summary>
        /// <param name="vertices">The vertices in the graph</param>
        /// <param name="edges">The edges that connect the vertices</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        [MethodImpl(Inline)]    
        public static Graph<V> Define<V>(Span<Vertex<V>> vertices, IEnumerable<Edge<V>> edges)
            where V : struct
            => Graph<V>.Define(vertices, edges);

        /// <summary>
        /// Defines an edge from an index-identified source to an index identified target
        /// </summary>
        /// <param name="src">The source index</param>
        /// <param name="dst">The target index</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        [MethodImpl(Inline)]    
        public static Edge<V> Edge<V>(V src, V dst)
            where V : struct
                => (src,dst);

        /// <summary>
        /// Defines a weighted edge from an index-identified source to an index identified target
        /// </summary>
        /// <param name="src">The source index</param>
        /// <param name="dst">The target index</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        [MethodImpl(Inline)]    
        public static Edge<V,W> Edge<V,W>(V src, V dst, W weight)
            where V : struct
            where W : struct
                => (src,dst,weight);

        /// <summary>
        /// Connects a source vertex to a target vertex
        /// </summary>
        /// <param name="src">The source vertex</param>
        /// <param name="dst">The target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        /// <typeparam name="T">The vertex payload type</typeparam>
        [MethodImpl(Inline)]    
        public static Edge<V> Connect<V,T>(in Vertex<V,T> src, in Vertex<V,T> dst)
            where V : struct
            where T : struct
                => new Edge<V>(src.Index,dst.Index);

        /// <summary>
        /// Connects a source vertex to a target vertex
        /// </summary>
        /// <param name="src">The source vertex</param>
        /// <param name="dst">The target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        public static Edge<V> Connect<V>(in Vertex<V> src, in Vertex<V> dst)
            where V : struct
                => new Edge<V>(src.Index,dst.Index);

        /// <summary>
        /// Creates a vertex without payload
        /// </summary>
        /// <param name="index">The index of the vertex that servies as a 
        /// unique identifier within the context of a graph</param>
        /// <typeparam name="V">The index type</typeparam>
        public static Vertex<V> Vertex<V>(V index)
            where V : struct
                => new Vertex<V>(index);

        /// <summary>
        /// Defines a vertex sequence with a specified length
        /// </summary>
        /// <param name="count">The number of virtices in the sequence</param>
        /// <typeparam name="V">The index type</typeparam>
        public static Span<Vertex<V>> Vertices<V>(int count)
            where V : struct
        {
            Span<Vertex<V>> dst = new Vertex<V>[count];
            for(var i=0; i<count; i++)
                dst[i] = new Vertex<V>(convert<V>(i));
            return dst;
        }

        /// <summary>
        /// Defines a vertex with payload for each source item
        /// </summary>
        /// <param name="s0">The first index assigned</param>
        /// <param name="data">The vertex payloads</param>
        /// <typeparam name="V">The index type</typeparam>
        public static Span<Vertex<V,T>> Vertices<V,T>(V s0, params T[] data)
            where V : struct
            where T : struct
        {
            var start = convert<V,ulong>(s0);
            Span<Vertex<V,T>> dst = new Vertex<V,T>[data.Length];

            for(var i=0; i<data.Length; i++, start++)
                dst[i] = new Vertex<V,T>(convert<V>(start),data[i]);
            return dst;
        }

        /// <summary>
        /// Creates a vertex with payload
        /// </summary>
        /// <param name="index">The index of the vertex that servies as a 
        /// unique identifier within the context of a graph</param>
        /// <typeparam name="V">The index type</typeparam>
        /// <typeparam name="V">The payload type</typeparam>
        [MethodImpl(Inline)]    
        public static Vertex<V,T> Vertex<V,T>(V index, T data)
            where V : struct
            where T : struct
                => new Vertex<V, T>(index,data);


        /// <summary>
        /// Finds the edges in a graph that target an identified vertex
        /// </summary>
        /// <param name="graph">The declaring graph</param>
        /// <param name="target">The index of the target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        public static ReadOnlySpan<Edge<V>> Incoming<V>(Graph<V> graph, V target)
            where V : struct
        {            
            Span<Edge<V>> dst = new Edge<V>[graph.EdgeCount];
            var j = 0;
            for(var i = 0u; i<graph.Edges.Length; i++)
            {
                ref readonly var edge = ref graph.Edge(i);
                if(gmath.eq(edge.Target, target))
                    dst[j++] = edge;                    
            }
            return dst.Slice(0, j);
        }


        /// <summary>
        /// Finds the edges in a graph that emit from an identified vertex
        /// </summary>
        /// <param name="graph">The declaring graph</param>
        /// <param name="target">The index of the target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        public static ReadOnlySpan<Edge<V>> Outgoing<V>(Graph<V> graph, V source)
            where V : struct
        {            
            Span<Edge<V>> dst = new Edge<V>[graph.EdgeCount];
            var j = 0;
            for(var i = 0u; i<graph.Edges.Length; i++)
            {
                ref readonly var edge = ref graph.Edge(i);
                if(gmath.eq(edge.Source, source))
                    dst[j++] = edge;                    
            }
            return dst.Slice(0, j);
        }

        /// <summary>
        /// Renders a graph using basic graphviz format
        /// </summary>
        /// <param name="graph">The declaring graph</param>
        /// <param name="label">An optional label for the graph</param>
        /// <typeparam name="V">The verex index type</typeparam>
        public static string Format<V>(Graph<V> src, string label = null)
            where V : struct
        {
            var text = sbuild();
            text.AppendLine("digraph " +(label ?? "g") + "   {");
            for(var i=0; i< src.Edges.Length; i++)
            {
                var edge = src.Edges[i];
                text.AppendLine($"    {edge.Source} -> {edge.Target}");                
            }
            text.AppendLine("}");
            return text.ToString();
        }

    }
}