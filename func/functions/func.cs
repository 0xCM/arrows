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

partial class zfunc
{

    /// <summary>
    /// The univeral identity function that returns the source value
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="A">The source value type</typeparam>
    /// <returns>The source value</returns>
    [MethodImpl(Inline)]   
    public static A  identity<A>(A x) => x;

    /// <summary>
    /// Evaluates a function over a value if the value is not null; otherwise,
    /// returns the default result value
    /// </summary>
    /// <typeparam name="X">The operand type</typeparam>
    /// <typeparam name="Y">The return type</typeparam>
    /// <param name="x">The operand</param>
    /// <param name="f1">The function to potentially evaluate</param>
    [MethodImpl(Inline)]
    public static Y ifNotNull<X, Y>(X x, Func<X, Y> f1, Y @default = default)
        => x != null ? f1(x) : @default;

    /// <summary>
    /// Returns the supplied value if not null, otherwise invokes a function to provide
    /// a non-null value as a replacement
    /// </summary>
    /// <typeparam name="T">The object type</typeparam>
    /// <param name="x">The object to test</param>
    /// <param name="replace">The function that yields a replacement value in the event that the supplied value is null</param>
    [MethodImpl(Inline)]
    public static T ifNull<T>(T x, Func<T> replace)
        where T : class => x ?? replace();

    /// <summary>
    /// Computes the number of bits required to store a value type
    /// </summary>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static BitSize bitsize<T>()
        where T :struct
            => Unsafe.SizeOf<T>()*8;

    /// <summary>
    /// The canonical swap function
    /// </summary>
    /// <param name="lhs">The left value</param>
    /// <param name="rhs">The right value</param>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static void swap<T>(ref T lhs, ref T rhs)
    {
        var temp = lhs;
        lhs = rhs;
        rhs = temp;
    }

    

}