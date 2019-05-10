//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;
    using static zfunc;

    /// <summary>
    /// Characterizes an operator over a specified type
    /// </summary>
    /// <typeparam name="T">The operand</typeparam>
    public interface IOperator<T>
    {

    }


    public interface IApplyOp<T> : IOperator<T>
    {

    }

    /// <summary>
    /// Characterizes a commutative binary operator
    /// </summary>
    /// <typeparam name="T">The operand/result type</typeparam>
    public interface ICommutativeOp<T> : IBinaryOp<T>
    {

    }


    public interface IBinaryApplyOp<T> : IApplyOp<T>, IBinaryOp<T>
    {
        T apply(T lhs, T rhs);
    }


    /// <summary>
    /// Characterizes a type that defines an homogenous binary operator
    /// </summary>
    /// <typeparam name="T">The operand/result type</typeparam>
    public interface IBinaryOp<T> : IOperator<T>
    {

    }



    /// <summary>
    /// Characterizes a type that defines an homogenous unary operator
    /// </summary>
    /// <typeparam name="T">The operand/result type</typeparam>
    public interface IUnaryOp<T> : IOperator<T>
    {
    }

    public interface IUnaryApplyOp<T> : IApplyOp<T>, IUnaryOp<T>
    {
        T apply(T lhs);
    }


    public static class OpStructures
    {


        /// <summary>
        /// Lifts a function to a unary operator
        /// </summary>
        /// <param name="f">The function to lift</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static UnaryOp<T> ToUnaryOp<T>(this Func<T,T> f)
            => new UnaryOp<T>(f);

        /// <summary>
        /// Lifts a function to a binary opeator operator
        /// </summary>
        /// <param name="f">The function to lift</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static BinaryStruct<T> ToBinaryOp<T>(this Func<T,T,T> f, bool commutative = false)
                => commutative 
                ?  cast<BinaryStruct<T>>(new CommutativeOp<T>(f)) 
                : new BinaryStruct<T>(f);

        /// <summary>
        /// Defines a binary operator
        /// </summary>
        public readonly struct BinaryStruct<T> : IBinaryOp<T>
        {
            readonly Func<T,T,T> op;

            [MethodImpl(Inline)]
            public T apply(T a, T b)
                => op(a,b);

            [MethodImpl(Inline)]
            public BinaryStruct(Func<T,T,T> op)
                => this.op = op;
        }

        /// <summary>
        /// Defines a unary operator
        /// </summary>
        public readonly struct UnaryOp<T> : IUnaryOp<T>
        {
            readonly Func<T,T> op;

            [MethodImpl(Inline)]
            public T apply(T x)
                => op(x);

            [MethodImpl(Inline)]
            public UnaryOp(Func<T,T> op)
                => this.op = op;
        }

        /// <summary>
        /// Defines a commutative (binary) operator
        /// </summary>
        public readonly struct CommutativeOp<T> : ICommutativeOp<T>
        {
            readonly Func<T,T,T> op;

            [MethodImpl(Inline)]
            public T apply(T a, T b)
                => op(a,b);

            [MethodImpl(Inline)]
            public CommutativeOp(Func<T,T,T> op)
                => this.op = op;
        }
    }
}