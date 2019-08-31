//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    
    
    using static zfunc;

    public interface IRuleExpr
    {
        
    }

    public interface IRuleExpr<T> : IRuleExpr
    {
        T Value {get;}
    }

    public interface IBinaryRuleExpr<T> : IRuleExpr
    {
        T Left {get;}

        T Right {get;}
    }

    public interface IRule
    {
        int RuleId {get;}
    }
    
    public interface IRule<T> : IRule
    {
        T Subject {get;}
    }

    public interface IRule<T,P1> : IRule<T>
        where P1 : struct
    {
        P1 Param1 {get;}
    }

    public interface IRule<T,P1,P2> : IRule<T,P1>
        where P1 : struct
        where P2 : struct

    {
        P2 Param2 {get;}
    }


    public interface IRuleEvaluator<T,R,X>
        where T : struct
        where R : struct, IRule
        where X : struct, IRuleExpr<T>
    {
        bool Satisfies(R rule, X test);
    }

    public interface IBooleanOp<T>
    {

    }

    /// <summary>
    /// Characterizes an operator that accepts a single operand and determines
    /// the truth value of the operand according to the operator definition
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IUnaryBooleanOp<T> : IBooleanOp<T>
    {
        bool Evaluate(T lhs);
    }

    /// <summary>
    /// Characterizes an operator that accepts two operands and determines
    /// the truth value of the operands according to the operator definition
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IBinaryBooleanOp<T> : IBooleanOp<T>
    {
        bool Evaluate(T lhs, T rhs);

    }

    public interface IFunctionRule 
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
    public interface IFunctionRule<in A, out B> : IFunctionRule
    {
        /// <summary>
        /// Carries an element of the domain to an element of the codomain as specified by the function definition
        /// </summary>
        /// <param name="src">An element in the domain</param>
        B Apply(A src); 

    }

    /// <summary>
    /// Characterizes a rule / function (A,B) -> C
    /// </summary>
    /// <typeparam name="A">The left function domain</typeparam>
    /// <typeparam name="B">The right function domain</typeparam>
    /// <typeparam name="C">The function codomain</typeparam>
    /// <remarks>The only difference between a rule and a function is 
    /// that a rule is presented as structure</remarks>
    public interface IFunctionRule<in A, in B, out C> : IFunctionRule
    {
        /// <summary>
        /// Carries an element of the domain to an element of the codomain as specified by the function definition
        /// </summary>
        /// <param name="src">An element in the domain</param>
        C Apply(A a, B b); 
    }

    /// <summary>
    /// Characterizes a function realization as determined by a set of function rules
    /// </summary>
    /// <typeparam name="A">The function domain</typeparam>
    /// <typeparam name="B">The function codomain</typeparam>
    public interface IRuledFunction<F,in A, out B> : IFunctionRule<A,B>
        where F : IRuledFunction<F,A,B>, new()
    {

    }   

    /// <summary>
    /// Characterizes a function realization as determined by a set of function rules
    /// </summary>
    /// <typeparam name="A">The left function domain</typeparam>
    /// <typeparam name="B">The right function domain</typeparam>
    /// <typeparam name="C">The function codomain</typeparam>
    public interface IRuledFunction<F, in A, in B, out C> : IFunctionRule<A,B,C>
        where F : IRuledFunction<F,A,B,C>, new()
    {

    }         


}