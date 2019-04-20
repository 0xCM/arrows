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



    public static class File
    {
        public static Option<int> save(IEnumerable<string> src, FilePath dst)
        {
            var count = 0;
            using var writer = new StreamWriter(dst.Name);            
            foreach(var line in src)
            {
                writer.WriteLine(line);
                count++;
            }
            return count;

        }
    }

}