//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;
    using static As;

    partial class xfunc
    {
        /// <summary>
        /// Lifts the content of a span into a LINQ enumerable
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<T> ToEnumerable<T>(this ReadOnlySpan<T> src)
            => src.ToArray();
            
        /// <summary>
        /// Lifts the content of a span into a LINQ enumerable
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<T> ToEnumerable<T>(this Span<T> src)
            => src.ReadOnly().ToEnumerable();

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
        /// Constructs a span from an array
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this T[] src)
            => src;

        /// <summary>
        /// Constructs a span from a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this ReadOnlySpan<T> src)
        {
            var dst = span<T>(src.Length);
            src.CopyTo(dst);
            return dst;
        }

        /// <summary>
        /// Constructs a span from an aray
        /// </summary>
        /// <param name="src">The source aray</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this T[] src)
            => src;

        /// <summary>
        /// Constructs a span from a (presumeably finite) sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this IEnumerable<T> src)
            => span(src);

        /// <summary>
        /// Creates a set from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ISet<T> ToSet<T>(this Span<T> src)        
            => new HashSet<T>(src.ToEnumerable());

        /// <summary>
        /// Creates a dictionary from a span using the element indices as keys
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static IDictionary<int,T> ToDictionary<T>(this Span<T> src)        
            => src.ReadOnly().ToDictionary();

        /// <summary>
        /// Creates a set from a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ISet<T> ToSet<T>(this ReadOnlySpan<T> src)        
            => new HashSet<T>(src.ToEnumerable());

        /// <summary>
        /// Constructs a 256-bit blocked span from an array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> ToSpan256<T>(this T[] src)
            where T : struct
            => Z0.Span256.load<T>(src);

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> ToSpan128<T>(this Span<T> src)
             where T : struct
                => Z0.Span128.load(src);

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> ToSpan256<T>(this Span<T> src)
             where T : struct
                => Z0.Span256.load(src);

         [MethodImpl(Inline)]
        public static byte[] ToByteArray(this ushort src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] ToByteArray(this short src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] ToByteArray(this uint src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] ToByteArray(this int src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] ToByteArray(this ulong src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] ToByteArray(this long src)
            => BitConverter.GetBytes(src);

 

    }

}