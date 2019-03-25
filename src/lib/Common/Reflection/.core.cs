//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;
using static corefunc;


partial class corefunc
{
    /// <summary>
    /// Gets the assembly in which the parametrized type is defined
    /// </summary>
    [MethodImpl(Inline)]
    public static Assembly assembly<T>()
        => typeof(T).Assembly;
}
