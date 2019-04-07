//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------

using System;
using System.Numerics;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Z0;

partial class zcore
{
    /// <summary>
    /// Provides the primitive numeric operations for a specified type 
    /// if they exist; otherwise, raises an error
    /// </summary>
    /// <typeparam name="T">The type for which primitive operations are desired</typeparam>
    public static Operative.PrimOps<T> primops<T>()
        => PrimOps.get<T>();

    /// <summary>
    /// Provides the primitive numeric operations for a specified type 
    /// if they exist; otherwise, raises an error
    /// </summary>
    /// <param name="exemplar">An instance of the type to permit inference</param>
    /// <typeparam name="T">The type for which primitive operations are desired</typeparam>
    public static Operative.PrimOps<T> primops<T>(T exemplar)
        => PrimOps.get<T>();
}
