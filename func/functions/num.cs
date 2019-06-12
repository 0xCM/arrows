//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;

partial class zfunc
{

    [MethodImpl(Inline)]
    public static bool testbit(in ulong src, in int pos)
        => (src & (U64One << pos)) != 0ul;


    [MethodImpl(Inline)]
    public static Span<float> floats<T>(params T[] src)
        where T : struct
            =>  convert<T,float>(src.ToReadOnlySpan());

    [MethodImpl(Inline)]
    public static Span<double> doubles<T>(params T[] src)
        where T : struct
            =>  convert<T,double>(src.ToReadOnlySpan());

}