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
    /// Prints a separator between items an emits and EOL after the last item
    /// </summary>
    /// <param name="items">The items to render</param>
    /// <param name="sep">The separator</param>
    /// <typeparam name="T">The item type</typeparam>
    [MethodImpl(Inline)]   
    public static void printline<T>(IEnumerable<T> items, string sep = ",")
    {
        var written = false;
        foreach(var item in items)
        {
            if(!written)
                written = true;
            else
                write(sep);

            write($"{item}");
        }
        if(!written)
            write(emptyset());            
        print();
    }

    [MethodImpl(Inline)]   
    public static void printline<T>(string title, IEnumerable<T> items, string sep = ",")
    {
        write($"{title} = ");
    
        printline(items,sep);      
    }

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
        var text = append(string.Join(',',items));
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
    /// Emits a highlighted information-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="member">The calling member</param>
    public static void hilite(object msg, [CallerMemberName] string member = null)
        => colorize(ConsoleColor.Blue, () => print($"{member}: {msg}"));

    /// <summary>
    /// Emits a verbose-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="member">The calling member</param>
    public static void babble(object msg, [CallerMemberName] string member = null)
        => colorize(ConsoleColor.DarkGray, () => print($"{member}: {msg}"));

    /// <summary>
    /// Emits an error-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="member">The calling member</param>
    public static void error(object msg, [CallerMemberName] string member = null)
        => colorize(ConsoleColor.Red, () => print($"{member}: {msg}"));
}