//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Operative
    {
    }

    partial class Structure
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


        /// <summary>
        /// Characterizes a reified set
        /// </summary>
        public interface Set<S,T> : Set<S>
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
        public interface InfiniteSet<T> : Set<T>
            where T : InfiniteSet<T>, new()
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
        public interface NonempySet<S,T> : NonempySet<S>, Structural<S,T>
            where S : NonempySet<S,T>, new()
        {

        }

    }
}
