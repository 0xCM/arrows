//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public interface IRule 
    {
        string RuleName {get;}

        uint Arity {get;}
    }

    /// <summary>
    /// Characterizes a rule / function A->B
    /// </summary>
    /// <typeparam name="A">The function domain</typeparam>
    /// <typeparam name="B">The function codomain</typeparam>
    /// <remarks>The only difference between a rule and a function is 
    /// that a rule is presented as structure</remarks>
    public interface IRule<in A, out B> : IRule
    {
        /// <summary>
        /// Carries an element of the domain to an element of the codomain as
        /// specified by the function definition
        /// </summary>
        /// <param name="src">An element in the domain</param>
        B apply(A src); 

    }

    /// <summary>
    /// Characterizes a rule / function (A,B) -> C
    /// </summary>
    /// <typeparam name="A">The left function domain</typeparam>
    /// <typeparam name="B">The right function domain</typeparam>
    /// <typeparam name="C">The function codomain</typeparam>
    /// <remarks>The only difference between a rule and a function is 
    /// that a rule is presented as structure</remarks>
    public interface IRule<in A, in B, out C> : IRule
    {
        /// <summary>
        /// Carries an element of the domain to an element of the codomain as
        /// specified by the function definition
        /// </summary>
        /// <param name="src">An element in the domain</param>
        C apply(A a, B b); 

    }


    /// <summary>
    /// Characterizes a function realization
    /// </summary>
    /// <typeparam name="A">The function domain</typeparam>
    /// <typeparam name="B">The function codomain</typeparam>
    public interface IRuled<F,in A, out B> : IRule<A,B>
        where F : IRuled<F,A,B>, new()
    {

    }   

    /// <summary>
    /// Characterizes a function realization
    /// </summary>
    /// <typeparam name="A">The left function domain</typeparam>
    /// <typeparam name="B">The right function domain</typeparam>
    /// <typeparam name="C">The function codomain</typeparam>
    public interface IRuled<F, in A, in B, out C> : IRule<A,B,C>
        where F : IRuled<F,A,B,C>, new()
    {

    }         


}