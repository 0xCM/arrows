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

    
    public readonly struct Edge : IEdge
    {        
        public Edge(ulong Source, ulong Target)
        {
            this.Source = Source;
            this.Target = Target;
        }
        
        public readonly ulong Source;

        public readonly ulong Target;


        public override string ToString() 
            => $"{Source} -> {Target}";

    }

}