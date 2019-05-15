//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.IO;

using Z0;

using static Z0.ReflectionFlags;

partial class zfunc
{

    /// <summary>
    /// Writes a sequence of messages to a log as a contiguous block
    /// </summary>
    /// <param name="messages">The messages to emit</param>
    /// <param name="dst">The destination log</param>
    public static void log(IEnumerable<AppMsg> messages, LogArea dst)
        => Log.Get(LogTarget.AreaRoot(dst)).Log(messages);

    /// <summary>
    /// Writes a message to a log
    /// </summary>
    /// <param name="messages">The message to emit</param>
    /// <param name="dst">The destination log</param>
    public static void log(AppMsg message, LogArea dst)
        => Log.Get(LogTarget.AreaRoot(dst)).Log(message);

    public static void log<T>(IEnumerable<IRecord> records, LogTarget<T> dst, char delimiter = ',', 
        bool writeHeader = true, bool newfile = true, FileExtension ext = null)
            where T : Enum
            => Log.Get(dst).Log(records, dst, delimiter, true, newfile, ext);

    public static void log(string text, LogArea dst)
        => Log.Get(LogTarget.AreaRoot(dst)).Log(text);
}

