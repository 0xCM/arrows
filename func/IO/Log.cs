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

        void Log<T>(IEnumerable<IRecord> records, LogTarget<T> target, char delimiter, bool writeHeader, bool newFile, FileExtension ext = null)
            where T : Enum;

        void Log(string text);
    }

    public static class Log
    {
        public static ILogger Get(ILogTarget dst)
            => dst.Area switch{
                LogArea.App => AppLog.TheOnly,
                LogArea.Bench => BenchLog.TheOnly,
                LogArea.Test => TestLog.TheOnly,
                _ => throw new ArgumentException()
            };

        abstract class Logger<A> : ILogger
            where A : Logger<A>, new()
        {
            public static ILogger TheOnly = new A();
            
            protected object locker = new object();
            
            protected Logger(LogArea Area)
            {
                this.Area = Area;
            }

            FilePath LogPath()
                => LogSettings.Get().LogPath(Area);

            FilePath LogPath<T>(LogTarget<T> target)
                where T : Enum
                    => LogSettings.Get().LogPath(target);

            FilePath UniqueLogPath(FileExtension ext = null)
                    => LogSettings.Get().UniqueLogPath(Area, ext);

            FilePath UniqueLogPath<T>(LogTarget<T> target, FileExtension ext = null)
                where T : Enum
                    => LogSettings.Get().UniqueLogPath(target,ext);

            public void Log(AppMsg src)
            {
                lock(locker)
                    LogPath().Append(src.ToString());
            }

            public void Log(IEnumerable<AppMsg> src)
            {
                lock(locker)
                    LogPath().Append(src.Select(x => x.ToString()));
            }

            void LogRecords(IReadOnlyList<IRecord> records, char delimiter, bool writeHeader, FilePath dstFile)
            {
                if(writeHeader)
                    dstFile.Append(string.Join(delimiter, records[0].GetHeaders()));
                
                iter(records, r => dstFile.Append(r.Delimited(delimiter)));
            }

            public void Log<T>(IEnumerable<IRecord> records, LogTarget<T> target, char delimiter, bool writeHeader = true, 
                bool newFile = true, FileExtension ext = null)
                    where T : Enum
            {
                var frozen = records.Freeze();
                if(frozen.Length == 0)
                    return;

                if(newFile)
                     LogRecords(frozen, delimiter, writeHeader, UniqueLogPath(target,ext));
                else
                    lock(locker)
                        LogRecords(frozen, delimiter, writeHeader, LogPath(target));
            }

            public void Log(string text)
            {
                lock(locker)
                    LogPath().Append(text);
            }

            public LogArea Area {get;}
            
        }

        class AppLog : Logger<AppLog>
        {
            public AppLog()            
             : base(LogArea.App)
            {

            }
        }

        class TestLog : Logger<TestLog>
        {
            public TestLog()            
             : base(LogArea.Test)
            {

            }
        }

        class BenchLog : Logger<BenchLog>
        {
            public BenchLog()            
             : base(LogArea.Bench)
            {

            }
        }
    }
}