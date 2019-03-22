//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using static Traits;

    partial class Traits
    {
        public interface Finite<T> : Ordered<T>
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
        public interface Finite<S,T> : Ordered<S,T>
            where S : Finite<S,T>, new()
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