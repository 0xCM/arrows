//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;



    public static partial class Contain
    {


        public interface Container<S>
            where S : Container<S>, new()
        {
            
        }

        /// <summary>
        /// Characterizes a set that, if nonempty, contains elements of unknown type
        /// </summary>
        public interface Set
        {
            /// <summary>
            /// Specifies whether the set is void of elements
            /// </summary>
            /// <value></value>
            bool empty {get;}

            /// <summary>
            /// Specifies whether the set is finite
            /// </summary>
            bool finite {get;}

            /// <summary>
            /// Specifies whether the set is discrete
            /// </summary>
            bool discrete {get;}

            /// <summary>
            /// Determines whether a supplied value is a member of the reified set
            /// </summary>
            /// <param name="candidate">The potential member to check</param>
            /// <returns></returns>
            bool member(object candidate);
        }

        /// <summary>
        /// Characterizes a set that, if nonempty, contains elements of specific type
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        public interface Set<T> : Set
        {

        }

        public interface Seq<S,T> 
            where S : Seq<S,T>, new()
        {
            
        }

        public interface DiscreteContainer<S,T> : Container<S>
            where S : DiscreteContainer<S,T>, new()
        {
            IEnumerable<T> content {get;}
        }


        public interface FiniteContainer<S,T> : DiscreteContainer<S,T>
            where S : FiniteContainer<S,T>, new()
        {
            /// <summary>
            /// The count providing evidence that the content is finite
            /// </summary>
            uint count {get;}

        }

        /// <summary>
        /// Characterizes an enumerable with a known length as specified
        /// by a natural type parameter
        /// </summary>
        public interface Enumerable<N,I> : IEnumerable<I>
            where N : TypeNat, new()
        {

            /// <summary>
            /// The value of the natural parameter
            /// </summary>
            uint length {get;}
        }

        public interface Array<N,T> : Enumerable<N,T>
            where N : TypeNat, new()
        {
            T this[int ix] {get; set;}

        }


        /// <summary>
        /// Characterizes a set indexed by another set
        /// </summary>
        /// <typeparam name="I">The indexing set</typeparam>
        /// <typeparam name="X">The indexed set</typeparam>
        public interface Index<I,T> : DiscreteContainer<I,KeyedValue<I,T>>
            where I : Index<I,T>, new()
        {
            /// <summary>
            /// Retrives an indexed value
            /// </summary>
            /// <param name="index">The index value</param>
            /// <returns>The indexed value</returns>
            T item(I index);

            /// <summary>
            /// Retrives an indexed value via an index operator
            /// </summary>
            /// <param name="index">The index value</param>
            /// <returns>The indexed value</returns>
            T  this[I ix] {get;}
        }


        /// <summary>
        /// Characterizes a set that has a countable number of members
        /// </summary>
        /// <typeparam name="T">The member type</typeparam>
        public interface DiscreteSet<S> : Set<S>
        {
        }

        /// <summary>
        /// Characteriizes a reified set that contains a finite number of values
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        /// <typeparam name="T">The member type</typeparam>
        public interface FiniteSet<S,T> : DiscreteSet<S,T>, IEquatable<S>
            where S : FiniteSet<S,T>, new()
        {
            /// <summary>
            /// Evidence that the set is indeed finite
            /// </summary>
            int count {get;}


            /// <summary>
            /// Determines whether the current set is a subset of a specified set.
            /// </summary>
            /// <param name="rhs">The candidate superset</param>
            /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
            bool subset(S rhs, bool proper = true);
            
            /// <summary>
            /// Determines whether the current set is a superset of a specified set.
            /// </summary>
            /// <param name="rhs">The candidate subset</param>
            /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
            /// <returns></returns>
            bool superset(S rhs, bool proper = true);

            /// <summary>
            /// Calculates the union between the current set and a specified set and
            /// returns a new set that embodies this result
            /// </summary>
            /// <param name="rhs">The set with which to union/param>
            S union(S rhs);
            
            /// <summary>
            /// Calculates the intersection between the current set and a specified set and
            /// returns a new set that embodies this result
            /// </summary>
            /// <param name="rhs">The set with which to intersect</param>
            S intersect(S rhs);
            
            /// <summary>
            /// Calculates the set difference, or symmetric difference, between the current 
            /// set and a specified set and returns a new set that embodies this result
            /// </summary>
            /// <param name="rhs">The set that should be differenced</param>
            /// <remarks>See https://en.wikipedia.org/wiki/Symmetric_difference</remarks>
            S difference(S rhs, bool symmetric = false);
        }


        /// <summary>
        /// Characteriizes a reified set for which there are a countable number of members
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        /// <typeparam name="M">The member type</typeparam>
        public interface DiscreteSet<S,T> : DiscreteSet<S>
            where S: DiscreteSet<S,T>, new()
        {
            /// <summary>
            /// Enumerates the members of the set
            /// </summary>
            Z0.Seq<T> members();
        }
    }
}