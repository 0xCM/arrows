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
    /// Retrives the operations of type O defined for a type T
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    /// <typeparam name="O">The operations type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static O ops<T,O>()
        => Resolver.ops<T,O>();

    /// <summary>
    /// Retrieves semigroup operations for a specified type
    /// </summary>
    [MethodImpl(Inline)]
    public static Traits.Equatable<T> equatable<T>() 
        where T : Traits.Equatable<T>, new()
            => new T();

    /// <summary>
    /// Retrieves semigroup operations for a specified type
    /// </summary>
    [MethodImpl(Inline)]
    public static Traits.Semigroup<T> semigroup<T>() 
        where T : Traits.Semigroup<T>, new()
            => new T();

    /// <summary>
    /// Retrieves semiring operations for a specified type
    /// </summary>
    [MethodImpl(Inline)]
    public static Traits.Semiring<T> semiring<T>() 
        where T : Traits.Semiring<T>, new()
            => new T();

    /// <summary>
    /// Retrieves the ordering operations defined for a specified type
    /// </summary>
    /// <typeparam name="T">The system type</typeparam>
    [MethodImpl(Inline)]
    public static Traits.Ordered<T> ordered<T>()
        where T : Traits.Ordered<T>, new()
        => new T();

    /// <summary>
    /// Retrieves the stepwise operations defined for a specified type
    /// </summary>
    /// <typeparam name="T">The system type</typeparam>
    [MethodImpl(Inline)]
    public static Traits.Stepwise<T> stepwise<T>()
        where T : Traits.Stepwise<T>, new()
            => new T();

}