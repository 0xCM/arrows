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
    /// Defines a weighted edge, parameterized by the vertex index type and the weight type
    /// </summary>
    public readonly struct Edge<V,W> : IEdge<V,W>
        where V : struct
        where W : struct
    {
        /// <summary>
        /// Sheds the associated weight to form a weight-free edge
        /// </summary>
        /// <param name="src">The source vertex</param>
        [MethodImpl(Inline)]
        public static implicit operator Edge<V>(Edge<V,W> src)
            => new Edge<V>(src.Source, src.Target);
        
        /// <summary>
        /// Constructs an edge from a 3-tuple
        /// </summary>
        /// <param name="src">The source index</param>
        /// <param name="dst">The target index</param>
        /// <param name="weight">The weight</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        /// <typeparam name="W">The weight type</typeparam>
        [MethodImpl(Inline)]
        public static implicit operator Edge<V,W>((V src, V dst, W weight) x)
            => new Edge<V, W>(x.src, x.dst, x.weight);

        [MethodImpl(Inline)]
        public Edge(V Source, V Target, W Weight)
        {
            this.Source = Source;
            this.Target = Target;
            this.Weight = Weight;
        }
        
        /// <summary>
        /// The index of the source vertex
        /// </summary>
        public readonly V Source;

        /// <summary>
        /// The index of the target vertex
        /// </summary>
        public readonly V Target;

        /// <summary>
        /// The weight given to the edge
        /// </summary>
        public readonly W Weight;

        V IEdge<V>.Source 
            => Source;

        V IEdge<V>.Target 
            => Target;

        W IEdge<V, W>.Weight 
            => Weight;

        public override string ToString() 
            => $"{Source} -> {Target}";

    }

}