//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Operative
    {

        public interface Negatable<T> : Operational<T>
        {
            /// <summary>
            /// Unary negation of input
            /// </summary>
            /// <param name="x">The input value</param>
            /// <returns></returns>
            T negate(T x);

        }

    }

    partial class Structure
    {
        public interface Negatable<S>
        {
            /// <summary>
            /// Unary structural negation
            /// </summary>
            /// <param name="a">The input value</param>
            S negate();


        }


        /// <summary>
        /// Characterizes structural unary negation and subtraction
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        /// <typeparam name="S">The structure/self type</typeparam>
        public interface Negatable<S,T> : Negatable<S>, Structural<S,T>
            where S : Negatable<S,T>, new()
        {

        }        

    }
}