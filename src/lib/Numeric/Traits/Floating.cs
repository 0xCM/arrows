//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using static Traits;

    partial class Operative
    {
        /// <summary>
        /// Characterizes an operation provider for floating point values
        /// </summary>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public interface Floating<T> : RealNumber<T>, Fractional<T>, Signed<T>, Subtractive<T>, Trigonmetric<T>
        {
            /// <summary>
            /// The minimal resolution of the data type
            /// </summary>
            /// <value></value>
            T epsilon {get;}

            /// <summary>
            /// Calculates the square root of the input
            /// </summary>
            /// <param name="x">The input value</param>
            /// <returns></returns>
            T sqrt(T x);   


        }

    
        /// <summary>
        /// Characterizes an operation provider for bounded floating point values
        /// </summary>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public interface FiniteFloat<T> : Floating<T>, BoundReal<T> 
        { }
            

        /// <summary>
        /// Characterizes operational reifications of RealFiniteUInt 
        /// </summary>
        /// <typeparam name="R">The reification type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        public interface FiniteFloat<R,T> : FiniteFloat<T>, Operational<R,T>
            where R : FiniteFloat<R,T>, new() { }

    }

    partial class Structure
    {

        public interface Floating<S> : RealNumber<S>, Fractional<S>, Signed<S>, Subtractive<S>, Trigonmetric<S>
        {
            S sqrt();
        }

        /// <summary>
        /// Characterizes a structure for a floating point number
        /// </summary>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public interface Floating<S,T> : Floating<S>,  Structural<S,T>
            where S : Floating<S,T>, new()
        {

    
            
        }

    }
}