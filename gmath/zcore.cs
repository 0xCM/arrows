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
static class zcore
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
    public static Stopwatch stopwatch() 
        => Stopwatch.StartNew();

    [MethodImpl(Inline)]   
    public static long elapsed(Stopwatch sw) 
        => sw.ElapsedTicks;

    [MethodImpl(Inline)]   
    public static T[] alloc<T>(int len)
        => new T[len];

    [MethodImpl(Inline)]   
    public static T[] array<T>(params T[] src)
        => src;

    [MethodImpl(Inline)]   
    public static int length<T>(T[] lhs, T[] rhs)
    {
        var lx = lhs.Length;
        var ly = rhs.Length;
        if(lx != ly)
            throw new Exception($"The lengths of the input arrays do not match: {lx} != {ly}");
        return lx;
    }


    [MethodImpl(Inline)]   
    public static int length<T>(Index<T> lhs, Index<T> rhs)
    {
        var lx = lhs.Length;
        var ly = rhs.Length;
        if(lx != ly)
            throw new Exception($"The lengths of the input arrays do not match: {lx} != {ly}");
        return lx;
    }

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


    [MethodImpl(Inline)]
    public static bool not(bool x)
        => !x;

    /// <summary>
    /// Concatenates an arbitrary number of strings
    /// </summary>
    /// <param name="src">The strings to be concatenated</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string append(params string[] src) 
        => string.Concat(src);
    
    /// <summary>
    /// Concatenates an arbitrary number of string representations
    /// </summary>
    /// <param name="src">The strings to be concatenated</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string append<T>(IEnumerable<T> src) 
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
    public static string append<T>(string delimiter, IEnumerable<T> src) 
        => string.Join(delimiter, src.Select(x => x.ToString()));

    static readonly long TicksPerMs 
        = Stopwatch.Frequency/1000L;
    
    [MethodImpl(Inline)]
    public static long ticksToMs(long ticks)
        => ticks/TicksPerMs;


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

    /// <summary>
    /// Returns the name of the supplied type
    /// </summary>
    /// <param name="full">Whether the full name should be returned</param>
    /// <typeparam name="T">The type to examine</typeparam>
    [MethodImpl(Inline)]   
    public static string typename<T>(bool full = false)
        => full ? typeof(T).FullName : typeof(T).Name;

    [MethodImpl(Inline)]   
    public static string name<T>(bool full = false)
        => typeof(T).DisplayName();
    
    /// <summary>
    /// Returns the System.Type of the supplied parametric type
    /// </summary>
    /// <typeparam name="T">The source type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static Type type<T>() 
        => typeof(T);


    /// <summary>
    /// Aplies an action to the sequence of integers min,min+1,...,max - 1
    /// </summary>
    /// <param name="min">The inclusive lower bound of the sequence</param>
    /// <param name="max">The non-inclusive upper bound of the sequence
    /// over intergers over which iteration will occur</param>
    /// <param name="f">The action to be applied to each  value</param>
    [MethodImpl(Inline)]
    public static void iter(int min, int max, Action<int> f)
    {
       for(var i = min; i< max; i++) 
            f(i);
    }

    /// <summary>
    /// Aplies an action to the sequence of integers min,min+1,...,max - 1
    /// </summary>
    /// <param name="min">The inclusive lower bound of the sequence</param>
    /// <param name="max">The non-inclusive upper bound of the sequence
    /// over intergers over which iteration will occur</param>
    /// <param name="f">The action to be applied to each  value</param>
    [MethodImpl(Inline)]
    public static void iter(long min, long max, Action<long> f)
    {
       for(var i = min; i< max; i++) 
            f(i);
    }

    /// <summary>
    /// Applies an action to the increasing sequence of integers 0,1,2,...,count - 1
    /// </summary>
    /// <param name="count">The number of times the action will be invoked
    /// <param name="f">The action to be applied to each value</param>
    [MethodImpl(Inline)]
    public static void iter(int count, Action<int> f)
    {
       for(var i = 0; i< count; i++) 
            f(i);
    }

    /// <summary>
    /// Iterates over the supplied items, invoking a receiver for each
    /// </summary>
    /// <param name="src">The source items</param>
    /// <param name="f">The receiver</param>
    /// <typeparam name="T">The item type</typeparam>
    [MethodImpl(Inline)]   
    public static Unit iter<T>(IEnumerable<T> items, Action<T> action, bool pll = false)
    {
        if (pll)
            items.AsParallel().ForAll(item => action(item));
        else
            foreach (var item in items)
                action(item);
        return Unit.Value;
    }

    [MethodImpl(Inline)]   
    public static T[] map<S,T>(S[] src, Func<S,T> f)
    {
        var dst = alloc<T>(src.Length);
        for(var i = 0; i<src.Length; i++)
            dst[i] = f(src[i]);
        return dst;
    }    

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
    /// Applies a function to elements of an input sequence to produce 
    /// a transformed output sequence
    /// </summary>
    /// <param name="f">The function to be applied</param>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="A">The source value type</typeparam>
    /// <typeparam name="B">The target value type</typeparam>
    /// <returns>The transformed sequence</returns>
    public static IEnumerable<B> mapi<A,B>(Func<int,A,B> f, IEnumerable<A> src)
    {
        var i = 0;
        foreach(var item in src)
            yield return f(i++,item);
    }

    /// <summary>
    /// Applies a function to a value
    /// </summary>
    /// <param name="x">The source value</param>
    /// <param name="f">The function to apply</param>
    /// <typeparam name="X">The source value type</typeparam>
    /// <typeparam name="Y">The output value type</typeparam>
    [MethodImpl(Inline)]   
    public static Y apply<X,Y>(X x,Func<X,Y> f)
        => f(x);

    /// <summary>
    /// Applies a function f:S->T over an input sequence [S] to obtain 
    /// a target sequence [T]
    /// </summary>
    /// <param name="f">The function to be applied</param>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]   
    public static IEnumerable<T> map<S,T>(IEnumerable<S> src, Func<S,T> f)
        => src.Select(x => f(x));


    /// <summary>
    /// Explicitly casts a source value to value of the indicated type, raising
    /// an exception if operation fails
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T cast<T>(object src) 
        => (T) src;

    [MethodImpl(Inline)]   
    public static Duration snapshot(Stopwatch sw)     
        => Duration.Define(sw.ElapsedTicks);        

    public static BenchSummary micromark(string title, OpId op, int cycles, int reps, Repeat repeater)
    {
        var runtime = stopwatch();
        var duration = default(Duration);
        var opcount = 0L;
        for(var cycle = 1; cycle<=cycles; cycle++)
        {
            var sw = stopwatch();
            var cycleDuration = repeater(reps);
            duration += cycleDuration;
            opcount += reps;
            if(cycle % 100 == 0)
                print(BenchmarkMessages.CycleEnd(title, op, cycle, cycleDuration, opcount, duration));
        }  
        return new BenchSummary(title, op, opcount, duration, snapshot(runtime));

    }



}