//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static zfunc;

    public class LogSettings
    {
        public static LogSettings Get()
            => new LogSettings();

        private LogSettings()
        {

        }
        
        public FolderPath RootLogDir
            => FolderPath.Define(@"J:\dev\projects\z0-logs");

        public FolderPath AppLogDir
            => RootLogDir + FolderName.Define("app");

        public FolderPath TestLogDir
            => RootLogDir + FolderName.Define("test");

        public FolderPath BenchLogDir
            => RootLogDir + FolderName.Define("bench");

        FolderPath LogDir(LogArea target)        
            => RootLogDir + FolderName.Define(target.ToString().ToLower());

        long LogDate
            => Date.Today.ToDateKey();

        FileExtension DefaultExtension
            => FileExtension.Define("log");
        
        public FilePath UniqueLogPath(LogArea area, FileExtension ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(area, ext, elapsed);
        }

        public FilePath UniqueLogPath<T>(LogTarget<T> target, FileExtension ext = null)
            where T : Enum
        {
            var first = new DateTime(2019,1,1);
            var current = now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(target, ext, elapsed);
        }

        /// <summary>
        /// Gets the path to a file in the test log directory
        /// </summary>
        /// <param name="filename">The bare filename</param>
        public FilePath TestLogPath(FileName filename)
            => LogDir(LogArea.Test) + filename;

        public FilePath LogPath(LogArea area, FileExtension ext = null, long? timestamp = null)
            => LogDir(area) + FileName.Define($"{area}.{timestamp ?? LogDate}.{ext ?? DefaultExtension}");

        public FilePath LogPath<T>(LogTarget<T> target, FileExtension ext = null, long? timestamp = null)
            where T : Enum
            => LogDir(target.Area) + FileName.Define($"{target.Area}.{target.KindName}.{timestamp ?? LogDate}.{ext ?? DefaultExtension}");
    }

}