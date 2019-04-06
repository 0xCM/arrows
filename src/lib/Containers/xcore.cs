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

    using static zcore;

    partial class xcore
    {
        /// <summary>
        /// Constructs a semi-sequence from a stream
        /// </summary>
        /// <param name="src">The element source</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static SemiSeq<T> ToSemiSeq<T>(this IEnumerable<T> src)
            where T : Structures.Semigroup<T>, new()
                => semiseq(src);

        /// <summary>
        /// Constructs a semi-sequence from a parameter array
        /// </summary>
        /// <param name="src">The element source</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static SemiSeq<T> ToSemiSeq<T>(this T[] src)
            where T : Structures.Semigroup<T>, new()
                => semiseq(src);

        [MethodImpl(Inline)]
        public static Slice<N,T> NatSlice<N,T>(this Z0.TypeNat<N> n, IEnumerable<T> src)
            where N : TypeNat, new()
                => new Slice<N, T>(src);

        [MethodImpl(Inline)]
        public static Slice<N,T> NatSlice<N,T>(this Z0.TypeNat<N> n, params T[] src)
            where N : TypeNat, new()
                => new Slice<N, T>(src);

        /// <summary>
        /// Constructs a vector from the components of a slice
        /// </summary>
        /// <param name="src">The component source</param>
        /// <typeparam name="N">The natural lenth type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> ToVector<N,T>(this Slice<N,T> src)
            where N : TypeNat, new()
                => vector<N,T>(src.data);

        /// <summary>
        /// Constructs a readonly list from from the entirety of a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static IReadOnlyList<T> Freeze<T>(this IEnumerable<T> src)
                => src.ToReadOnlyList();

        /// <summary>
        /// Constructs a readonly list from from the a specified number of
        /// elmements from of a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static IReadOnlyList<T> Freeze<T>(this IEnumerable<T> src, int count)
                => src.Take(count).Freeze();

        /// <summary>
        /// Constructs a slice from a sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<T> ToSlice<T>(this IEnumerable<T> src)
                => new Slice<T>(src);

        /// <summary>
        /// Constructs a slice of natural length from a sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]        
        public static Slice<N,T> ToSlice<N,T>(this IEnumerable<T> src, N natrep = default)
            where N : TypeNat, new()
                => new Slice<N,T>(src.Take(nati<N>()));

        /// <summary>
        /// Constructs a slice with natural length from a sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        /// <typeparam name="N">The natural type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<N,T> Freeze<N,T>(this IEnumerable<T> src)
            where N : TypeNat, new()
                => Z0.Slice.define<N,T>(src);

        /// <summary>
        /// Creates a transformed array
        /// </summary>
        /// <typeparam name="S">The source item type</typeparam>
        /// <typeparam name="T">The target item type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="transform">The transformation function</param>
        public static T[] ToArray<S, T>(this IEnumerable<S> src, Func<S, T> transform)
            => src.Select(transform).ToArray();

        /// <summary>
        /// Creates a new array from a (contiguous) subset of an existing array
        /// </summary>
        /// <typeparam name="T">The array element type</typeparam>
        /// <param name="src">The source array</param>
        /// <param name="startpos">The position of the first element of the source array </param>
        /// <param name="endpos">The position of the last element of the source array</param>
        /// <returns></returns>
        public static T[] Subset<T>(this T[] src, int startpos, int endpos)
            => array.subset(src,startpos,endpos);

        /// <summary>
        /// Defines a window over a 1-d array beginning at a specified index 
        /// for a specified length
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="start">The 0-based starting index</param>
        /// <param name="len">The length of the segment</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static IReadOnlyList<T> Segment<T>(this T[] src, uint start, uint len)
            => new ArraySegment<T>(src, (int)start, (int)len);

        /// <summary>
        /// Defines a window over a 1-d array beginning at a specified index 
        /// for a specified length
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="start">The 0-based starting index</param>
        /// <param name="len">The length of the segment</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static IReadOnlyList<T> Segment<T>(this T[] src, ulong start, ulong len)
            => new ArraySegment<T>(src, (int)start, (int)len);

        /// <summary>
        /// Reifies a Seq[T] value from an enumerable
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static Seq<T> ToSeq<T>(this IEnumerable<T> src)
                => Seq.define(src);
    
        /// <summary>
        /// Reifies an enumerable as a finite sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static FiniteSeq<T> ToFiniteSeq<T>(this IEnumerable<T> src)
            where T : Structure<T>, new()
                => Seq.finite(src);

        /// <summary>
        /// Formats a stream of formattable things
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static string Format<T>(this IEnumerable<T> src, string sep = ", ")
            where T : Formattable
                => embrace(string.Join(sep, src.Select(x => x.format())).TrimEnd());

        /// <summary>
        /// Defines missing Take(stream,n:uint) method
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="count">The number of elements to remove from the from of the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<T> Take<T>(this IEnumerable<T> src, uint count)
            => src.Take((int)count);
    }
}    