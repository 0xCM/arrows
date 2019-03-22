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