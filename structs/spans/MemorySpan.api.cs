    //-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;
    using System.Buffers;

    using static nfunc;
    using static zfunc;

    public static class MemorySpan
    {
        /// <summary>
        /// Allocates a memory span of specified length
        /// </summary>
        /// <param name="len">The data length</param>
        /// <param name="fill">An optional fill value</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Alloc<T>(int len, T? fill = default)
            where T : unmanaged
        {
            var dst = new T[len];
            if(fill != null)
                dst.AsSpan().Fill(fill.Value);
            return dst;
        }
    
        /// <summary>
        /// Creates a memory span from array content
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] From<T>(params T[] src)
            where T : unmanaged
                => src;
    

    }

}