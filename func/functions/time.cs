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

}