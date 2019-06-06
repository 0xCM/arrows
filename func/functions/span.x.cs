//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;

    partial class xfunc
    {
        /// <summary>
        /// Constructs a span from a sequence selection
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this T[] src)
            => src;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this Span<T> src)
            => src;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this ReadOnlyMemory<T> src)
            => new ReadOnlySpan<T>(src.ToArray());

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
        /// Converts a mutable span to a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> Freeze<T>(this Span<T> src)
            => src;

        /// <summary>
        /// Splits a range into a left/right tuple index
        /// </summary>
        /// <param name="left">The index at which the selection begins</param>
        /// <param name="right">The index at which the selection ends</param>
        [MethodImpl(Inline)]
        public static (Index left, Index right) Split(this Range selection)
            => (selection.Start, selection.End);

        [MethodImpl(Inline)]
        public static void Copy<T>(this ReadOnlySpan<T> src, Span<T> dst)
            => src.CopyTo(dst);

        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this ReadOnlySpan<T> src)
        {
            var dst = span<T>(src.Length);
            src.CopyTo(dst);
            return dst;
        }

        /// <summary>
        /// Determines whether any elements of the source match the target
        /// </summary>
        /// <param name="src">The source values</param>
        /// <param name="match">The target value to match</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(NotInline)]
        public static bool Contains<T>(this ReadOnlySpan<T> src, T match)        
            where T : struct
        {
            var enumerator = src.GetEnumerator();
            while(enumerator.MoveNext())
                if(enumerator.Current.Equals(match))
                    return true;
            return false;
        }

        [MethodImpl(Inline)]
        public static bool Contains<T>(this Span<T> src, T match)        
            where T : struct
                => src.Freeze().Contains(match);

        [MethodImpl(NotInline)]
        public static bool Any<T>(this ReadOnlySpan<T> src, Func<T,bool> f)
             where T : struct
        {
            var it = src.GetEnumerator();
            while(it.MoveNext())
                if(f(it.Current))
                    return true;
            return false;
        }

        [MethodImpl(NotInline)]
        public static bool All<T>(this ReadOnlySpan<T> src, Func<T,bool> f)
             where T : struct
        {
            var it = src.GetEnumerator();
            while(it.MoveNext())
                if(!f(it.Current))
                    return false;
            return true;
        }

        [MethodImpl(Inline)]
        public static bool Any<T>(this Span<T> src, Func<T,bool> f)
             where T : struct
                => src.ToReadOnlySpan().Any(f);

        [MethodImpl(Inline)]
        public static bool All<T>(this Span<T> src, Func<T,bool> f)
             where T : struct
                => src.ToReadOnlySpan().All(f);

        /// <summary>
        /// Constructs a span from the entireity of a sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this IEnumerable<T> src)
            => span(src);

        [MethodImpl(Inline)]
        public static Span<T> TakeSpan<T>(this IEnumerable<T> src, int length)
            => span(src.Take(length));

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
        
        public static Span<T> MapRange<S, T>(this Span<S> src, int offset, int length, Func<S, T> f)
        {
            var dst = span<T>(length);
            for (int i = offset; i < length; i++)
                dst[i] = f(src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> Replicate<T>(this ReadOnlySpan<T> src)
        {
            var dst = span<T>(src.Length);
            src.CopyTo(dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> Replicate<T>(this Span<T> src)
        {
            var dst = span<T>(src.Length);
            src.CopyTo(dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> FillWith<T>(this Span<T> io, T value)
        {
            io.Fill(value);
            return io;
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> ToBytes<T>(this ReadOnlySpan<T> src)
            where T : struct
            => MemoryMarshal.AsBytes(src);
        
        [MethodImpl(Inline)]
        public static Span<byte> ToBytes<T>(this Span<T> src)
            where T : struct
            => MemoryMarshal.AsBytes(src);

        public static (int Index, T Value)[] ToIndexedValues<T>(this ReadOnlySpan<T> src)
        {
            var dst = alloc<(int,T)>(src.Length);
            for(var i = 0; i< dst.Length; i++)
                dst[i] = (i,src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static (int Index, T Value)[] ToIndexedValues<T>(this Span<T> src)        
            => src.ToReadOnlySpan().ToIndexedValues();

        [MethodImpl(Inline)]
        public static (T[] Left, T[] Right) PairReplicate<T>(this ReadOnlySpan<T> src)
            where T : struct
                => (src.Replicate().ToArray(), src.Replicate().ToArray());

    }
}