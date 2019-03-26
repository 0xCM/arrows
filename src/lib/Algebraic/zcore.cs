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
using static Z0.Credit;
using static Z0.Traits;


partial class zcore
{
    /// <summary>
    /// Retrieves semigroup operations for a specified type
    /// </summary>
    [MethodImpl(Inline)]
    public static Traits.Semigroup<T> semigroup<T>() 
        => ops<T,Traits.Semigroup<T>>();


    /// <summary>
    /// Retrieves semiring operations for a specified type
    /// </summary>
    [MethodImpl(Inline)]
    public static Traits.Semiring<T> semiring<T>() 
        => ops<T,Traits.Semiring<T>>();



    /// <summary>
    /// Retrieves the ordering operations defined for a specified type
    /// </summary>
    /// <typeparam name="T">The system type</typeparam>
    [MethodImpl(Inline)]
    public static Ordered<T> ordered<T>()
        => ops<T,Ordered<T>>();


    /// <summary>
    /// Retrieves the stepwise operations defined for a specified type
    /// </summary>
    /// <typeparam name="T">The system type</typeparam>
    [MethodImpl(Inline)]
    public static Stepwise<T> stepwise<T>()
        => ops<T,Stepwise<T>>();

}