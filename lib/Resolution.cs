//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;


partial class zcore
{

    /// <summary>
    /// Retrieves semigroup operations for a specified type
    /// </summary>
    [MethodImpl(Inline)]
    public static ISemigroupOps<T> semigroup<T>() 
        where T : ISemigroupOps<T>, new()
            => new T();

    /// <summary>
    /// Retrieves semiring operations for a specified type
    /// </summary>
    [MethodImpl(Inline)]
    public static ISemiringOps<T> semiring<T>() 
        where T : ISemiringOps<T>, new()
            => new T();

    /// <summary>
    /// Retrieves the ordering operations defined for a specified type
    /// </summary>
    /// <typeparam name="T">The system type</typeparam>
    [MethodImpl(Inline)]
    public static IOrderedOps<T> ordered<T>()
        where T : IOrderedOps<T>, new()
        => new T();

    /// <summary>
    /// Retrieves the stepwise operations defined for a specified type
    /// </summary>
    /// <typeparam name="T">The system type</typeparam>
    [MethodImpl(Inline)]
    public static IStepwiseOps<T> stepwise<T>()
        where T : IStepwiseOps<T>, new()
            => new T();

}