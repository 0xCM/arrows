//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;    
using Z0;


using static zcore;
using static Z0.Traits;

partial class zcore
{
    /// <summary>
    /// Provides the primitive numeric operations for a specified type 
    /// if they exist; otherwise, raises an error
    /// </summary>
    /// <typeparam name="T">The type for which primitive operations are desired</typeparam>
    public static PrimOps<T> primops<T>()
        => PrimOps<T>.Inhabitant;

    /// <summary>
    /// Provides the primitive numeric operations for a specified type 
    /// if they exist; otherwise, raises an error
    /// </summary>
    /// <param name="exemplar">An instance of the type to permit inference</param>
    /// <typeparam name="T">The type for which primitive operations are desired</typeparam>
    public static PrimOps<T> primops<T>(T exemplar)
        => PrimOps<T>.Inhabitant;

}