//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Characterizes a set-theoretic pair
    /// </summary>
    /// <typeparam name="A">The type of the left value</typeparam>
    /// <typeparam name="B">The type of the left value</typeparam>
    public interface IPair<A,B>
    {
        A Left {get;}

        B Right {get;}
    }    

    /// <summary>
    /// Characterizes a set-theoretic dual to Pair
    /// </summary>
    /// <typeparam name="A">The type of the potential left value</typeparam>
    /// <typeparam name="B">The type of the potential left value</typeparam>
    public interface ICopair<A,B>
    {
        /// <summary>
        /// The potential left value
        /// </summary>
        Option<A> Left {get;}

        /// <summary>
        /// The potential right value
        /// </summary>
        Option<B> Right {get;}
        
    }

}