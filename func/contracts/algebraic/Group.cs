//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// Characterizes group operations over a type
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IGroupOps<T> : IInvertiveOps<T>, IMonoidOps<T>
    {
        
    }


    public interface IGroupMOps<T> : IGroupOps<T>, IMonoidMOps<T>, InvertiveMOps<T>
    {

    }

    /// <summary>
    /// Characterizes additive/abelian group operations
    /// </summary>
    public interface IGroupAOps<T> : IGroupOps<T>, IMonoidAOps<T>, INegatableOps<T> 
    {

    }

    public interface IGroup<S> : IInvertive<S>, IMonoid<S>
        where S : IGroup<S>, new()
    {

    }

    public interface IGroupM<S> : IGroup<S>, IMonoidM<S>
        where S : IGroupM<S>, new()
    {
        
    }

    public interface IGroupA<S> : IGroup<S>, IMonoidA<S>, INegatable<S>
        where S : IGroupA<S>, new()
    {

    }
    /// <summary>
    /// Characterizes a group structure
    /// </summary>
    /// <typeparam name="T">The type over which the structure is defind</typeparam>
    /// <typeparam name="S">The structure type</typeparam>
    public interface IGroup<S,T> : IGroup<S>
        where S : IGroup<S,T>, new()
    {
        
    }

    /// <summary>
    /// Characterizes a multiplicative group structure
    /// </summary>
    /// <typeparam name="T">The type over which the structure is defind</typeparam>
    /// <typeparam name="S">The structure type</typeparam>
    public interface IGroupM<S,T> : IGroupM<S>, IGroup<S,T>, IMonoidM<S,T>
        where S : IGroupM<S,T>, new()
    {
        
    }


    /// <summary>
    /// Characterizes an additive group structure
    /// </summary>
    /// <typeparam name="T">The type over which the structure is defind</typeparam>
    /// <typeparam name="S">The structure type</typeparam>
    public interface IGroupA<S,T> : IGroupA<S>, IGroup<S,T>, IMonoidA<S,T>
        where S : IGroupA<S,T>, new()
    {
        
    }

}