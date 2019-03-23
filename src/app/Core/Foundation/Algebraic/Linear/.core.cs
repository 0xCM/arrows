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

using Core;
using static Core.Credit;
using static corefunc;


public static partial class corefunc
{
    /// <summary>
    /// Constructs a vector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Vector<N,T> vector<N,T>(params T[] components)
        where N : TypeNat, new()
            => new Core.Vector<N,T>(components);

    public static Vector<N,T> vector<N,T>(T component)
        where N : TypeNat, new()
            => new Vector<N,T>(repeat<N,T>(component));

    /// <summary>
    /// Constructs a vector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Vector<N,T> vector<N,T>(IEnumerable<T> components)
        where N : TypeNat, new()
            => new Vector<N,T>(components);

    /// <summary>
    /// Constructs a vector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <remarks>No allocation occurs during construction</remarks>
    public static Vector<N,T> vector<N,T>(IReadOnlyList<T> components)
        where N : TypeNat, new()
            => new Vector<N,T>(components);

    /// <summary>
    /// Constructs a covector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Covector<N,T> covector<N,T>(params T[] components)
        where N : TypeNat, new()
            => new Covector<N,T>(components);

    /// <summary>
    /// Constructs a covector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Covector<N,T> covector<N,T>(IReadOnlyList<T> components)
        where N : TypeNat, new()
            => new Covector<N,T>(components);

}