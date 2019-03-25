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
using static Z0.Credit;
using static corefunc;
using static Z0.Traits;


public static partial class corefunc
{

   /// <summary>
    /// Constructs a non-valued option
    /// </summary>
    /// <typeparam name="A">The underlying type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Option<A> none<A>() 
        => Option.none<A>();
    
    /// <summary>
    /// Constructs a valued option
    /// </summary>
    /// <param name="value">The option value</param>
    /// <typeparam name="A">The underlying type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Option<A> some<A>(A value) 
        => new Option<A>(value);


}