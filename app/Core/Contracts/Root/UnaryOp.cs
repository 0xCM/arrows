//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;
    using static corefunc;

    /// <summary>
    /// Characterizes a type that defines an homogenous unary operator
    /// </summary>
    /// <typeparam name="T">The operand/result type</typeparam>
    public interface UnaryOp<T> : Operator<T>
    {
        /// <summary>
        /// Applies the characterized operator
        /// </summary>
        /// <param name="a">The input value</param>
        /// <returns></returns>
        T apply(T a);
    }


}