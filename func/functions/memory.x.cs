//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;    
    using System.Diagnostics;
    
    using static zfunc;
    
    partial class xfunc
    {
        /// <summary>
        ///  Constructs a memory segment from the content of the (hopefully finite) stream (allocating)
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> ToMemory<T>(this IEnumerable<T> src)
            => src.ToArray();

        /// <summary>
        /// Encloses the source memory in readonly container (non-allocating)
        /// </summary>
        /// <param name="src">The source memory</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlyMemory<T> Readonly<T>(this Memory<T> src)
            => src;

        /// <summary>
        ///  Constructs a memory segment from the content of the (hopefully finite) stream (allocating)
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlyMemory<T> ToReadOnlyMemory<T>(this IEnumerable<T> src)
            => src.ToMemory();

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
        /// Constructs a memory segment of specified length from a stream (allocating)
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="length">The length of the index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> TakeMemory<T>(this IEnumerable<T> src, int length)
            => src.Take(length).ToMemory();

        /// <summary>
        /// Constructs a memory segment of specified length from a stream (allocating)
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="length">The length of the index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlyMemory<T> TakeReadOnlyMemory<T>(this IEnumerable<T> src, int length)
            => src.Take(length).ToMemory();

        /// <summary>
        /// Constructs an array from a specified number of elmements from a source stream after a skip (allocating)
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> TakeMemory<T>(this IEnumerable<T> src, int skip, int count)
            => src.Skip(skip).TakeMemory(count);

        /// <summary>
        /// Uses the (void*) explicit operator defined by the source type to
        /// present said source as a void*
        /// </summary>
        /// <param name="src">The source pointer representative</param>
        [MethodImpl(Inline)]
        public static unsafe void* ToVoid(this IntPtr src)
            => (void*)src;

        /// <summary>
        /// Gets the void* for the identified field
        /// </summary>
        /// <param name="src">The runtime field handle</param>
        [MethodImpl(Inline)]
        public static unsafe void* ToVoid(this RuntimeFieldHandle src)
            => src.Value.ToVoid();
    }

}