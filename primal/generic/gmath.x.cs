//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    
    
    using static As;
    using static zfunc;

    partial class MathX
    {
        public static T[] ToScalars<T>(this bool[] src)
            where T : struct
                => map(src, x => x ? gmath.one<T>() : gmath.zero<T>());

        public static Span<T> ToScalars<T>(this Span<bool> src)
            where T : struct
        {
            var dst = span<T>(src.Length);
            var one = gmath.one<T>();
            var zed = gmath.zero<T>();
            for(var i = 0; i<src.Length; i++)
                dst[i] = src[i] ? one : zed;
            return dst;
        }


        public static Option<int> WriteTo<T>(this DivisorIndex<T> src, FolderPath dst)
            where T : struct
        {
            var filename = FileName.Define($"divisors{src.Range}.csv");
            var outpath = dst + filename;
            var lists = src.Lists.OrderBy(x => x.Dividend);
            return outpath.Overwrite(map(lists, d => d.ToString()));
        }

        
    }


}