//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;

    partial class Traits
    {
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
            /// <summary>
            /// Determines whether a supplied value is a member of the reified set
            /// </summary>
            /// <param name="candidate">The potential member to check</param>
            /// <returns></returns>
            bool member(T candidate);
        }

        /// <summary>
        /// Characterizes a set that contains at least one individual
        /// </summary>
        /// <typeparam name="M">The member type</typeparam>
        public interface NonempySet<M> : Set<M>
        {

        }

        /// <summary>
        /// Characterizes a reified set
        /// </summary>
        public interface Set<S,T> : Set<T>
            where S : Set<S,T>, new()
        {

        }

        /// <summary>
        /// Characterizes a set that has a countable number of members
        /// </summary>
        /// <typeparam name="M">The member type</typeparam>
        public interface DiscreteSet<M> : Set<M>
        {
            /// <summary>
            /// Enumerates the members of the set
            /// </summary>
            Enumerable<M> members();            
        }

        /// <summary>
        /// Characteriizes a reified set for which there are a countable number of members
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        /// <typeparam name="M">The member type</typeparam>
        public interface DiscreteSet<S,T> : DiscreteSet<T> 
            where S: DiscreteSet<S,T>, new()
        {

        }

        /// <summary>
        /// Characterizes a type that represents an infinite number of values
        /// </summary>
        /// <typeparam name="M">The member type</typeparam>
        public interface InfiniteSet<M> : Set<M>
        {

        }

        /// <summary>
        /// Characteriizes a set that contains a finite number of values
        /// </summary>
        /// <typeparam name="M">The member type</typeparam>
        public interface FiniteSet<M> : DiscreteSet<M>
        {
            /// <summary>
            /// Evidence that the set is indeed finite
            /// </summary>
            int count {get;}

        }

        /// <summary>
        /// Characteriizes a reified set that contains a finite number of values
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        /// <typeparam name="M">The member type</typeparam>
        public interface FiniteSet<S,M> : FiniteSet<M>, DiscreteSet<S,M>
            where S : FiniteSet<S,M>, new()
        {

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
}
