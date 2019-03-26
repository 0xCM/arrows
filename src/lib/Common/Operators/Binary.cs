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

    partial class Traits
    {

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

    }

    /// <summary>
    /// Defines a binary operator
    /// </summary>
    public readonly struct BinaryOp<T> : Traits.BinaryOp<T>
    {
        readonly Func<T,T,T> op;

        [MethodImpl(Inline)]
        public T apply(T a, T b)
            => op(a,b);

        [MethodImpl(Inline)]
        public BinaryOp(Func<T,T,T> op)
            => this.op = op;
    }


}