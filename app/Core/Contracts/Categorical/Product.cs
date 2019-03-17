//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;

    /// <summary>
    /// Characterizes a categorical product
    /// </summary>
    public interface Product<X,Y>
    {

    }

    /// <summary>
    /// Characterizes a categorical coproduct
    /// </summary>
    /// <typeparam name="F"></typeparam>
    /// <typeparam name="G"></typeparam>
    /// <typeparam name="C"></typeparam>
    public interface Coproduct<F,G,C> 
    {
        Function<F, Copair<F, G>> left {get;}

        Function<G, Copair<F, G>> right {get;}

        Function<Copair<F, G>,C> unique {get;}

    }
}