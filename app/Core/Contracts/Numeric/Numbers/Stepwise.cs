//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;
    using System.Numerics;

    public interface Decrementable<T>
        where T : new()
    {
        T dec(T x);        
    }

    public interface Decrementable<S,T>
        where S : Decrementable<S,T>, new()
        where T : new()
    {
        S dec();
    }

    public interface Incrementable<T>
        where T : new()
    {
        T inc(T x);        
    }

    public interface Incrementable<S,T> : Number<S,T>
        where S : Incrementable<S,T>, new()
        where T : new()
    {
        S inc();        
    }

    public interface Stepwise<T> : Incrementable<T>, Decrementable<T>
        where T : new()
    {
        
    }

    public interface Stepwise<S,T> : Incrementable<S,T>, Decrementable<S,T>
        where S : Stepwise<S,T>, new()
        where T : new()
    {

    }

}