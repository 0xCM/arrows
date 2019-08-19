//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes an exponentiation operation
    /// </summary>
    /// <typeparam name="B">The base type</typeparam>
    /// <typeparam name="E">The exponent type</typeparam>
    public interface IPoweredOps<B,E> 
    {
        B Pow(B b, E exp);
    }

    public interface IPowered<B,E> 
        where B : IPowered<B,E>, new()
    {
        B Pow(E exp);
        
    }

    public interface INaturallyPowered<S> : IPowered<S, int>
        where S : INaturallyPowered<S>, new()
    {
    }


}