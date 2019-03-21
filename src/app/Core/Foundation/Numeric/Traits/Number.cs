//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    partial class Traits
    {
        public interface Number<T> : 
            SemigroupA<T>,  
            SemigroupM<T>, 
            Semiring<T>,
            Negatable<T>,
            Divisive<T>,
            Powered<T,int> 
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
        public interface Number<S,T> : Structure<S,T>, 
                Semiring<S,T>,
                Negatable<S,T>,
                Divisive<S,T>
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