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
    using BM = Z0.BitMatrix;

    public static partial class RngD
    {
        [MethodImpl(Inline)]
        static T TypeMin<T>()
            where T : struct
                => gmath.minval<T>();
        
        [MethodImpl(Inline)]
        static T TypeMax<T>()
            where T : struct
                => gmath.maxval<T>();

 
        [MethodImpl(Inline)]
        internal static Interval<T> Configure<T>(this Interval<T>? domain)        
            where T : struct
                => domain.ValueOrElse(() => Rng.TypeDomain<T>());



    }

}