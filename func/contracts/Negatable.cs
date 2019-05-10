//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    
    public interface INegatableOps<T>
    {
        /// <summary>
        /// Unary negation of input
        /// </summary>
        /// <param name="x">The input value</param>
        T negate(T x);

    }

    public interface INegatable<S>
        where S : INegatable<S>, new()
    {
        /// <summary>
        /// Unary structural negation
        /// </summary>
        /// <param name="a">The input value</param>
        S negate();
    }

}