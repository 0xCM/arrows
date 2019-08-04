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

    using static zfunc;

    public static class IOX
    {
        /// <summary>
        /// Creates a reader initialized with the source file. The caller
        /// if responsible for cleanup
        /// </summary>
        /// <param name="src">The source file</param>
        public static StreamReader Reader(this FilePath src)
            => new StreamReader(src.FullPath);

        /// <summary>
        /// Creates a writer initialized with the source file. The caller
        /// if responsible for cleanup
        /// </summary>
        /// <param name="dst">The source file</param>
        public static StreamWriter Writer(this FilePath dst, bool append = false)
            => new StreamWriter(dst.FullPath,append);

        /// <summary>
        /// Determines whether a file exists
        /// </summary>
        /// <param name="src">The file for which existence is in question</param>
        public static bool Exists(this FilePath src)
            => File.Exists(src.FullPath);

        /// <summary>
        /// Creates a folder if it doesn't exist
        /// </summary>
        /// <param name="dst">The target folder</param>
        public static FolderPath CreateIfMissing(this FolderPath dst)
        {   if(!Directory.Exists(dst.Name)) 
                Directory.CreateDirectory(dst.Name);
            return dst;
        }
        
        
        public static int Overwrite(this FilePath dst, params string[] lines)
        {
            dst.FolderPath.CreateIfMissing();
         
            var count = 0;
            using var writer = new StreamWriter(dst.Name,false);            
            foreach(var line in lines)
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