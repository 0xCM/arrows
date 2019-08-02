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

    public readonly struct Edge<V,W> : IEdge<V,W>
        where V : struct
        where W : struct
    {
        public static implicit operator Edge<V>(Edge<V,W> src)
            => new Edge<V>(src.Source, src.Target);
        public Edge(V Source, V Target, W Weight)
        {
            this.Source = Source;
            this.Target = Target;
            this.Weight = Weight;
        }
        
        public readonly V Source;

        public readonly V Target;

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