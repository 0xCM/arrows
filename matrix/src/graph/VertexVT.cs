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
    /// Defines a vertex to which data may be attached
    /// </summary>
    /// <typeparam name="V">The vertex index type</typeparam>
    /// <typeparam name="T">The payload type</typeparam>
    public readonly struct Vertex<V,T> : IVertex<V,T>
        where T : struct
        where V : struct
    {
        [MethodImpl(Inline)]
        public static Edge<V> operator +(Vertex<V,T> source, Vertex<V,T> target)
            => source.Connect(target);

        /// <summary>
        /// Sheds the associated data to form a payload-free vertex
        /// </summary>
        /// <param name="src">The source vertex</param>
        [MethodImpl(Inline)]
        public static implicit operator Vertex<V>(Vertex<V,T> src)
            => new Vertex<V>(src.Index);

        [MethodImpl(Inline)]
        public Vertex(V Index, T Data)
        {
            this.Index = Index;
            this.Data = Data;
        }

        /// <summary>
        /// The index of the vertex that uniquely identifies it within a graph
        /// </summary>
        public readonly V Index;

        /// <summary>
        /// The vertex payload
        /// </summary>
        public readonly T Data;

        T IVertex<V, T>.Data 
            => Data;

        V IVertex<V>.Index 
            => Index;

        public override string ToString() 
            => $"({Index},{Data})";
    }
}