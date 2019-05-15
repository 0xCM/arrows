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

    public interface ILogger
    {
        void Log(IEnumerable<AppMsg> src);
        
        void Log(AppMsg src);

        void Log(IRecord record, char delimiter);

        void Log(IEnumerable<IRecord> records, char delimiter, bool writeHeader);

        void Log(string text);
    }

    public static class Log
    {
        public static ILogger Get(LogTarget dst)
            => dst switch{
                LogTarget.AppLog => AppLog.TheOnly,
                LogTarget.BenchLog => BenchLog.TheOnly,
                LogTarget.TestLog => TestLog.TheOnly,
                _ => throw new ArgumentException()
            };

        abstract class Logger<T> : ILogger
            where T : Logger<T>, new()
        {
            public static ILogger TheOnly = new T();
            
            protected object locker = new object();
            
            protected Logger(LogTarget Target)
            {
                this.Target = Target;
            }

            FilePath LogPath
                => LogSettings.Get().LogPath(Target);

            public void Log(AppMsg src)
            {
                lock(locker)
                    LogPath.Append(src.ToString());

            }

            public void Log(IEnumerable<AppMsg> src)
            {
                lock(locker)
                    LogPath.Append(src.Select(x => x.ToString()));
            }

            public void Log(IEnumerable<IRecord> records, char delimiter, bool writeHeader = true)
            {
                var frozen = records.Freeze();
                if(frozen.Length == 0)
                    return;

                lock(locker)
                {                        
                    if(writeHeader)
                        LogPath.Append(string.Join(delimiter, frozen[0].Headers()));
                    
                    iter(frozen, r => LogPath.Append(r.Delimited(delimiter)));
                    
                }
            }

            public void Log(IRecord record, char delimiter)
            {
                lock(locker)
                    LogPath.Append(record.Delimited(delimiter));
            }

            public void Log(string text)
            {
                lock(locker)
                    LogPath.Append(text);
            }

            public LogTarget Target {get;}
            
        }

        class AppLog : Logger<AppLog>
        {
            public AppLog()            
             : base(LogTarget.AppLog)
            {

            }
        }

        class TestLog : Logger<TestLog>
        {
            public TestLog()            
             : base(LogTarget.TestLog)
            {

            }
        }

        class BenchLog : Logger<BenchLog>
        {
            public BenchLog()            
             : base(LogTarget.BenchLog)
            {

            }
        }
    }
}