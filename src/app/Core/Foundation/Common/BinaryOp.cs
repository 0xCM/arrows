//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static corefunc;

    partial class Reify
    {
        /// <summary>
        /// Defines a binary operator
        /// </summary>
        public readonly struct BinaryOp<T> : Core.BinaryOp<T>
        {
            readonly Func<T,T,T> op;

            [MethodImpl(Inline)]
            public T apply(T a, T b)
                => op(a,b);

            [MethodImpl(Inline)]
            public BinaryOp(Func<T,T,T> op)
                => this.op = op;
        }

        /// <summary>
        /// Defines a commutative (binary) operator
        /// </summary>
        public readonly struct CommutativeOp<T> : Core.CommutativeOp<T>
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