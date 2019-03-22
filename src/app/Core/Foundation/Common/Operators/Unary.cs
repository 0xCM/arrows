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

    /// <summary>
    /// Defines a unary operator
    /// </summary>
    public readonly struct UnaryOp<T> : Traits.UnaryOp<T>
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