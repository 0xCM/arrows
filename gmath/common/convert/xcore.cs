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
    using System.Text;

    using static zcore;
    using static mfunc;

    public static class ConvertX
    {

        [MethodImpl(Inline)]
        public static long ToLong(this Decimal? src)
            => (long)src.ValueOrDefault();

        [MethodImpl(Inline)]
        public static long? ToNullableLong(this Decimal? src)
            => (long?)src.ValueOrDefault();

        [MethodImpl(Inline)]
        public static int ToInt(this Decimal? src)
            => (int)src.ValueOrDefault();

        [MethodImpl(Inline)]
        public static int? ToNullableInt(this Decimal? src)
            => (int?)src.ValueOrDefault();

    }

}