namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    public static class MemBlock
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
        public static ref T AsSingle<S,T>(this Span<S> src, int offset = 0, int? length = null)
            where S : struct
            where T : struct
        {
            var bytes = 
                (offset == 0 && length == null) 
                ? MemoryMarshal.AsBytes(src)
                : length == null 
                ? MemoryMarshal.AsBytes(src.Slice(offset)) 
                : MemoryMarshal.AsBytes(src.Slice(offset, length.Value));
            return ref MemoryMarshal.AsRef<T>(bytes);
        }

        /// <summary>
        /// Renders a non-allocating immutable view over a source span segment that presents as an individual value of a target type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The index of the first source element</param>
        /// <param name="length">The number of source elements required to constitute a target type</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T AsSingle<S,T>(this ReadOnlySpan<S> src, int offset = 0, int? length = null)
            where S : struct
            where T : struct
        {
            var bytes = 
                (offset == 0 && length == null) 
                ? MemoryMarshal.AsBytes(src)
                : length == null 
                ? MemoryMarshal.AsBytes(src.Slice(offset)) 
                : MemoryMarshal.AsBytes(src.Slice(offset, length.Value));
            return ref MemoryMarshal.AsRef<T>(bytes);
        }

        [MethodImpl(Inline)]
        public static unsafe Span<S> AsSpan<T,S>(this ref T src)
            where T : struct
            where S : struct
                => new Span<S>(Unsafe.AsPointer(ref src), Unsafe.SizeOf<T>() / Unsafe.SizeOf<S>());

        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan<S> AsReadOnlySpan<T,S>(this ref T src)
            where T : struct
            where S : struct
                => new ReadOnlySpan<S>(Unsafe.AsPointer(ref Unsafe.AsRef(in src)), Unsafe.SizeOf<T>() / Unsafe.SizeOf<S>());

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> AsReadOnlySpan(this string src)
            => src;
    }


}