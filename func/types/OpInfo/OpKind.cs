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
    using System.ComponentModel;
    using static zfunc;

    using static MathSym;
    using AsciCompound = AsciSym.Compound;

    public enum NumericKind : byte
    {
        /// <summary>
        /// Classifier for system-defined numeric types, which is determined by 
        /// the literals of the PrimalKind enum
        /// </summary>
        Native = 0,

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

        /// <summary>
        /// Identifies an atomic generic number for which the type parameter values
        /// can range, at minimum, over the primal types
        /// </summary>
        NumG = 6,

        /// <summary>
        /// Identifies a generic vector for which the type parameter values
        /// can range, at minimum, over the primal types
        /// </summary>
        VecG = 7,

        /// <summary>
        /// Identifies a non-generic value type that is closely aligned with
        /// a primal type
        /// </summary>
        Analog

    }

    public enum NumericSystem : byte
    {
        Primal = 0,

        Intrinsic = 1
    }


    public enum Genericity : byte
    {
        Direct = 1,


        Generic = 2        
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

    public enum OpClass
    {
        Arithmetic,

        Bitwise
    }

    /// <summary>
    /// Classifies an operator's variance characteristics
    /// </summary>
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

    public enum ParamVariance
    {
        Value,

        In,

        Out,

        Ref, 

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
        [Symbol(AsciSym.Amp), Arity(OpArity.Binary), OpClass(OpClass.Bitwise)]
        And,

        /// <summary>
        /// Indicates a binary operator that computes the bitwise or of the source operands
        /// </summary>
        [Symbol(AsciSym.Pipe), Arity(OpArity.Binary), OpClass(OpClass.Bitwise)]
        Or,

        /// <summary>
        /// Indicates a binary operator that computes the bitwise xor of the source operands
        /// </summary>
        [Symbol(AsciSym.Caret), Arity(OpArity.Binary), OpClass(OpClass.Bitwise)]
        XOr,

        /// <summary>
        /// Indicates a left-shift bitwise operator
        /// </summary>
        [Symbol(AsciCompound.ShiftL,MathSym.LT2), Arity(OpArity.Binary), OpClass(OpClass.Bitwise)]
        ShiftL,

        /// <summary>
        /// Indicates a right-shift bitwise operator
        /// </summary>
        [Symbol(AsciCompound.ShiftR, MathSym.GT2)]
        ShiftR,

        [Description("Indicates a bitwise operator that rotates the bits of an operand leftwards")]
        RotL,

        [Description("Indicates a bitwise operator that rotates the bits of an operand rightwards")]
        RotR,


        [Symbol(AsciSym.Tilde), Arity(OpArity.Unary),
            Description("Indicates a two's complement bitwise operator that reverses that state over every bit in the operand")]
        Flip,

        /// <summary>
        /// Indicates a bit test operator
        /// </summary>
        [Arity(OpArity.Binary), Description("Indicates a bitwise binary operator that tests the state of a bit")]
        Test,

        /// <summary>
        /// Indicates a bit toggle operator
        /// </summary>
        [Arity(OpArity.Binary), Description("Indicates a bitwise binary operator that reverses the state of a bit")]
        Toggle,

        [Arity(OpArity.Unary), Description("Indicates a bitwise unary operator that computes the count of an operand's on bits")]
        Pop,

        [Arity(OpArity.Unary), Description("Indicates a bitwise unary operator that computes the count of an operand's trailing zero bits")]
        Ntz,

        [Arity(OpArity.Unary), Description("Indicates a bitwise unary operator that computes the count of an operand's leading zero bits")]
        Nlz,

        /// <summary>
        /// Indicates a unary operator that flips the sign of a signed number
        /// </summary>
        [Symbol(AsciSym.Minus), Arity(OpArity.Unary), 
            Description("Indicates a unary operator that reverses the sign of a signed number")]
        Negate,

        /// <summary>
        /// Indicates a unary increment operator
        /// </summary>
        [Symbol(AsciCompound.Increment), Arity(OpArity.Unary),
            Description("Indicates a unary increment operator")]
        Inc,

        /// <summary>
        /// Indicates a unary operator that decrements a value by a unit
        /// </summary>
        [Symbol(AsciCompound.Decrement), Arity(OpArity.Unary), 
            Description("Indicates a unary decrement operator")]
        Dec,

        New,

        /// <summary>
        /// Indicates a unary operator that computes the absolute value of a signed number
        /// </summary>
        [Symbol(MathSym.Abs), Arity(OpArity.Unary),
            Description("Indicates an absolute value operator")]
        Abs,

        /// <summary>
        /// Indicates a sum aggregation operator
        /// </summary>
        [Symbol(MathSym.Sum), Description("Indicates an aggregation operator that computes the sum of an arbitrary number of values")]
        Sum,

        /// <summary>
        /// Indicates an aggregate unary operator that calculates the
        /// average of the operand constituents
        /// </summary>
        [Arity(OpArity.UnaryCollection),Description("Indicates an aggregation operator that computes the average of an arbitrary number of values")]
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
        [Symbol(AsciCompound.GtEq,MathSym.GTEQ), Arity(OpArity.Binary)]
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
        [Symbol(AsciCompound.LtEq, MathSym.LTEQ), Arity(OpArity.Binary)]
        LtEq,

        [Arity(OpArity.Unary)]
        Sqrt,

        [Arity(OpArity.Unary)]
        Square,

        Parse,


        [Description("Indicates an operator that coverts a value of one type to a value of another type")]
        Convert
    }



    public enum Multiplicity : byte
    {
        Zero,
        
        One,
        
        ZeroOrOne,
        
        ZeroOrMore,
        
        OneOrMore,
    }

    public class OpClassAttribute : Attribute
    {
        public OpClassAttribute(OpClass Class)
        {
            this.Class = Class;
        }

        public OpClass Class {get;}
    }

    public class MultiplicityAttribute : Attribute
    {
        public MultiplicityAttribute(Multiplicity Multiplicity)
            => this.Multiplicity = Multiplicity;
        
        public Multiplicity Multiplicity {get;}
    }

    public class ResultMultiplicityAttribute : Attribute
    {
        public ResultMultiplicityAttribute(Multiplicity Multiplicity)
            => this.Multiplicity = Multiplicity;
        
        public Multiplicity Multiplicity {get;}
    }

    public class LeftMultiplicityAttribute : Attribute
    {
        public LeftMultiplicityAttribute(Multiplicity Multiplicity)
            => this.Multiplicity = Multiplicity;
        
        public Multiplicity Multiplicity {get;}
    }

    public class RightMultiplicityAttribute : Attribute
    {
        public RightMultiplicityAttribute(Multiplicity Multiplicity)
            => this.Multiplicity = Multiplicity;
        
        public Multiplicity Multiplicity {get;}
    }

}