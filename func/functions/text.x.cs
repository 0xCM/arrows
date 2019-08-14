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
    using System.Text;

    using static zfunc;

    partial class xfunc
    {
        /// <summary>
        /// Invokes the implic conversion string -> ReadOnlySpan[char]
        /// </summary>
        /// <param name="src">the souce string</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> ToReadOnlySpan(this string src)
            => src;

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
        public static bool StartsWithDigit(this string s)
            => nonempty(s) ? Char.IsDigit(s.First()) : false;

        /// <summary>
        /// Determines whether a string ends with a digit
        /// </summary>
        /// <param name="s">The string to search</param>
        [MethodImpl(Inline)]
        public static bool EndsWithDigit(this string s)
            => nonempty(s) ? Char.IsDigit(s.Last()) : false;

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
        /// Joins a sequence of source characters with optional interspersed separator
        /// </summary>
        /// <param name="chars"></param>
        /// <param name="sep"></param>
        public static string Concat(this IEnumerable<char> chars, char? sep = null)
        {
            if(sep == null)
                return new string(chars.TakeSpan());
            else
                return new string(chars.Intersperse(sep.Value).TakeSpan());                        
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
        /// Formats a sequence of values between braces 
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static string Embrace<T>(this IEnumerable<T> src, string sep = ", ")
            => embrace(string.Join(sep, src.Select(x => x.ToString())).TrimEnd());

        /// <summary>
        /// Formats a sequence of values between parentheses 
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static string Parenthetical<T>(this IEnumerable<T> src, string sep = ", ")
            => paren(string.Join(sep, src.Select(x => x.ToString())).TrimEnd());

        /// <summary>
        /// Formats a sequence of values between brackets 
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static string Bracket<T>(this IEnumerable<T> src, string sep = ", ")
            => bracket(string.Join(sep, src.Select(x => x.ToString())).TrimEnd());

        /// <summary>
        /// Encloses a string between left and right brackets
        /// </summary>
        [MethodImpl(Inline)]
        public static string Bracket(this string src)
            => bracket(src);

        /// <summary>
        /// Formats a stream as a vector
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <typeparam name="T">The item type</typeparam>
        public static string FormatAsVector<T>(this IEnumerable<T> src, string sep = ", ")
            => AsciSym.Lt + string.Join(sep, src.Select(x => x.ToString())).TrimEnd() + AsciSym.Gt;
 
        /// <summary>
        /// Formats a stream as a delimited sequence with an optional custom value formatter
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <param name="formatter">An optional custom value formatter</formatter>
        /// <typeparam name="T">The item type</typeparam>
        public static string FormatSequence<T>(this IEnumerable<T> src, string sep = ", ",  Func<T,string> formatter = null)
            => string.Join(sep, src.Select(x => formatter?.Invoke(x) ?? x.ToString())).TrimEnd();



        [MethodImpl(Inline)]   
        public static string Format(this ReadOnlySpan<char> src)
            => new string(src);

        [MethodImpl(Inline)]   
        public static string Format(this Span<char> src)
            => new string(src);

        [MethodImpl(Inline)]   
        public static ReadOnlySpan<char> Concat(this ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs)
            => lhs.Format() + rhs.Format();

        public static string Concat(this ReadOnlySpan<string> src, string sep = null)
        {
            var delimiter = sep ?? " | ";
            var sb = new StringBuilder();
            for(var i=0; i<src.Length; i++)
            {
                if(i != 0)
                    sb.Append(delimiter);                
                sb.Append(src[i]);            
            }
            return sb.ToString();
        }

        // [MethodImpl(Inline)]   
        // public static string Concat(this Span<string> src, string sep = null)        
        //     => src.ReadOnly().Concat(sep);

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
        static bool IsBlank(string s)
            => string.IsNullOrWhiteSpace(s);

        /// <summary>
        /// Returns true if not blank as determined by <see cref="IsBlank(string)"/>, false otherwise
        /// </summary>
        /// <param name="s"></param>
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
                result = groupValue;
            else if (valueType.IsNullableType())
                result = System.Convert.ChangeType(groupValue, Nullable.GetUnderlyingType(valueType));
            else
                result = System.Convert.ChangeType(groupValue, valueType);
            return (T)result;
        }

        public static IEnumerable<string> Partition(this string src, int max)
        {
            Span<char> buffer = stackalloc char[max];
            for(int i = 0, j=0; i< src.Length; i++, j++)
            {
                if(j < max)
                    buffer[j] = src[i];
                else
                {
                    yield return new string(buffer);
                    buffer = stackalloc char[max];
                    j = 0;
                    buffer[j] = src[i];
                }
            }
            var trim = buffer.Trim();
            if(trim.Length != 0)
                yield return new string(trim);                
        }

        public static string Concat(this IEnumerable<string> src, string sep = null)
        {
            var sb = new StringBuilder();
            var x = src.ToArray();
            for(var i=0; i<x.Length; i++)
            {
                sb.Append(x[i]);
                if(sep != null && i < x.Length - 1)
                    sb.Append(sep);
            }
            return sb.ToString();
        }

        [MethodImpl(Inline)]
        public static string SeparateBlocks(this string src, int blocklen, string sep)
            => src.Partition(blocklen).Concat(sep);

        [MethodImpl(Inline)]
        public static string SeparateBlocks(this string src, int blocklen, char sep)
            => src.Partition(blocklen).Concat(sep.ToString());

        /// <summary>
        /// Creates a new string by weaving a specified character between each pari
        /// of members in the source string
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="c">The character to intersperse</param>
        public static string Intersperse(this string src, char c)
        {
            var sb = sbuild();
            foreach(var item in src)
            {
                sb.Append(item);
                sb.Append(c);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static bool Eq(this ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs)        
             =>  lhs.CompareTo(rhs, StringComparison.InvariantCulture) == 0;

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static bool Eq(this Span<char> lhs, ReadOnlySpan<char> rhs)        
             =>  lhs.ReadOnly().Eq(rhs);

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static bool Eq(this Span<char> lhs, Span<char> rhs)        
             =>  lhs.ReadOnly().Eq(rhs);

        [MethodImpl(Inline)]
        public static string RemoveWhitespace(this string src)
            => src.RemoveAny(items(AsciSym.Space, AsciEscape.LineFeed, AsciEscape.NewLine, AsciEscape.Tab));
    }
}