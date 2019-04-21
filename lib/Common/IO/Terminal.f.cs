//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;
using static Z0.Bibliography;
using static zcore;
using static Z0.Traits;
using static Z0.ReflectionFlags;

partial class zcore
{

    static readonly Terminal terminal = Terminal.Get();

    /// <summary>
    /// Renders the supplied value to the console with no carriage return
    /// </summary>
    /// <param name="x"></param>
    [MethodImpl(Inline)]   
    public static void write(object x)
        => terminal.Write(x);


    /// <summary>
    /// Writes a single messages to the terminal
    /// </summary>
    /// <param name="msg">The message to print</param>    
    public static void print(AppMsg msg)
        => terminal.WriteMessage(msg);

    /// <summary>
    /// Renders terminal content at a specified severiy level
    /// </summary>
    /// <param name="content">The content to print</param>    
    /// <param name="level">The severity level of the message</param>    
    public static void print(object content, SeverityLevel level)
        => terminal.WriteLine(content, level);

    /// <summary>
    /// Prints a sequence of messages in an unbroken block
    /// </summary>
    /// <param name="messages">The messages to print</param>    
    public static void print(IEnumerable<AppMsg> messages)
        => terminal.WriteMessages(messages);

    /// <summary>
    /// Reads a line of text from the terminal
    /// </summary>
    public static string read()
        => terminal.ReadLine();

    /// <summary>
    /// Emits an information-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void inform(object msg, [CallerMemberName] string caller = null)
        => terminal.WriteMessage(
                AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Info, caller));

    /// <summary>
    /// Emits a highlighted information-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void hilite(object msg, SeverityLevel? level = null,  [CallerMemberName] string caller = null)
        => terminal.WriteMessage(
                AppMsg.Define(msg?.ToString() ?? string.Empty, level ?? SeverityLevel.HiliteBL, caller));

    /// <summary>
    /// Emits a verbose-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void babble(object msg, [CallerMemberName] string caller = null)
        => terminal.WriteMessage(
                AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Verbose, caller));

    /// <summary>
    /// Emits a verbose-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="host">The declaring type of the member</param>
    /// <param name="caller">The calling member</param>
    public static void babble<T>(object msg, T host, [CallerMemberName] string caller = null)
        => terminal.WriteMessage(
                AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Verbose, $"{name<T>()}/{caller}"));

    /// <summary>
    /// Emits an error-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void error(object msg, [CallerMemberName] string caller = null)
        => terminal.WriteMessage(
                AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Error, caller));

    /// <summary>
    /// Emits an error-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="host">The declaring type of the member</param>
    /// <param name="caller">The calling member</param>
    public static void error<T>(object msg, T host, [CallerMemberName] string caller = null)
        => terminal.WriteMessage(
                AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Error, $"{name<T>()}/{caller}"));

}