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
        /// Characterizes operations over (ordered) values that 
        /// exist between upper and lower bounds
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface BoundReal<T> : RealNumber<T>
        {
            /// <summary>
            /// Spedifies the greatest lower T-bound
            /// </summary>
            T infimum {get;}

            /// <summary>
            /// Specifes the least upper T-bound
            /// </summary>
            T supremum {get;}

        }

        /// <summary>
        /// Characterizes a bounded structural number
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underling primitive</typeparam>
        public interface BoundReal<S,T> :  BoundReal<S>, Structural<S,T>
            where S : BoundReal<S,T>, new()
        {


        }


    }
}