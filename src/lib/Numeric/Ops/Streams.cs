//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;


    public static partial class PrimalList
    {
        static ArgumentException mismatched<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            => new ArgumentException($"The left item count {lhs.Count} does not match the right item count {rhs.Count}");
        
        [MethodImpl(Inline)]
        static int matchedCount<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            => lhs.Count != rhs.Count ? throw mismatched(lhs,rhs) : lhs.Count;

        [MethodImpl(Inline)]
        static T[] target<T>(int count)
            => array<T>(count);

        [MethodImpl(Inline)]
        static T[] fuse<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs, Func<T,T,T> f)
        {
            var dst = target<T>(matchedCount(lhs,rhs));
            for(var i = 0; i < dst.Length ; i++)
                dst[i] = f(lhs[i], rhs[i]);
            return dst;

        }

        [MethodImpl(Inline)]
        public static IReadOnlyList<int> add(IReadOnlyList<int> lhs, IReadOnlyList<int> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<int> sub(IReadOnlyList<int> lhs, IReadOnlyList<int> rhs)
            => fuse(lhs,rhs,(x,y) => x - y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<int> mul(IReadOnlyList<int> lhs, IReadOnlyList<int> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<int> div(IReadOnlyList<int> lhs, IReadOnlyList<int> rhs)
            => fuse(lhs,rhs,(x,y) => x / y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<int> mod(IReadOnlyList<int> lhs, IReadOnlyList<int> rhs)
            => fuse(lhs,rhs,(x,y) => x % y);

    }
}
