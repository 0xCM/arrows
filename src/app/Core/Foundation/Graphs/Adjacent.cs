//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    partial class Traits
    {

        public interface Successive<T>
        {
            T next(T x);
        }

        public interface Antecedant<T>
        {
            T prior(T x);
        }

        /// <summary>
        /// Caracterizes an association between two types for which there
        /// exists a notion of unique succession
        /// </summary>
        /// <typeparam name="A1">The source type</typeparam>
        /// <typeparam name="A2">The type of the successor</typeparam>
        /// <remarks>
        /// Given a universe U that contain A and B, along with a strict partial order <,
        /// reification codifies that A < B
        /// </remarks>
        public interface Successive<A1,A2> 
        {
            /// <summary>
            /// Given an A-value, computes the next B-value
            /// </summary>
            /// <param name="a">The source vlue</param>
            /// <returns></returns>
            A2 next();
        }

        /// <summary>
        /// Caracterizes an association between two types for which there
        /// exists a notion of unique antecedant
        /// </summary>
        /// <typeparam name="A1">The source type</typeparam>
        /// <typeparam name="A2">The type of the successor</typeparam>
        /// <remarks>
        /// Given a universe U that contain A and B, along with a strict partial order <,
        /// reification codifies that B < A
        /// </remarks>
        public interface Antecedant<A1,A2>
        {
            /// <summary>
            /// Given an A-value, computes the prior B-value
            /// </summary>
            /// <param name="a">The source vlue</param>
            /// <returns></returns>
            A2 prior();
        }

        /// <summary>
        /// Characterizes a bidirectional association between types for which
        /// the exists notions successors and antecedants
        /// </summary>
        /// <typeparam name="A">The type that succeeds B</typeparam>
        /// <typeparam name="B">The type that precedes A</typeparam>
        public interface Adjacent<A,B> : Successive<B,A>, Antecedant<A,B>
        {

        }
    }
}