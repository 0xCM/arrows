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

    /// <summary>
    /// Defines an unweighted edge, parameterized by the vertex index type
    /// </summary>
    /// <typeparam name="V">The vertex index type</typeparam>
    public readonly struct Edge<V> : IEdge<V>
        where V : struct
    {
        [MethodImpl(Inline)]
        public static implicit operator (V src, V dst)(Edge<V> edge)
            => (edge.Source,edge.Target);

        [MethodImpl(Inline)]
        public static implicit operator Edge<V>((V src, V dst) x)
            => (x.src,x.dst);
        
        [MethodImpl(Inline)]
        public Edge(V Source, V Target)
        {
            this.Source = Source;
            this.Target = Target;
        }
        
        /// <summary>
        /// The index of the source vertex
        /// </summary>
        public readonly V Source;

        /// <summary>
        /// The index of the target vertex
        /// </summary>
        public readonly V Target;

        V IEdge<V>.Source 
            => Source;

        V IEdge<V>.Target 
            => Target;

        public string Format() 
            => $"{Source} -> {Target}";

        public override string ToString() 
            => Format();
    }
}