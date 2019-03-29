//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using static Traits;

    partial class Traits
    {
        /// <summary>
        /// Characterizes an operation provider for floating point values
        /// </summary>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public interface Floating<T> : RealNumber<T>, Fractional<T>, Signed<T>, Negatable<T>, Trigonmetric<T>
        {
            /// <summary>
            /// The minimal resolution of the data type
            /// </summary>
            /// <value></value>
            T ε {get;}

            /// <summary>
            /// Calculates the square root of the input
            /// </summary>
            /// <param name="x">The input value</param>
            /// <returns></returns>
            T sqrt(T x);   


        }

        /// <summary>
        /// Characterizes a structure for a floating point number
        /// </summary>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public interface Floating<S,T> : Floating<S>, Structural<S,T>
            where S : Floating<S,T>, new()
        {

            S sqrt();
            
        }
    
        /// <summary>
        /// Characterizes an operation provider for bounded floating point values
        /// </summary>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public interface FiniteFloat<T> : Floating<T>, BoundReal<T> 
        {

        }


    }
}