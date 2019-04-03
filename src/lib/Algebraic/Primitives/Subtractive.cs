//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Operative
    {


        /// <summary>
        /// Characterizes operational negation and subtraction
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        public interface Subtractive<T> : Negatable<T>
        {

            /// <summary>
            /// Combines the first operand with the negation of the second
            /// </summary>
            /// <param name="lhs">The first operand</param>
            /// <param name="rhs">The second operand</param>
            /// <returns></returns>
            T sub(T lhs, T rhs);
        }


    }

    partial class Structures
    {

        public interface Subtractive<S> : Negatable<S>
            where S : Subtractive<S>, new()
        {
            /// <summary>
            /// Structural subtraction
            /// </summary>
            /// <param name="rhs">The right operand</param>
            S sub(S rhs);
        }


    }

}