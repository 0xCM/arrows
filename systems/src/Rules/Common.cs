//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    
    
    using static zfunc;

    public interface IRuleExpr<T>
    {
        T Value {get;}
    }

    public interface IBinaryRuleExpr<T>
    {
        T Left {get;}

        T Right {get;}
    }

    public interface IRule
    {

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

    public readonly struct LiteralExpr<T> : IRuleExpr<T>
    {
        public LiteralExpr(T Value)
            => this.Value = Value;
        
        public T Value {get;}
    }

    public readonly struct BooleanExpr<X> 
        where X : struct
    {

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

}