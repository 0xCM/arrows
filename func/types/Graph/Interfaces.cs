//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public interface IEdge
    {
        
    }

    public interface IEdge<V> : IEdge
        where V : struct
    {
        V Source {get;}

        V Target {get;}
    }

    public interface IEdge<V,W> : IEdge<V>
        where V : struct
        where W : struct
    {
        W Weight {get;}
    }

    public interface IVertex
    {
        
    }    

    public interface IVertex<V> : IVertex
        where V : struct
    {
        /// <summary>
        /// The index of the vertex that uniquely identifies
        /// it within a graph
        /// </summary>
        V Index {get;}        
    }    

    public interface IVertex<V,T> : IVertex<V>
        where V : struct
        where T : struct
    {
        T Data {get;} 
    }    


}