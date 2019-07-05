//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Collections;
    using System.IO;

    using static zfunc;

    /// <summary>
    /// Defines minimal contract for a log message sink
    /// </summary>
    public interface ILogger
    {
        void Log(IEnumerable<AppMsg> src);
        
        void Log(AppMsg src);

        void Log<R,T>(IEnumerable<R> records, LogTarget<T> target, char delimiter, bool writeHeader, bool newFile, FileExtension ext = null)
            where T : Enum
            where R : IRecord;
            

        void Log(string text);
    }


}