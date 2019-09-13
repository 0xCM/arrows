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
            => memory(src);

        /// <summary>
        ///  Constructs a memory segment from the content of the (hopefully finite) stream (allocating)
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlyMemory<T> ToReadOnlyMemory<T>(this IEnumerable<T> src)
            => src.ToMemory();

        /// <summary>
        /// Constructs a memory segment of specified length from a stream (allocating)
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="length">The length of the index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> TakeMemory<T>(this IEnumerable<T> src, int length)
            => memory(src,length);

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

/*
TODO


    public static class MemoryExtensions
    {
        public static ReadOnlyMemory<char> AsMemory(this string? text);        
        public static Memory<T> AsMemory<T>(this T[] array, Range range);            
        public static Memory<T> AsMemory<T>(this T[] array, int start, int length);        
        public static Memory<T> AsMemory<T>(this T[] array, int start);            
        public static Memory<T> AsMemory<T>(this T[] array);            
        public static Memory<T> AsMemory<T>(this ArraySegment<T> segment, int start, int length);                
        public static Memory<T> AsMemory<T>(this T[] array, Index startIndex);                
        public static Memory<T> AsMemory<T>(this ArraySegment<T> segment);
        public static ReadOnlyMemory<char> AsMemory(this string? text, Range range);
        public static ReadOnlyMemory<char> AsMemory(this string? text, int start, int length);
        public static ReadOnlyMemory<char> AsMemory(this string? text, int start);
        public static ReadOnlyMemory<char> AsMemory(this string? text, Index startIndex);
        public static Memory<T> AsMemory<T>(this ArraySegment<T> segment, int start);
        public static Span<T> AsSpan<T>(this T[] array);                
        public static Span<T> AsSpan<T>(this T[] array, Range range);
        public static Span<T> AsSpan<T>(this T[] array, int start, int length);
        public static Span<T> AsSpan<T>(this T[] array, int start);
        public static Span<T> AsSpan<T>(this T[] array, Index startIndex);
        public static Span<T> AsSpan<T>(this ArraySegment<T> segment, Range range);
        public static ReadOnlySpan<char> AsSpan(this string? text);
        public static Span<T> AsSpan<T>(this ArraySegment<T> segment, int start);                
        public static Span<T> AsSpan<T>(this ArraySegment<T> segment, Index startIndex);
        public static Span<T> AsSpan<T>(this ArraySegment<T> segment);
        public static ReadOnlySpan<char> AsSpan(this string? text, int start, int length);
        public static ReadOnlySpan<char> AsSpan(this string? text, int start);
        public static Span<T> AsSpan<T>(this ArraySegment<T> segment, int start, int length);
        public static int BinarySearch<T, TComparable>(this Span<T> span, TComparable comparable) where TComparable : IComparable<T>;        
        public static int BinarySearch<T, TComparable>(this ReadOnlySpan<T> span, TComparable comparable) where TComparable : IComparable<T>;
        public static int BinarySearch<T, TComparer>(this Span<T> span, T value, TComparer comparer) where TComparer : IComparer<T>;
        public static int BinarySearch<T>(this Span<T> span, IComparable<T> comparable);
        public static int BinarySearch<T, TComparer>(this ReadOnlySpan<T> span, T value, TComparer comparer) where TComparer : IComparer<T>;
        public static int BinarySearch<T>(this ReadOnlySpan<T> span, IComparable<T> comparable);
        public static int CompareTo(this ReadOnlySpan<char> span, ReadOnlySpan<char> other, StringComparison comparisonType);
        public static bool Contains(this ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType);
        public static bool Contains<T>(this ReadOnlySpan<T> span, T value) where T : IEquatable<T>;
        public static bool Contains<T>(this Span<T> span, T value) where T : IEquatable<T>;
        public static void CopyTo<T>(this T[] source,  Memory<T> destination);
        public static void CopyTo<T>(this T[] source,  Span<T> destination);
        public static bool EndsWith<T>(this Span<T> span,  ReadOnlySpan<T> value) where T : IEquatable<T>;
        public static bool EndsWith(this ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType);
        public static bool EndsWith<T>(this ReadOnlySpan<T> span,  ReadOnlySpan<T> value) where T : IEquatable<T>;
        public static SpanRuneEnumerator EnumerateRunes(this ReadOnlySpan<char> span);
        public static SpanRuneEnumerator EnumerateRunes(this Span<char> span);
        public static bool Equals(this ReadOnlySpan<char> span, ReadOnlySpan<char> other, StringComparison comparisonType);
        public static int IndexOf<T>(this ReadOnlySpan<T> span, T value) where T : IEquatable<T>;
        public static int IndexOf<T>(this Span<T> span, T value) where T : IEquatable<T>;
        public static int IndexOf<T>(this Span<T> span,  ReadOnlySpan<T> value) where T : IEquatable<T>;
        public static int IndexOf<T>(this ReadOnlySpan<T> span,  ReadOnlySpan<T> value) where T : IEquatable<T>;
        public static int IndexOf(this ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType);
        public static int IndexOfAny<T>(this Span<T> span, T value0, T value1) where T : IEquatable<T>;
        public static int IndexOfAny<T>(this Span<T> span, T value0, T value1, T value2) where T : IEquatable<T>;
        public static int IndexOfAny<T>(this ReadOnlySpan<T> span, T value0, T value1, T value2) where T : IEquatable<T>;
        public static int IndexOfAny<T>(this ReadOnlySpan<T> span, T value0, T value1) where T : IEquatable<T>;
        public static int IndexOfAny<T>(this ReadOnlySpan<T> span,  ReadOnlySpan<T> values) where T : IEquatable<T>;
        public static int IndexOfAny<T>(this Span<T> span,  ReadOnlySpan<T> values) where T : IEquatable<T>;
        public static bool IsWhiteSpace(this ReadOnlySpan<char> span);
        public static int LastIndexOf<T>(this ReadOnlySpan<T> span, T value) where T : IEquatable<T>;
        public static int LastIndexOf(this ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType);
        public static int LastIndexOf<T>(this Span<T> span, T value) where T : IEquatable<T>;
        public static int LastIndexOf<T>(this Span<T> span,  ReadOnlySpan<T> value) where T : IEquatable<T>;
        public static int LastIndexOf<T>(this ReadOnlySpan<T> span,  ReadOnlySpan<T> value) where T : IEquatable<T>;
        public static int LastIndexOfAny<T>(this Span<T> span, T value0, T value1, T value2) where T : IEquatable<T>;
        public static int LastIndexOfAny<T>(this Span<T> span, T value0, T value1) where T : IEquatable<T>;
        public static int LastIndexOfAny<T>(this Span<T> span,  ReadOnlySpan<T> values) where T : IEquatable<T>;
        public static int LastIndexOfAny<T>(this ReadOnlySpan<T> span, T value0, T value1, T value2) where T : IEquatable<T>;
        public static int LastIndexOfAny<T>(this ReadOnlySpan<T> span, T value0, T value1) where T : IEquatable<T>;
        public static int LastIndexOfAny<T>(this ReadOnlySpan<T> span,  ReadOnlySpan<T> values) where T : IEquatable<T>;
        public static bool Overlaps<T>(this ReadOnlySpan<T> span,  ReadOnlySpan<T> other);
        public static bool Overlaps<T>(this ReadOnlySpan<T> span,  ReadOnlySpan<T> other, out int elementOffset);
        public static bool Overlaps<T>(this Span<T> span,  ReadOnlySpan<T> other);
        public static bool Overlaps<T>(this Span<T> span,  ReadOnlySpan<T> other, out int elementOffset);
        public static void Reverse<T>(this Span<T> span);
        public static int SequenceCompareTo<T>(this ReadOnlySpan<T> span,  ReadOnlySpan<T> other) where T : IComparable<T>;
        public static int SequenceCompareTo<T>(this Span<T> span,  ReadOnlySpan<T> other) where T : IComparable<T>;
        public static bool SequenceEqual<T>(this Span<T> span,  ReadOnlySpan<T> other) where T : IEquatable<T>;
        public static bool SequenceEqual<T>(this ReadOnlySpan<T> span,  ReadOnlySpan<T> other) where T : IEquatable<T>;
        public static bool StartsWith(this ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType);
        public static bool StartsWith<T>(this ReadOnlySpan<T> span,  ReadOnlySpan<T> value) where T : IEquatable<T>;
        public static bool StartsWith<T>(this Span<T> span,  ReadOnlySpan<T> value) where T : IEquatable<T>;
        public static int ToLower(this ReadOnlySpan<char> source, Span<char> destination, CultureInfo? culture);
        public static int ToLowerInvariant(this ReadOnlySpan<char> source, Span<char> destination);
        public static int ToUpper(this ReadOnlySpan<char> source, Span<char> destination, CultureInfo? culture);
        public static int ToUpperInvariant(this ReadOnlySpan<char> source, Span<char> destination);        
        public static Memory<T> Trim<T>(this Memory<T> memory,  ReadOnlySpan<T> trimElements) where T : IEquatable<T>;        
        public static ReadOnlySpan<T> Trim<T>(this ReadOnlySpan<T> span, T trimElement) where T : IEquatable<T>;        
        public static ReadOnlySpan<T> Trim<T>(this ReadOnlySpan<T> span,  ReadOnlySpan<T> trimElements) where T : IEquatable<T>;        
        public static ReadOnlyMemory<T> Trim<T>(this ReadOnlyMemory<T> memory, T trimElement) where T : IEquatable<T>;        
        public static ReadOnlyMemory<T> Trim<T>(this ReadOnlyMemory<T> memory,  ReadOnlySpan<T> trimElements) where T : IEquatable<T>;        
        public static Memory<T> Trim<T>(this Memory<T> memory, T trimElement) where T : IEquatable<T>;        
        public static Span<T> Trim<T>(this Span<T> span,  ReadOnlySpan<T> trimElements) where T : IEquatable<T>;        
        public static Span<T> Trim<T>(this Span<T> span, T trimElement) where T : IEquatable<T>;
        public static Memory<char> Trim(this Memory<char> memory);
        public static ReadOnlyMemory<char> Trim(this ReadOnlyMemory<char> memory);
        public static ReadOnlySpan<char> Trim(this ReadOnlySpan<char> span);
        public static ReadOnlySpan<char> Trim(this ReadOnlySpan<char> span, char trimChar);
        public static ReadOnlySpan<char> Trim(this ReadOnlySpan<char> span, ReadOnlySpan<char> trimChars);
        public static Span<char> Trim(this Span<char> span);
        public static ReadOnlySpan<char> TrimEnd(this ReadOnlySpan<char> span);
        public static ReadOnlyMemory<char> TrimEnd(this ReadOnlyMemory<char> memory);        
        public static Span<T> TrimEnd<T>(this Span<T> span, T trimElement) where T : IEquatable<T>;        
        public static Span<T> TrimEnd<T>(this Span<T> span,  ReadOnlySpan<T> trimElements) where T : IEquatable<T>;
        public static ReadOnlySpan<char> TrimEnd(this ReadOnlySpan<char> span, ReadOnlySpan<char> trimChars);
        public static ReadOnlySpan<T> TrimEnd<T>(this ReadOnlySpan<T> span,  ReadOnlySpan<T> trimElements) where T : IEquatable<T>;
        public static ReadOnlySpan<char> TrimEnd(this ReadOnlySpan<char> span, char trimChar);
        public static Memory<char> TrimEnd(this Memory<char> memory);
        public static Span<char> TrimEnd(this Span<char> span);        
        public static Memory<T> TrimEnd<T>(this Memory<T> memory,  ReadOnlySpan<T> trimElements) where T : IEquatable<T>;        
        public static ReadOnlyMemory<T> TrimEnd<T>(this ReadOnlyMemory<T> memory, T trimElement) where T : IEquatable<T>;        
        public static Memory<T> TrimEnd<T>(this Memory<T> memory, T trimElement) where T : IEquatable<T>;        
        public static ReadOnlyMemory<T> TrimEnd<T>(this ReadOnlyMemory<T> memory,  ReadOnlySpan<T> trimElements) where T : IEquatable<T>;        
        public static ReadOnlySpan<T> TrimEnd<T>(this ReadOnlySpan<T> span, T trimElement) where T : IEquatable<T>;        
        public static Span<T> TrimStart<T>(this Span<T> span, T trimElement) where T : IEquatable<T>;        
        public static Span<T> TrimStart<T>(this Span<T> span,  ReadOnlySpan<T> trimElements) where T : IEquatable<T>;        
        public static ReadOnlySpan<T> TrimStart<T>(this ReadOnlySpan<T> span, T trimElement) where T : IEquatable<T>;        
        public static ReadOnlySpan<T> TrimStart<T>(this ReadOnlySpan<T> span,  ReadOnlySpan<T> trimElements) where T : IEquatable<T>;        
        public static ReadOnlyMemory<T> TrimStart<T>(this ReadOnlyMemory<T> memory,  ReadOnlySpan<T> trimElements) where T : IEquatable<T>;        
        public static Memory<T> TrimStart<T>(this Memory<T> memory, T trimElement) where T : IEquatable<T>;        
        public static Memory<T> TrimStart<T>(this Memory<T> memory,  ReadOnlySpan<T> trimElements) where T : IEquatable<T>;
        public static Span<char> TrimStart(this Span<char> span);
        public static ReadOnlySpan<char> TrimStart(this ReadOnlySpan<char> span, char trimChar);
        public static ReadOnlySpan<char> TrimStart(this ReadOnlySpan<char> span);
        public static ReadOnlyMemory<char> TrimStart(this ReadOnlyMemory<char> memory);
        public static Memory<char> TrimStart(this Memory<char> memory);        
        public static ReadOnlyMemory<T> TrimStart<T>(this ReadOnlyMemory<T> memory, T trimElement) where T : IEquatable<T>;
        public static ReadOnlySpan<char> TrimStart(this ReadOnlySpan<char> span, ReadOnlySpan<char> trimChars);
    }


 */