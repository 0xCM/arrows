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
using static zcore;

public static partial class zcore
{
    /// <summary>
    /// Constructs a vector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The vector length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [MethodImpl(Inline)]   
    public static Vector<N,T> vector<N,T>(params T[] components)
        where N : TypeNat, new()
        where T : struct, IEquatable<T>
            => new Z0.Vector<N,T>(components);

    /// <summary>
    /// Constructs a vector where each component has the same value
    /// </summary>
    /// <param name="component">The value assigned to each component</param>
    /// <typeparam name="N">The vector length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [MethodImpl(Inline)]   
    public static Vector<N,T> vector<N,T>(T component)
        where N : TypeNat, new()
        where T : struct, IEquatable<T>
            => new Vector<N,T>(repeat<N,T>(component));

    /// <summary>
    /// Constructs a vector characterized by length and component type
    /// </summary>
    /// <param name="components">The components with which to construct the vector</param>
    /// <typeparam name="N">The vector length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Vector<N,T> vector<N,T>(IEnumerable<T> components)
        where N : TypeNat, new()
        where T : struct, IEquatable<T>
            => Vector.define(natrep<N>(), components);

    /// <summary>
    /// Constructs a vector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [MethodImpl(Inline)]   
    public static Vector<N,T> vector<N,T>(N len, IEnumerable<T> components)
        where N : TypeNat, new()
        where T : struct, IEquatable<T>
            => Vector.define(len,components);

    /// <summary>
    /// Constructs a vector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <remarks>No allocation occurs during construction</remarks>
    public static Vector<N,T> vector<N,T>(N len, IReadOnlyList<T> components)
        where N : TypeNat, new()
        where T : struct, IEquatable<T>
            => Vector.define(len,components);

    /// <summary>
    /// Constructs a covector from sequence of components
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The covector length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [MethodImpl(Inline)]   
    public static Covector<N,T> covector<N,T>(Dim<N> dim, params T[] components)
        where N : TypeNat, new()
        where T : struct, IEquatable<T>
            => Covector.define<N,T>(dim, components);

    /// <summary>
    /// Constructs a covector from a sequence of components
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The covector length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [MethodImpl(Inline)]   
    public static Covector<N,T> covector<N,T>(IEnumerable<T> components)
        where N : TypeNat, new()
        where T : struct, IEquatable<T>
            => Covector.define<N,T>(components);

    /// <summary>
    /// Constructs a covector from a component parameter array
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The covector length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [MethodImpl(Inline)]   
    public static Covector<N,T> covector<N,T>(params T[] components)
        where N : TypeNat, new()
        where T : struct, IEquatable<T>
            => Covector.define<N,T>(components);
}