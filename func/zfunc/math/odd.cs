//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Returns true if the test value is odd by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bool odd(sbyte test)
        => (test & 1) != 0;

    /// <summary>
    /// Returns true if the test value is odd by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bool odd(byte test)
        => (test & 1) != 0;

    /// <summary>
    /// Returns true if the test value is odd by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bool odd(short test)
        => (test & 1) != 0;

    /// <summary>
    /// Returns true if the test value is odd by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bool odd(ushort test)
        => (test & 1) != 0;

    /// <summary>
    /// Returns true if the test value is odd by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bool odd(int test)
        => (test & 1) != 0;

    /// <summary>
    /// Returns true if the test value is odd by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bool odd(uint test)
        => (test & 1) != 0;

    /// <summary>
    /// Returns true if the test value is odd by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bool odd(long test)
        => (test & 1) != 0;

    /// <summary>
    /// Returns true if the test value is odd by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bool odd(ulong test)
        => (test & 1) != 0;

    /// <summary>
    /// Returns true if the test value is even by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bool even(sbyte test)
        => !odd(test);

    /// <summary>
    /// Returns true if the test value is even by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bool even(byte test)
        => !odd(test);

    /// <summary>
    /// Returns true if the test value is even by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bool even(short test)
        => !odd(test);

    /// <summary>
    /// Returns true if the test value is even by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bool even(int test)
        => !odd(test);

    /// <summary>
    /// Returns true if the test value is even by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bool even(ushort test)
        => !odd(test);

    /// <summary>
    /// Returns true if the test value is even by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bool even(uint test)
        => !odd(test);

    /// <summary>
    /// Returns true if the test value is even by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bool even(long test)
        => !odd(test);

    /// <summary>
    /// Returns true if the test value is even by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bool even(ulong test)
        => !odd(test);



}

