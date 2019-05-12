//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;
using System.Diagnostics;

using Z0;
using static zfunc;

partial class mfunc
{
    /// <summary>
    /// Converts an integer to a sequence of digits
    /// </summary>
    /// <param name="src">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static byte[] digits(byte src)
        => src.ToString().Select(c => byte.Parse(c.ToString())).ToArray();

    /// <summary>
    /// Converts an integer to a sequence of digits
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]
    public static byte[] digits(ushort src)
        => src.ToString().Select(c => byte.Parse(c.ToString())).ToArray();

    /// <summary>
    /// Converts an integer to a sequence of digits
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]
    public static byte[] digits(uint src)
        => src.ToString().Select(c => byte.Parse(c.ToString())).ToArray();

    /// <summary>
    /// Converts an integer to a sequence of digits
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]
    public static byte[] digits(ulong src)
        => src.ToString().Select(c => byte.Parse(c.ToString())).ToArray();

    [MethodImpl(Inline)]
    public static BinaryDigit[] digits(params BinaryDigit[] src)
        => src;
}