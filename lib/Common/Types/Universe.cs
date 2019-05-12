//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes a type in the sense that an object A is a type if it inhabits
    /// some universe
    /// </summary>
    public interface IInhabitant
    {
    }

    /// <summary>
    /// Characterizes a type that inhabits a specific universe
    /// </summary>
    public interface IInhabitant<U> : IInhabitant
        where U : IUniverse
    {
        /// <summary>
        /// The least universe, with respect to hierarchy, if known/relevant, in which the
        /// inhabitant may be found
        /// </summary>
        Option<U> Location();
    }

    
    /// <summary>
    /// Characterizes a type that is inhabited by other types
    /// </summary>
    /// <remarks>
    /// See http://localhost:9000/refs/books/Y2013HTT.pdf#page=36
    /// </remarks>
    public interface IUniverse : IInhabitant
    {
        IEnumerable<IInhabitant> Inhabitants();
    }
    

    /// <summary>
    /// Characterizes a universe at a specific level in a given hierarchy of universes
    /// </summary>
    public interface IIndexedUniverse : IUniverse
    {
        /// <summary>
        /// The location of the universe within the context of a universe hierachy
        /// </summary>
        /// <value></value>
        int level {get;}
    }
    
    /// <summary>
    /// Characterizes a universe that is inhabited by a specified type
    /// </summary>
    /// <typeparam name="A">The type contained by the universe</typeparam>
    public interface IUniverse<A> : IUniverse
        where A : IInhabitant
    {

    }

    /// <summary>
    /// Characterizes a universe that is simultaneously inhabited by 
    /// two specified types
    /// </summary>
    /// <typeparam name="A">The type contained by the universe</typeparam>
    public interface IUniverse<A,B> : IUniverse
        where A : IInhabitant
        where B : IInhabitant
    {

    }

 
}