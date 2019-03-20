//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    partial class Class
    {
        /// <summary>
        /// Characterizes external unary negation
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        public interface Negatable<T> :  TypeClass
        {
            /// <summary>
            /// Unary negation of input
            /// </summary>
            /// <param name="x">The input value</param>
            /// <returns></returns>
            T negate(T x);

            /// <summary>
            /// Combines the first operand with the negation of the second
            /// </summary>
            /// <param name="lhs">The first operand</param>
            /// <param name="rhs">The second operand</param>
            /// <returns></returns>
            T sub(T lhs, T rhs);
        }
        public interface Negatable<H,T> : TypeClass<H>
            where H : Negatable<H,T>, new()
        {


        }

    }

    partial class Struct
    {
        /// <summary>
        /// Characterizes self unary negation
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        /// <typeparam name="S">The structure/self type</typeparam>
        public interface Negatable<S,T> : Structure<S,T>
            where S : Negatable<S,T>, new()
        {
            /// <summary>
            /// Unary negation of self
            /// </summary>
            /// <param name="a">The input value</param>
            /// <returns></returns>
            S negate();

        }



    }



}