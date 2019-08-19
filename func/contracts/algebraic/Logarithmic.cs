//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a type that supports primitive logarithmic operations
    /// </summary>
    /// <typeparam name="T">The type of the underlying primitive</typeparam>
    public interface ILogarithmicOps<T>
    {
        /// <summary>
        /// Computes the natural logarithm 
        /// </summary>
        /// <param name="x">The input value</param>
        T Ln(T x);

        /// <summary>
        /// Computes the base-10 logarithm
        /// </summary>
        /// <param name="x">The input value</param>
        T Log(T x);

        /// <summary>
        /// Computes a logarithm at a specified base
        /// </summary>
        /// <param name="x">The input value</param>
        /// <param name="@base">The logarithm base</param> 
        T LogB(T x, T @base);
    }

    public interface ILogarithmic<S>
        where S : ILogarithmic<S>, new()
    {
        /// <summary>
        /// Computes the natural logarithm 
        /// </summary>
        /// <param name="x">The input value</param>
        S Ln();

        /// <summary>
        /// Computes the base-10 logarithm
        /// </summary>
        /// <param name="x">The input value</param>
        S Log();

        /// <summary>
        /// Computes a logarithm at a specified base
        /// </summary>
        /// <param name="x">The input value</param>
        /// <param name="@base">The logarithm base</param> 
        S LogB(S @base);
    }
}