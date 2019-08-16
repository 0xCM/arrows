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


    public static class Log
    {
        static ILogger BenchmarkLogger        
            => Log.Get(LogTarget.AreaRoot(LogArea.Bench));
        
        static LogTarget<LogArea> BenchmarkTarget
            => LogTarget.AreaRoot(LogArea.Bench);

        public static void LogBenchmarks<R>(string name, bool newFile, bool writeHeader, char delimiter, params R[] records)
            where R : IRecord
        {
            if(records.Length == 0)
                return;
            
            BenchmarkLogger.Log(records, name, delimiter, writeHeader, newFile,FileExtension.Define("csv"));

        }

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


            FilePath LogPath(string topic, FileExtension ext = null)
                => LogSettings.Get().LogPath(Area, topic, ext);

            FilePath UniqueLogPath(string topic, FileExtension ext = null)
                    => LogSettings.Get().UniqueLogPath(Area, topic, ext);

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

            public void LogRecords<R>(IReadOnlyList<R> records, FilePath dstFile, char? delimiter = null, bool? writeHeader = null, bool append = true)
                where R : IRecord
            {
                
                if(records.Count == 0)
                    return;
                
                if(!append)
                    dstFile.DeleteIfExists();
                
                var emitHeader =  writeHeader ?? (append && !dstFile.Exists());
                var sep = delimiter ?? '|';

                if(emitHeader)
                    dstFile.Append(string.Join(sep, records[0].GetHeaders()));
                
                iter(records, r => dstFile.Append(r.DelimitedText(sep)));
            }

            void LogRecords<R>(IReadOnlyList<R> records, char delimiter, bool writeHeader, FilePath dstFile)
                where R : IRecord
            {
                
                if(records.Count == 0)
                    return;

                if(writeHeader)
                    dstFile.Append(string.Join(delimiter, records[0].GetHeaders()));
                
                iter(records, r => dstFile.Append(r.DelimitedText(delimiter)));
            }

            public void Log<R>(IEnumerable<R> records, string topic, char delimiter, bool writeHeader = true, 
                bool newFile = true, FileExtension ext = null)
                    where R : IRecord
            {
                var frozen = records.Freeze();
                if(frozen.Length == 0)
                    return;                

                if(newFile)
                     LogRecords(frozen, delimiter, writeHeader, UniqueLogPath(topic,ext));
                else
                    lock(locker)
                        LogRecords(frozen, delimiter, writeHeader, LogPath(topic, ext));
            }

            public void Log<R,T>(IEnumerable<R> records, LogTarget<T> target, char delimiter, bool writeHeader = true, 
                bool newFile = true, FileExtension ext = null)
                    where R : IRecord
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