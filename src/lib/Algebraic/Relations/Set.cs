//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;



    partial class Structures
    {

        public interface Set<S> : Structure<S>
            where S : Set<S>, new()
        {

        }
        /// <summary>
        /// Characterizes a reified set
        /// </summary>
        public interface Set<S,T> : Structure<S>
            where S : Set<S,T>, new()
        {
            /// <summary>
            /// Determines whether a supplied value is a member of the reified set
            /// </summary>
            /// <param name="candidate">The potential member to check</param>
            /// <returns></returns>
            bool member(T candidate);

        }


        /// <summary>
        /// Characterizes a type that represents an infinite number of values
        /// </summary>
        /// <typeparam name="T">The member type</typeparam>
        public interface InfiniteSet<S> : Set<S>
            where S : InfiniteSet<S>, new()
        {

        }

        public interface DiscreteSet<T> 
        {
            /// <summary>
            /// Enumerates the members of the set
            /// </summary>
            Z0.Seq<T> members();

        }

        /// <summary>
        /// Characteriizes a reified set for which there are a countable number of members
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        /// <typeparam name="M">The member type</typeparam>
        public interface DiscreteSet<S,T> : DiscreteSet<T>, Set<S,T>
            where S: DiscreteSet<S,T>, new()
        {

        }

        public interface FiniteSet<S,T> :  DiscreteSet<S,T>
            where S : FiniteSet<S,T>, new()
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


        /// Characterizes a set that contains at least one individual
        /// </summary>
        /// <typeparam name="T">The member type</typeparam>
        public interface NonempySet<T> : Set<T>            
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

    }
}
