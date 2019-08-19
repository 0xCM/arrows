//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;

    public interface IDecrementableOps<T> 
    {
        T Dec(T x);        
    }

    public interface IIncrementableOps<T>
    {
        T Inc(T x);        
    }

    /// <summary>
    /// Characterizes a type that realizes both incrementing and decrementing operations
    /// </summary>
    /// <typeparam name="T">The target type</typeparam>
    public interface IStepwiseOps<T> : IIncrementableOps<T>, IDecrementableOps<T>
    {
        
    }

    public interface IDecrementable<S> : IOrderable<S>
        where S : IDecrementable<S>, new()
    {
        S Dec();
    }

    public interface IIncrementable<S> : IOrderable<S>
        where S : IIncrementable<S>, new()
    {
        S Inc();        
    }

    /// <summary>
    /// Characterizes a structure over which both incrementing and decrementing 
    /// operations are defined
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    public interface IStepwise<S> : IIncrementable<S>, IDecrementable<S>
        where S : IStepwise<S>, new()
    {

    }

}