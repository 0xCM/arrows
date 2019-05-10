//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using static Operative;

    public interface IRealNumberOps<T> : IOrderedNumberOps<T>, ITrigonmetricOps<T>
        where T : struct, IEquatable<T>

    {

    }

    /// <summary>
    /// Characterizes operations over (ordered) values that 
    /// exist between upper and lower bounds
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IBoundRealOps<T> : IRealNumberOps<T>
        where T : struct, IEquatable<T>
    {

    }

    /// <summary>
    /// Characterizes a structured real
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    public interface IRealNumber<S> : IOrderedNumber<S>, ITrigonmetric<S>, IComparable<S>
        where S : IRealNumber<S>, new()
    {

    }

    public interface IBoundReal<S> :  IRealNumber<S>
        where S : IBoundReal<S>, new()
    {

    }


    /// <summary>
    /// Characterizes a reification structure over real numbers
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    /// <typeparam name="T">The underlying type</typeparam>
    public interface IRealNumber<S,T> : IRealNumber<S>
        where S : IRealNumber<S,T>, new()
    {

    }

}