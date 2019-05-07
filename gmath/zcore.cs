//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;
using static zfunc;

static partial class zcore
{
    public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;



    [MethodImpl(Inline)]   
    public static IEnumerable<T> items<T>(params T[] src)
        => src;


    [MethodImpl(Inline)]   
    public static T[] alloc<T>(int len)
        => new T[len];

    [MethodImpl(Inline)]   
    public static T[] array<T>(params T[] src)
        => src;

    static Exception lengthMismatch(int lhs, int rhs)
        => throw new Exception($"Length mismatch, {lhs} != {rhs}");

    static Exception countMismatch(int lhs, int rhs)
        => throw new Exception($"Count mismatch, {lhs} != {rhs}");


    [MethodImpl(Inline)]   
    public static int length<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);


    [MethodImpl(Inline)]   
    public static int length<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
        where T : struct, IEquatable<T>
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);


    [MethodImpl(Inline)]   
    public static int length<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
        where T : struct, IEquatable<T>
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);


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
    /// Emits a warning-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void warn(object msg, [CallerMemberName] string caller = null)
        => terminal.WriteMessage(
                AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Warning, caller));

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


    [MethodImpl(Inline)]   
    public static string name<T>(bool full = false)
        => typeof(T).DisplayName();
    

    /// <summary>
    /// Explicitly casts a source value to value of the indicated type, raising
    /// an exception if operation fails
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T cast<T>(object src) 
        => (T) src;


    /// <summary>
    /// Demands truth that is enforced with an exeption upon false
    /// </summary>
    /// <param name="x">The value to test</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static bool demand(bool x, string message = null)
        => x ? x : throw new Exception(message ?? "demand failed");

    /// <summary>
    /// Constructs a value if boolean predondition is true; otherwise, raises an exception
    /// </summary>
    /// <param name="condition">The condition to test</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static T demand<T>(bool condition, string msg = null)
        where T : new()
        => condition ? new T() : throw new Exception(msg ?? $"Precondition for construction of {type<T>().Name} unmet");    

}