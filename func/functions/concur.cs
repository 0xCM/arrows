using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;

partial class zfunc
{


    /// <summary>
    /// Retrieves the current process
    /// </summary>
    [MethodImpl(Inline)]   
    public static Process process()
        => Process.GetCurrentProcess();

    /// <summary>
    /// Retrieves the process id of the current process
    /// </summary>
    [MethodImpl(Inline)]   
    public static int procid()
        => Process.GetCurrentProcess().Id;

    /// <summary>
    /// Retrieves the name of the current process
    /// </summary>
    [MethodImpl(Inline)]   
    public static string procname()
        => Process.GetCurrentProcess().ProcessName;

    /// <summary>
    /// Retrieves a process identified by a process id
    /// </summary>
    [MethodImpl(Inline)]   
    public static Process process(int procid)
        => Process.GetProcessById(procid);

    [MethodImpl(Inline)]   
    public static IntPtr intptr(ulong address)
        => new IntPtr((long)address);

    [MethodImpl(Inline)]   
    public static Task<T> task<T>(Func<T> worker)
        => Task.Factory.StartNew(worker);

    [MethodImpl(Inline)]   
    public static Task task(Action worker)
        => Task.Factory.StartNew(worker);

    [MethodImpl(Inline)]   
    public static Task<T> task<S,T>(Func<S,T> worker, S s0)
        => Task.Factory.StartNew(o => worker((S)o), s0);
}