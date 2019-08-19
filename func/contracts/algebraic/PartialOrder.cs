//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes a partial order, i.e. a reflexive, transitive and 
    /// antisymmetric binary operator
    /// </summary>
    /// <typeparam name="T">The relation domain</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Partially_ordered_set</remarks>
    public interface IPartialOrderOps<T> : IReflexiveOps<T>, IAntisymmetricOps<T>, ITransitiveOps<T>
    {

    }


    /// <summary>
    /// Characterizes a set equipped with a partial order
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Partially_ordered_set </remarks>
    public interface IPosetOps<T> : IPartialOrderOps<T>

    {
        /// <summary>
        /// Determines whether order may be adjudicated between two particluar elements
        /// </summary>
        /// <param name="x">The left element</param>
        /// <param name="y">The right element</param>
        /// <returns>Returns true if either a ~ b or b ~ a and false oterwise</returns>
        bool Comparable(T x, T y);
    }



}