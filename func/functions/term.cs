//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;

using Z0;

partial class zfunc
{
    static readonly Terminal terminal = Terminal.Get();

    /// <summary>
    /// Writes a single messages to the terminal
    /// </summary>
    /// <param name="msg">The message to print</param>    
    public static void print(AppMsg msg)
        => terminal.WriteMessage(msg);

    /// <summary>
    /// Writes a single line to the terminal
    /// </summary>
    /// <param name="msg">The message to print</param>    
    public static void print(string msg)
        => terminal.WriteLine(msg);

    public static void print()
        => terminal.WriteLine();

    /// <summary>
    /// Prints a sequence of messages in an unbroken block
    /// </summary>
    /// <param name="messages">The messages to print</param>    
    public static void print(IEnumerable<AppMsg> messages)
        => terminal.WriteMessages(messages);    

    /// <summary>
    /// Emits a contiguous sequence of concatentated characters
    /// </summary>
    /// <param name="chars">The characters to be printed in a continguous sequence</param>
    public static void print(IEnumerable<char> chars)
        => terminal.WriteLine(new string(chars.TakeSpan()));

    /// <summary>
    /// Emits an information-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void inform(object msg, [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
        => terminal.WriteMessage(
                AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Info, caller, file, line));

    /// <summary>
    /// Renders the supplied value to the console with no carriage return
    /// </summary>
    public static void write(object x)
        => terminal.Write(x);

    /// <summary>
    /// Renders terminal content at a specified severiy level
    /// </summary>
    /// <param name="content">The content to print</param>    
    /// <param name="level">The severity level of the message</param>    
    public static void print(object content, SeverityLevel level)
        => terminal.WriteLine(content, level);

    /// <summary>
    /// Reads a line of text from the terminal
    /// </summary>
    public static string read()
        => terminal.ReadLine();

    /// <summary>
    /// Reads a character from the terminal
    /// </summary>
    public static char readKey(string msg = null)
        => terminal.ReadKey(msg != null ? appMsg(msg, SeverityLevel.HiliteCL) : null);

    /// <summary>
    /// Reads a line of text from the terminal after printing a supplied message
    /// </summary>
    public static string read(string msg = null)
        => terminal.ReadLine(msg != null ? appMsg(msg, SeverityLevel.HiliteCL) : null);

    /// <summary>
    /// Emits a warning-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void warn(object msg, [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
        => terminal.WriteMessage(AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Warning, caller, file, line));

    /// <summary>
    /// Emits a highlighted information-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void hilite(object msg, SeverityLevel? level = null,  [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
        => terminal.WriteMessage(AppMsg.Define(msg?.ToString() ?? string.Empty, level ?? SeverityLevel.HiliteBL, caller, file, line));

    /// <summary>
    /// Emits an information-level message with a magenta foreground
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void magenta(string title, object msg)
        => terminal.WriteMessage(AppMsg.Define( $"{title}: " + msg?.ToString() ?? string.Empty, SeverityLevel.HiliteML));

    /// <summary>
    /// Emits an information-level message with a magenta foreground
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void magenta(object msg)
        => terminal.WriteMessage(AppMsg.Define( msg?.ToString() ?? string.Empty, SeverityLevel.HiliteML));


    /// <summary>
    /// Emits an information-level message with a cyan foreground
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void cyan(string title, object msg)
        => terminal.WriteMessage(AppMsg.Define(  $"{title}: " + msg?.ToString() ?? string.Empty, SeverityLevel.HiliteCL));

    /// <summary>
    /// Emits an information-level message with a cyan foreground
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void cyan(object msg)
        => terminal.WriteMessage(AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.HiliteCL));

    /// <summary>
    /// Emits a verbose-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void babble(object msg, [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
        => terminal.WriteMessage(AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Babble, caller, file, line));

    /// <summary>
    /// Emits a verbose-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="host">The declaring type of the member</param>
    /// <param name="caller">The calling member</param>
    public static void babble<T>(object msg, T host, [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
        => terminal.WriteMessage(AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Babble, $"{name<T>()}/{caller}", file, line));

    /// <summary>
    /// Emits an error-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void error(object msg, [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
        => terminal.WriteError(AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Error, caller, file, line));

    /// <summary>
    /// Emits an error-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="host">The declaring type of the member</param>
    /// <param name="caller">The calling member</param>
    public static void error<T>(object msg, T host, [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
        => terminal.WriteError(AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Error, $"{name<T>()}/{caller}", file, line));

    public static AppMsg trace(string title, string msg, int? tpad = null, SeverityLevel? severity = null)
    {
        var titleFmt = tpad.Map(pad => title.PadRight(pad), () => title.PadRight(20));        
        var appMsg = AppMsg.Define($"{titleFmt}: {msg}", severity ?? SeverityLevel.Babble);        
        print(appMsg);
        return appMsg;
    }

    public static AppMsg trace<T>(NamedValue<T> nv, int? npad = null, SeverityLevel? severity = null)
        => trace(nv.Name, $"{nv.Value}", npad, severity);

    public static AppMsg trace<T>(Expression<Func<T>> fx, int? npad = null, SeverityLevel? severity = null)
        => trace(fx.Evaluate(), npad, severity);

    public static AppMsg trace(OpTimePair timing, int? labelPad = null)
    {
        var msg = appMsg(timing.Format(labelPad), SeverityLevel.Benchmark);
        print(msg);
        return msg;            
    }

    public static AppMsg TracePerf(OpTime timing, int? labelPad = null)
    {
        var msg = appMsg(timing.Format(labelPad), SeverityLevel.Benchmark);
        print(msg);
        return msg;
    }

}