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

static class zcore
{
    public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

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
}