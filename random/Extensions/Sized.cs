//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static partial class RandomSizedX
    {        
        [MethodImpl(Inline)]
        public static Vec128<T> NextVec128<T>(this IRandomSource random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : struct
                => random.Span128<T>(1, domain, filter).ToVec128();

        [MethodImpl(Inline)]
        public static Vec256<T> NextVec256<T>(this IRandomSource random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : struct
                => random.Span256<T>(1, domain, filter).ToVec256();
        
        [MethodImpl(Inline)]
        public static M512 NextM512<T>(this IRandomSource random, Interval<T> domain, Func<T,bool> filter = null)
            where T : struct
                => m512.define(random.Stream(domain, filter).TakeSpan(64/SizeOf<T>.Size).ReadOnly());

        [MethodImpl(Inline)]
        public static m256i NextM256i<T>(this IRandomSource random, Interval<T> domain, Func<T,bool> filter = null)
            where T : struct
                => default;
        
        [MethodImpl(Inline)]
        public static M512 NextM512<T>(this IRandomSource random, Func<T,bool> filter = null)
            where T : struct
                => m512.define(random.Stream<T>(null, filter).TakeSpan(64/SizeOf<T>.Size).ReadOnly());
    }
}