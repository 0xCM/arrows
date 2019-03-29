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

// safelight auto glass 417 powerhouse 75071 972-379-2704 1:00 friday
partial class zcore
{

    
    /// <summary>
    /// Formats and concatenates an arbitrary number of elements
    /// </summary>
    /// <param name="rest">The formattables to be rendered and concatenated</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string format(Formattable first, params Formattable[] rest)
        => first.format() + concat(rest.Select(x => x.format()));

    /// <summary>
    /// Concatenates an arbitrary number of strings
    /// </summary>
    /// <param name="src">The strings to be concatenated</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string concat(params string[] src) 
        => string.Concat(src);
    
    /// <summary>
    /// Concatenates an arbitrary number of string representations
    /// </summary>
    /// <param name="src">The strings to be concatenated</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string concat<T>(IEnumerable<T> src) 
        => string.Concat(src);

    /// <summary>
    /// Renders an end-of-line marker
    /// </summary>
    [MethodImpl(Inline)]   
    public static string eol() 
        => AsciEscape.EOL;

    /// <summary>
    /// Concatenates an arbitrary number of string representations,
    /// separated by a specified delimiter
    /// </summary>
    /// <param name="delimiter">The separator</param>
    /// <param name="src">The values for which string representations will
    /// be formed</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string concat<T>(string delimiter, IEnumerable<T> src) 
        => string.Join(delimiter, src.Select(x => x.ToString()));

    /// <summary>
    /// Defines a symbol
    /// </summary>
    /// <param name="name">The name of the symbol</param>
    /// <param name="description">Formal or informal description depending on context/needs</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Symbol symbol(string name, string description = null)
        => new Symbol(name,description);


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
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string format<X1,X2>((X1 x1, X2 x2) x)
        => $"({x.x1}, {x.x2})";

    /// <summary>
    /// Encloses text content between left and right braces
    /// </summary>
    /// <param name="content">The content to be embraced</param>
    /// <returns></returns>
    public static string embrace(object content)      
        => $"{AsciSym.Lbrace}{content}{AsciSym.Rbrace}";


    /// <summary>
    /// Left-Pads the input string with an optionally-specified character.
    /// </summary>
    /// <param name="src">The input text</param>
    /// <param name="width">The with of the padded string</param>
    /// <param name="c">The padding character, if specifed; otherwise, a space is used as the filler</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string lpad(string src, int width, char? c = null)
        => src.PadLeft(width,c ?? ' ');

    /// <summary>
    /// Left-Pads the input string with zeros
    /// </summary>
    /// <param name="src">The input text</param>
    /// <param name="width">The with of the padded string</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string lpadZ(string src, int width)
        => src.PadLeft(width,'0');

    /// <summary>
    /// Right-Pads the input string with an optionally-specified character.
    /// </summary>
    /// <param name="src">The input text</param>
    /// <param name="width">The with of the padded string</param>
    /// <param name="c">The padding character, if specifed; otherwise, a space is used as the filler</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string rpad(string src, int width, char? c = null)
        => src.PadRight(width,c ?? ' ');

    /// <summary>
    /// Right-Pads the input string with zeros
    /// </summary>
    /// <param name="src">The input text</param>
    /// <param name="width">The with of the padded string</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string rpadZ(string src, int width)
        => src.PadRight(width,'0');

    /// <summary>
    /// Renders the supplied value to the console followed by a carriage return
    /// </summary>
    /// <param name="x">The value to reveal</param>
    [MethodImpl(Inline)]   
    public static void print<T>(T x)
        => Console.WriteLine(x);

    /// <summary>
    /// Renders the supplied value to the console with no carriage return
    /// </summary>
    /// <param name="x"></param>
    /// <typeparam name="T"></typeparam>
    [MethodImpl(Inline)]   
    public static void write<T>(T x)
        => Console.Write(x);

    /// <summary>
    /// Writes an empty line to the console
    /// </summary>
    /// <param name="x">The value to reveal</param>
    [MethodImpl(Inline)]   
    public static void print()
        => Console.WriteLine();

    /// <summary>
    /// Invokes the print operation for each item in the sequence
    /// </summary>
    /// <param name="x">The value to reveal</param>
    [MethodImpl(Inline)]   
    public static void printeach<T>(IEnumerable<T> items)
        => iter(items, print) ;

    /// <summary>
    /// Invokes the print operation for each item in the sequence
    /// </summary>
    /// <param name="x">The value to reveal</param>
    [MethodImpl(Inline)]   
    public static void printeach<T>(string msg, IEnumerable<T> items)
    {
        print(msg);
        printeach(items);
    }
     
    /// <summary>
    /// Invokes the print operation for each item in the sequence
    /// </summary>
    /// <param name="x">The value to reveal</param>
    [MethodImpl(Inline)]   
    public static void print<T>(string msg, IEnumerable<T> items)
    {
        var text = concat(string.Join(',',items));
        print($"{msg}: {text}");       
    }


    public static void colorize(ConsoleColor color, Action action)
    {
        var fg = Console.ForegroundColor;
        Console.ForegroundColor = color;
        action();
        Console.ForegroundColor = fg;
    }

    /// <summary>
    /// Emits an information-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="member">The calling member</param>
    public static void inform(object msg, [CallerMemberName] string member = null)
        => colorize(ConsoleColor.Green, () => print($"{member}: {msg}"));

    /// <summary>
    /// Emits an error-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="member">The calling member</param>
    public static void error(object msg, [CallerMemberName] string member = null)
        => colorize(ConsoleColor.Red, () => print($"{member}: {msg}"));

    static readonly ConcurrentDictionary<string, Regex> _regexCache
        = new ConcurrentDictionary<string, Regex>();

    static readonly NumberStyles NumberStyleOptions =
        NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign |
        NumberStyles.AllowCurrencySymbol | NumberStyles.AllowThousands;

    static readonly HashSet<string> TrueValues
        = new HashSet<string>(new[] { "true", "t", "1", "y", "+" });

    static readonly HashSet<string> FalseValues
        = new HashSet<string>(new[] { "false", "f", "0", "n", "-" });

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

    /// <summary>
    /// Produces the empty string
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string emptys()
        => string.Empty;

    /// <summary>
    /// Produces a left parenthesis character
    /// </summary>
    /// <returns></returns>
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
        => ";";

    /// <summary>
    /// Produces a "." character
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string dot()
        => ".";

    /// <summary>
    /// Produces a colon character
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string colon()
        => ":";
    /// <summary>
    /// Conditionally emits the value of a command flag predicated on the evaluation of a given value
    /// </summary>
    /// <param name="value">The value to evaluate</param>
    /// <param name="flag">The text to emit when the value is evaluated to true</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string cmdFlag(bool value, string flag, string arg = null)
        => not(value) ? emptys() : flag + arg ?? emptys();

    /// <summary>
    /// Conditionally emits the value of a command flag predicated on the evaluation of a given value
    /// </summary>
    /// <param name="value">The value to evaluate</param>
    /// <param name="flag">The text to emit when the value is evaluated to true</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string cmdFlag(string value, string flag, string arg = null)
        => isBlank(value) ? emptys() : flag + arg ?? emptys();

    /// <summary>
    /// Conditionally emits the value of a command option predicated on its nullity
    /// </summary>
    /// <param name="value">The value to evaluate</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string cmdOption(object value)
        => show(value);

    /// <summary>
    /// Appends the tail to the head
    /// </summary>
    /// <param name="head">The first part of the string</param>
    /// <param name="tail">The last part of the string</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string append(string head, string tail)
        => isBlank(head) ? tail : head + tail;

    /// <summary>
    /// Conditionally appends the tail to the head
    /// </summary>
    /// <param name="head">The first part of the string</param>
    /// <param name="tail">The last part of the string</param>
    /// <param name="onlyIfMissing">Indicated whether the head should be suffixed with the tail only if the head
    /// does not end with the tail</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string append(string head, string tail, bool onlyIfMissing)
        => onlyIfMissing
        ? (head.EndsWith(tail) ? head : append(head, tail))
        : append(head, tail);

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
    /// Shorthand for the <see cref="string.IsNullOrEmpty(string)"/> method
    /// </summary>
    /// <param name="subject">The string to evaluate</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static bool isBlank(string subject)
        => String.IsNullOrWhiteSpace(subject);

    /// <summary>
    /// Shorthand for the negation of the <see cref="string.IsNullOrEmpty(string)"/> method
    /// </summary>
    /// <param name="subject">The string to evaluate</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static bool isNotBlank(string subject)
        => not(isBlank(subject));

    /// <summary>
    /// Determines whether a string 2-tuple consists of only the empty string
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static bool isNotBlank((string s1, string s2) s)
        => isNotBlank(s.s1) || isNotBlank(s.s2);

    /// <summary>
    /// A string-specific coalescing operation
    /// </summary>
    /// <param name="subject">The subject string</param>
    /// <param name="replace">The replacement value if blank</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string ifBlank(string subject, string replace)
        => isBlank(subject) ? replace : subject;

    /// <summary>
    /// Replacement returned if the input is not blank
    /// </summary>
    /// <param name="subject">The subject string</param>
    /// <param name="replace">The replacement value if input is not blank</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string ifNotBlank(string subject, string replace)
        => isNotBlank(subject) ? replace : subject;

    /// <summary>
    /// Appends the tail to the head, separating the two by a new line
    /// </summary>
    /// <param name="head">The first part of the string</param>
    /// <param name="tail">The last part of the string</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string appendl(string head, string tail)
        => head + Environment.NewLine + tail;

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
    /// <returns></returns>
    [MethodImpl(Inline)]
    static string toString(string subject, string ifBlank = null)
        => isNotBlank(subject) ? subject : ifBlank ?? String.Empty;

    /// <summary>
    /// If subject is not null, invokes its ToString() method; otherwise, returns an empty string or a supplied marker
    /// </summary>
    /// <typeparam name="T">The subject type</typeparam>
    /// <param name="subject">The subject</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string show<T>(T subject, string ifMissing)
        => (subject is string)
            ? toString(subject as string, ifMissing)
            : (subject != null ? subject.ToString() : ifMissing ?? emptys());

    /// <summary>
    /// If subject is not null, invokes its ToString() method; otherwise, returns an empty string or a supplied marker
    /// </summary>
    /// <typeparam name="T">The subject type</typeparam>
    /// <param name="subject">The subject</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string show<T>(T subject)
        => (subject is string)
            ? toString(subject as string, emptys())
            : (subject != null ? subject.ToString() : emptys());

    /// <summary>
    /// If subject is not null, invokes its ToString() method; otherwise, returns an empty string or a supplied marker
    /// </summary>
    /// <typeparam name="T">The subject type</typeparam>
    /// <param name="subject">The subject</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string toString<T>(T subject, string ifMissing = null)
        => (subject is string)
            ? toString(subject as string, ifMissing)
            : (subject != null ? subject.ToString() : ifMissing ?? String.Empty);

    /// <summary>
    /// Functional equivalalent of <see cref="string.Join(string, object[])"/>
    /// </summary>
    /// <param name="values">The values to be rendered as text</param>
    /// <param name="sep">The item delimiter</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string join<T>(string sep, IEnumerable<T> values)
        => string.Join(sep, values);

    // public static string concat(IEnumerable<object> items, string separator = ",")
    //     => string.Join(separator, items);

    /// <summary>
    /// Does what you would expect when supplying a sequence of characters to a 
    /// concatenation function (!)
    /// </summary>
    /// <param name="chars">The characters to concatenate</param>
    /// <returns></returns>
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

    
    /// <summary>
    /// Encloses the supplied text in quotation marks
    /// </summary>
    /// <param name="text">The text to be quoted</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string enquote(string text)
        => "\"" + text + "\"";

    /// <summary>
    /// Encloses text within a bounding string
    /// </summary>
    /// <param name="text">The text to enclose</param>
    /// <param name="boundary">The surrounding text</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string enclose(string text, string boundary)
        => boundary + text + boundary;

    /// <summary>
    /// Encloses a character within uniform left/right bounding string
    /// </summary>
    /// <param name="c">The character to enclose</param>
    /// <param name="boundary">The surrounding text</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string enclose(char c, string boundary)
        => $"{boundary}{c}{boundary}";

    /// <summary>
    /// Encloses text within (possibly distinct) left and right boundaries
    /// </summary>
    /// <param name="text">The text to be bounded</param>
    /// <param name="left">The text on the left</param>
    /// <param name="right">The text on the right</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string enclose(string text, string left, string right)
        => left + text + right;

    /// <summary>
    /// Encloses text within (possibly distinct) left and right boundaries
    /// </summary>
    /// <param name="text">The text to be bounded</param>
    /// <param name="left">The character on the left</param>
    /// <param name="right">The character on the right</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string enclose(string text, char left, char right)
        => $"{left}{text}{right}";

    /// <summary>
    /// Encloses a character within (possibly distinct) left and right boundaries
    /// </summary>
    /// <param name="c">The character to be bounded</param>
    /// <param name="left">The text on the left</param>
    /// <param name="right">The text on the right</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string enclose(char c, string left, string right)
        => $"{left}{c}{right}";

    /// <summary>
    /// Encloses content within specified boundaries
    /// </summary>
    /// <param name="content">The fenced contant</param>
    /// <param name="left">The text on the left</param>
    /// <param name="right">The text on the right</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string wrap(object left, object content, object right)
        => $"{show(left)}{show(content)}{show(right)}";

    /// <summary>
    /// Encloses text between single quote (') characters
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string squote(string text)
        => enclose(text, "'");

    /// <summary>
    /// Encloses a character between single quote (') characters
    /// </summary>
    /// <param name="c"></param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string squote(char c)
        => enclose(c, "'");

    /// <summary>
    /// Encloses text between '(' and ')' characters
    /// </summary>
    /// <param name="content"></param>
    [MethodImpl(Inline)]
    public static string paren(params object[] content)
        => enclose(concat(content), lparen(), rparen());

    /// <summary>
    /// Renders a content array as a comma-separated list of values
    /// </summary>
    /// <param name="content"></param>
    [MethodImpl(Inline)]
    public static string csv(object o1, object o2, params object[] content)
        =>  string.Join(',', o1, o2) + string.Join(',', content);

    /// <summary>
    /// Renders a sequence of items as a comma-separated list of values
    /// </summary>
    /// <param name="content"></param>
    [MethodImpl(Inline)]
    public static string csv(IEnumerable<object> content)
        => string.Join(',', content);

    /// <summary>
    /// Renders a sequence of items as a comma-separated list of values
    /// </summary>
    /// <param name="content"></param>
    [MethodImpl(Inline)]
    public static string csv<T>(IEnumerable<T> content)
        => string.Join(',', content);

    /// <summary>
    /// Renders each item from a sequence as list of values, delimited by end-of-line
    /// </summary>
    /// <param name="content">The source items</param>
    [MethodImpl(Inline)]
    public static string eol(IEnumerable<object> content)
        => string.Join(eol(), content);

    /// <summary>
    /// Renders a content array as a space-separated list of values
    /// </summary>
    /// <param name="content"></param>
    [MethodImpl(Inline)]
    public static string space(params object[] content)
        => string.Join(' ', content);

    
    /// <summary>
    /// Encloses text between '[' and ']' characters
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string bracket(string content)
        => enclose(content, lbracket(), rbracket());

    /// <summary>
    /// Encloses text between '{' and '}' characters
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string embrace(string content)
        => wrap(lbrace(), content, rbrace());

    /// <summary>
    /// Encloses text between less than and greater than characters
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string angled(string content)
        => wrap("<", content, ">");

    /// <summary>
    /// Produces a string containing a specified number of tab characters
    /// </summary>
    /// <param name="count">The number of tab characters the output string should contain</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string tabs(int count)
        => count == 0
        ? emptys()
        : new string('\t', count);

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
        => concat(tabs(count), content);

    /// <summary>
    /// Produces a string containing a specified number of spaces
    /// </summary>
    /// <param name="count">The number of spaces the output string should contain</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string spaces(int count)
        => count == 0 ? emptys() : new string(' ', count);

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
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string spaced(IEnumerable<object> items)
        => join(space(), items);

    /// <summary>
    /// Removes a substring from the subject
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string remove(string text, string substring)
        => text.Replace(substring, String.Empty);

    /// <summary>
    /// Encloses the potential text in quotation marks
    /// </summary>
    /// <param name="text">The text to be quoted</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string enquote(Option<string> text)
        => enquote(text ? text.ValueOrDefault() ?? String.Empty : String.Empty);


    /// <summary>
    /// Trims leading characters when matched
    /// </summary>
    /// <param name="text">The text to manipulate</param>
    /// <param name="chars">The leading characters to remove</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string ltrim(string text, params char[] chars)
        => isBlank(text) ? string.Empty : text.TrimStart(chars);

    /// <summary>
    /// Trims trailing characters when matched
    /// </summary>
    /// <param name="text">The text to manipulate</param>
    /// <param name="chars">The leading characters to remove</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string rtrim(string text, params char[] chars)
        => isBlank(text) ? string.Empty : text.TrimEnd(chars);

    /// <summary>
    /// Splits the string into delimited and nonempy parts
    /// </summary>
    /// <param name="text">The text to split</param>
    /// <param name="c">The delimiter</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static IReadOnlyList<string> split(string text, char c)
        => isBlank(text)
        ? array<string>()
        : text.Split(new char[] { c }, StringSplitOptions.RemoveEmptyEntries);

    /// <summary>
    /// Returns the substring [0,chars-1]
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string left(string text, int chars)
        => isBlank(text)
        ? text
        : text.Substring(0, text.Length < chars ? text.Length : chars);

    /// <summary>
    /// Returns the substring [0,chars-1]
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string reverse(string text)
    {
        if (isBlank(text))
            return text;

        var dst = new char[text.Length];
        int j = 0;
        for (var i = text.Length - 1; i >= 0; i--)
            dst[j++] = text[i];
        return new string(dst);
    }

    [MethodImpl(Inline)]
    public static string right(string text, int chars)
    {
        if (isBlank(text))
            return text;

        var len = text.Length < chars ? text.Length : chars;
        var dst = new char[len];
        for (var i = 0; i < len; i++)
            dst[i] = text[text.Length - len + i];
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
    /// Computes the lenth of the string
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int len(string s)
        => s.Length;

    public static string trim(string s)
        => s?.Trim() ?? string.Empty;


    /// <summary>
    /// Helper to parse a boolean value in a more reasonable fashion than the intrinsic <see cref="bool.Parse(string)"/> method
    /// </summary>
    /// <param name="s">The text to parse</param>
    /// <returns></returns>
    static bool ParseBool(string s)
    {
        var key = s.ToLower();
        if (TrueValues.Contains(key))
            return true;
        else if (FalseValues.Contains(key))
            return false;
        else
            throw new ArgumentException($"Could not interpret {s} as a boolean value");
    }

    /// <summary>
    /// Parses an <see cref="Int32"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="s">The text to parse</param>
    /// <returns></returns>
    static int? TryParseInt32(string s)
    {
        if (Int32.TryParse(s, out int result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses an <see cref="Int64"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="s">The text to parse</param>
    /// <returns></returns>
    static long? TryParseInt64(string s)
    {
        if (Int64.TryParse(s, out long result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="Byte"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="s">The text to parse</param>
    /// <returns></returns>
    static byte? TryParseUInt8(string s)
    {
        var result = (byte)0;
        if (Byte.TryParse(s, out result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="Date"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="s">The text to parse</param>
    /// <returns></returns>
    static Date? TryParseDate(string s)
    {
        if (Date.TryParse(s, out Date result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="DateTime"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="s">The text to parse</param>
    /// <returns></returns>
    static DateTime? TryParseDateTime(string s)
    {
        if (DateTime.TryParse(s, out DateTime result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="Guid"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="s">The text to parse</param>
    /// <returns></returns>
    static Guid? TryParseGuid(string s)
    {
        if (Guid.TryParse(s, out Guid result))
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
    /// <returns></returns>
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
    /// <returns></returns>
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
    /// <returns></returns>
    static decimal? TryParseDecimal(string s)
    {
        if (decimal.TryParse(s, NumberStyleOptions, CultureInfo.InvariantCulture, out decimal result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Retrieves the value of the identified field
    /// </summary>
    /// <typeparam name="T">The value type</typeparam>
    /// <param name="o">The object on which the field is defined</param>
    /// <param name="fieldName">The name of the field</param>
    /// <returns></returns>
    static T GetDeclaredFieldValue<T>(object o, string fieldName)
    {
        var f = o.GetType().GetField(fieldName, BF_DeclaredInstance);
        return (T)(f != null ? f.GetValue(o) : null);
    }

    /// <summary>
    /// Determines whether the supplied value conforms to the pattern encoded by a regular expression
    /// </summary>
    /// <param name="value">The test value</param>
    /// <param name="regex">The regular expression</param>
    /// <returns></returns>
    [DebuggerStepThrough]
    public static Option<string> validate(string value, Regex regex, Action<string> error = null)
    {
        if (not(regex.Match(value).Success))
        {
            error?.Invoke($"The value '{value}' did not satisfy the expression {GetDeclaredFieldValue<string>(regex,"pattern")}");
            return none<string>();
        }
        else
            return value;
    }

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
    /// <returns></returns>
    public static T parse<T>(string s)
        => ifNotNull(s, _ => (T)parsers[typeof(T)](s), () => default(T));

    /// <summary>
    /// Attempts to parse the supplied value
    /// </summary>
    /// <typeparam name="T">The target type</typeparam>
    /// <param name="s">The value to parse</param>
    /// <returns></returns>
    public static Option<T> try_parse<T>(string s, Action<Exception> error = null)
    {
        try
        {
            return ifNotNull(s, _ => (T)parsers[typeof(T)](s), () => none<T>());
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
    /// <returns></returns>
    public static Option<object> try_parse(Type t, string s, Action<Exception> error = null)
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
    /// <returns></returns>
    public static T parse<T>(IReadOnlyList<(string name, string value)> values)
        where T : new()
    {
        var element = new T();
        var properties = props(element).ToDictionary(x => x.Name);
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
    /// <returns></returns>
    public static IReadOnlyList<T> parse<T>(IEnumerable<IReadOnlyList<(string name, string value)>> values)
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
    /// <returns></returns>
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
    /// <returns></returns>
    public static T parseEnum<T>(string value)
        => (T)Enum.Parse(typeof(T), value, true);
}
