//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;

    using static zfunc;

    partial class xfunc
    {
        /// <summary>
        /// Encloses a string within a boundary
        /// </summary>
        /// <param name="s">The string to enclose</param>
        /// <param name="left">The left boundary</param>
        /// <param name="right">The right boundary</param>
        [MethodImpl(Inline)]
        public static string EncloseWithin(this string s, string left, string right)
            => $"{left}{s}{right}";

        /// <summary>
        /// Determines whether the subject is contained betwee specified left and right markers
        /// </summary>
        /// <param name="s">The subject to test</param>
        /// <param name="left">The left marker</param>
        /// <param name="right">The right marker</param>
        /// <param name="compare">Th comparison type</param>
        [MethodImpl(Inline)]
        public static bool EnclosedBy(this string s, string left, string right,
            StringComparison compare = StringComparison.InvariantCulture) => s.StartsWith(left, compare) && s.EndsWith(right, compare);


        /// <summary>
        /// Determines whether the subject is contained betwee specified left and right markers
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="left">The left marker</param>
        /// <param name="right">The right marker</param>
        [MethodImpl(Inline)]
        public static bool EnclosedBy(this string s, char left, char right)
            => String.IsNullOrEmpty(s) ? false : s[0] == left && s.Last() == right;

        /// <summary>
        /// Determines whether a string begins with a specific character
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The character to match</param>
        [MethodImpl(Inline)]
        public static bool StartsWith(this string s, char c)
            => nonempty(s) ? s.StartsWith(c.ToString()) : false;

        /// <summary>
        /// Determines whether a string ends with a specific character
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The character to match</param>
        [MethodImpl(Inline)]
        public static bool EndsWith(this string s, char c)
            => nonempty(s) ? s.EndsWith(c.ToString()) : false;

        /// <summary>
        /// Determines whether a string starts with a digit
        /// </summary>
        /// <param name="s">The string to search</param>
        [MethodImpl(Inline)]
        public static bool StartsWithNumber(this string s)
            => nonempty(s) ? Char.IsDigit(s.First()) : false;

        /// <summary>
        /// Determines whether a string ends with a digit
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <returns></returns>
        public static bool EndsWithNumber(this string s)
            => nonempty(s) ? Char.IsDigit(s.Last()) : false;

        /// <summary>
        /// Formats an array of bytes as a string of hex characters
        /// </summary>
        /// <param name="bytes">The data to format to format</param>
        public static string ToHexString(this byte[] bytes, bool tlz = true, bool pfs = true)
            => "0x" + BitConverter.ToString(bytes).Replace("-", String.Empty);

        [MethodImpl(Inline)]
        public static string ToHexString(this sbyte src, bool zpad = true, bool specifier = true)
            => (specifier ? "0x" : string.Empty) + (zpad ? src.ToString("x") : src.ToString("x").PadLeft(2, '0'));

        [MethodImpl(Inline)]
        public static string ToHexString(this byte src, bool zpad = true, bool specifier = true)
            => (specifier ? "0x" : string.Empty) + (zpad ? src.ToString("x") : src.ToString("x").PadLeft(2, '0'));

        [MethodImpl(Inline)]
        public static string ToHexString(this short src, bool zpad = true, bool specifier = true)
            => (specifier ? "0x" : string.Empty) + (zpad ? src.ToString("x") : src.ToString("x").PadLeft(4, '0'));

        [MethodImpl(Inline)]
        public static string ToHexString(this ushort src, bool zpad = true, bool specifier = true)
            => (specifier ? "0x" : string.Empty) + (zpad ? src.ToString("x") : src.ToString("x").PadLeft(4, '0'));

        [MethodImpl(Inline)]
        public static string ToHexString(this int src, bool zpad = true, bool specifier = true)
            => (specifier ? "0x" : string.Empty) + (zpad ? src.ToString("x") : src.ToString("x").PadLeft(8, '0'));

        /// <summary>
        /// Represents an integer as a hex-formatted string
        /// </summary>
        /// <param name="src">The value for which a hextring will be produced</param>
        /// <param name="zpad">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="specifier">Specifies whether to prepend the '0x' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static string ToHexString(this uint src, bool zpad = true, bool specifier = true)
            => (specifier ? "0x" : string.Empty) + (zpad ? src.ToString("x") : src.ToString("x").PadLeft(8, '0'));

        /// <summary>
        /// Represents an integer as a hex-formatted string
        /// </summary>
        /// <param name="src">The value for which a hextring will be produced</param>
        /// <param name="zpad">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="specifier">Specifies whether to prepend the '0x' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static string ToHexString(this long src, bool zpad = true, bool specifier = true)
            => (specifier ? "0x" : string.Empty) + (zpad ? src.ToString("x") : src.ToString("x").PadLeft(16, '0'));

        /// <summary>
        /// Represents an integer as a hex-formatted string
        /// </summary>
        /// <param name="src">The value for which a hextring will be produced</param>
        /// <param name="zpad">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="specifier">Specifies whether to prepend the '0x' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static string ToHexString(this ulong src, bool zpad = true, bool specifier = true)
            => (specifier ? "0x" : string.Empty) + (zpad ? src.ToString("x").PadLeft(16, '0') : src.ToString("x"))  ;


        /// <summary>
        /// Represents an integer as a hex-formatted string
        /// </summary>
        /// <param name="src">The value for which a hextring will be produced</param>
        /// <param name="zpad">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="specifier">Specifies whether to prepend the '0x' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static string ToHexString(this UInt128 src, bool zpad = true, bool specifier = true)
            => src.x1.ToHexString(false, true) + src.x0.ToHexString(true,false);

        [MethodImpl(Inline)]
        public static string ToHexString(this float src)
            => "0x" + BitConverter.SingleToInt32Bits(src).ToString("x").PadLeft(8, '0');

       [MethodImpl(Inline)]
        public static string ToHexString(this double src)
            => "0x" + BitConverter.DoubleToInt64Bits(src).ToString("x").PadLeft(16, '0');

        /// <summary>
        /// Determines whether a string starts with a value from a supplied set
        /// </summary>
        /// <param name="src">The string to examine</param>
        /// <param name="values">The characters for which to search</param>
        public static bool StartsWithAny(this string src, IEnumerable<string> values)
        {
            foreach (var v in values)
                if (src.StartsWith(v))
                    return true;
            return false;
        }

        /// <summary>
        /// Determines whether a string terminates with a value from a supplied set
        /// </summary>
        /// <param name="src">The string to examine</param>
        /// <param name="values">The characters for which to search</param>
        public static bool EndsWithAny(this string src, IEnumerable<string> values)
        {
            foreach (var v in values)
                if (src.EndsWith(v))
                    return true;
            return false;
        }

        /// <summary>
        /// Determines whether a string leads with any of a specified set of characters
        /// </summary>
        /// <param name="src">The string to examine</param>
        /// <param name="chars">The characters for which to search</param>
        /// <returns></returns>
        public static bool StartsWithAny(this string src, IEnumerable<char> chars)
            => empty(src) ? false : chars.Contains(src[0]);

        /// <summary>
        /// Determines whether a string contains any of the characters in a supplied sequence
        /// </summary>
        /// <param name="src">The string to test</param>
        /// <param name="chars">The characters for which to search</param>
        public static bool ContainsAny(this string src, IEnumerable<char> chars)
        {
            foreach (var c in chars)
            {
                if (src.Contains(c))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Determines whether a string contains any of the supplied substrings
        /// </summary>
        /// <param name="src">The string to test</param>
        /// <param name="substrings">The characters for which to search</param>
        public static bool ContainsAny(this string src, params string[] substrings)
        {
            foreach (var c in substrings)
            {
                if (src.Contains(c))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Determines whether a string contains any of the supplied substrings
        /// </summary>
        /// <param name="src">The string to test</param>
        /// <param name="substrings">The characters for which to search</param>
        public static bool ContainsAny(this string src, IEnumerable<string> substrings)
            => substrings.Any(ss => src.Contains(ss));


        /// <summary>
        /// Gets the string to the right of, but not including, a specified index
        /// </summary>
        /// <param name="src">The string to search</param>
        /// <param name="idx">The index</param>
        /// <returns></returns>
        public static string RightOf(this string src, int idx)
            => (idx >= src.Length - 1) ? String.Empty : src.Substring(idx + 1);

        /// <summary>
        /// Gets the string to the right of, but not including, a specified substring
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="substring">The substring to match</param>
        public static string RightOf(this string s, string substring)
        {
            var idx = s.IndexOf(substring);
            if (idx != -1)
                return s.RightOf(idx + substring.Length);
            else
                return string.Empty;
        }

        /// <summary>
        /// Gets the string to the left of, but not including, a specified substring
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="substring">The substring to match</param>
        public static string LeftOf(this string s, string substring)
        {
            var idx = s.IndexOf(substring);
            if (idx != -1)
                return s.LeftOf(idx);
            else
                return string.Empty;
        }

        /// <summary>
        /// Formats the source as a braced list
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static string Embrace<T>(this IEnumerable<T> src)
            => embrace(string.Join(',',src));

        /// <summary>
        /// Gets the string to the left of, but not including, a specified index
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="idx">The index</param>
        public static string LeftOf(this string s, int idx)
            => (idx >= s.Length - 1) ? String.Empty : s.Substring(0, idx);

        /// <summary>
        /// Gets the string to the left of, but not including, the first instance of a specified character
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The character</param>
        public static string LeftOf(this string s, char c)
            => s.Substring(0, apply(s.IndexOf(c), idx => idx == -1 ? s.Length - 1 : idx));

        /// <summary>
        /// Gets the string to the right of, but not including, the first instance of a specified character
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The character</param>
        public static string RightOf(this string s, char c)
            => s.RightOf(s.IndexOf(c));

        /// <summary>
        /// Partitions a string into two part, predicated on the first occurrence of a specified marker
        /// </summary>
        /// <param name="s">The string to partition</param>
        /// <param name="marker">The demarcator</param>
        /// <param name="trim">Whether to trim the parts prior to packing the resulting tuple</param>
        public static (string Left, string Right) Split(this string s, string marker, bool trim = true)
            => (ifTrue(trim, LeftOf(s, marker),x => x.Trim()), 
                ifTrue(trim, RightOf(s, marker),x => x.Trim()));
 
         /// <summary>
        /// Formats a stream 
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatMany<T>(this IEnumerable<T> src, string sep = ", ")
                => embrace(string.Join(sep, src.Select(x => x.ToString())).TrimEnd());
 
        [MethodImpl(Inline)]
        public static Atoms Contain(this IEnumerable<Atom> src)
           => Atoms.Contain(src);

        [MethodImpl(Inline)]   
        public static string Format(this ReadOnlySpan<char> src)
            => new string(src);

        [MethodImpl(Inline)]   
        public static string Format(this Span<char> src)
            => new string(src);

        [MethodImpl(Inline)]   
        public static ReadOnlySpan<char> Concat(this ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs)
            => lhs.Format() + rhs.Format();


    /// <summary>
    /// Defines an unsigned alterantive to the intrinsic Count property
    /// </summary>
    /// <param name="src">The source list</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static uint Length<T>(this IReadOnlyList<T> src)
        => (uint)src.Count;


    /// <summary>
    /// Replaces occurrences of specified characters is a string if any are present
    /// </summary>
    /// <param name="s">The string that contains characters to be replaced</param>
    /// <param name="replacements">The characters that will be used to replace existing characters</param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string ReplaceAny(this string s, IReadOnlyDictionary<char, char> replacements)
    {
        if (s.ContainsAny(replacements.Keys))
        {
            var dst = new char[s.Length];
            var src = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (replacements.ContainsKey(src[i]))
                {
                    dst[i] = replacements[src[i]];
                }
                else
                    dst[i] = src[i];
            }
            return new string(dst);
        }
        else
        {
            return s;
        }
    }

    public static string ReplaceAny(this string s, IReadOnlyDictionary<string, string> replacements)
    {
        var result = s;
        foreach (var r in replacements)
            result = result.Replace(r.Key, r.Value);
        return result;
    }

    public static string ReplaceExact(this string s, IReadOnlyDictionary<string, string> replacements)
    {
        foreach (var r in replacements)
            if (s == r.Key)
                return r.Value;
        return s;
    }

    /// <summary>
    /// Creates a new string from the first n - 1 characters of a string of length n
    /// </summary>
    /// <param name="s"></param>
    public static string RemoveLast(this string s)
        => IsBlank(s)
        ? string.Empty
        : s.Substring(0, s.Length - 1);

    /// <summary>
    /// Adds a variant of split that is inexplicably missing from System.String
    /// </summary>
    /// <param name="s">The string to split</param>
    /// <param name="delimiter">The delimiter</param>
    /// <returns></returns>
    public static IReadOnlyList<string> Split(this string s, string delimiter)
        => s.Split(array(delimiter), StringSplitOptions.RemoveEmptyEntries);

    /// <summary>
    /// Erases a specified set of character occurrences in a string
    /// </summary>
    /// <param name="s"></param>
    /// <param name="removals"></param>
    /// <returns></returns>
    public static string RemoveAny(this string s, IEnumerable<char> removals)
    {
        if (s.ContainsAny(removals))
        {
            var dst = String.Empty;
            var src = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (!removals.Contains(src[i]))
                {
                    dst += src[i];
                }
            }
            return dst;
        }
        else
        {
            return s;
        }
    }

    /// <summary>
    /// Concatenates a sequence of strings, placing separators between adjacent items
    /// </summary>
    /// <param name="items">The items to concatenate</param>
    /// <param name="separator">The separator</param>
    /// <returns></returns>
    public static string Concat(this IEnumerable<object> items, string separator)
        => string.Join(separator, items);

    /// <summary>
    /// Transforms a generic-valued dictionary into a string-valued dictionary via the generic type's 
    /// ToString() methoc
    /// </summary>
    /// <typeparam name="T">The type of value contained by the dictionary</typeparam>
    /// <param name="src">The dictionary to transform</param>
    /// <returns></returns>
    public static IReadOnlyDictionary<string, string> ToStringDictionary<T>(this IReadOnlyDictionary<string, T> src)
            => src.ToDictionary(x => x.Key, x => x.Value != null ? x.Value.ToString() : String.Empty);

    /// <summary>
    /// Transforms a generic-valued dictionary into a string-valued dictionary via the generic type's 
    /// ToString() methoc
    /// </summary>
    /// <typeparam name="T">The type of value contained by the dictionary</typeparam>
    /// <param name="src">The dictionary to transform</param>
    /// <returns></returns>
    public static IReadOnlyDictionary<string, string> ToStringDictionary<T>(this IDictionary<string, T> src)
        => src.ToDictionary(x => x.Key,
                x => x.Value != null
                   ? x.Value.ToString()
                   : String.Empty);

    /// <summary>
    /// Searches for the last index of a specified character in a string
    /// </summary>
    /// <param name="s">The string to search</param>
    /// <param name="c">The character to match</param>
    /// <returns></returns>
    public static Option<int> TryGetLastIndexOf(this string s, char c)
    {
        var idx = s.LastIndexOf(c);
        return idx != -1 ? some(idx) : none<int>();
    }

    /// <summary>
    /// Searches a string for the first occurrence of a specified character
    /// </summary>
    /// <param name="s">The string to search</param>
    /// <param name="c">The marking character</param>
    /// <returns></returns>
    public static Option<int> TryGetFirstIndexOf(this string s, char c)
    {
        var idx = s.IndexOf(c);
        return idx != -1 ? some(idx) : none<int>();
    }

    /// <summary>
    /// Extracts a substring determined by left/right indexes
    /// </summary>
    /// <param name="s">The string from which to extract a substring</param>
    /// <param name="l">The left index</param>
    /// <param name="r">The right index</param>
    /// <param name="inclusive"></param>
    public static string BetweenIndices(this string s, uint l, uint r, bool inclusive = false)
    {
        if (s.Length <= r)
            return string.Empty;

        var result = string.Empty;
        for(var i = (int)l; i <= r; i++)
        {
            if (i == l)
            {
                if(inclusive)
                    s += s[i];
            }
            else if (i == r - 1 && not(inclusive))
            {
                s += s[i];
                break;
            }
            else
                s += s[i];
        }

        return result;        
        
    }

    /// <summary>
    /// Retrieves the substring that follows the last occurrence of a marker
    /// </summary>
    /// <param name="s">The string to search</param>
    /// <param name="match">The substring to match</param>
    /// <returns></returns>
    public static string RightOfLast(this string s, string match)
    {
        var idx = s.LastIndexOf(match);
        if (idx != -1)
            return s.Substring(idx + match.Length);
        else
            return string.Empty;
    }


    /// <summary>
    /// Returns true if a string is null or whitespace; otherwise, returns false
    /// </summary>
    /// <param name="s">The string to evaluate</param>
    /// <returns></returns>
    static bool IsBlank(string s)
        => string.IsNullOrWhiteSpace(s);

    /// <summary>
    /// Returns true if not blank as determined by <see cref="IsBlank(string)"/>, false otherwise
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    static bool HasValue(string s)
        => !IsBlank(s);

    static bool HasContent(this (string content, string remainder) value)
        => HasValue(value.content);

    static bool HasRemainder(this (string content, string remainder) value)
        => HasValue(value.remainder);

    static bool HasBoundedContent(this string text, (char l, char r) boundary)
    {
        var l = text.IndexOf(boundary.l);
        var r = text.LastIndexOf(boundary.r);
        return r - l > 0;
    }

    static bool HasBoundedContent(this string text, (string l, string r) boundary)
    {
        var l = text.IndexOf(boundary.l);
        var r = text.LastIndexOf(boundary.r);
        return r - l > 0;
    }

    static (string content, string remainder) Next(this string s, (char l, char r) boundary)
    {
        if (!s.HasBoundedContent(boundary))
            return (string.Empty, string.Empty);

        var content = string.Empty;
        var match = 1;
        var idx = 0;
        for (var i = s.IndexOf(boundary.l) + 1; i < s.Length; i++)
        {
            idx = i;
            var c = s[i];
            if (c == boundary.l)
                match++;
            else if (c == boundary.r)
                match--;

            if (match == 0)
                break;
            else
                content += s[i];
        }
        return (content, s.Substring(idx + 1));
    }

    static IEnumerable<string> Drill(this string text, (char l, char r) boundary)
    {
        var current = text;
        while (current.HasBoundedContent(boundary))
        {
            var drill = Next(current, boundary);
            if (drill.HasContent())
            {
                var drilled = drill.content;
                yield return drilled;

                if (drilled.HasBoundedContent(boundary))
                    foreach (var content in drilled.GetBoundedContent(boundary))
                        if (HasValue(content))
                            yield return content;

                current = drill.remainder;
            }
        }
    }

    /// <summary>
    /// Extracts text segments that are demarcated by left/right charcter boundaries
    /// </summary>
    /// <param name="s">The string to search</param>
    /// <param name="l">The left boundary</param>
    /// <param name="r">The right boundary</param>
    /// <returns></returns>
    public static IEnumerable<string> GetBoundedContent(this string s, char l, char r)
        => s.GetBoundedContent((l, r));

    /// <summary>
    /// Extracts text segments that are demarcated by left/right charcter boundaries
    /// </summary>
    /// <param name="s">The string to search</param>
    /// <param name="boundary">The boundary characters</param>
    /// <returns></returns>
    public static IEnumerable<string> GetBoundedContent(this string s, (char l, char r) boundary)
    {
        var next = Next(s, boundary);

        if (next.HasContent())
        {
            yield return next.content;

            foreach (var drilled in next.remainder.Drill(boundary))
                yield return drilled;

            foreach (var content in next.content.GetBoundedContent(boundary))
            {
                if (HasValue(content))
                    yield return content;
            }
        }
    }

    /// <summary>
    /// Formats the supplied decimal value as currency to two decimal places
    /// </summary>
    /// <param name="d">The decimal value</param>
    public static string FormatAsCurrency(this decimal src, int scale = 2)
        => String.Format(embrace($"0:C{scale}"), src);

    [MethodImpl(Inline)]
    public static string FormatWithCommas(this short src)
            => src.ToString("#,#");

    [MethodImpl(Inline)]
    public static string FormatWithCommas(this ushort src)
            => src.ToString("#,#");

    [MethodImpl(Inline)]
    public static string FormatWithCommas(this int src)
            => src.ToString("#,#");

    [MethodImpl(Inline)]
    public static string FormatWithCommas(this uint src)
        => src.ToString("#,#");

    [MethodImpl(Inline)]
    public static string FormatWithCommas(this long src)
        => src.ToString("#,#");

    [MethodImpl(Inline)]
    public static string FormatWithCommas(this ulong src)
        => src.ToString("#,#");

    [MethodImpl(Inline)]
    public static string FormatWithCommas(this float src)
        => src.ToString("#,#");

    [MethodImpl(Inline)]
    public static string FormatWithCommas(this double src)
        => src.ToString("#,#");

    /// <summary>
    /// Determines whether a <see cref="Match"/> obtained via a regular expression contains a specified group
    /// </summary>
    /// <param name="m">The match</param>
    /// <param name="name">The candidate group name</param>
    public static bool HasGroupValue(this Match m, string name)
        => m.Groups[name].Success;

    /// <summary>
    /// Gets the value of a named match group if it exists; otherwise, throws an exception
    /// </summary>
    /// <param name="m">The matched expression</param>
    /// <param name="name">The name of the group</param>
    public static string GetGroupValue(this Match m, string name)
    {
        if (!m.Groups[name].Success)
            throw new ArgumentException($"The group {name} was not matched successfully");

        return m.Groups[name].Value;
    }

    public static Option<string> TryGetGroupValue(this Regex x, string input, string group)
    {
        var match = x.Match(input);
        if (match.Success && match.Groups[group].Success)
            return match.Groups[group].Value;
        else
            return none<string>();
    }

    /// <summary>
    /// Gets the value of an identified regular expression group
    /// </summary>
    /// <typeparam name="T">The group value type</typeparam>
    /// <param name="m">The matched expression</param>
    /// <param name="name">The name of the group</param>
    public static T GetGroupValue<T>(this Match m, string name)
    {
        var result = default(object);

        var groupValue = m.GetGroupValue(name);
        var valueType = typeof(T);
        if (valueType.IsString())
        {
            result = groupValue;
        }
        else if (valueType.IsNullableType())
        {
            result = System.Convert.ChangeType(groupValue, Nullable.GetUnderlyingType(valueType));
        }
        else
        {
            result = System.Convert.ChangeType(groupValue, valueType);
        }
        return (T)result;
    }

    }
}