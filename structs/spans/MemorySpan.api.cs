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
        public static MemorySpan<T> Alloc<T>(int len, T? fill = default)
            where T : unmanaged
                => new MemorySpan<T>(len,fill);
    
        /// <summary>
        /// Creates a memory span from array content
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static MemorySpan<T> From<T>(params T[] src)
            where T : unmanaged
                => src;
    
        /// <summary>
        /// Creates a memory span from memory content
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static MemorySpan<T> From<T>(Memory<T> src)
            where T : unmanaged
                => src;

        /// <summary>
        /// Creates a memory span from readonly memory content (allocating?)
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static MemorySpan<T> From<T>(ReadOnlyMemory<T> src)
            where T : unmanaged
                => MemoryMarshal.AsMemory(src);

        /// <summary>
        /// Creates a memory span from a readonly span (allocating)
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static MemorySpan<T> From<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => new MemorySpan<T>(src.ToArray());
    
        /// <summary>
        /// Interchanges elements i and j
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="i">An index of a span element</param>
        /// <param name="j">An index of a span element</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]
        public static void Swap<T>(this MemorySpan<T> src, int i, int j)
            where T : unmanaged
        {
            if(i != j)
            {
                var tmp = src[i];
                src[i] = src[j];
                src[j] = tmp;
            }
        }
    }

}