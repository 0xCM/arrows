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
        /// Determines whether a string starts with a value from a supplied set
        /// </summary>
        /// <param name="s">The string to examine</param>
        /// <param name="values">The characters for which to search</param>
        /// <returns></returns>
        public static bool StartsWithAny(this string s, IEnumerable<string> values)
        {
            foreach (var v in values)
                if (s.StartsWith(v))
                    return true;
            return false;
        }

        /// <summary>
        /// Determines whether a string terminates with a value from a supplied set
        /// </summary>
        /// <param name="s">The string to examine</param>
        /// <param name="values">The characters for which to search</param>
        /// <returns></returns>
        public static bool EndsWithAny(this string s, IEnumerable<string> values)
        {
            foreach (var v in values)
                if (s.EndsWith(v))
                    return true;
            return false;
        }


        /// <summary>
        /// Determines whether a string leads with any of a specified set of characters
        /// </summary>
        /// <param name="s">The string to examine</param>
        /// <param name="chars">The characters for which to search</param>
        /// <returns></returns>
        public static bool StartsWithAny(this string s, IEnumerable<char> chars)
            => isBlank(s) ? false : chars.Contains(s[0]);

        /// <summary>
        /// Determines whether a string contains any of the characters in a supplied sequence
        /// </summary>
        /// <param name="s">The string to test</param>
        /// <param name="chars">The characters for which to search</param>
        /// <returns></returns>
        public static bool ContainsAny(this string s, IEnumerable<char> chars)
        {
            foreach (var c in chars)
            {
                if (s.Contains(c))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Determines whether a string contains any of the supplied substrings
        /// </summary>
        /// <param name="s">The string to test</param>
        /// <param name="substrings">The characters for which to search</param>
        /// <returns></returns>
        public static bool ContainsAny(this string s, params string[] substrings)
        {
            foreach (var c in substrings)
            {
                if (s.Contains(c))
                    return true;
            }
            return false;
        }


        /// <summary>
        /// Gets the string to the right of, but not including, a specified index
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="idx">The index</param>
        /// <returns></returns>
        public static string RightOf(this string s, int idx)
            => (idx >= s.Length - 1) ? String.Empty : s.Substring(idx + 1);

        /// <summary>
        /// Gets the string to the right of, but not including, a specified substring
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="substring">The substring to match</param>
        /// <returns></returns>
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
        /// <returns></returns>
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
    /// <returns></returns>
    public static string LeftOf(this string s, int idx)
        => (idx >= s.Length - 1) ? String.Empty : s.Substring(0, idx);

    /// <summary>
    /// Gets the string to the left of, but not including, the first instance of a specified character
    /// </summary>
    /// <param name="s">The string to search</param>
    /// <param name="c">The character</param>
    /// <returns></returns>
    public static string LeftOf(this string s, char c)
        => s.Substring(0, apply(s.IndexOf(c), idx => idx == -1 ? s.Length - 1 : idx));

    /// <summary>
    /// Gets the string to the right of, but not including, the first instance of a specified character
    /// </summary>
    /// <param name="s">The string to search</param>
    /// <param name="c">The character</param>
    /// <returns></returns>
    public static string RightOf(this string s, char c)
        => s.RightOf(s.IndexOf(c));

    /// <summary>
    /// Partitions a string into two part, predicated on the first occurrence of a specified marker
    /// </summary>
    /// <param name="s">The string to partition</param>
    /// <param name="marker">The demarcator</param>
    /// <param name="trim">Whether to trim the parts prior to packing the resulting tuple</param>
    /// <returns></returns>
    public static (string Left, string Right) Bifurcate(this string s, string marker, bool trim = true)
        => (ifTrue(trim, LeftOf(s, marker),x => x.Trim()), 
            ifTrue(trim, RightOf(s, marker),x => x.Trim()));


    }
}