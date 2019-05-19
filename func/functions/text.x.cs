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
            => isNotBlank(s) ? s.StartsWith(c.ToString()) : false;

        /// <summary>
        /// Determines whether a string ends with a specific character
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The character to match</param>
        [MethodImpl(Inline)]
        public static bool EndsWith(this string s, char c)
            => isNotBlank(s) ? s.EndsWith(c.ToString()) : false;

        /// <summary>
        /// Determines whether a string starts with a digit
        /// </summary>
        /// <param name="s">The string to search</param>
        [MethodImpl(Inline)]
        public static bool StartsWithNumber(this string s)
            => isNotBlank(s) ? Char.IsDigit(s.First()) : false;

        /// <summary>
        /// Determines whether a string ends with a digit
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <returns></returns>
        public static bool EndsWithNumber(this string s)
            => isNotBlank(s) ? Char.IsDigit(s.Last()) : false;

        /// <summary>
        /// Formats an array of bytes as a string of hex characters
        /// </summary>
        /// <param name="bytes">The data to format to format</param>
        public static string ToHexString(this byte[] bytes)
            => "0x" + BitConverter.ToString(bytes).Replace("-", String.Empty);

        [MethodImpl(Inline)]
        public static string ToHexString(this sbyte src)
            => "0x" + src.ToString("x").PadLeft(2, '0');

        [MethodImpl(Inline)]
        public static string ToHexString(this byte src)
            => "0x" + src.ToString("x").PadLeft(2, '0');

        [MethodImpl(Inline)]
        public static string ToHexString(this short src)
            => "0x" + src.ToString("x").PadLeft(4, '0');

        [MethodImpl(Inline)]
        public static string ToHexString(this ushort src)
            => "0x" + src.ToString("x").PadLeft(4, '0');

        [MethodImpl(Inline)]
        public static string ToHexString(this int src)
            => "0x" + src.ToString("x").PadLeft(8, '0');

        [MethodImpl(Inline)]
        public static string ToHexString(this uint src)
            => "0x" + src.ToString("x").PadLeft(8, '0');

        [MethodImpl(Inline)]
        public static string ToHexString(this long src)
            => "0x" + src.ToString("x").PadLeft(16, '0');
        
        [MethodImpl(Inline)]
        public static string ToHexString(this ulong src)
            => "0x" + src.ToString("x").PadLeft(16, '0');

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
            => isBlank(src) ? false : chars.Contains(src[0]);

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
        public static string Format<T>(this IEnumerable<T> src, string sep = ", ")
                => embrace(string.Join(sep, src.Select(x => x.ToString())).TrimEnd());
 
        [MethodImpl(Inline)]
        public static Atoms Contain(this IEnumerable<Atom> src)
           => Atoms.Contain(src);

    }
}