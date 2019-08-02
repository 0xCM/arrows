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

    public class GraphBuilder<V>
        where V : struct
    {
        public GraphBuilder()
        {
            NextIndex = 0;
            Vertices = new List<Vertex<V>>();

        }

        ulong NextIndex;
        
        List<Vertex<V>> Vertices;
        public GraphBuilder<V> WithVertex()
        {
            Vertices.Add(new Vertex<V>(convert<V>(NextIndex++)));
            return this;
        }
    }
}