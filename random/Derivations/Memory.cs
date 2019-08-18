//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class RngX
    {

        [MethodImpl(Inline)]
        public static Memory<T> Memory<T>(this IRandomSource random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var stream = domain != null ? random.Stream<T>(domain.Value) : random.Stream<T>();
            return stream.TakeMemory(length);
        }

        [MethodImpl(Inline)]
        public static Memory<T> Memory<T>(this IRandomSource random, int length, Interval<T> domain)
            where T : struct
            => random.Stream<T>(domain).TakeMemory(length);

        [MethodImpl(Inline)]
        public static Memory<T> NonZeroMemory<T>(this IRandomSource random, int samples, Interval<T>? domain = null)
                where T : struct
                    => random.Memory<T>(samples, domain, gmath.nonzero);        
    }

}