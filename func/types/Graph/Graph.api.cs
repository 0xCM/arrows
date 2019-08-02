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
    /// Defines the primary API surface for manipulated graphs
    /// and related elements
    /// </summary>
    public static class Graph
    {

        public static Graph<V,T> Define<V,T>(IEnumerable<Vertex<V,T>> vertices, IEnumerable<Edge<V>> edges)
            where V : struct
            where T : struct
                => Graph<V,T>.Define(vertices,edges);
        
        /// <summary>
        /// Connects a source vertex to a target vertex
        /// </summary>
        /// <param name="src">The source vertex</param>
        /// <param name="dst">The target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        /// <typeparam name="T">The vertex payload type</typeparam>
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
        public static Vertex<V,T> Vertex<V,T>(V index, T data)
            where V : struct
            where T : struct
                => new Vertex<V, T>(index,data);

    }




}