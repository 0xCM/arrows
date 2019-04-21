//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Operative
    {
        /// <summary>
        /// Characterizes a type that supports primitive logarithmic operations
        /// </summary>
        /// <typeparam name="T">The type of the underlying primitive</typeparam>
        public interface Logarithmic<T>
        {
            /// <summary>
            /// Computes the natural logarithm 
            /// </summary>
            /// <param name="x">The input value</param>
            /// <returns></returns>
            T ln(T x);

            /// <summary>
            /// Computes the base-10 logarithm
            /// </summary>
            /// <param name="x">The input value</param>
            /// <returns></returns>
            T log(T x);

            /// <summary>
            /// Computes a logarithm at a specified base
            /// </summary>
            /// <param name="x">The input value</param>
            /// <param name="@base">The logarithm base</param> 
            /// <returns></returns>
            T logb(T x, T @base);

        }

    }
    partial class Structures
    {
        public interface Logarithmic<S>
            where S : Logarithmic<S>, new()
        {
            /// <summary>
            /// Computes the natural logarithm 
            /// </summary>
            /// <param name="x">The input value</param>
            /// <returns></returns>
            S ln();

            /// <summary>
            /// Computes the base-10 logarithm
            /// </summary>
            /// <param name="x">The input value</param>
            /// <returns></returns>
            S log();

            /// <summary>
            /// Computes a logarithm at a specified base
            /// </summary>
            /// <param name="x">The input value</param>
            /// <param name="@base">The logarithm base</param> 
            /// <returns></returns>
            S logb(S @base);
        }


    }

}