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

    public static class NumberFile
    {
        public static Option<int> save<T>(DivisorIndex<T> src, FolderPath dstFolder)
            where T : struct, IEquatable<T>
        {
            var filename = FileName.Define($"divisors{src.Range}.csv");
            var outpath = dstFolder + filename;
            var lists = src.Lists.OrderBy(x => x.Dividend);
            return File.save(map(lists, d => d.format()),outpath);
        }
    }

}