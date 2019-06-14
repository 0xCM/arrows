//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;


public static class constant
{
    internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    /// <summary>
    /// Converts an integer to a sequence of digits
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]
    internal static byte[] digits(ulong src)
        => src.ToString().Select(c => byte.Parse(c.ToString())).ToArray();

}