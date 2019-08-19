//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IDiscreteGroup<S> : IGroup<S>
        where S : IDiscreteGroup<S>, new()
    {
        
    }

    /// <summary>
    /// Characterizes a discrete group structure
    /// </summary>
    /// <typeparam name="T">The operational type</typeparam>
    /// <typeparam name="S">The structure type</typeparam>
    public interface IDiscreteGroup<S,T> : IGroup<S,T>, IDiscreteSet<S,T>
        where S : IDiscreteGroup<S,T>, new()
    {

    }

    public interface IFiniteGroup<S,T> : IDiscreteGroup<S,T>
        where S : IFiniteGroup<S,T>, new()
    {


    }


    public interface IDiscreteAbelianGroup<S,T> : IGroupA<S,T>, IDiscreteSet<S,T>
        where S : IDiscreteAbelianGroup<S,T>, new()
    {

    }

    public interface IFiniteAbelianGroup<S,T> : IDiscreteAbelianGroup<S,T>, IFiniteSet<S,T>
        where S : IFiniteAbelianGroup<S,T>, new()
    {


    }


}