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


    partial class Operative
    {

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
    }


    /// <summary>
    /// Defines a unary operator
    /// </summary>
    public readonly struct UnaryOp<T> : Operative.UnaryOp<T>
    {
        readonly Func<T,T> op;

        [MethodImpl(Inline)]
        public T apply(T x)
            => op(x);

        [MethodImpl(Inline)]
        public UnaryOp(Func<T,T> op)
            => this.op = op;
    }
}