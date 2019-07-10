//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Numerics;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Z0;

partial class zfunc
{
    [MethodImpl(Inline)]
    public static Arrow<S,T> arrow<S,T>(S source, T target)
        => new Arrow<S,T>(source, target);    
}