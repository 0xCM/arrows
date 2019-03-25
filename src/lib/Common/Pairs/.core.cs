//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

public static partial class corefunc
{

    /// <summary>
    /// Constructs a left-valuedcopair
    /// </summary>
    /// <param name="left"></param>
    /// <typeparam name="A">The left type</typeparam>
    /// <typeparam name="B">The right type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Copair<A,B> copair<A,B>(A left)
        => new Copair<A, B>(left);

    /// <summary>
    /// Constructs a right-valued copair
    /// </summary>
    /// <param name="right"></param>
    /// <typeparam name="A">The left type</typeparam>
    /// <typeparam name="B">The right type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Copair<A,B> copair<A,B>(B right)
        => new Copair<A, B>(right);

    /// <summary>
    /// Extracts a pair's left member
    /// </summary>
    /// <param name="pair">The source pair</param>
    /// <typeparam name="A">The left member type</typeparam>
    /// <typeparam name="B">The right member type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static A left<A,B>(Pair<A,B> pair)
        => pair.left;

    /// <summary>
    /// Extracts a pair's right member
    /// </summary>
    /// <param name="pair">The source pair</param>
    /// <typeparam name="A">The left member type</typeparam>
    /// <typeparam name="B">The right member type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static B right<A,B>(Pair<A,B> pair)
        => pair.right;

    /// <summary>
    /// Constructs a pair
    /// </summary>
    /// <param name="a">The value of the left member</param>
    /// <param name="b">The value of the right member</param>
    /// <typeparam name="A">The left member type</typeparam>
    /// <typeparam name="B">The right member type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Pair<A,B> pair<A,B>(A a, B b)
        => new Pair<A,B>(a,b);

    /// <summary>
    /// Constructs an elementwise cartesian product from the input sequences
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static IEnumerable<Pair<T,T>> cross<T>(IEnumerable<T> x, IEnumerable<T> y)
        => from a in x from b in y select pair(a,b);

}