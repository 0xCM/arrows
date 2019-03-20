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
    /// Characterizes a type that defines an homogenous binary operator
    /// </summary>
    /// <typeparam name="T">The operand/result type</typeparam>
    public interface BinaryOp<T> : Operator<T>
    {
        
    }

    /// <summary>
    /// Characterizes a commutative binary operator
    /// </summary>
    /// <typeparam name="T">The operand/result type</typeparam>
    public interface CommutativeOp<T> : BinaryOp<T>
    {

    }



}