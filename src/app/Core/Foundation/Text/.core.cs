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

using Core;
using static Core.Credit;
using static corefunc;
using static Core.Traits;


public static partial class corefunc
{

    
    /// <summary>
    /// Concatenates an arbitrary number of strings
    /// </summary>
    /// <param name="src">The strings to be concatenated</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string concat(params string[] src) => string.Concat(src);
    
    /// <summary>
    /// Concatenates an arbitrary number of string representations
    /// </summary>
    /// <param name="src">The strings to be concatenated</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string concat<T>(IEnumerable<T> src) 
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


}