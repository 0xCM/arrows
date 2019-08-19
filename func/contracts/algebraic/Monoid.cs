//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;


    /// <summary>
    /// Characterizes monoidal operations
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IMonoidOps<T> : ISemigroupOps<T>
    {


    }

    public interface IMonoidalOps<T> : IMonoidOps<T>
    {
        T Identity {get;}
        
        T Compose(T lhs, T rhs);
    }

    /// <summary>
    /// Characterizes multiplicative monoidal operations
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IMonoidMOps<T> : IMonoidOps<T>, ISemigroupMOps<T>, IUnitalOps<T>
    {

    }

    /// <summary>
    /// Characterizes additive monoidal operations
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IMonoidAOps<T> : IMonoidOps<T>, ISemigroupAOps<T>, INullaryOps<T>
    {
        
    }

    public interface IMonoid<S> : ISemigroup<S>
        where S : IMonoid<S>, new()
    {

    }

    /// <summary>
    /// Characterizes monoidal structure
    /// </summary>
    /// <typeparam name="S">The classified structure</typeparam>
    /// <typeparam name="T">The underlying type</typeparam>
    public interface IMonoid<S,T> : IMonoid<S>, ISemigroup<S,T>
        where S : IMonoid<S,T>, new()
    {
        
    }            

    public interface IMonoidM<S> : IMonoid<S>, ISemigroupM<S>, IUnital<S>
        where S: IMonoidM<S>, new()
    {

    }

    public interface IMonoidA<S> : IMonoid<S>, ISemigroupA<S>, INullary<S>
        where S : IMonoidA<S>, new()
    {

    }

    /// <summary>
    /// Characterizes multiplicative monoidal structure
    /// </summary>
    /// <typeparam name="S">The classified structure</typeparam>
    /// <typeparam name="T">The underlying type</typeparam>
    public interface IMonoidM<S,T> : IMonoidM<S>, IMonoid<S,T>, ISemigroupM<S,T>
        where S : IMonoidM<S,T>, new()
    {

    }            

    /// <summary>
    /// Characterizes additive monoidal structure
    /// </summary>
    /// <typeparam name="S">The classified structure</typeparam>
    /// <typeparam name="T">The underlying type</typeparam>
    public interface IMonoidA<S,T> :  IMonoidA<S>, IMonoid<S,T>, ISemigroupA<S,T>
        where S : IMonoidA<S,T>, new()
    {

    }            

}