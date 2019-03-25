//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Traits;

    partial class Traits
    {
        /// <summary>
        /// Characterizes something for which a fininte count can be defined
        /// </summary>
        /// <typeparam name="T">The type for which a finite number of instances exist
        /// within a reification context</typeparam>
        public interface Finite<T> 
        {
            /// <summary>
            /// The count providing evidence that the reification is finite
            /// </summary>
            int count {get;}
        }

        public interface Bounded<T> : Ordered<T>
        {
            /// <summary>
            /// The minimum value the number may obtain
            /// </summary>
            T minval {get;}

            /// <summary>
            /// The maximum value the number may obtain
            /// </summary>
            T maxval {get;}

        }

        /// <summary>
        /// Characterizes a bounded structural number
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underling primitive</typeparam>
        public interface Bounded<S,T> : Ordered<S,T>
            where S : Bounded<S,T>, new()
        {

            /// <summary>
            /// The minimum value the number may obtain
            /// </summary>
            /// <value></value>
            S minval {get;}

            /// <summary>
            /// The maximum value the number may obtain
            /// </summary>
            /// <value></value>
            S maxval {get;}

        }
    }

}