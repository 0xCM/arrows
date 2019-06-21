//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Creates a span of replicated characters 
    /// </summary>
    /// <param name="src"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<char> Replicate(this char src, int count)
        => new string(src,count);


}