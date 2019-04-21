//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

partial class zcore
{
    /// <summary>
    /// Retrieves the value of the natural number associated with a typenat
    /// </summary>
    /// <typeparam name="N">The nat type</typeparam>
    [MethodImpl(Inline)]   
    public static ulong natval<N>() 
        where N : TypeNat, new()
            => new N().value; 

    [MethodImpl(Inline)]   
    public static intg<ulong> natg<N>() 
        where N : TypeNat, new()
            => u(new N().value); 

    /// <summary>
    /// Retrieves the value of a type natural represented as a signed integer
    /// </summary>
    /// <typeparam name="N">The nat type</typeparam>
    [MethodImpl(Inline)]   
    public static int nati<N>() 
        where N : TypeNat, new()
            => (int)natval<N>();

    /// <summary>
    /// Retrieves the value of a type natural represented as an usigned int
    /// </summary>
    /// <typeparam name="N">The nat type</typeparam>
    [MethodImpl(Inline)]   
    public static uint natui<N>() 
        where N : TypeNat, new()
            => (uint)natval<N>();

    /// <summary>
    /// Retrieves the value of a type natural represented as an integer
    /// </summary>
    /// <typeparam name="N">The nat type</typeparam>
    [MethodImpl(Inline)]   
    public static int nati<N>(N rep) 
        where N : TypeNat, new()
            => (int)rep.value;

    /// <summary>
    /// Constructs a natural representative
    /// </summary>
    /// <typeparam name="K">The representative type</typeparam>
    [MethodImpl(Inline)]   
    public static K natrep<K>()
        where K : TypeNat,new()
            => new K(); 

    /// <summary>
    /// Constructs a 1-component natural dimension
    /// </summary>
    /// <typeparam name="K">The natural type</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K> dim<K>()
        where K : TypeNat, new()
            => Dim.define<K>();

    /// <summary>
    /// Constructs a 1-component natural dimension
    /// </summary>
    /// <typeparam name="K">The natural type</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K> dim<K>(K k)
        where K : TypeNat, new()
            => Dim.define<K>();

    /// <summary>
    /// Constructs a 2-component natural dimension
    /// </summary>
    /// <typeparam name="K1">The type of the first component</typeparam>
    /// <typeparam name="K2">The type of the second component</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K1,K2> dim<K1,K2>()
        where K1 : TypeNat, new()
        where K2 : TypeNat, new()
            => Dim.define<K1,K2>();

    /// <summary>
    /// Constructs a 2-component natural dimension
    /// </summary>
    /// <typeparam name="K1">The type of the first component</typeparam>
    /// <typeparam name="K2">The type of the second component</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K1,K2> dim<K1,K2>(K1 k1, K2 k2)
        where K1 : TypeNat, new()
        where K2 : TypeNat, new()
            => Dim.define<K1,K2>();

    /// <summary>
    /// Constructs a 3-component natural dimension
    /// </summary>
    /// <typeparam name="K1">The type of the first component</typeparam>
    /// <typeparam name="K2">The type of the second component</typeparam>
    /// <typeparam name="K3">The type of the third component</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K1,K2,K3> dim<K1,K2,K3>()
        where K1 : TypeNat, new()
        where K2 : TypeNat, new()
        where K3 : TypeNat, new()
            => Dim.define<K1,K2,K3>();

    /// <summary>
    /// Constructs a 3-component natural dimension
    /// </summary>
    /// <typeparam name="K1">The type of the first component</typeparam>
    /// <typeparam name="K2">The type of the second component</typeparam>
    /// <typeparam name="K3">The type of the third component</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K1,K2,K3> dim<K1,K2,K3>(K1 k1, K2 k2, K3 k3)
        where K1 : TypeNat, new()
        where K2 : TypeNat, new()
        where K3 : TypeNat, new()
            => Dim.define<K1,K2,K3>();

}