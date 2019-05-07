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
using static mfunc;

static partial class zcore
{
 
    [MethodImpl(Inline)]   
    public static IEnumerable<T> items<T>(params T[] src)
        => src;


    static Exception lengthMismatch(int lhs, int rhs)
        => throw new Exception($"Length mismatch, {lhs} != {rhs}");

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
    /// Writes a single messages to the terminal
    /// </summary>
    /// <param name="msg">The message to print</param>    
    public static void print(AppMsg msg)
        => terminal.WriteMessage(msg);

    /// <summary>
    /// Prints a sequence of messages in an unbroken block
    /// </summary>
    /// <param name="messages">The messages to print</param>    
    public static void print(IEnumerable<AppMsg> messages)
        => terminal.WriteMessages(messages);    


    /// <summary>
    /// Emits an information-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void inform(object msg, [CallerMemberName] string caller = null)
        => terminal.WriteMessage(
                AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Info, caller));

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
}