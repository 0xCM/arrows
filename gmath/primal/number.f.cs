//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;
using System.Diagnostics;

using Z0;
using static zfunc;

partial class mfunc
{

    public static numbers<T> numbers<T>(Span<T> src)
        where T : struct, IEquatable<T>
            => src;

    public static numbers<T> numbers<T>(ReadOnlySpan<T> src)
        where T : struct, IEquatable<T>
            => src.ToArray();

}