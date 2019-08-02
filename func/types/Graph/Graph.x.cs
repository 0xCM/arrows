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

    public static class GraphX
    {
        public static Edge<V> Connect<V,T>(this Vertex<V,T> src, Vertex<V,T> dst)
            where V : struct
            where T : struct
                => Graph.Connect(src,dst);

        public static Edge<V> Connect<V>(this Vertex<V> src, Vertex<V> dst)
            where V : struct
                => Graph.Connect(src,dst);
    }


}