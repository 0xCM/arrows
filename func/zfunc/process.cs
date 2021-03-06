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

}