//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
 
    public class LogSettings
    {
        public static LogSettings Get()
            => new LogSettings();

        private LogSettings()
        {

        }
        
        public FolderPath LogDir
            => FolderPath.Define(@"J:\dev\projects\z0-logs");

        public FolderPath AppLogDir
            => LogDir + FolderName.Define("app");

        public FolderPath TestLogDir
            => LogDir + FolderName.Define("test");

        public FolderPath BenchLogDir
            => LogDir + FolderName.Define("bench");

        int LogDate
            => Date.Today.ToDateKey();

        public FilePath LogPath(LogTarget target)
            => target switch{
                LogTarget.AppLog =>  AppLogDir + FileName.Define($"App.{LogDate}.log"),
                LogTarget.BenchLog => BenchLogDir + FileName.Define($"Bench.{LogDate}.log"),
                LogTarget.TestLog => TestLogDir + FileName.Define($"Test.{LogDate}.log"),
                _ => throw new ArgumentException()
            };
    }


}