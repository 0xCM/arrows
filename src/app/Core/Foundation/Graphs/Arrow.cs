//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface Pointed<X>
    {
        X basepoint {get;}    
    }

    public interface Edge 
    {
        /// <summary>
        /// Specifies the edge's logical identifier that must be
        /// unique within a graph
        /// </summary>
        /// <value></value>
        Label label {get;}

    }

    public interface Edge<A,B> : Edge
    {

    }

    public interface PointedEdge<S,T> : Edge
    {
        /// <summary>
        /// Specifies the S-valued basepoint
        /// </summary>
        S source {get;}

        /// <summary>
        /// Specifies the T-valued basepoint
        /// </summary>
        T target {get;}


    }

    /// <summary>
    /// Represents a path from a dynamically-typed source node to a dynamically-typed target node
    /// </summary>
    public interface Arrow : Edge
    {
    
        
    }
    
    /// <summary>
    /// Represents a path from a statically-typed source node to a statically-typed target node
    /// </summary>
    /// <typeparam name="S">The source node type</typeparam>
    /// <typeparam name="T">The target node type</typeparam>
    public interface Arrow<S,T> : Arrow, Edge<S,T>
    {
        T apply(S src);
    }

    /// <summary>
    /// Defines an arrow of higher-kind k=2 from one arrow to another
    /// </summary>
    /// <typeparam name="S1"></typeparam>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="S2"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public interface Arrow<S1,T1,S2,T2> : Arrow<Arrow<S1,T1>,Arrow<S2,T2>>
    {

    }

    /// <summary>
    /// Represents a path from the basepoint of a source node to the 
    /// basepoint of a target node
    /// </summary>
    /// <typeparam name="S">The source node</typeparam>
    /// <typeparam name="T">The target node</typeparam>
    public interface PointedArrow<S,T> : PointedEdge<S,T>
    {
 
    }


}