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
using static zcore;
using static zfunc;

using static Z0.Traits;
using static Z0.ReflectionFlags;

partial class zcore
{
    /// <summary>
    /// Defines a symbol
    /// </summary>
    /// <param name="name">The name of the symbol</param>
    /// <param name="description">Formal or informal description depending on context/needs</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Symbol symbol(string name)
        => new Symbol(name);

    /// <summary>
    /// Encloses the potential text in quotation marks
    /// </summary>
    /// <param name="text">The text to be quoted</param>
    [MethodImpl(Inline)]
    public static string enquote(Option<string> text)
        => enquote(text ? text.ValueOrDefault() ?? String.Empty : String.Empty);

    static readonly ConcurrentDictionary<string, Regex> _regexCache
        = new ConcurrentDictionary<string, Regex>();


    /// <summary>
    /// Formats and concatenates an arbitrary number of elements
    /// </summary>
    /// <param name="rest">The formattables to be rendered and concatenated</param>
    [MethodImpl(Inline)]   
    public static string format(Formattable first, params Formattable[] rest)
        => first.format() + append(rest.Select(x => x.format()));

    /// <summary>
    /// Conditionally emits the value of a command flag predicated on the evaluation of a given value
    /// </summary>
    /// <param name="value">The value to evaluate</param>
    /// <param name="flag">The text to emit when the value is evaluated to true</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string cmdFlag(bool value, string flag, string arg = null)
        => not(value) ? estring() : flag + arg ?? estring();

    /// <summary>
    /// Conditionally emits the value of a command flag predicated on the evaluation of a given value
    /// </summary>
    /// <param name="value">The value to evaluate</param>
    /// <param name="flag">The text to emit when the value is evaluated to true</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string cmdFlag(string value, string flag, string arg = null)
        => isBlank(value) ? estring() : flag + arg ?? estring();

    /// <summary>
    /// Conditionally emits the value of a command option predicated on its nullity
    /// </summary>
    /// <param name="value">The value to evaluate</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string cmdOption(object value)
        => show(value);


    /// <summary>
    /// Creates a complied regular expression from the supplied pattern
    /// </summary>
    /// <param name="pattern">The regex pattern/></param>
    /// <returns></returns>
    [DebuggerStepThrough]
    public static Regex regex(string pattern)
        => new Regex(pattern, RegexOptions.Compiled);

    /// <summary>
    /// Creates a complied regular expression and (c)aches it
    /// </summary>
    /// <param name="pattern">The regex pattern/></param>
    /// <returns></returns>
    [DebuggerStepThrough]
    public static Regex regexc(string pattern)
        => _regexCache.GetOrAdd(pattern, p => regex(p));


    
    /// <summary>
    /// Constructs a depiction of the empty set, {∅}
    /// </summary>
    [MethodImpl(Inline)]
    public static string emptyset()
        => embrace(MathSym.emptyset);


    /// <summary>
    /// Splits the string into delimited and nonempy parts
    /// </summary>
    /// <param name="src">The text to split</param>
    /// <param name="c">The delimiter</param>
    [MethodImpl(Inline)]
    public static IReadOnlyList<string> split(string src, char c)
        => isBlank(src)
        ? array<string>()
        : src.Split(new char[] { c }, StringSplitOptions.RemoveEmptyEntries);

    /// <summary>
    /// Returns the substring [0,chars-1]
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string left(string src, int chars)
        => isBlank(src)
        ? src
        : src.Substring(0, src.Length < chars ? src.Length : chars);

    /// <summary>
    /// Returns the substring [0,chars-1]
    /// </summary>
    [MethodImpl(Inline)]
    public static string reverse(string src)
    {
        if (isBlank(src))
            return src;

        var dst = new char[src.Length];
        int j = 0;
        for (var i = src.Length - 1; i >= 0; i--)
            dst[j++] = src[i];
        return new string(dst);
    }

    [MethodImpl(Inline)]
    public static string right(string src, int chars)
    {
        if (isBlank(src))
            return src;

        var len = src.Length < chars ? src.Length : chars;
        var dst = new char[len];
        for (var i = 0; i < len; i++)
            dst[i] = src[src.Length - len + i];
        return new string(dst);
    }

    /// <summary>
    /// Compares two strings using ordinal/case-insensitive comparison
    /// </summary>
    /// <param name="x">The first string</param>
    /// <param name="y">The second string</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static bool equals(string x, string y)
        => ifBlank(x, string.Empty).Equals(y, StringComparison.OrdinalIgnoreCase);

    /// <summary>
    /// Boxes a value
    /// </summary>
    /// <param name="value">The value to box</param>
    [MethodImpl(Inline)]
    public static Box<T> box<T>(T value)
        where T : struct
        => value;

}
