//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{


    /// <summary>
    /// Characterizes a type that defines a notion of additivity
    /// </summary>
    /// <typeparam name="T">The type subject to multiplication</typeparam>
    public interface Multiplicative<T> : Operational<T>
    {
        T mul(T a, T b);

    }

    /// <summary>
    /// Characterizes structural multiplicativity
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="T">The individual type</typeparam>
    public interface Multiplicative<S,T> : Structural<S,T>
        where S : Multiplicative<S,T>, new()
        where T : new()
    {
        S mul(S a);

    }



}