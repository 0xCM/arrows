//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;



    /// <summary>
    /// Characterizes a set by the type of individual it contains
    /// </summary>
    public interface Set<I>
    {
        bool contains(I item);
    }

    /// <summary>
    /// Characterizes a type that has a countable number of values
    /// </summary>
    /// <typeparam name="T">The type of the discretized individual</typeparam>
    public interface DiscreteSet<T> : Set<T>
    {
        Enumerable<T> individuals();            
    }

    public interface FiniteSet<T> : DiscreteSet<T>
    {
        /// <summary>
        /// Specifies the number of contained elements
        /// </summary>
        int count {get;}

    }

}
