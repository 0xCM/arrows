//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;

    
    /// <summary>
    /// Characterizes a bounded fractional operation provider
    /// </summary>
    /// <typeparam name="T">The primitive type</typeparam>
    public interface ICurrencyOps<T> : IBoundRealOps<T>, IFractionalOps<T> 
        where T : struct

    {

    }

    /// <summary>
    /// Characterizes structural reifications of Currency 
    /// </summary>
    /// <typeparam name="S">The structural reification type</typeparam>
    public interface ICurrency<S> : IBoundReal<S>, IFractional<S>
        where S : ICurrency<S>, new()
    {

    }


}