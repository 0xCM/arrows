//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using Z0;
    using static zcore;

    partial class xcore
    {
        [MethodImpl(Inline)]   
        public static IReadOnlyList<T> Unwrap<T>(this IEnumerable<intg<T>> src)
            => src.Select(unwrap).ToList();

        [MethodImpl(Inline)]   
        public static IReadOnlyList<T> Unwrap<T>(this IEnumerable<real<T>> src)
            => src.Select(unwrap).ToList();

        [MethodImpl(Inline)]
        public static T Sum<T>(this IEnumerable<T> src)
            where T : Structures.Additive<T>, Structures.Nullary<T>, new()
                => sum(src);

        [MethodImpl(Inline)]
        public static T Sup<T>(this IEnumerable<T> src)
            where T : struct, Structures.Ordered<T>
                => max(src);

        [MethodImpl(Inline)]
        public static T Inf<T>(this IEnumerable<T> src)
            where T : struct, Structures.Ordered<T>
                => min(src);

        [MethodImpl(Inline)]
        public static IEnumerable<T> Pow<T>(this IEnumerable<T> src, int exp)
            where T : Structures.Powered<T>, new() 
                => pow(src,exp);

        [MethodImpl(Inline)]
        public static T Avg<T>(this IEnumerable<T> src)
            where T : Structures.RealNumber<T>,new()
                => avg(src);
   }
}