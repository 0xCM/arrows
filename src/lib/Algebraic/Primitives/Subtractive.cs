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

    partial class Structure
    {

        public interface Subtractive<S> : Negatable<S>
        {
            /// <summary>
            /// Structural subtraction
            /// </summary>
            /// <param name="rhs">The right operand</param>
            S sub(S rhs);
        }

        /// <summary>
        /// Characterizes structural unary negation and subtraction
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        /// <typeparam name="S">The structure/self type</typeparam>
        public interface Subtractive<S,T> : Negatable<S,T>, Subtractive<S>
            where S : Subtractive<S,T>, new()
        {

        }

    }

}