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
            where T : Equality<T>, new()
                => new Slice<N, T>(src);

        [MethodImpl(Inline)]
        public static Slice<N,T> NatSlice<N,T>(this Z0.TypeNat<N> n, params T[] src)
            where N : TypeNat, new()
            where T : Equality<T>, new()
                => new Slice<N, T>(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> ToVector<N,T>(this Slice<N,T> src)
            where N : TypeNat, new()
            where T : Equality<T>, new()
                => vector<N,T>(src.data);


        /// <summary>
        /// Constructs a slice from a supplied sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<T> ToSlice<T>(this IEnumerable<T> src)
            where T : Equality<T>, new()
                => Z0.Slice.define(src);

        /// <summary>
        /// Constructs a slice with natural length from a sequence of elements
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        /// <typeparam name="N">The natural type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<N,T> ToSlice<N,T>(this IEnumerable<T> src)
            where N : TypeNat, new()
            where T : Equality<T>, new()
                => Z0.Slice.define<N,T>(src);
 

    }
}    
