//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;

    public static class GraphX
    {
        /// <summary>
        /// Produces an edge that connects a source vertex to a target vertex
        /// </summary>
        /// <param name="src">The source vertex</param>
        /// <param name="dst">The target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        /// <typeparam name="T">The vertex payload type</typeparam>
        public static Edge<V> Connect<V,T>(this Vertex<V,T> src, Vertex<V,T> dst)
            where V : struct
            where T : struct
                => Graph.Connect(src,dst);

        /// <summary>
        /// Produces an edge that connects a source vertex to a target vertex
        /// </summary>
        /// <param name="src">The source vertex</param>
        /// <param name="dst">The target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        public static Edge<V> Connect<V>(this Vertex<V> src, Vertex<V> dst)
            where V : struct
                => Graph.Connect(src,dst);
        
        /// <summary>
        /// Converts an graph edge to an arrow
        /// </summary>
        /// <param name="e">The edge to convert</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        [MethodImpl(Inline)]
        public static Arrow<V> ToArrow<V>(this Edge<V> e)
            where V : struct
                => new Arrow<V>(e.Source, e.Target);

        /// <summary>
        /// Renders a graph using basic graphviz format
        /// </summary>
        /// <param name="graph">The declaring graph</param>
        /// <param name="label">An optional label for the graph</param>
        /// <typeparam name="V">The verex index type</typeparam>
        public static string Format<V>(this Graph<V> graph, string label = null)
            where V : struct
                => Graph.Format(graph,label);

        /// <summary>
        /// Finds the edges in a graph that target an identified vertex
        /// </summary>
        /// <param name="graph">The declaring graph</param>
        /// <param name="target">The index of the target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        public static ReadOnlySpan<Edge<V>> Incoming<V>(this Graph<V> graph, V target)
            where V : struct
                => Graph.Incoming(graph, target);

        /// <summary>
        /// Finds the edges in a graph that emit from an identified vertex
        /// </summary>
        /// <param name="graph">The declaring graph</param>
        /// <param name="target">The index of the target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        public static ReadOnlySpan<Edge<V>> Outgoing<V>(this Graph<V> graph, V source)
            where V : struct
                => Graph.Outgoing(graph, source);

    }
}