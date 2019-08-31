//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    public static class SpanConvert
    {
        /// <summary>
        /// Renders a non-allocating mutable view over a source span segment that presents as an individual value of a target type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The index of the first source element</param>
        /// <param name="length">The number of source elements required to constitute a target type</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T TakeSingle<S,T>(Span<S> src, int offset = 0, int? length = null)
            where S : struct
            where T : struct
                => ref MemoryMarshal.AsRef<T>(src.AsBytes(offset,length));

        /// <summary>
        /// Renders a non-allocating immutable view over a source span segment that presents as an individual value of a target type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The index of the first source element</param>
        /// <param name="length">The number of source elements required to constitute a target type</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T TakeSingle<S,T>(ReadOnlySpan<S> src, int offset = 0, int? length = null)
            where S : struct
            where T : struct            
                => ref MemoryMarshal.AsRef<T>(src.AsBytes(offset, length));

        /// <summary>
        /// Presents an S-value as a T-Span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source value type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Span<T> AsSpan<S,T>(ref S src)
            where S : struct
            where T : struct
                => new Span<T>(Unsafe.AsPointer(ref src), Unsafe.SizeOf<S>() / Unsafe.SizeOf<T>());

        /// <summary>
        /// Presents an S-value as a readonly T-Span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source value type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan<T> AsReadOnlySpan<S,T>(ref S src)
            where S : struct
            where T : struct
                => new ReadOnlySpan<T>(Unsafe.AsPointer(ref src), Unsafe.SizeOf<S>() / Unsafe.SizeOf<T>());

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> ToReadOnlySpan(this string src)
            => src;
    }
}