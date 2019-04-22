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
using static Z0.Traits;

partial class zcore
{
    /// <summary>
    /// Returns the supplied value if not null, otherwise invokes a function to provide
    /// a non-null value as a replacement
    /// </summary>
    /// <typeparam name="T">The object type</typeparam>
    /// <param name="x">The object to test</param>
    /// <param name="replace">The function that yields a replacement value in the event that the supplied value is null</param>
    [MethodImpl(Inline)]
    public static T coalesce<T>(T x, Func<T> replace)
        where T : class => x ?? replace();

    /// <summary>
    /// Returns the source value if not null; otherwise returns the fallback value
    /// </summary>
    /// <param name="x">The source value</param>
    /// <param name="fallback">The value to return when the source is null</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static T coalesce<T>(T x, T replace)
        where T : class => x ?? replace;

    /// <summary>
    /// Returns the source value if not null; otherwise result of fallback invocation
    /// </summary>
    /// <param name="x">The source value</param>
    /// <param name="fallback">A function that produces a value if needed</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static T coalesce<T>(T? x, Func<T> fallback)
        where T : struct
            => x == null ? fallback() : x.Value;

    /// <summary>
    /// Returns the source value if not null; otherwise returns the fallback value
    /// </summary>
    /// <param name="x">The source value</param>
    /// <param name="fallback">The value to return when the source is null</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static T coalesce<T>(T? x, T fallback)
        where T : struct
            => x == null ? fallback : x.Value;

}