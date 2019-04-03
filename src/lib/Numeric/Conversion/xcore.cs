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
using Z0;


using static zcore;


partial class xcore
{

    [MethodImpl(Inline)]
    public static long ToLong(this Decimal? src)
        => (long)(src.ValueOrDefault(0));

    [MethodImpl(Inline)]
    public static long? ToNullableLong(this Decimal? src)
        => src.HasValue ? (long)src.Value : (long?)null;

    [MethodImpl(Inline)]
    public static int ToInt(this Decimal? src)
        => (int)(src.ValueOrDefault(0));

    [MethodImpl(Inline)]
    public static int? ToNullableInt(this Decimal? src)
        => src.HasValue ? (int)src.Value : (int?)null;

}

