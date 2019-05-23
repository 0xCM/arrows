//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;
using System.Diagnostics;
using System.Numerics;

using Z0;
using static zfunc;

public static partial class mfunc
{
    internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    
    internal const MethodImplOptions NotInline = MethodImplOptions.NoInlining;

    internal const MethodImplOptions Optimize = MethodImplOptions.AggressiveOptimization;

    public static IEnumerable<T> items<T>(ValueTuple<T,T> tuple)
        => zfunc.items(tuple.Item1, tuple.Item2);

    public static TimedPair measure(Action left, Action right, int reps)
    {
        var i = 0;        
        var sw = stopwatch(false);
        
        sw.Restart();
        while(i++ < reps)    
            left();
        
        var leftTime = snapshot(sw);

        i = 0;
        sw.Restart();        
        while(i++ < reps)    
            left();
        var rightTime = snapshot(sw);

        return (leftTime,rightTime);            
    }

    [MethodImpl(Inline)]
    public static void assert(bool condition, string msg = null, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
    {
        if(!condition)
            throw new Exception($"{caller} {file} line{line}: {msg ?? "Assertion Failed" }" );
    }
         
    [MethodImpl(Inline)]
    public static Memory<T> memory<T>(ReadOnlyMemory<T> src)
            => MemoryMarshal.AsMemory(src);

    /// <summary>
    /// Returns true if a value is the NaN representative
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]
    public static bool isNaN(float src)
        => float.IsNaN(src);

    /// <summary>
    /// Returns true if one of the supplied values is the NaN representative
    /// </summary>
    /// <param name="x0">The first source value</param>
    /// <param name="x1">The second source value</param>
    /// <param name="x2">The third source value</param>
    /// <param name="x3">The fourth source value</param>
    [MethodImpl(Inline)]
    public static bool anyNaN(float x0, float x1, float x2, float x3)
        => isNaN(x0) || isNaN(x1) || isNaN(x2) || isNaN(x3);

    /// <summary>
    /// Returns true if a value is the NaN representative
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]
    public static bool isNaN(double src)
        => double.IsNaN(src);

    /// <summary>
    /// Returns true if one of the supplied values is the NaN representative
    /// </summary>
    /// <param name="x0">The first source value</param>
    /// <param name="x1">The second source value</param>
    [MethodImpl(Inline)]
    public static bool anyNan(double x0, double x1)
        => isNaN(x0) || isNaN(x1);

    /// <summary>
    /// Replaces a NaN representive value with 0
    /// </summary>
    /// <param name="src">The source value to sanitize</param>
    [MethodImpl(Inline)]
    public static double clearNaN(double x, double replacement = -1)
        => isNaN(x) ? replacement : x;

    /// <summary>
    /// Replaces a NaN representive value with 0
    /// </summary>
    /// <param name="src">The source value to sanitize</param>
    [MethodImpl(Inline)]
    public static float clearNaN(float x, float replacement = -1)
        => isNaN(x) ? replacement : x;

    /// <summary>
    /// Demands truth that is enforced with an exeption upon false
    /// </summary>
    /// <param name="x">The value to test</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static bool demand(bool x, string message = null)
        => x ? x : throw new Exception(message ?? "demand failed");


}