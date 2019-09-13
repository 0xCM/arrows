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


    public class ParamSig
    {
        public static ParamSig Create(int pos, PrimalKind dataType, ParamVariance? variance = null)
            => new ParamSig(pos, dataType, variance ?? ParamVariance.Value);
        
        public ParamSig(int Position, PrimalKind DataType, ParamVariance Variance)
        {
            this.Position = Position;
            this.Primitive = DataType;
            this.Variance = Variance;
        }
        
        public int Position {get;}

        public ParamVariance Variance {get;}
        
        public PrimalKind Primitive {get;}

    }

    public interface IOpSig
    {
        NumericKind NumKind {get;}

        OpKind Op {get;}

        ParamSig[] Parameters {get;}            

        ParamSig Return {get;}

        OpArity Arity
            => (OpArity)Parameters.Length;
    }

    
    public abstract class OpSig : IOpSig
    {
        public static IOpSig Define(NumericKind numKind, OpKind op, ParamSig operand, ParamSig ret)
            => new UnaryOpSig(numKind, op, operand, ret);
        
        public static IOpSig Define(NumericKind numKind, OpKind op, ParamSig lhs, ParamSig rhs, ParamSig ret)
            => new BinaryOpSig(numKind, op, lhs, rhs, ret);
        
        public NumericKind NumKind {get;}

        public OpKind Op {get;}

        public ParamSig[] Parameters 
            => GetParameters();

        protected abstract ParamSig[] GetParameters();

        public OpSig(NumericKind NumKind, OpKind Op, ParamSig Return)
        {
            this.NumKind = NumKind;
            this.Op = Op;
            this.Return = Return;
        }
        public ParamSig Return{get;}
    }

    public class UnaryOpSig : OpSig
    {
        public UnaryOpSig(NumericKind NumKind, OpKind Op, ParamSig Operand, ParamSig Return)
            : base(NumKind, Op, Return)
        {
            this.Operand = Operand;
        }
        protected override ParamSig[] GetParameters()
            => array(Operand);

        public ParamSig Operand {get;}

    }

    public class BinaryOpSig : OpSig
    {
        public BinaryOpSig(NumericKind NumKind, OpKind Op, ParamSig Lhs, ParamSig Rhs, ParamSig Return)
            : base(NumKind, Op, Return)

        {
            this.Lhs = Lhs;
            this.Rhs = Rhs;
        }

        protected override ParamSig[] GetParameters()
            => array(Lhs,Rhs);

        public ParamSig Lhs {get;}

        public ParamSig Rhs {get;}

    }
}