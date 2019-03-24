//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
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
        public interface Floating<T> 
            : Fractional<T>, 
              Signed<T>, 
              Negatable<T>, 
              Ordered<T>, 
              Trigonmetric<T>
        {
            /// <summary>
            /// The minimal resolution of the data type
            /// </summary>
            /// <value></value>
            T ε {get;}

            /// <summary>
            /// Partitions an interval into a sequence of values of a specified with
            /// </summary>
            /// <param name="min"></param>
            /// <param name="max"></param>
            /// <param name="width"></param>
            /// <returns></returns>
            IEnumerable<T> partition(T min, T max,T width = default(T)); 

            
            T sqrt(T x);   


        }

        /// <summary>
        /// Characterizes a structure for a floating point number
        /// </summary>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public interface Floating<S,T> : Fractional<S,T>, Ordered<S,T>, Signed<S,T>, Negatable<S,T>, Trigonmetric<S,T>
            where S : Floating<S,T>, new()
        {

            /// <summary>
            /// The minimal resolution of the data type
            /// </summary>
            /// <value></value>
            S ε {get;}

            S sqrt();
            IEnumerable<S> partition(S min, S max,S width = default(S));     
        }
    
        /// <summary>
        /// Characterizes an operation provider for bounded floating point values
        /// </summary>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public interface FiniteFloat<T> : Floating<T>, Finite<T> 
        {

        }

        /// <summary>
        /// Characterizes a structure for a bounded floating point number
        /// </summary>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public interface FiniteFloat<S,T> : Floating<S,T>, Finite<S,T>
            where S : FiniteFloat<S,T>, new()
            where T : new()

        {
        
        
        }
    
    }
}