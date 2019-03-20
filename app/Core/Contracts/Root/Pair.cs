//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using Root;


    public interface Copair<A,B>
    {
        /// <summary>
        /// The potential left value
        /// </summary>
        Option<A> left {get;}

        /// <summary>
        /// The potential right value
        /// </summary>
        Option<B> right {get;}
        
    }

    public interface Pair<A,B>
    {
        A left {get;}

        B right {get;}
    }    

    public interface Cotriple<A,B,C>
    {
        Option<A> left {get;}

        Option<C> center {get;}
        
        Option<B> right {get;}

    }

    public interface Triple<A,B,C>
    {
        A left {get;}

        C center {get;}
        
        B right {get;}

    }
}
