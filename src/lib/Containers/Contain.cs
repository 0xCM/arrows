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

        /// <summary>
        /// Characterizes a reified container
        /// </summary>
        /// <typeparam name="S">The container type</typeparam>
        public interface Container<S>
            where S : Container<S>, new()
        {
            
        }

        /// <summary>
        /// Characterizes a reified container parametrized by the contained type
        /// </summary>
        /// <typeparam name="S">The container type</typeparam>
        /// <typeparam name="T">The contained type</typeparam>
        public interface Container<S,T> : Container<S>
            where S : Container<S,T>, new()
        {
            
        }

        /// <summary>
        /// Characterizes a set that contains at least one individual
        /// </summary>
        /// <typeparam name="T">The member type</typeparam>
        public interface NonempySet<T> 
            where T : NonempySet<T>, new()
        {

        }

        /// <summary>
        /// Characterizes a set that contains at least one individual
        /// </summary>
        /// <typeparam name="T">The member type</typeparam>
        public interface NonempySet<S,T> : NonempySet<S>
            where S : NonempySet<S,T>, new()
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
            /// Determines whether a value is a member
            /// </summary>
            /// <param name="candidate">The potential member to check</param>
            bool member(object candidate);
        }

        /// <summary>
        /// Characterizes a set that, if nonempty, contains elements of specific type
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        public interface Set<T> : Set
        {
        }


        /// <summary>
        /// Characterizes a reified set
        /// </summary>
        /// <typeparam name="S">The container type</typeparam>
        /// <typeparam name="T">The contained type</typeparam>
        public interface Set<S,T> : Set<T>, Container<S,T>
            where S : Set<S,T>, new()
        {
            /// <summary>
            /// Determines whether a supplied value is a member of the reified set
            /// </summary>
            /// <param name="candidate">The potential member to check</param>
            bool member(T candidate);
        
        }

        /// <summary>
        /// Characterizes a container that comprises discrete content
        /// </summary>
        /// <typeparam name="S">The container type</typeparam>
        /// <typeparam name="T">The contained type</typeparam>
        public interface DiscreteContainer<S,T> : Container<S,T>
            where S : DiscreteContainer<S,T>, new()
        {
            IEnumerable<T> content {get;}
        }

        /// <summary>
        /// Characterizes a concatenable container with discrete content 
        /// </summary>
        /// <typeparam name="S">The container type</typeparam>
        /// <typeparam name="T">The contained type</typeparam>
        public interface Seq<S,T> : DiscreteContainer<S,T>, Structures.Concatenable<S,T>
            where S : Seq<S,T>, new()
        {
            
        }

        /// <summary>
        /// Characterizes a container of semigroup elements which is, itself, a semigroup
        /// </summary>
        /// <typeparam name="S">The reifying type</typeparam>
        /// <typeparam name="T">The contained type</typeparam>
        public interface SemiSeq<S,T> : Seq<S,T>, Structures.Semigroup<S>
            where S : SemiSeq<S,T>, new()
            where T : Structures.Semigroup<T>, new()
        {

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
            /// <summary>
            /// Specifies or retrieves an array value via an unchecked index
            /// </summary>
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
        /// Characteriizes a reified set for which there are a countable number of members
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        /// <typeparam name="T">The member type</typeparam>
        public interface DiscreteSet<S,T> : Set<S,T>, DiscreteContainer<S,T>
            where S: DiscreteSet<S,T>, new()
        {

        }

        /// <summary>
        /// Characterizes a type that represents an infinite number of values
        /// </summary>
        /// <typeparam name="T">The member type</typeparam>
        public interface InfiniteSet<S>
            where S : InfiniteSet<S>, new()
        {

        }

        /// <summary>
        /// Characterizes a type that represents an infinite number of values
        /// </summary>
        /// <typeparam name="T">The member type</typeparam>
        public interface InfiniteSet<S,T> : InfiniteSet<S>, Set<S,T>
            where S : InfiniteSet<S,T>, new()
        {

        }


    } 
}