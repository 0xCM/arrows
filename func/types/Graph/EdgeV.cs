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

    public readonly struct Edge<V> : IEdge<V>
        where V : struct
    {
        public static implicit operator (V src, V dst)(Edge<V> edge)
            => (edge.Source,edge.Target);
        
        public Edge(V Source, V Target)
        {
            this.Source = Source;
            this.Target = Target;
        }
        
        public readonly V Source;

        public readonly V Target;

        V IEdge<V>.Source 
            => Source;

        V IEdge<V>.Target 
            => Target;

        public override string ToString() 
            => $"{Source} -> {Target}";

    }


}