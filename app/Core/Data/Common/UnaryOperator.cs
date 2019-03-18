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

    using C = Contracts;


    public static class UnaryOperator
    {
        /// <summary>
        /// Lifts a function to a unary operator
        /// </summary>
        /// <param name="f">The function to lift</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static C.UnaryOperator<T> define<T>(Func<T,T> f)
            => new UnaryOperator<T>(f);
    }

    /// <summary>
    /// Defines a unary operator
    /// </summary>
    public readonly struct UnaryOperator<T> : C.UnaryOperator<T>
    {
        readonly Func<T,T> op;

        [MethodImpl(Inline)]
        public T apply(T x)
            => op(x);

        [MethodImpl(Inline)]
        public UnaryOperator(Func<T,T> op)
            => this.op = op;
    }

}