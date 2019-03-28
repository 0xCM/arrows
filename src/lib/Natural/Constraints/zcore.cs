//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

public static partial class zcore
{
    /// <summary>
    /// Proves, if possible, that n1:T1 & n2:T2 => n1 == n2; otherwise
    /// raises an exception
    /// </summary>
    /// <typeparam name="T1">The left operand</typeparam>
    /// <typeparam name="T2">The right operand</typeparam>
    [MethodImpl(Inline)]   
    public static Same<T1,T2> eq<T1,T2>()
        where T1: TypeNat, new()
        where T2: TypeNat, new()
            => demand<Same<T1,T2>>(natval<T1>() == natval<T2>());

    /// <summary>
    /// Proves, if possible, that n1:T1 & n2:T2 => n1 == n2; otherwise
    /// raises an exception
    /// </summary>
    /// <typeparam name="T1">The left operand</typeparam>
    /// <typeparam name="T2">The right operand</typeparam>
    [MethodImpl(Inline)]   
    public static Different<T1,T2> neq<T1,T2>()
        where T1: TypeNat, new()
        where T2: TypeNat, new()
            => demand<Different<T1,T2>>(natval<T1>() != natval<T2>());

    /// <summary>
    /// Proves, if possible, that n1:T1, n2:T2 => n1 > n2; otherwise
    /// raises an exception
    /// </summary>
    /// <typeparam name="T1">The left operand</typeparam>
    /// <typeparam name="T2">The right operand</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Larger<T1,T2> larger<T1,T2>()
        where T1: TypeNat, new()
        where T2: TypeNat, new()
            => demand<Larger<T1,T2>>(natval<T1>() > natval<T2>());

    /// <summary>
    /// Proves, if possible, that n1:T1, n2:T2 => n1 < n2; otherwise
    /// raises an exception
    /// </summary>
    /// <typeparam name="T1">The left operand</typeparam>
    /// <typeparam name="T2">The right operand</typeparam>
    [MethodImpl(Inline)]   
    public static Smaller<T1,T2> smaller<T1,T2>()
        where T1:TypeNat, new()
        where T2:TypeNat, new()
            => demand<Smaller<T1,T2>>(natval<T1>() < natval<T2>());

    /// <summary>
    /// Proves, if possible, that n:T => n = 0; otherwise
    /// raises an exception
    /// </summary>
    /// <typeparam name="T">The operand</typeparam>
    [MethodImpl(Inline)]   
    public static Nonzero<T> nonzero<T>()
        where T: TypeNat, new()
        => demand<Nonzero<T>>(natval<T>() != 0);

    /// <summary>
    /// Proves, if possible, that n:T => n is prime; otherwise
    /// raises an exception
    /// </summary>
    /// <typeparam name="P">The operand</typeparam>
    [MethodImpl(Inline)]   
    public static Prime<P> prime<P>()
        where P : TypeNat, new()
            => demand<Prime<P>>(prime(natvalg<P>()) );

}
