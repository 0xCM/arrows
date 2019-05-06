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

    /// <summary>
    /// Converts from one value to another, provided the 
    /// required conversion operation is defined; otherwise,
    /// raises an error
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<S,T>(S src)
        where T : struct, IEquatable<T>
        where S : struct, IEquatable<S>
            => ClrConverter.convert<S,T>(src);

    /// <summary>
    /// Vectorized conversion
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    /// <param name="src">The source array</param>
    [MethodImpl(Inline)]   
    public static T[] convert<S,T>(S[] src)
        => ClrConverter.convert<S,T>(src);


    [MethodImpl(Inline)]   
    public static T convert<T>(int src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<int,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(uint src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<uint,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(long src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<long,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(ulong src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<ulong,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(float src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<float,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(double src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<double,T>(src);



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
    public static int length<T>(ReadOnlyMemory<T> lhs, ReadOnlyMemory<T> rhs)
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);

    [MethodImpl(Inline)]   
    public static int length<T>(T[] lhs, T[] rhs)
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);


    [MethodImpl(Inline)]   
    public static int length<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);

    [MethodImpl(Inline)]   
    public static int length<T>(Span<T> lhs, Span<T> rhs)
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);

    [MethodImpl(Inline)]   
    public static int length<T>(Span128<T> lhs, Span128<T> rhs)
        where T : struct, IEquatable<T>
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);

    /// <summary>
    /// Returns the common number of 128-bit blocks in the supplied spans, if possible. Otherwise,
    /// raises an exception
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<T>(Span128<T> lhs, Span128<T> rhs)
        where T : struct, IEquatable<T>
        => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount : throw countMismatch(lhs.BlockCount,rhs.BlockCount);

    /// <summary>
    /// Returns the common number of 256-bit blocks in the supplied spans, if possible. Otherwise,
    /// raises an exception
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<T>(Span256<T> lhs, Span256<T> rhs)
        where T : struct, IEquatable<T>
        => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount : throw countMismatch(lhs.BlockCount,rhs.BlockCount);

    /// <summary>
    /// Returns the common number of 128-bit blocks in the supplied spans, if possible. Otherwise,
    /// raises an exception
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
        where T : struct, IEquatable<T>
        => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount : throw countMismatch(lhs.BlockCount,rhs.BlockCount);

    /// <summary>
    /// Returns the common number of 256-bit blocks in the supplied spans, if possible. Otherwise,
    /// raises an exception
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
        where T : struct, IEquatable<T>
        => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount : throw countMismatch(lhs.BlockCount,rhs.BlockCount);

    [MethodImpl(Inline)]   
    public static int length<T>(Span256<T> lhs, Span256<T> rhs)
        where T : struct, IEquatable<T>
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);

    [MethodImpl(Inline)]   
    public static int length<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
        where T : struct, IEquatable<T>
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);


    [MethodImpl(Inline)]   
    public static int length<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
        where T : struct, IEquatable<T>
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);

    [MethodImpl(Inline)]   
    public static int length<T>(Index<T> lhs, Index<T> rhs)
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);

    /// <summary>
    /// Shorthand for the <see cref="string.IsNullOrEmpty(string)"/> method
    /// </summary>
    /// <param name="subject">The string to evaluate</param>
    [MethodImpl(Inline)]
    public static bool isBlank(string subject)
        => String.IsNullOrWhiteSpace(subject);

    /// <summary>
    /// A string-specific coalescing operation
    /// </summary>
    /// <param name="subject">The subject string</param>
    /// <param name="replace">The replacement value if blank</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string ifBlank(string subject, string replace)
        => isBlank(subject) ? replace : subject;


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