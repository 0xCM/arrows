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
using System.Collections.Concurrent;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Reflection;

using Z0;
using static Z0.Bibliography;
using static zcore;
using static Z0.Traits;
using static Z0.ReflectionFlags;

partial class zcore
{
    /// <summary>
    /// Functional equivalalent of <see cref="string.Join(string, object[])"/>
    /// </summary>
    /// <param name="values">The values to be rendered as text</param>
    /// <param name="sep">The item delimiter</param>
    [MethodImpl(Inline)]
    public static string join<T>(string sep, IEnumerable<T> values)
        => string.Join(sep, values);

    /// <summary>
    /// Does what you would expect when supplying a sequence of characters to a 
    /// concatenation function (!)
    /// </summary>
    /// <param name="chars">The characters to concatenate</param>
    [MethodImpl(Inline)]
    public static string concat(IEnumerable<char> chars)
        => new string(chars.ToArray());

    /// <summary>
    /// Does what you would expect when supplying a sequence of characters to a 
    /// concatenation function (!)
    /// </summary>
    /// <param name="chars">The characters to concatenate</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string concat(this char[] chars)
        => new string(chars);
}