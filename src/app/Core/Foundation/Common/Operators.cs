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
    /// Characterizes an operator over a specified type
    /// </summary>
    /// <typeparam name="T">The operand</typeparam>
    public interface Operator<T>
    {
        
    }

    /// <summary>
    /// Characterizes a type that defines an homogenous binary operator
    /// </summary>
    /// <typeparam name="T">The operand/result type</typeparam>
    public interface BinaryOp<T> : Operator<T>
    {
        /// <summary>
        /// Effects the composition of two values as determined by the operator realization
        /// </summary>
        /// <param name="lhs">The left-handed value</param>
        /// <param name="rhs">The right-handed value</param>
        T apply(T lhs, T rhs);
    }

    public interface BinaryOp<O,T> : BinaryOp<T>
        //where O : BinaryOp<O,T>
    {
        O composer {get;}
    }

    /// <summary>
    /// Characterizes a commutative binary operator
    /// </summary>
    /// <typeparam name="T">The operand/result type</typeparam>
    public interface CommutativeOp<T> : BinaryOp<T>
    {

    }

    /// <summary>
    /// Characterizes a type that defines an homogenous unary operator
    /// </summary>
    /// <typeparam name="T">The operand/result type</typeparam>
    public interface UnaryOp<T> : Operator<T>
    {
        /// <summary>
        /// Applies the characterized operator
        /// </summary>
        /// <param name="x">The input value</param>
        /// <returns></returns>
        T apply(T x);
    }

}