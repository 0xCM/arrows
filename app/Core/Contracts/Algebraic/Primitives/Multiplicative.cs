//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{


    /// <summary>
    /// Characterizes a type that defines a notion of additivity
    /// </summary>
    /// <typeparam name="A">The type subject to multiplication</typeparam>
    public interface Multiplicative<A>
    {
        A mul(A a, A b);

    }

    /// <summary>
    /// Characterizes structural multiplicativity
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="I">The individual type</typeparam>
    public interface Multiplicative<S,I> : Multiplicative<I>
    {
        

    }



}