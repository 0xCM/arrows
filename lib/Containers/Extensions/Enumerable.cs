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
    using System.Diagnostics;
    
    using static zcore;
    using static zfunc;

    partial class xcore
    {

        /// <summary>
        /// Convenience wrapper for Enumerable.SelectMany that yields a sequence of elements from a sequence of sequences
        /// </summary>
        /// <typeparam name="T">The sequence element type</typeparam>
        /// <param name="src"></param>
        public static IEnumerable<T> Reduce<T>(this IEnumerable<IEnumerable<T>> src)
            => src.SelectMany(y => y);

        /// <summary>
        /// Prepends one or more items to the head of the sequence
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The sequence that will be prependend</param>
        /// <param name="preceding">The items that will be prepended</param>
        /// <returns></returns>
        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> src, params T[] preceding)
            => preceding.Concat(src);

        /// <summary>
        /// Partitions the source sequence into segments of natural length
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <typeparam name="N">The segment length</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<IReadOnlyList<T>> Partition<N,T>(this IEnumerable<T> src)
            where N : ITypeNat, new()
                => partition<N,T>(src);    
        
        /// <summary>
        /// Constructs a sequence of singleton sequences from a sequence of elements
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<IEnumerable<T>> Singletons<T>(this IEnumerable<T> src)
            => singletons(src);
    }
}