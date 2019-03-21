//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes a type in the sense that an object A is a type if it inhabits
    /// some universe
    /// </summary>
    public interface Inhabitant
    {
        /// <summary>
        /// The least universe, with respect to hierarchy, if known/relevant, in which the
        /// inhabitant may be found
        /// </summary>
        /// <value></value>
        Option<Universe> Location {get;}
    }

    /// <summary>
    /// Characterizes a type that inhabits a specific universe
    /// </summary>
    public interface Inhabitant<U> : Inhabitant
        where U : Universe
    {
        /// <summary>
        /// The least universe, with respect to hierarchy, if known/relevant, in which the
        /// inhabitant may be found
        /// </summary>
        /// <value></value>
        new Option<U> Location {get;}
    }

    /// <summary>
    /// Characterizes a function whose type inhabits a specified universe
    /// </summary>
    /// <typeparam name="A">The function domain</typeparam>
    /// <typeparam name="B">The function codomain</typeparam>
    /// <typeparam name="U">The universe that is inhabited by the function type A->B</typeparam>
    public interface Function<A,B,U> : Inhabitant<U>, Function<A,B>
        where U : Universe        
    {

    }


    /// <summary>
    /// Characterizes a type that is inhabited by other types
    /// </summary>
    /// <remarks>
    /// See http://localhost:9000/refs/books/Y2013HTT.pdf#page=36
    /// </remarks>
    public interface Universe : Inhabitant
    {
        IEnumerable<Inhabitant> inhabitants {get;}
    }

    

    /// <summary>
    /// Characterizes a universe at a specific level in a given hierarchy of universes
    /// </summary>
    public interface IndexedUniverse : Universe
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
    public interface Universe<A> : Universe
        where A : Inhabitant
    {

    }

    /// <summary>
    /// Characterizes a universe that is simultaneously inhabited by 
    /// two specified types
    /// </summary>
    /// <typeparam name="A">The type contained by the universe</typeparam>
    public interface Universe<A,B> : Universe
        where A : Inhabitant
        where B : Inhabitant
    {

    }

    /// <summary>
    /// Characterizes any type family
    /// </summary>
    public interface TypeFamily : Function
    {

    }

    /// <summary>
    /// Characterizes a type family with domain A and codomain U. This models
    /// a collection of types indexed by A-values, typically denoted by
    /// B:A->U where B is understood to be a type that **depends** on a value
    /// of A.
    /// </summary>
    /// <typeparam name="A">The domain</typeparam>
    /// <typeparam name="U">The codomain</typeparam>
    /// <remarks>
    /// See http://localhost:9000/refs/books/Y2013HTT.pdf#page=36
    /// </remarks>
    public interface TypeFamily<in A, out U> : TypeFamily, Function<A,U>
        where U : Universe
    {

    }

    /// <summary>
    /// Characterizes a constant type family
    /// </summary>
    /// <typeparam name="A">The domain</typeparam>
    /// <typeparam name="B">A distinguished element of U</typeparam>
    /// <typeparam name="U">The universe containing B</typeparam>
    public interface TypeFamily<in A, out B, U> : TypeFamily<A,U>
        where U : Universe
    {


    }

    /// <summary>
    /// Characterizes a function that ranges over values of a type A ∈ 𝒰 and
    /// yields values (types) in 𝒰
    /// </summary>
    /// <typeparam name="A">The function domain type</typeparam>
    /// <typeparam name="U">The universal codomain</typeparam>
    /// <remarks>
    /// See http://localhost:9000/refs/books/Y2013HTT.pdf#page=37
    /// </remarks>
    public interface DependentFunction<A,U> : Function<A,U>
       where U : Universe
    {

        TypeFamily<A,U> B {get;}
    }
}