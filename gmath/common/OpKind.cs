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

    public static class OpKinds
    {
        public static IEnumerable<OpKind> All
            => typeof(OpKind).GetEnumValues().AsQueryable().Cast<OpKind>();

        public static OpId OpId(this OpKind op, PrimalKind prim, bool generic = false, bool intrinsic = false)
                => Z0.OpId.Define(op, prim, generic, intrinsic);

        public static OpId OpId<T>(this OpKind kind, bool generic = false, bool intrinsic = false)
            where T : struct, IEquatable<T>
                => Z0.OpId.Define<T>(kind, generic, intrinsic);
    }

    public enum OpKind
    {        
        /// <summary>
        /// Indicates a binary predicate that adjudicates operand equality
        /// </summary>
        Eq,
        
        /// <summary>
        /// Indicates a binary predicate that determines whether the left
        /// operand is strictly larger than the right operand
        /// </summary>
        Gt,
        
        /// <summary>
        /// Indicates a binary predicate that determines whether the left
        /// operand is not smaller than the right operand
        /// </summary>
        GtEq,
        
        /// <summary>
        /// Indicates a binary predicate that determines whether the left
        /// operand is strictly smaller than the right operand
        /// </summary>
        Lt,
        
        /// <summary>
        /// Indicates a binary predicate that determines whether the left
        /// operand is not larger than the right operand
        /// </summary>
        LtEq,

        /// <summary>
        /// Indicates a binary operator that computes the sum of the left
        /// and right operands
        /// </summary>
        Add,

        /// <summary>
        /// Indicates a binary operator that computes the difference between
        /// the left and right operands
        /// </summary>
        Sub,
        
        /// <summary>
        /// Indicates a binary operator that divides the left operand by the
        /// right operand
        /// </summary>
        Div,
        
        /// <summary>
        /// Indicates a binary predicate that computes the product of the left
        /// and right operands
        /// </summary>
        Mul,

        Mod,

        Abs,

        Or,

        XOr,

        And,

        Flip,

        Create,
        
        /// <summary>
        /// Indicates an aggregate unary operator that calculates the
        /// sum of the operand constituents
        /// </summary>
        Sum,

        /// <summary>
        /// Indicates an aggregate unary operator that calculates the
        /// average of the operand constituents
        /// </summary>
        Avg,

        
        /// <summary>
        /// Indicates a unary operator that increments a value by a unit
        /// </summary>
        Inc,

        /// <summary>
        /// Indicates a unary operator that decrements a value by a unit
        /// </summary>
        Dec,

        Max,

        Min
    }

}