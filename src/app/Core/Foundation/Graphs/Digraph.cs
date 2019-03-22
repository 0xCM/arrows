//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
        
    using static corefunc;
      

    /// <summary>
    /// Represents a directed graph with two node types
    /// </summary>
    public readonly struct Digraph
    {
        Index<Label,Traits.Arrow> edges {get;}    

        public Digraph(IEnumerable<Traits.Arrow> edges)
            => this.edges = index(edges.Select(x => (x.label,x)));

        
        // public Option<Arrow<A,B>> arrow<A,B>(Label label)
        //     => map(edges.lookup(label), x => (Arrow<A,B>) x);
    }

    

    public readonly struct Triangle<X1,X2,X3>
    {
        Index<Label, Traits.Arrow> edges {get;} 

        public Triangle(IEnumerable<Traits.Arrow> edges)
            => this.edges = index(edges.Select(x => (x.label,x)));

    }


}