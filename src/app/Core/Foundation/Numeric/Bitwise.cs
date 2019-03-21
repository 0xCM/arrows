//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;

    partial class Class
    {
        /// <summary>
        /// Characterizes a type that supports a notion of bit-level logic
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface BitLogics<T>
        {
            /// <summary>
            /// Computes the bitwise and from the supplied values
            /// </summary>
            /// <param name="a">The left value</param>
            /// <param name="b">The right value</param>
            /// <returns></returns>
            T and(T a, T b);

            /// <summary>
            /// Computes the bitwise or from the supplied values
            /// </summary>
            /// <param name="a">The left value</param>
            /// <param name="b">The right value</param>
            /// <returns></returns>
            T or(T a, T b);

            /// <summary>
            /// Computes the bitwise exlusive or from the supplied values
            /// </summary>
            /// <param name="a">The left value</param>
            /// <param name="b">The right value</param>
            /// <returns></returns>
            T xor(T a, T b);

            /// <summary>
            /// Calculates the bitwise two's-complement of the input
            /// </summary>
            /// <param name="a">The source value</param>
            /// <returns></returns>
            T flip(T a);
        }

        public interface BitShifts<T>
        {
            T lshift(T a, int shift);

            T rshift(T a, int shift);

        }

        public interface Bitwise<T> : BitLogics<T>, BitShifts<T>
        {
            
        }

        public interface BitLogics<S,T>
            where S : BitLogics<S,T>
        {
            /// <summary>
            /// Computes the bitwise and from the supplied values
            /// </summary>
            /// <param name="a">The left value</param>
            /// <param name="b">The right value</param>
            /// <returns></returns>
            S and(S a);

            /// <summary>
            /// Computes the bitwise or from the supplied values
            /// </summary>
            /// <param name="a">The left value</param>
            /// <param name="b">The right value</param>
            /// <returns></returns>
            S or(S a);

            /// <summary>
            /// Computes the bitwise exlusive or from the supplied values
            /// </summary>
            /// <param name="a">The left value</param>
            /// <param name="b">The right value</param>
            /// <returns></returns>
            S xor(S a);

            /// <summary>
            /// Calculates the bitwise two's-complement of the input
            /// </summary>
            /// <param name="a">The source value</param>
            /// <returns></returns>
            S flip();

        }

        public interface BitShifts<S,T>
            where S : BitShifts<S,T>
        {
            S lshift(int shift);

            S rshift(int shift);

        }
        

        public interface Bitwise<S,T> : BitLogics<S,T>, BitShifts<S,T>
            where S : Bitwise<S,T>, new()
        {
            
        }

    }


}