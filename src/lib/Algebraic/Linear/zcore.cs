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
using static Z0.Bibliography;
using static zcore;


public static partial class zcore
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
        where T : Operative.Equatable<T>, new()            
            => new Z0.Vector<N,T>(components);

    [MethodImpl(Inline)]   
    public static Vector<N,T> vector<N,T>(T component)
        where N : TypeNat, new()
        where T : Operative.Equatable<T>, new()            
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
        where T : Operative.Equatable<T>, new()            
            => Vector.define(dim<N>(),components);

    /// <summary>
    /// Constructs a vector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Vector<N,T> vector<N,T>(Dim<N> dim, IEnumerable<T> components)
        where N : TypeNat, new()
        where T : Operative.Equatable<T>, new()            
            => Vector.define(dim,components);

    /// <summary>
    /// Constructs a vector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <remarks>No allocation occurs during construction</remarks>
    public static Vector<N,T> vector<N,T>(Dim<N> dim, IReadOnlyList<T> components)
        where N : TypeNat, new()
        where T : Operative.Equatable<T>, new()            
            => Vector.define(dim,components);


    /// <summary>
    /// Constructs a covector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Covector<N,T> covector<N,T>(Dim<N> dim, params T[] components)
        where N : TypeNat, new()
        where T : Operative.Equatable<T>, new()            
            => Covector.define<N,T>(dim, components);

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
        where T : Operative.Equatable<T>, new()            
            => Covector.define<N,T>(components);

}