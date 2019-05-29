//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static MathSym;
    using AsciCompound = AsciSym.Compound;

    public enum NumericKind : byte
    {
        /// <summary>
        /// Classifier for system-defined numeric types, more specifically, those 
        /// types which listed in the PrimalKind enumeration
        /// </summary>
        Native = 0,

        /// <summary>
        /// Identifies the custom generic number type, num[T]
        /// </summary>
        Number = 1,

        /// <summary>
        /// Identifies a 128-bit intrinsic scalar
        /// </summary>
        Num128 = 2,

        /// <summary>
        /// Identifies a 128-bit intrinsic vector
        /// </summary>
        Vec128 = 3,

        /// <summary>
        /// Identifies a 256-bit intrinsic scalar
        /// </summary>
        Num256 = 4,
        
        /// <summary>
        /// Identifies a 256-bit intrinsic vector
        /// </summary>
        Vec256 = 5,

        Default = Native
    }

    public enum NumericSystem : byte
    {
        Primal = 0,

        Intrinsic = 1
    }


    public enum Genericity : byte
    {
        Direct = 1,


        Generic = 2,

        Default = Direct,

    }

    public enum OpArity : byte
    {
        None = 0,
        
        /// <summary>
        /// Indicates an operator that accepts one input
        /// </summary>
        Unary = 1,


        /// <summary>
        /// Indicates an operator that accepts two inputs, normally described by "left" and "right"
        /// </summary>
        Binary = 2,

        /// <summary>
        /// Indicates an operator that accepts three inputs
        /// </summary>
        Ternary = 3,

        /// <summary>
        /// Indicates an operator that accepts a single input which
        /// can be partitioned into a finite number of elements
        /// </summary>
        UnaryCollection = 10,
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class ArityAttribute : Attribute
    {
        public ArityAttribute(OpArity Arity)
            => this.Arity = Arity;

        public OpArity Arity {get;} 
    }
    public enum OpFusion : byte
    {
        Atomic,

        Fused,
        
    }

    public enum OpRole : byte
    {
        Baseline,

        Benchmark,

    }

    public enum OpVariance : byte
    {        
        /// <summary>
        /// Indicates that an operator does not modify its operands
        /// </summary>
        In,

        /// <summary>
        /// Indicates that an operator may modify one or more operands
        /// </summary>
        Ref,

        /// <summary>
        /// Indicates that an operator must modify one or more operands
        /// </summary>
        Out,        
    }
    

    public enum OpKind : byte
    {        
        None = 0,

        /// <summary>
        /// Indicates a binary operator that computes the sum of the left
        /// and right operands
        /// </summary>
        [Symbol(AsciSym.Plus), Arity(OpArity.Binary)]
        Add,

        /// <summary>
        /// Indicates a binary operator that computes the difference between
        /// the left and right operands
        /// </summary>
        [Symbol(AsciSym.Minus), Arity(OpArity.Binary)]
        Sub,

        /// <summary>
        /// Indicates a binary predicate that computes the product of the left
        /// and right operands
        /// </summary>
        [Symbol(AsciSym.Star), Arity(OpArity.Binary)]
        Mul,

        /// <summary>
        /// Indicates a binary operator that divides the left operand by the
        /// right operand
        /// </summary>
        [Symbol(AsciSym.FSlash), Arity(OpArity.Binary)]
        Div,
        
        /// <summary>
        /// Indicates a binary operator that computes the modulus of the source operands
        /// </summary>
        [Symbol(AsciSym.Percent), Arity(OpArity.Binary)]
        Mod,

        /// <summary>
        /// Indicates a binary operator that computes the bitwise and of the source operands
        /// </summary>
        [Symbol(AsciSym.Amp), Arity(OpArity.Binary)]
        And,

        /// <summary>
        /// Indicates a binary operator that computes the bitwise or of the source operands
        /// </summary>
        [Symbol(AsciSym.Pipe), Arity(OpArity.Binary)]
        Or,

        /// <summary>
        /// Indicates a binary operator that computes the bitwise xor of the source operands
        /// </summary>
        [Symbol(AsciSym.Caret), Arity(OpArity.Binary)]
        XOr,

        /// <summary>
        /// Indicates a left-shift bitwise operator
        /// </summary>
        [Symbol(AsciCompound.LShift), Symbol(MathSym.LT2,false), Arity(OpArity.Binary)]
        LShift,

        /// <summary>
        /// Indicates a right-shift bitwise operator
        /// </summary>
        [Symbol(AsciCompound.RShift), Symbol(MathSym.GT2, false)]
        RShift,

        [Symbol(AsciSym.Tilde), Arity(OpArity.Unary)]
        Flip,

        [Arity(OpArity.Binary)]
        TestBit,

        [Arity(OpArity.Binary)]
        ToggleBit,

        /// <summary>
        /// Indicates a unary operator that flips the sign of a signed number
        /// </summary>
        [Symbol(AsciSym.Minus), Arity(OpArity.Unary)]
        Negate,

        /// <summary>
        /// Indicates a unary operator that increments a value by a unit
        /// </summary>
        [Symbol(AsciCompound.Increment), Arity(OpArity.Unary)]
        Inc,

        /// <summary>
        /// Indicates a unary operator that decrements a value by a unit
        /// </summary>
        [Symbol(AsciCompound.Decrement), Arity(OpArity.Unary)]
        Dec,

        New,

        /// <summary>
        /// Indicates a unary operator that computes the absolute value of a signed number
        /// </summary>
        [Symbol(MathSym.Abs), Arity(OpArity.Unary)]
        Abs,

        /// <summary>
        /// Indicates an aggregate unary operator that calculates the
        /// sum of the operand constituents
        /// </summary>
        [Symbol(MathSym.Sum)]
        Sum,

        /// <summary>
        /// Indicates an aggregate unary operator that calculates the
        /// average of the operand constituents
        /// </summary>
        [Arity(OpArity.UnaryCollection)]
        Avg,
        
        /// <summary>
        /// Indicates a unary aggregate operator calculates the maximum value contained in a collection
        /// </summary>
        [Arity(OpArity.UnaryCollection)]
        Max,

        /// <summary>
        /// Indicates a unary aggregate operator calculates the minimum value contained in a collection
        /// </summary>
        [Arity(OpArity.UnaryCollection)]
        Min,


        [Symbol(Arrows.RightSquiggle)]
        Stream,

        /// <summary>
        /// Indicates a binary float comparison predicate
        /// </summary>
        [Arity(OpArity.Binary)]
        FCmp,
 
        /// <summary>
        /// Indicates a binary predicate that adjudicates operand equality
        /// </summary>
        [Symbol(AsciCompound.Eq), Arity(OpArity.Binary)]
        Eq,
        
        /// <summary>
        /// Indicates a binary predicate that determines whether the left
        /// operand is strictly larger than the right operand
        /// </summary>
        [Symbol(AsciSym.Gt), Arity(OpArity.Binary)]
        Gt,
        
        /// <summary>
        /// Indicates a binary predicate that determines whether the left
        /// operand is not smaller than the right operand
        /// </summary>
        [Symbol(AsciCompound.GtEq), Symbol(MathSym.GTEQ), Arity(OpArity.Binary)]
        GtEq,
        
        /// <summary>
        /// Indicates a binary predicate that determines whether the left
        /// operand is strictly smaller than the right operand
        /// </summary>
        [Symbol(AsciSym.Lt), Arity(OpArity.Binary)]
        Lt,
        
        /// <summary>
        /// Indicates a binary predicate that determines whether the left
        /// operand is not larger than the right operand
        /// </summary>
        [Symbol(AsciCompound.LtEq), Symbol(MathSym.LTEQ, false), Arity(OpArity.Binary)]
        LtEq,

        [Arity(OpArity.Unary)]
        Sqrt,

        [Arity(OpArity.Unary)]
        Square,

        Parse,

        [Arity(OpArity.Unary)]
        Pop,

        [Arity(OpArity.Unary)]
        Ntz,

        [Arity(OpArity.Unary)]
        Nlz,
    }

    public enum Multiplicity : byte
    {
        Zero,
        
        One,
        
        ZeroOrOne,
        
        ZeroOrMore,
        
        OneOrMore,
    }

    public static class OpKindX
    {        
                
        public static OpArity Arity(this OpKind op)
        {
            var attributions = (from a in typeof(OpKind).DeclaredFieldAttributions<ArityAttribute>() 
                                 select (a.Key.Name, a.Value.Arity)).ToDictionary();

            if(attributions.ContainsKey(op.ToString()))
                return attributions[op.ToString()];
            else
            return OpArity.None;
        }
                

        public static bool NonZeroRight(this OpKind op)
            => op == OpKind.Div || op == OpKind.Mod;


    }
}