//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;

    /// <summary>
    /// Characterizes a function with non-parametric domain/codomain
    /// </summary>
    public interface Function
    {
        Type domain {get;}

        Type codomain {get;}
    }

    /// <summary>
    /// Characterizes a function with a specified domain and codomain
    /// </summary>
    /// <typeparam name="A"></typeparam>
    /// <typeparam name="B"></typeparam>
    public interface Function<in A, out B> : Function
    {
        /// <summary>
        /// Carries an element of the domain to an element of the codomain as
        /// specified by the function definition
        /// </summary>
        /// <param name="a">An element in the domain</param>
        /// <returns></returns>
        B map(A a); 

        /// <summary>
        /// The represented function expressed as a (delegate) type
        /// </summary>
        /// <returns></returns>
        Func<A,B> func {get;}

        
    }


}