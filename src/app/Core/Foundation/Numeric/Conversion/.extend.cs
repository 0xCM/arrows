//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;    
using System.Text;
using Core;

using C = Core.Contracts;

using static corefunc;
using static Core.Operations;


public static partial class ConversionX
{
    [MethodImpl(Inline)]   
    public static IReadOnlyList<T> Unwrap<T>(this IEnumerable<intg<T>> src)
        => src.Select(x => x.data).ToList();





}

