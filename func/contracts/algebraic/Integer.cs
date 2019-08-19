//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using static zfunc;

    /// <summary>
    /// Characterizes operations over an integer type
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IIntegerOps<T> : IRealNumberOps<T>, IStepwiseOps<T>, IBitwiseOps<T> 
        where T : struct
    { 

    }

    public interface IFiniteIntOps<T> : IIntegerOps<T>, IBoundRealOps<T> 
        where T : struct
    { 

    }

    /// <summary>
    /// Characterizes operations over unbound integers
    /// </summary>
    public interface IInfiniteIntOps<T> : IIntegerOps<T>, IInfiniteOps<T> 
        where T : struct
    { 

    }

    /// <summary>
    /// Characterizes operations over a signed interal type
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface ISignedIntOps<T> : IIntegerOps<T>, ISignableOps<T>, ISubtractiveOps<T> 
        where T : struct
    { 

    }

    /// <summary>
    /// Characterizes operations over a signed, finite interal type
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IFiniteSignedIntOps<T> : ISignedIntOps<T>, IBoundRealOps<T> 
        where T : struct
    { 

    } 

    /// <summary>
    /// Characterizes operations over an unbound signed integral type
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IInfiniteSignedIntOps<T> : IInfiniteIntOps<T>, ISignedIntOps<T> 
        where T : struct
    {

    }

    public interface IInteger<S> :  IRealNumber<S>, IStepwise<S>, IBitwise<S> 
        where S : IInteger<S>, new()
    { }

    /// <summary>
    /// Characterizes a reification structure over an integer type
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    /// <typeparam name="T">The underlying type</typeparam>
    public interface IInteger<S,T> : IInteger<S>
        where S : IInteger<S,T>, new() { }
}