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
    public static Equatable<T> equatable<T>() 
        where T : Equatable<T>, new()
            => new T();

    /// <summary>
    /// Retrieves semigroup operations for a specified type
    /// </summary>
    [MethodImpl(Inline)]
    public static Operative.Semigroup<T> semigroup<T>() 
        where T : Operative.Semigroup<T>, new()
            => new T();

    /// <summary>
    /// Retrieves semiring operations for a specified type
    /// </summary>
    [MethodImpl(Inline)]
    public static Operative.Semiring<T> semiring<T>() 
        where T : Operative.Semiring<T>, new()
            => new T();

    /// <summary>
    /// Retrieves the ordering operations defined for a specified type
    /// </summary>
    /// <typeparam name="T">The system type</typeparam>
    [MethodImpl(Inline)]
    public static Operative.Ordered<T> ordered<T>()
        where T : Operative.Ordered<T>, new()
        => new T();

    /// <summary>
    /// Retrieves the stepwise operations defined for a specified type
    /// </summary>
    /// <typeparam name="T">The system type</typeparam>
    [MethodImpl(Inline)]
    public static Operative.Stepwise<T> stepwise<T>()
        where T : Operative.Stepwise<T>, new()
            => new T();

}