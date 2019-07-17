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

using Z0;

partial class zfunc
{
    [MethodImpl(Inline)]   
    public static Stopwatch stopwatch(bool start = true) 
        => start ? Stopwatch.StartNew() : new Stopwatch();

    [MethodImpl(Inline)]   
    public static long elapsed(Stopwatch sw) 
        => sw.ElapsedTicks;

    [MethodImpl(Inline)]   
    public static Duration snapshot(Stopwatch sw)     
        => Duration.Define(sw.ElapsedTicks);        

    static readonly long TicksPerMs 
        = Stopwatch.Frequency/1000L;
    
    [MethodImpl(Inline)]
    public static long ticksToMs(long ticks)
        => ticks/TicksPerMs;

    public static DateTime now()
        => DateTime.Now;

    public static Date today()
        => DateTime.Today;

    /// <summary>
    /// Measures the respective times required to execute a pair of functions,
    /// each of which iterate a computational block a specified number of times
    /// </summary>
    /// <param name="n">The number of computational block iterations</param>
    /// <param name="left">The first function</param>
    /// <param name="right">THe second function</param>
    public static OpTimePair measure(long n, string leftLabel, string rightLabel, Action<long> left, Action<long> right)
    {
        var lTimer = stopwatch();
        left(n);
        var lTime = OpTime.Define(leftLabel, n, snapshot(lTimer));
        var rTimer = stopwatch();
        right(n);
        var rTime = OpTime.Define(rightLabel, n, snapshot(rTimer));
        OpTimePair result = (lTime, rTime);
        return result;
    }


}