//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    partial class Traits
    {
        /// <summary>
        /// Characterizes a type that supports primitive logarithmic operations
        /// </summary>
        /// <typeparam name="T">The type of the underlying primitive</typeparam>
        public interface Logarithmic<T>
            where T : new()
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
            T log(T x, T @base);

        }
    }

    partial class Struct
    {
        /// <summary>
        /// Characterizes a structure for which logarithms can be calculated
        /// </summary>
        /// <typeparam name="T">The type of the underlying primitive</typeparam>
        /// <typeparam name="S">The structure type</typeparam>
        public interface Logarithmic<S,T>
                where S : Logarithmic<S,T>,  new()
        {
            /// <summary>
            /// Computes the natural logarithm 
            /// </summary>
            /// <param name="x">The input value</param>
            /// <returns></returns>
            T ln();

            /// <summary>
            /// Computes the base-10 logarithm
            /// </summary>
            /// <param name="x">The input value</param>
            /// <returns></returns>
            T log();

            /// <summary>
            /// Computes a logarithm at a specified base
            /// </summary>
            /// <param name="x">The input value</param>
            /// <param name="@base">The logarithm base</param> 
            /// <returns></returns>
            T log(T @base);
        }
    }
}