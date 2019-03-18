//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using Root;
    using Content;
    
    using static corefunc;

    using C = Contracts;


    /// <summary>
    /// Represents a directed graph with two node types
    /// </summary>
    public readonly struct Digraph
    {
        Map<Label,C.Arrow> edges {get;}    

        public Digraph(IEnumerable<C.Arrow> edges)
            => this.edges = index(edges.Select(x => (x.label,x)));

        
        public Option<Arrow<A,B>> arrow<A,B>(Label label)
            => map(edges.lookup(label), x => (Arrow<A,B>) x);
    }

    

    public readonly struct Triangle<X1,X2,X3>
    {
        Map<Label,C.Arrow> edges {get;} 

        public Triangle(IEnumerable<C.Arrow> edges)
            => this.edges = index(edges.Select(x => (x.label,x)));

    }


}