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


    public static class BinaryOperator
    {
        /// <summary>
        /// Lifts a function to a binary operator
        /// </summary>
        /// <param name="f">The function to lift</param>
        /// <param name="commutative">Whether the operator is commutative on its comain</param>
        /// <typeparam name="T">The operator domain type</typeparam>
        /// <returns></returns>
        public static C.BinaryOperator<T> define<T>(Func<T,T,T> f, bool commutative = false)
            => commutative 
            ?  cast<C.BinaryOperator<T>>(new Commutative<T>(f)) 
            : new BinaryOperator<T>(f);
    }

    /// <summary>
    /// Defines a binary operator
    /// </summary>
    public readonly struct BinaryOperator<T> : C.BinaryOperator<T>
    {
        readonly Func<T,T,T> op;

        [MethodImpl(Inline)]
        T C.BinaryOperator<T>.compose(T a, T b)
            => op(a,b);

        [MethodImpl(Inline)]
        public BinaryOperator(Func<T,T,T> op)
            => this.op = op;
    }

    /// <summary>
    /// Defines a commutative (binary) operator
    /// </summary>
    public readonly struct Commutative<T> : C.Commutative<T>
    {
        readonly Func<T,T,T> op;

        [MethodImpl(Inline)]
        T C.BinaryOperator<T>.compose(T a, T b)
            => op(a,b);

        [MethodImpl(Inline)]
        public Commutative(Func<T,T,T> op)
            => this.op = op;
    }


}