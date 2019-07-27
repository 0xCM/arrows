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
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Collections.Concurrent;
using System.Numerics;

using Z0;

partial class zfunc
{ 
    static readonly ConcurrentDictionary<string, Regex> _regexCache
        = new ConcurrentDictionary<string, Regex>();

    /// <summary>
    /// Renders an end-of-line marker
    /// </summary>
    [MethodImpl(Inline)]   
    public static string eol() 
        => "\r\n";

    /// <summary>
    /// Formats the source value as a string
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string format<T>(T x)
        => x == null ? string.Empty : x.ToString();

    /// <summary>
    /// Formats a tuple as one would expect
    /// </summary>
    /// <param name="x1">The first coordinate</param>
    /// <param name="x2">The second coordinate</param>
    /// <typeparam name="X1">The first coordinate type</typeparam>
    /// <typeparam name="X1">The second coordinate type</typeparam>
    [MethodImpl(Inline)]
    public static string format<X1,X2>((X1 x1, X2 x2) x)
        => $"({x.x1}, {x.x2})";

    /// <summary>
    /// Encloses text content between left and right braces
    /// </summary>
    /// <param name="content">The content to be embraced</param>
    public static string embrace(string content)      
        => $"{AsciSym.LBrace}{content}{AsciSym.RBrace}";

    /// <summary>
    /// Left-Pads the input string with an optionally-specified character.
    /// </summary>
    /// <param name="src">The input text</param>
    /// <param name="width">The with of the padded string</param>
    /// <param name="c">The padding character, if specifed; otherwise, a space is used as the filler</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string lpad(string src, uint width, char? c = null)
        => src.PadLeft((int)width,c ?? ' ');

    /// <summary>
    /// Left-Pads the input string with zeros
    /// </summary>
    /// <param name="src">The input text</param>
    /// <param name="width">The with of the padded string</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string zpad(string src, uint width)
        => src.PadLeft((int)width,'0');

    /// <summary>
    /// Formats the source value and left-pads the result with zeros
    /// </summary>
    /// <param name="src">The input text</param>
    /// <param name="width">The with of the padded string</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string zpad<T>(T src, uint width)
        => $"{src}".PadLeft((int)width, '0');

    /// <summary>
    /// Right-Pads the input string with an optionally-specified character.
    /// </summary>
    /// <param name="src">The input text</param>
    /// <param name="width">The with of the padded string</param>
    /// <param name="c">The padding character, if specifed; otherwise, a space is used as the filler</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string rpad(string src, uint width, char? c = null)
        => src.PadRight((int)width,c ?? ' ');

    /// <summary>
    /// Right-Pads the input string with zeros
    /// </summary>
    /// <param name="src">The input text</param>
    /// <param name="width">The with of the padded string</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string rpadZ(string src, uint width)
        => src.PadRight((int)width,'0');

    /// <summary>
    /// Shorthand for the <see cref="string.IsNullOrEmpty(string)"/> method
    /// </summary>
    /// <param name="subject">The string to evaluate</param>
    [MethodImpl(Inline)]
    public static bool empty(string subject)
        => String.IsNullOrWhiteSpace(subject);

    /// <summary>
    /// Shorthand for the negation of the <see cref="string.IsNullOrEmpty(string)"/> method
    /// </summary>
    /// <param name="subject">The string to evaluate</param>
    [MethodImpl(Inline)]
    public static bool nonempty(string subject)
        => not(empty(subject));

    /// <summary>
    /// Determines whether a string 2-tuple consists of only the empty string
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static bool nonempty((string s1, string s2) s)
        => nonempty(s.s1) || nonempty(s.s2);

    /// <summary>
    /// A string-specific coalescing operation
    /// </summary>
    /// <param name="subject">The subject string</param>
    /// <param name="replace">The replacement value if blank</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string ifEmpty(string subject, string replace)
        => empty(subject) ? replace : subject;

    /// <summary>
    /// Replacement returned if the input is not blank
    /// </summary>
    /// <param name="subject">The subject string</param>
    /// <param name="replace">The replacement value if input is not blank</param>
    [MethodImpl(Inline)]
    public static string ifNonempty(string subject, string replace)
        => nonempty(subject) ? replace : subject;

    /// <summary>
    /// Produces the empty string
    /// </summary>
    [MethodImpl(Inline)]
    public static string estring()
        => string.Empty;

    /// <summary>
    /// Produces a left parenthesis character
    /// </summary>
    [MethodImpl(Inline)]
    public static string lparen()
        => "(";

    /// <summary>
    /// Produces a '[' character
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string lbracket()
        => "[";

    /// <summary>
    /// Produces a ']' character
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string rbracket()
        => "]";

    /// <summary>
    /// Produces a right parenthesis character
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string rparen()
        => ")";

    /// <summary>
    /// Produces a tab character
    /// </summary>
    [MethodImpl(Inline)]
    public static string tab(int count = 1)
        => new string('\t', count);


    /// <summary>
    /// Produces a quote
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string quote()
        => "\"";

    /// <summary>
    /// Produces a quote
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string quote(string content)
        => $"{quote()}{content}{quote()}";


    /// <summary>
    /// Produces a space character as a string
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string space()
        => " ";

    /// <summary>
    /// Produces a left-brace character as a string
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string lbrace() => "{";

    /// <summary>
    /// Produces a right-brace character as a string
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string rbrace() => "}";

    /// <summary>
    /// Produces a ',' character
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string comma()
        => ",";

    /// <summary>
    /// Produces a '/' character
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string fslash()
        => "/";

    /// <summary>
    /// Produces a '\' character
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string bslash()
        => "\\";

    /// <summary>
    /// Produces a ";" character
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string semicolon()
        => AsciSym.Semicolon.ToString();

    /// <summary>
    /// Produces a "." character
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string dot()
        => AsciSym.Dot.ToString();

    /// <summary>
    /// Produces a colon character
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string colon()
        => AsciSym.Colon.ToString();

    /// <summary>
    /// Encloses the supplied text in quotation marks
    /// </summary>
    /// <param name="text">The text to be quoted</param>
    [MethodImpl(Inline)]
    public static string enquote(string text)
        => $"{AsciSym.Quote}{text}{AsciSym.Quote}";

    /// <summary>
    /// Encloses text within (possibly distinct) left and right boundaries
    /// </summary>
    /// <param name="content">The text to be bounded</param>
    /// <param name="left">The text on the left</param>
    /// <param name="right">The text on the right</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string enclose(string content, string left, string right)
        => $"{left}{content}{right}";

    /// <summary>
    /// Encloses text within a bounding string
    /// </summary>
    /// <param name="content">The text to enclose</param>
    /// <param name="delimiter">The left and right boundary</param>
    [MethodImpl(Inline)]
    public static string enclose(string content, string delimiter)
        => $"{delimiter}{content}{delimiter}";

    /// <summary>
    /// Encloses text within (possibly distinct) left and right boundaries
    /// </summary>
    /// <param name="content">The text to be surrounded by the left and right delimiters</param>
    /// <param name="left">The left delimiter</param>
    /// <param name="right">The right delimiter</param>
    [MethodImpl(Inline)]
    public static string enclose(string content, char left, char right)
        => $"{left}{content}{right}";

    /// <summary>
    /// Encloses a character within uniform left/right bounding string
    /// </summary>
    /// <param name="content">The character to be surrounded by the left and right delimiters</param>
    /// <param name="delimiter">The boundary delimiter</param>
    [MethodImpl(Inline)]
    public static string enclose(char content, string delimiter)
        => $"{delimiter}{content}{delimiter}";

    /// <summary>
    /// Encloses a character within (possibly distinct) left and right boundaries
    /// </summary>
    /// <param name="content">The character to be bounded</param>
    /// <param name="left">The text on the left</param>
    /// <param name="right">The text on the right</param>
    [MethodImpl(Inline)]
    public static string enclose(char content, string left, string right)
        => $"{left}{content}{right}";

    /// <summary>
    /// Encloses content within specified boundaries
    /// </summary>
    /// <param name="content">The fenced contant</param>
    /// <param name="left">The text on the left</param>
    /// <param name="right">The text on the right</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string wrap(object left, object content, object right)
        => $"{left}{content}{right}";

    /// <summary>
    /// Encloses text between single quote (') characters
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string squote(string text)
        => enclose(text, AsciSym.SQuote.ToString());

    /// <summary>
    /// Encloses a character between single quote (') characters
    /// </summary>
    /// <param name="c"></param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string squote(char c)
        => enclose(c, AsciSym.SQuote.ToString());

    /// <summary>
    /// Encloses text between '(' and ')' characters
    /// </summary>
    /// <param name="content"></param>
    [MethodImpl(Inline)]
    public static string paren(params object[] content)
        => enclose(concat(content.Select(x => x.ToString())), lparen(), rparen());

    /// <summary>
    /// Renders a content array as a comma-separated list of values
    /// </summary>
    /// <param name="content"></param>
    [MethodImpl(Inline)]
    public static string csv(object o1, object o2, params object[] content)
        =>  string.Join(AsciSym.Comma, o1, o2) + string.Join(AsciSym.Comma, content);

    /// <summary>
    /// Renders a sequence of items as a comma-separated list of values
    /// </summary>
    [MethodImpl(Inline)]
    public static string csv(IEnumerable<object> content)
        => string.Join(AsciSym.Comma, content);

    /// <summary>
    /// Renders a sequence of items as an x-separated list of values
    /// </summary>
    /// <param name="content"></param>
    [MethodImpl(Inline)]
    public static string xsv(string separator, params object[] content)
        => string.Join(separator, content);

    /// <summary>
    /// Renders a stream as a comma-separated list of values
    /// </summary>
    /// <param name="src">The source items</param>
    [MethodImpl(Inline)]
    public static string csv<T>(IEnumerable<T> src)
        => string.Join(AsciSym.Comma, src);

    /// <summary>
    /// Renders each item from a sequence as list of values, delimited by end-of-line
    /// </summary>
    /// <param name="content">The content to enclose</param>
    [MethodImpl(Inline)]
    public static string eol(IEnumerable<object> content)
        => string.Join(eol(), content);

    /// <summary>
    /// Renders a content array as a space-separated list of values
    /// </summary>
    /// <param name="content">The content to enclose</param>
    [MethodImpl(Inline)]
    public static string space(params object[] content)
        => string.Join(' ', content);
    
    /// <summary>
    /// Encloses text between '[' and ']' characters
    /// </summary>
    /// <param name="content">The content to enclose</param>
    [MethodImpl(Inline)]
    public static string bracket(string content)
        => enclose(content, lbracket(), rbracket());

    /// <summary>
    /// Encloses text between less than and greater than characters
    /// </summary>
    /// <param name="content">The content to enclose</param>
    [MethodImpl(Inline)]
    public static string angled(string content)
        => String.IsNullOrWhiteSpace(content) ? string.Empty : $"<{content}>";

    /// <summary>
    /// Trims leading characters when matched
    /// </summary>
    /// <param name="src">The text to manipulate</param>
    /// <param name="chars">The leading characters to remove</param>
    [MethodImpl(Inline)]
    public static string ltrim(string src, params char[] chars)
        => empty(src) ? string.Empty : src.TrimStart(chars);

    /// <summary>
    /// Trims trailing characters when matched
    /// </summary>
    /// <param name="src">The text to manipulate</param>
    /// <param name="chars">The leading characters to remove</param>
    [MethodImpl(Inline)]
    public static string rtrim(string src, params char[] chars)
        => empty(src) ? string.Empty : src.TrimEnd(chars);

    /// <summary>
    /// Produces a string containing a specified number of tab characters
    /// </summary>
    /// <param name="count">The number of tab characters the output string should contain</param>
    [MethodImpl(Inline)]
    public static string tabs(int count)
        => count == 0
        ? estring()
        : new string(AsciEscape.Tab, count);

    /// <summary>
    /// Produces a string containing a specified number of '.' characters
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string dots(int count = 3)
        => count == 0
        ? string.Empty
        : new string('.', count);

    /// <summary>
    /// Produces a string indented by a specified number of tab characters
    /// </summary>
    /// <param name="count">The number of tab characters the output string should contain</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string tabs(int count, string content)
        => tabs(count) + content;

    /// <summary>
    /// Produces a string containing a specified number of spaces
    /// </summary>
    /// <param name="count">The number of spaces the output string should contain</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string spaces(int count)
        => count == 0 ? estring() : new string(' ', count);

    /// <summary>
    /// Separates each item with a space
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string spaced(params object[] items)
        => string.Join(space(), items);

    /// <summary>
    /// Separates each item with a space
    /// </summary>
    [MethodImpl(Inline)]
    public static string spaced(IEnumerable<object> items)
        => string.Join(space(), items);

    /// <summary>
    /// Removes a substring from the subject
    /// </summary>
    [MethodImpl(Inline)]
    public static string remove(string text, string substring)
        => text.Replace(substring, String.Empty);


    /// <summary>
    /// Functional equivalalent of <see cref="string.Join(string, IEnumerable{string})"/>
    /// </summary>
    /// <param name="values">The values to be rendered as text</param>
    /// <param name="sep">The item delimiter</param>
    /// <returns></returns>
    public static string toString(IEnumerable<object> values, string sep = null)
        => string.Join(sep ?? "|", values);

    /// <summary>
    /// If input is not blank, returns the input; otherwise, returns an empty string or a supplied marker
    /// </summary>
    /// <param name="subject">The subject</param>
    [MethodImpl(Inline)]
    static string toString(string subject, string ifBlank = null)
        => nonempty(subject) ? subject : ifBlank ?? String.Empty;

    /// <summary>
    /// If subject is not null, invokes its ToString() method; otherwise, returns an empty string or a supplied marker
    /// </summary>
    /// <typeparam name="T">The subject type</typeparam>
    /// <param name="subject">The subject</param>
    [MethodImpl(Inline)]
    public static string toString<T>(T subject, string ifMissing)
        => (subject is string)
            ? toString(subject as string, ifMissing)
            : (subject != null ? subject.ToString() : ifMissing ?? estring());


    [MethodImpl(Inline)]
    public static string hexstring(byte src)
        => src.ToString("X");

    [MethodImpl(Inline)]
    public static string hexstring(sbyte src)
        => src.ToString("X");

    [MethodImpl(Inline)]
    public static string hexstring(short src)
        => src.ToString("X");

    [MethodImpl(Inline)]
    public static string hexstring(ushort src)
        => src.ToString("X");

    [MethodImpl(Inline)]
    public static string hexstring(int src)
        => src.ToString("X");

    [MethodImpl(Inline)]
    public static string hexstring(uint src)
        => src.ToString("X");

    [MethodImpl(Inline)]
    public static string hexstring(long src)
        => src.ToString("X");

    [MethodImpl(Inline)]
    public static string hexstring(ulong src)
        => src.ToString("X");

    [MethodImpl(Inline)]   
    public static string hexstring(BigInteger x)
        => x.ToString("X");

    [MethodImpl(Inline)]   
    public static string hexstring(decimal src)
    {
        var parts = Decimal.GetBits(src);        
        return hexstring(parts[0]) + hexstring(parts[1]) + hexstring(parts[2]) + hexstring(parts[3]);
    }
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

    /// <summary>
    /// Formats and concatenates an arbitrary number of elements
    /// </summary>
    /// <param name="rest">The formattables to be rendered and concatenated</param>
    [MethodImpl(Inline)]   
    public static string format(object first, params object[] rest)
        => first.ToString() + concat(rest.Select(x => x.ToString()));

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
        => empty(value) ? estring() : flag + arg ?? estring();


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
        => embrace(MathSym.EmptySet.ToString());

    /// <summary>
    /// Splits the string into delimited and nonempy parts
    /// </summary>
    /// <param name="src">The text to split</param>
    /// <param name="c">The delimiter</param>
    [MethodImpl(Inline)]
    public static IReadOnlyList<string> split(string src, char c)
        => empty(src)
        ? zfunc.array<string>()
        : src.Split(new char[] { c }, StringSplitOptions.RemoveEmptyEntries);

    /// <summary>
    /// Returns the substring [0,chars-1]
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string left(string src, int chars)
        => empty(src)
        ? src
        : src.Substring(0, src.Length < chars ? src.Length : chars);

    /// <summary>
    /// Returns the substring [0,chars-1]
    /// </summary>
    public static string reverse(string src)
    {
        if (empty(src))
            return src;

        var dst = new char[src.Length];
        int j = 0;
        for (var i = src.Length - 1; i >= 0; i--)
            dst[j++] = src[i];
        return new string(dst);
    }

    public static string right(string src, int chars)
    {
        if (empty(src))
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
    [MethodImpl(Inline)]
    public static bool equals(string x, string y)
        => ifEmpty(x, string.Empty).Equals(y, StringComparison.OrdinalIgnoreCase);


    /// <summary>
    /// Joins the string representation of a sequence of values
    /// </summary>
    /// <param name="values">The values to be joined</param>
    /// <param name="delimiter">The value delimiter</param>
    [MethodImpl(Inline)]
    public static string join(string delimiter, IEnumerable<object> values)
        => string.Join(delimiter, values);


    [MethodImpl(Inline)]
    public static StringBuilder sbuild(string s0 = null)
        => s0 != null ? new StringBuilder(s0) : new StringBuilder();

}