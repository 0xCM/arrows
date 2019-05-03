//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;

    public static class SpanX
    {
        /// <summary>
        /// Constructs a span from the entireity of a sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> ToSpan128<T>(this T[] src, int offset = 0)
            where T : struct, IEquatable<T>
                => Span128.define(src,offset);

        [MethodImpl(Inline)]
        public static Span128<T> ToSpan128<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct, IEquatable<T>
                => Span128.define(src,offset);

        [MethodImpl(Inline)]
        public static bool Contains<T>(this ReadOnlySpan<T> src, T match)        
            where T : struct, IEquatable<T>
        {
            var enumerator = src.GetEnumerator();
            while(enumerator.MoveNext())
            {
                if(enumerator.Current.Equals(match))
                    return true;
            }
            return false;
        }
        
        /// <summary>
        /// Constructs mutable span from a slice of a read-only span
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> MutableSlice<T>(this ReadOnlySpan<T> src, int? offset = null, int? length = null)
            where T : struct, IEquatable<T>
                => src.Slice(offset ?? 0, length ?? src.Length).ToArray();


        /// <summary>
        /// Constructs a span from the entireity of a sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this IEnumerable<T> src)
            => span(src);

        /// <summary>
        /// Constructs a span from a sequence selection
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="offset">The number of elements to skip from the head of the sequence</param>
        /// <param name="length">The number of elements to take from the sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this IEnumerable<T> src, int? offset = null, int? length = null)
            => span(src,offset,length);

        /// <summary>
        /// Constructs a span from a sequence selection
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this T[] src)
            => src;
 
        /// <summary>
        /// Constructs a span from an array selection
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="start">The array index where the span is to begin</param>
        /// <param name="length">The number of elements to cover from the aray</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this T[] src, Index start, int length)
            => span(src,start.Value,length);

        /// <summary>
        /// Constructs a subspan from a starting index to the end of the span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="start">The start index</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Segment<T>(this Span<T> src, Index start)
            => src.Slice(start);

        /// <summary>
        /// Converts a mutable span to a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this Span<T> src)
            => src;


        /// <summary>
        /// Constructs a subspan from a starting index to the end of the span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="start">The start index</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Segment<T>(this Span<T> src, Index start, Index end)
            => src.Slice(new Range(start,end));

        /// <summary>
        /// Constructs a subspan from a starting index to the end of the span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="start">The start index</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Segment<T>(this Span<T> src, Range selection)
            => src.Slice(selection);

        /// <summary>
        /// Splits a range into a left/right tuple index
        /// </summary>
        /// <param name="left">The index at which the selection begins</param>
        /// <param name="right">The index at which the selection ends</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static (Index left, Index right) Split(this Range selection)
            => (selection.Start, selection.End);

        // [MethodImpl(Inline)]
        // public static Option<bool> TryCopy<T>(this Span<T> src, Span<T> dst)
        //     => src.TryCopyTo(dst) ? true : none<bool>();

        // [MethodImpl(Inline)]
        // public static void Copy<T>(this Span<T> src, Span<T> dst)
        //     => onFalse(src.TryCopyTo(dst), () => throw new Exception("Span copy failed"));


        [MethodImpl(Inline)]
        public static void Copy<T>(this ReadOnlySpan<T> src, Span<T> dst)
            => src.CopyTo(dst);

        // [MethodImpl(Inline)]
        // public static Option<bool> TryCopy<T>(this ReadOnlySpan<T> src, Span<T> dst)
        // {
        //     try
        //     {
        //         src.Copy(dst);
        //         return true;
        //     }
        //     catch(Exception)
        //     {
        //         return none<bool>();
        //     }
        // }

    }

}