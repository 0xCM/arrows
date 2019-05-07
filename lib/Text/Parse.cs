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

using static Z0.Bibliography;
using static Z0.Traits;
using static Z0.ReflectionFlags;

partial class zcore
{
    /// <summary>
    /// Indexes default set of primitive parsers
    /// </summary>
    static IDictionary<Type, Func<string, object>> parsers = new Dictionary<Type, Func<string, object>>
    {
        [typeof(Date)] = s => Date.Parse(s),

        [typeof(Date?)] = s => TryParseDate(s),

        [typeof(DateTime)] = s => DateTime.Parse(s),

        [typeof(DateTime?)] = s => TryParseDateTime(s),

        [typeof(Guid)] = s => Guid.Parse(s),

        [typeof(Guid?)] = s => TryParseGuid(s),

        [typeof(decimal)] = s => decimal.Parse(s, NumberStyleOptions, CultureInfo.InvariantCulture),

        [typeof(decimal?)] = s => TryParseDecimal(s),

        [typeof(TimeSpan)] = s => TimeSpan.Parse(s),

        [typeof(TimeSpan?)] = s => TryParseTimeSpan(s),

        [typeof(bool)] = s => ParseBool(s),

        [typeof(bool?)] = s => isBlank(s) ? null : (bool?)ParseBool(s),

        [typeof(int)] = s => int.Parse(s),

        [typeof(int?)] = s => TryParseInt32(s),

        [typeof(short)] = s => short.Parse(s),

        [typeof(short?)] = s => TryParseInt16(s),

        [typeof(long)] = s => long.Parse(s),

        [typeof(long?)] = s => TryParseInt64(s),

        [typeof(double)] = s => double.Parse(s),

        [typeof(double?)] = s => TryParseDouble(s),

        [typeof(string)] = s => s
    };

    static readonly NumberStyles NumberStyleOptions =
        NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign |
        NumberStyles.AllowCurrencySymbol | NumberStyles.AllowThousands;

    static readonly HashSet<string> TrueValues
        = new HashSet<string>(new[] { "true", "t", "1", "y", "+" });

    static readonly HashSet<string> FalseValues
        = new HashSet<string>(new[] { "false", "f", "0", "n", "-" });


    /// <summary>
    /// Attempts to parse the supplied value
    /// </summary>
    public static object parse(Type t, string s)
        => parsers[t](s);

    /// <summary>
    /// Attempts to parse the supplied value
    /// </summary>
    /// <typeparam name="T">The target type</typeparam>
    /// <param name="s">The value to parse</param>
    public static T parse<T>(string s)
        => ifvalue(s, _ => (T)parsers[typeof(T)](s), () => default(T));

    /// <summary>
    /// Attempts to parse the supplied value
    /// </summary>
    /// <typeparam name="T">The target type</typeparam>
    /// <param name="s">The value to parse</param>
    public static Option<T> tryParse<T>(string s, Action<Exception> error = null)
    {
        try
        {
            return ifvalue(s, _ => (T)parsers[typeof(T)](s), () => none<T>());
        }
        catch (Exception e)
        {
            error?.Invoke(e);
            return none<T>();
        }
    }
    
    /// <summary>
    /// Returns a parsed value if successful, otherwise none
    /// </summary>
    /// <param name="t">The type to be hydrated</param>
    /// <param name="s">The text to be parsed</param>
    public static Option<object> tryParse(Type t, string s, Action<Exception> error = null)
    {
        try
        {
            return s != null  ? parsers[t](s) : null;
        
        }
        catch (Exception e)
        {
            error?.Invoke(e);
            return none<object>();
        }
    }

    /// <summary>
    /// Parses a list of name-value pairs and hydrates a conforming type
    /// </summary>
    /// <typeparam name="T">The type to materialize from the sequence of (name,value) pairs</typeparam>
    /// <param name="values">The values to parse</param>
    public static T parse<T>(Index<(string name, string value)> values)
        where T : new()
    {
        var element = new T();
        var properties = typeof(T).GetProperties().ToDictionary(x => x.Name);
        iter(values,
            kvp => properties.TryFind(kvp.name)
                             .OnSome(p => p.SetValue(element, parse(p.PropertyType, kvp.value))));
        return element;
    }

    /// <summary>
    /// Parses a collection of name-value pair sequences to hydrate a set of corresponding orjectes
    /// </summary>
    /// <typeparam name="T">The type to materialize from each (name,value) pair sequence</typeparam>
    /// <param name="values"></param>
    public static Index<T> parse<T>(IEnumerable<Index<(string name, string value)>> values)
        where T : new()
    {
        var results = new ConcurrentBag<T>();
        values.AsParallel().ForAll(v => results.Add(parse<T>(v)));
        return results.ToList();
    }

    /// <summary>
    /// Parse an enum or returns a default value if parsing fails
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="text"></param>
    /// <param name="default"></param>
    public static T parseEnum<T>(string text, T @default)
        where T : struct
    {
        var result = @default;
        Enum.TryParse(text, true, out result);
        return result;
    }

    /// <summary>
    /// Parses an enumeration
    /// </summary>
    /// <typeparam name="T">The enumeration type</typeparam>
    /// <param name="value">The value of the enumeration</param>
    public static T parseEnum<T>(string value)
        => (T)Enum.Parse(typeof(T), value, true);

    /// <summary>
    /// Helper to parse a boolean value in a more reasonable fashion than the intrinsic <see cref="bool.Parse(string)"/> method
    /// </summary>
    /// <param name="src">The text to parse</param>
    static bool ParseBool(string src)
    {
        var key = src.ToLower();
        if (TrueValues.Contains(key))
            return true;
        else if (FalseValues.Contains(key))
            return false;
        else
            throw new ArgumentException($"Could not interpret {src} as a boolean value");
    }

    /// <summary>
    /// Parses an <see cref="Int32"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="src">The text to parse</param>
    static int? TryParseInt32(string src)
    {
        if (Int32.TryParse(src, out int result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses an <see cref="Int64"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="src">The text to parse</param>
    static long? TryParseInt64(string src)
    {
        if (Int64.TryParse(src, out long result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="Byte"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="src">The text to parse</param>
    /// <returns></returns>
    static byte? TryParseUInt8(string src)
    {
        var result = (byte)0;
        if (Byte.TryParse(src, out result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="Date"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="src">The text to parse</param>
    /// <returns></returns>
    static Date? TryParseDate(string src)
    {
        if (Date.TryParse(src, out Date result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="DateTime"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="src">The text to parse</param>
    /// <returns></returns>
    static DateTime? TryParseDateTime(string src)
    {
        if (DateTime.TryParse(src, out DateTime result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="Guid"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="src">The text to parse</param>
    /// <returns></returns>
    static Guid? TryParseGuid(string src)
    {
        if (Guid.TryParse(src, out Guid result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses an <see cref="Int16"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="s">The text to parse</param>
    /// <returns></returns>
    static Int16? TryParseInt16(string s)
    {
        if (Int16.TryParse(s, out Int16 result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="Double"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="s">The text to parse</param>
    static double? TryParseDouble(string s)
    {
        if (double.TryParse(s, out double result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="TimeSpan"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="s">The text to parse</param>
    static TimeSpan? TryParseTimeSpan(string s)
    {
        if (TimeSpan.TryParse(s, out TimeSpan result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="decimal"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="s">The text to parse</param>
    static decimal? TryParseDecimal(string s)
    {
        if (decimal.TryParse(s, NumberStyleOptions, CultureInfo.InvariantCulture, out decimal result))
            return result;
        else
            return null;
    }
}