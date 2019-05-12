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