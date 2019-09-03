//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;
    using static nfunc;

    public static partial class MemX
    {
        /// <summary>
        /// Converts a memory segment to a memory span
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static MemorySpan<T> ToMemorySpan<T>(this Memory<T> src)
            where T : unmanaged
                => src;

        /// <summary>
        ///  Constructs a memory segment from the content of an array (non-allocating)
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> ToMemory<T>(this T[] src)
            => src;

        /// <summary>
        ///  Constructs a readonly memory segment from the content of an array (non-allocating)
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static ReadOnlyMemory<T> ToReadOnlyMemory<T>(this T[] src)
            => src;

        /// <summary>
        /// Encloses the source memory in readonly container (non-allocating)
        /// </summary>
        /// <param name="src">The source memory</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlyMemory<T> Readonly<T>(this Memory<T> src)
            => src;

        /// <summary>
        /// Reverses the memory cells in-place
        /// </summary>
        /// <param name="src">The source memory</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> Reverse<T>(this Memory<T> src)
        {
            src.Span.Reverse();
            return src;
        }

        /// <summary>
        /// Interchanges cells i and j
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="i">An index of a memory cell</param>
        /// <param name="j">An index of a memory cell</param>
        /// <typeparam name="T">The memory cell type type</typeparam>
        [MethodImpl(Inline)]
        public static void Swap<T>(this Memory<T> src, int i, int j)
            => src.Span.Swap(i,j);

        /// <summary>
        /// If the length of a source span is less than a specified length, a new span of the desired length
        /// is allocated and then filled with the source span content; otherwise, the source span is returned
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="minlen">The desired minimum length</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> Extend<T>(this Memory<T> src, int minlen)
        {
            if(src.Length >= minlen)
                return src;
            else
            {
                var dst = new T[minlen];
                src.CopyTo(dst); 
                return dst;               
            }
        }           

        /// <summary>
        /// Projects a memory source to target via a supplied transformation
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="f">The transformation</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> Map<S,T>(this Memory<S> src, Func<S, T> f)
        {
            var dst = new T[src.Length];
            for(var i= 0; i<src.Length; i++)
                dst[i] = f(src.Span[i]);
            return dst;
        }
    }

}