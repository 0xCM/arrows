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
        [MethodImpl(Inline)]
        public static Slice<N,T> NatSlice<N,T>(this Z0.TypeNat<N> n, IEnumerable<T> src)
            where N : TypeNat, new()
            where T : Equatable<T>, new()
                => new Slice<N, T>(src);

        [MethodImpl(Inline)]
        public static Slice<N,T> NatSlice<N,T>(this Z0.TypeNat<N> n, params T[] src)
            where N : TypeNat, new()
            where T : Equatable<T>, new()
                => new Slice<N, T>(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> ToVector<N,T>(this Slice<N,T> src)
            where N : TypeNat, new()
            where T : Equatable<T>, new()
                => vector<N,T>(src.data);

        /// <summary>
        /// Constructs a slice from a supplied sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<T> Freeze<T>(this IEnumerable<T> src)
            where T : Equatable<T>, new()
                => Z0.Slice.define(src);

        /// <summary>
        /// Constructs a slice with natural length from a sequence of elements
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        /// <typeparam name="N">The natural type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<N,T> Freeze<N,T>(this IEnumerable<T> src)
            where N : TypeNat, new()
            where T : Equatable<T>, new()
                => Z0.Slice.define<N,T>(src);

        [MethodImpl(Inline)]
        public static IEqualityComparer<T> ToEqualityComparer<T>(this Equality<T> eq)
            => new EqualityComparer<T>(eq);

        /// <summary>
        /// Creates a transformed array
        /// </summary>
        /// <typeparam name="S">The source item type</typeparam>
        /// <typeparam name="T">The target item type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="transform">The transformation function</param>
        /// <returns></returns>
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
            where T : IEquatable<T>
                => Seq.finite(src);


    }
}    
