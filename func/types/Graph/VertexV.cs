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
    /// Defines a vertex within a graph
    /// </summary>
    public readonly struct Vertex<V> : IVertex<V>
        where V : struct
    {        
        public static Edge<V> operator +(Vertex<V> source, Vertex<V> target)
            => source.Connect(target);

        public Vertex(V Index)
        {
            this.Index = Index;
        }

        /// <summary>
        /// The index of the vertex that uniquely identifies
        /// it within a graph
        /// </summary>
        public readonly V Index;

        V IVertex<V>.Index 
            => Index;

        public override string ToString() 
            => $"({Index})";

    }


}