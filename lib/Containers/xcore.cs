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
    using static zfunc;

    using static nats;

    partial class xcore
    {


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
            where T : struct, IEquatable<T>
                => Seq.finite(src);

        /// <summary>
        /// Wraps an array within an index
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static Index<T> ToIndex<T>(this T[] src)
            where T : IEquatable<T>
                => src;

        /// <summary>
        /// Wraps an array within an index
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static Index<T> ToIndex<T>(this IEnumerable<T> src)
                => src.ToArray();

        /// <summary>
        /// Constructs a semi-sequence from a stream
        /// </summary>
        /// <param name="src">The element source</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static SemiSeq<T> ToSemiSeq<T>(this IEnumerable<T> src)
            where T : struct, Structures.ISemigroup<T>
                => semiseq(src);

        /// <summary>
        /// Constructs a semi-sequence from a parameter array
        /// </summary>
        /// <param name="src">The element source</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static SemiSeq<T> ToSemiSeq<T>(this T[] src)
            where T : struct, Structures.ISemigroup<T>
                => semiseq(src);

        /// <summary>
        /// Constructs a slice from a sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<T> ToSlice<T>(this IEnumerable<T> src)
            where T : struct, IEquatable<T>
                => new Slice<T>(src);

    }
}    
