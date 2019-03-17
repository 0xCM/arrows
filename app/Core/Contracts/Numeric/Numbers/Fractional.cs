//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;
    using System.Numerics;


    /// <summary>
    /// Characterizes a fractional operation provider
    /// </summary>
    /// <typeparam name="T">The primitive type</typeparam>
    public interface Fractional<T> : Arithmetic<T>, Divisive<T>
        where T : new()
    {
        T ceiling(T x);
        
        T floor(T x);   
        
    }

    /// <summary>
    /// Characterizes a bounded, structured type that admits non-whole values
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="T">The primitive type</typeparam>
    public interface Fractional<S,T> : Number<S,T>
        where S : Fractional<S,T>, new()
        where T : new()
    {
        S ceiling();
        
        S floor();   
    }
}