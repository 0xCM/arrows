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
    /// Concatenates an arbitrary number of strings
    /// </summary>
    /// <param name="src">The strings to be concatenated</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string append(params string[] src) 
        => string.Concat(src);
    
    /// <summary>
    /// Concatenates an arbitrary number of string representations
    /// </summary>
    /// <param name="src">The strings to be concatenated</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string append<T>(IEnumerable<T> src) 
        => string.Concat(src);

    /// <summary>
    /// Concatenates an arbitrary number of string representations,
    /// separated by a specified delimiter
    /// </summary>
    /// <param name="delimiter">The separator</param>
    /// <param name="src">The values for which string representations will
    /// be formed</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string append<T>(string delimiter, IEnumerable<T> src) 
        => string.Join(delimiter, src.Select(x => x.ToString()));

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