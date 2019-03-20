//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;
    using static Class;
    using static Struct;

    partial class Class
    {
        /// <summary>
        /// Characterizes an operation provider for floating point values
        /// </summary>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public interface Floating<T> : Fractional<T>, Signed<T>, Negatable<T>, Ordered<T>, Trigonmetric<T>
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

        }

        public interface Floating<H,T> : TypeClass<H>, Floating<T>
            where H : Floating<H,T>, new()
        {

        }
    }

    partial class Struct
    {
        /// <summary>
        /// Characterizes a structure for a floating point number
        /// </summary>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public interface Floating<S,T> :   
            Fractional<S,T>, 
            Signed<S,T>, 
            Negatable<S,T>, 
            Ordered<S,T>, 
            Trigonmetric<S,T>
            where S : Floating<S,T>, new()
            where T : new()
        {

            /// <summary>
            /// The minimal resolution of the data type
            /// </summary>
            /// <value></value>
            S ε {get;}

            IEnumerable<S> partition(S min, S max,S width = default(S));     
        }
    }
}