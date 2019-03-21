//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;

    public interface Set
    {
        /// <summary>
        /// Specifies whether the set is void of elements
        /// </summary>
        /// <value></value>
        bool empty {get;}
    }

    /// <summary>
    /// Characterizes a set by the type of individual it contains
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface Set<T> : Set
    {
        bool contains(T item);
    }

    /// <summary>
    /// Characterizes a set that contains at least one individual
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface NonempySet<T> : Set<T>
    {

    }

    /// <summary>
    /// Characterizes a set by the type of individual it contains
    /// </summary>
    public interface Set<S,T> : Set<T>
        where S : Set<S,T>
    {

    }

    /// <summary>
    /// Characterizes a type that has a countable number of values
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface DiscreteSet<T> : Set<T>
    {
        Enumerable<T> individuals();            
    }

    /// <summary>
    /// Characterizes a type that represents an infinite number of values
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface InfiniteSet<T> : Set<T>
    {

    }

    /// <summary>
    /// Characteriizes a set that contains a finite number of values
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface FiniteSet<T> : DiscreteSet<T>
    {
        /// <summary>
        /// Evidence that the set is indeed finite
        /// </summary>
        int count {get;}

    }

    /// <summary>
    /// Characteries a type that repesents an infinite number of values but
    /// which can be enumerated
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface InfiniteDiscreteSet<T> : InfiniteSet<T>, DiscreteSet<T>
    {

    }
}
