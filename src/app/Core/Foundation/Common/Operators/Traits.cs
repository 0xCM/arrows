//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;
    using static corefunc;

    partial class Traits
    {
        /// <summary>
        /// Characterizes an operator over a specified type
        /// </summary>
        /// <typeparam name="T">The operand</typeparam>
        public interface Operator<T>
        {
            
        }

        public interface Apply<T> : Operator<T>
        {

        }

        /// <summary>
        /// Characterizes a type that defines an homogenous unary operator
        /// </summary>
        /// <typeparam name="T">The operand/result type</typeparam>
        public interface UnaryOp<T> : Operator<T>
        {
        }

        public interface UnaryApply<T> : Apply<T>, UnaryOp<T>
        {
            T apply(T lhs);
        }


        /// <summary>
        /// Characterizes a type that defines an homogenous binary operator
        /// </summary>
        /// <typeparam name="T">The operand/result type</typeparam>
        public interface BinaryOp<T> : Operator<T>
        {

        }

        public interface BinaryApply<T> : Apply<T>, BinaryOp<T>
        {
            T apply(T lhs, T rhs);
        }


        /// <summary>
        /// Characterizes a commutative binary operator
        /// </summary>
        /// <typeparam name="T">The operand/result type</typeparam>
        public interface CommutativeOp<T> : BinaryOp<T>
        {

        }

    
    }

}