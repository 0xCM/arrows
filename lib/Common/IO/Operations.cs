//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.IO;

    using static zcore;

    public enum LogTarget
    {
        TestLog,

        BenchLog,

        AppLog
    }

    public static class IOX
    {
        public static FolderPath CreateIfMissing(this FolderPath dst)
        {   if(!Directory.Exists(dst.Name)) 
                Directory.CreateDirectory(dst.Name);
            return dst;
        }
        
        public static int Overwrite(this FilePath dst, IEnumerable<string> src)
        {
            dst.FolderPath.CreateIfMissing();
         
            var count = 0;
            using var writer = new StreamWriter(dst.Name,false);            
            foreach(var line in src)
            {
                writer.WriteLine(line);
                count++;
            }
            return count;

        }

        public static int Append(this FilePath dst, params string[] src)
            => dst.Append((IEnumerable<string>)src);
            
        public static int Append(this FilePath dst, IEnumerable<string> src)
        {
            dst.FolderPath.CreateIfMissing();
            
            var count = 0;
            using var writer = new StreamWriter(dst.Name,true);            
            foreach(var line in src)
            {
                writer.WriteLine(line);
                count++;
            }
            return count;

        }

    }

}