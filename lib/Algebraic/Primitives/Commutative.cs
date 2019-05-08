//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using static zcore;

    /// <summary>
    /// Characterizes commutative operations
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface ICommutativeOps<T>
    {

    }

    /// <summary>
    /// Characterizes structural commutativity
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    public interface ICommutative<S>
        where S : ICommutative<S>, new()
    {

    }

}