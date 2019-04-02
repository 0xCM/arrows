//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Operative
    {
        public interface BitSource<T>
        {
            /// <summary>
            /// Formats the source value a sequence of base-2 digits
            /// </summary>
            Z0.BitString bitstring(T x);


        }
     
        public interface Shifty<T> 
        {
            T lshift(T lhs, int rhs);

            T rshift(T lhs, int rhs);

        }

        

        /// <summary>
        /// Characterizes bitwise logical operations over a type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface BitLogic<T>
        {
            /// <summary>
            /// Computes the bitwise and from the supplied values
            /// </summary>
            /// <param name="lhs">The left value</param>
            /// <param name="rhs">The right value</param>
            /// <returns></returns>
            T and(T lhs, T rhs);

            /// <summary>
            /// Computes the bitwise or from the supplied values
            /// </summary>
            /// <param name="lhs">The left value</param>
            /// <param name="rhs">The right value</param>
            /// <returns></returns>
            T or(T lhs, T rhs);

            /// <summary>
            /// Computes the bitwise exlusive or from the supplied values
            /// </summary>
            /// <param name="lhs">The left value</param>
            /// <param name="rhs">The right value</param>
            /// <returns></returns>
            T xor(T lhs, T rhs);

            /// <summary>
            /// Calculates the bitwise two's-complement of the input
            /// </summary>
            /// <param name="x">The source value</param>
            /// <returns></returns>
            T flip(T x);
        }


        /// <summary>
        /// Characterizes bitwise operations over an operand
        /// </summary>
        public interface Bitwise<T> : BitLogic<T>, Shifty<T> { }


    }

    partial class Structure
    {

        public interface Shifty<S>
        {
            S lshift(int rhs);

            S rshift(int rhs);

        }

        public interface BitSource<S>
        {
            /// <summary>
            /// Formats the source value a sequence of base-2 digits
            /// </summary>
            Z0.BitString bitstring();

        }
        
        public interface BitLogic<S> 
        {
            /// <summary>
            /// Computes the bitwise and
            /// </summary>
            /// <param name="rhs">The right value</param>
            /// <returns></returns>
            S and(S rhs);

            /// <summary>
            /// Computes the bitwise or
            /// </summary>
            /// <param name="rhs">The right  value</param>
            /// <returns></returns>
            S or(S rhs);

            /// <summary>
            /// Computes the bitwise exlusive or
            /// </summary>
            /// <param name="rhs">The right  value</param>
            /// <returns></returns>
            S xor(S rhs);

            /// <summary>
            /// Calculates the bitwise two's-complement
            /// </summary>
            /// <returns></returns>
            S flip();
        }

        public interface Bitwise<S> : BitLogic<S>, Shifty<S>, BitSource<S>
        {

        }


    }

}