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
    }

    public readonly struct OpId 
    {
        public static OpId Define(OpKind Kind, PrimalKind Primitive)
            => new OpId(Kind, Primitive);

        public static OpId Define<T>(OpKind Kind)
            where T : struct, IEquatable<T>
            => new OpId(Kind, PrimalKinds.kind<T>());

        public OpId(OpKind Kind, PrimalKind Primitive)
        {
            this.Kind = Kind;
            this.Primitive = Primitive;
        }
        
        public readonly OpKind Kind;

        public readonly PrimalKind Primitive;

        
        public override string ToString() 
            => $"{Kind}/{Primitive}";

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
        
        GtEq,
        
        /// <summary>
        /// Indicates a binary predicate that determines whether the left
        /// operand is strictly smaller than the right operand
        /// </summary>
        Lt,
        
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
        
        Mul,

        Mod,

        Abs,

        Or,

        XOr,

        And,

        Flip,

        Sum,

        Avg,

        
        /// <summary>
        /// Indicates a unary operator that increments a value by a unit
        /// </summary>
        Inc,

        /// <summary>
        /// Indicates a unary operator that decrements a value by a unit
        /// </summary>
        Dec
    }

}