//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;
    using System.Collections.Generic;
    using static corefunc;

    /// <summary>
    /// Characterizes a type that defines an homogenous unary operator
    /// </summary>
    /// <typeparam name="T">The operand/result type</typeparam>
    public interface UnaryOperator<T>
    {
        /// <summary>
        /// Applies the characterized operator
        /// </summary>
        /// <param name="a">The input value</param>
        /// <returns></returns>
        T apply(T a);
    }


    /// <summary>
    /// Characterizes a type that defines an homogenous binary operator
    /// </summary>
    /// <typeparam name="T">The operand/result type</typeparam>
    public interface BinaryOperator<T>
    {
        T compose(T a, T b);
    }

    /// <summary>
    /// Characterizes a commutative binary operator
    /// </summary>
    /// <typeparam name="T">The operand/result type</typeparam>
    public interface Commutative<T> : BinaryOperator<T>
    {

    }
}