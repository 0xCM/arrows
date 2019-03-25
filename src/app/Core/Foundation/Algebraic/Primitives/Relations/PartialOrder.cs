//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;

    partial class Traits
    {

        /// <summary>
        /// Characterizes a partial order, i.e. a reflexive, transitive and 
        /// antisymmetric binary operator
        /// </summary>
        /// <typeparam name="T">The relation domain</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Partially_ordered_set</remarks>
        public interface PartialOrder<T> : Reflexive<T>, Antisymmetric<T>, Transitive<T>
        {

        }


        /// <summary>
        /// Characterizes a set equipped with a partial order
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Partially_ordered_set </remarks>
        public interface Poset<T> : Set<T>, PartialOrder<T>
            where T : IEquatable<T>

        {
            /// <summary>
            /// Determines whether order may be adjudicated between two particluar elements
            /// </summary>
            /// <param name="x">The left element</param>
            /// <param name="y">The right element</param>
            /// <returns>Returns true if either a ~ b or b ~ a and false oterwise</returns>
            bool comparable(T x, T y);
        }

    }



}