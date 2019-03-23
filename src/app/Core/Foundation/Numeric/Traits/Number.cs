//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    partial class Traits
    {
        /// <summary>
        /// Defines the minimal aspects for a value to be considered a "real number"
        /// The dual contract, that subsumes every possible aspect of number, is 
        /// defined via the Real trait. Note that every Number can be parameterized 
        /// by any underlying primitive numeric type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Number<T> :  GroupA<T>,  SemigroupM<T>, Semiring<T>, Divisive<T>, Powered<T,int> 
        {                    
            T muladd(T x, T y, T z);

            /// <summary>
            /// Calculates the number's absolute value
            /// </summary>
            /// <returns></returns>
            T abs(T x);

            /// <summary>
            /// Calculates the number's sign
            /// </summary>
            Sign sign(T x);

            /// <summary>
            /// Formats the source value a sequence of base-2 digits
            /// </summary>
            string bitstring(T x);

        }

        /// <summary>
        /// Characterizes a structral number
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The structure subect</typeparam>
        public interface Number<S,T> : Semiring<S,T>, Negatable<S,T>, Divisive<S,T>
            where S : Number<S,T>, new()
        {
            /// <summary>
            /// Calculates the number's magnitude
            /// </summary>
            /// <returns></returns>
            S abs();

            /// <summary>
            /// Calculates the number's sign
            /// </summary>
            Sign sign();

            string bitstring();
                        
        }

    }
}