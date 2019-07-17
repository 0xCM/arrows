//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using Z0;

partial class zfunc
{
    /// <summary>
    /// Executes a worker that computes a value within the context of a new task
    /// </summary>
    /// <param name="worker">The worker to execute</param>
    [MethodImpl(Inline)]   
    public static Task<T> task<T>(Func<T> worker)
        => Task.Factory.StartNew(worker);

    /// <summary>
    /// Executes a worker within the context of a new task
    /// </summary>
    /// <param name="worker">The worker to execute</param>
    [MethodImpl(Inline)]   
    public static Task task(Action worker)
        => Task.Factory.StartNew(worker);

    /// <summary>
    /// Executes a worker that computes a value within the context of a new task
    /// </summary>
    /// <param name="worker">The worker to execute</param>
    /// <param name="s0">The value to supply to the worker</param>
    [MethodImpl(Inline)]   
    public static Task<T> task<S,T>(Func<S,T> worker, S s0)
        => Task.Factory.StartNew(o => worker((S)o), s0);

    /// <summary>
    /// Returns after specified duration has elapsed
    /// </summary>
    /// <param name="duration">The time to wait before returning</param>
    [MethodImpl(Inline)]   
    public static void delay(TimeSpan duration)
        => Task.Delay(duration).RunSynchronously();

    /// <summary>
    /// Introduces an asynchronous delay
    /// </summary>
    /// <param name="duration">The length of the delay to introduce</param>
    /// <returns></returns>
    public static async Task asyncDelay(TimeSpan duration)
            => await Task.Delay(duration);

    /// <summary>
    /// Searches for a thread given an OS-assigned id
    /// </summary>
    /// <param name="threadId">The OS thread Id</param>
    [MethodImpl(Inline)]   
    public static Option<ProcessThread> thread(uint threadId)
        => process().ProcessThreads().FirstOrDefault(t => t.Id == threadId);
}


