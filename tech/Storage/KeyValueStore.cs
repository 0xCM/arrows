//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Storage
{
    using System;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;

    using FASTER.core;
    using static zfunc;


    using Key2 = StoreKey<ulong>;


    public abstract class KeyValueStore<K,V> 
        where K : struct
        where V : struct
    {

        static FolderName TypeName
            => FolderName.Define(typeof(V).Name);
        
        protected static FolderPath RootDir
            => Z0.LogSettings.Get().RootLogDir + FolderName.Define($"Store");

        protected static FolderPath DataDir
                => (RootDir + TypeName).CreateIfMissing();

        protected static FolderPath LogDir
        {
            get
            {
                var logDir = (RootDir + TypeName) + FolderName.Define("logs");            
                return logDir.CreateIfMissing();
            }
        }

        protected static FolderPath CpDir
            => (DataDir + FolderName.Define("checkpoints")).CreateIfMissing();

        protected static IDevice OpenLog()
        {
            var logdir = LogDir;
            var fileName = FileName.Define(typeof(V).Name) + FileExtension.Define("log");
            var logPath = logdir + fileName;
            return Devices.CreateLogDevice(logPath.ToString(),true, false);
        }
                
            
        protected static CheckpointSettings CpConfig()
        {
            var settings = new CheckpointSettings
            { 
                CheckpointDir = CpDir.ToString(),
                CheckPointType = CheckpointType.Snapshot
            };
            
            return settings;
        }

        protected static void CloseLog(IDevice log)
        {
            
            log.Close();
        }

        protected static LogSettings LogConfig(IDevice log)
        {
            var settings = new LogSettings 
            {
                LogDevice = log, 
                MutableFraction = 0.9, 
                MemorySizeBits = 20, 
                PageSizeBits = 12, 
                SegmentSizeBits = 20
            };
            return settings;
        }

    }
 

}