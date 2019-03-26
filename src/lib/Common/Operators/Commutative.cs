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
        /// Characterizes a commutative binary operator
        /// </summary>
        /// <typeparam name="T">The operand/result type</typeparam>
        public interface CommutativeOp<T> : BinaryOp<T>
        {

        }

    }


    /// <summary>
    /// Defines a commutative (binary) operator
    /// </summary>
    public readonly struct CommutativeOp<T> : Traits.CommutativeOp<T>
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