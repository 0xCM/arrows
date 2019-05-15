//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface INaturalOps<T> : IIntegerOps<T>, INonNegativeOps<T> 
        where T : struct
    {}


    /// <summary>
    /// Characterizes an operation provider for bounded natural types
    /// </summary>
    /// <typeparam name="T">The type over which operations are defined</typeparam>
    public interface IFiniteNaturalOps<T> : INaturalOps<T>, IBoundRealOps<T> 
        where T : struct
    { }

    /// <summary>
    /// Characterizes operational reifications of RealFiniteUInt 
    /// </summary>        
    /// <typeparam name="R">The reification type</typeparam>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IFiniteNaturalOps<R,T> : IFiniteNaturalOps<T>
        where R : IFiniteNaturalOps<R,T>, new() 
        where T : struct
        {  

        }

    /// <summary>
    /// Characterizes a reification structure over natural types S where
    /// s:S => s ∈ {1, … n} where n is some natural number subject to the
    /// bounds implied by the underlying data structure
    /// </summary>
    /// <typeparam name="S">The type of the realizing structure</typeparam>
    public interface INatural<S> : IInteger<S>, INonNegative<S>
        where S : INatural<S>, new()
    {

    }            
}

