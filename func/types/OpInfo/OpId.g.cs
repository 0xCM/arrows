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
    using static zfunc;

    public class OpId<T> : IOpId<T>
        where T : struct
    {
        public static readonly OpId<T> Zero 
            = new OpId<T>(NumericSystem.Primal, OpKind.None, NumericKind.Native, Genericity.Direct, OpFusion.Atomic, string.Empty);
        
        public static bool operator ==(OpId<T> lhs, OpId<T> rhs)
            => lhs.OpKind == rhs.OpKind
            && lhs.NumKind == rhs.NumKind
            && lhs.OperandType == rhs.OperandType
            && lhs.Generic == rhs.Generic
            && lhs.Fusion == rhs.Fusion
            && lhs.NumSystem == rhs.NumSystem
            && lhs.OpTitle == rhs.OpTitle;

        public static bool operator !=(OpId<T> lhs, OpId<T> rhs)
            => !(lhs == rhs);

        public static implicit operator OpId(OpId<T> src)
            =>  src.OpKind.OpId(src.NumSystem, src.OperandType, src.NumKind, src.Generic, src.Fusion,  src.OpTitle);

        public static OpId<T> operator ~(OpId<T> src)
            => src.FlipGeneric();

        public OpId(NumericSystem NumSystem, OpKind OpKind, NumericKind NumKind, Genericity Generic, OpFusion Fusion, string OpTitle)
        {
            this.NumSystem = NumSystem;
            this.OpKind = OpKind;
            this.NumKind = NumKind;
            this.OperandType = PrimalKinds.kind<T>();
            this.Generic = Generic;
            this.Fusion = Fusion;
            this.OpTitle =  ifEmpty(OpTitle, OpId.DefineOpTitle(this));
            this.OpUri = OpId.BuildOpUri(this);
        }
        public NumericSystem NumSystem {get;}
        
        public OpKind OpKind {get;}

        public NumericKind NumKind {get;}

        public PrimalKind OperandType {get;}
        
        public Genericity Generic {get;}

        public OpFusion Fusion {get;}
 
        public string OpUri {get;}

        public string OpTitle {get;}

        public bool NonZero
            => OpKind != OpKind.None;

        public bool Intrinsic 
            => NumSystem == NumericSystem.Intrinsic;

        public bool Primal
            => NumSystem == NumericSystem.Primal;

        public override string ToString()
            => OpUri;

        public override bool Equals(object obj)
            => obj is OpId<T> ? (OpId<T>)obj == this : false;

        public override int GetHashCode()
            => ToString().GetHashCode();

        public OpId<T> WithTitle(string OpTitle)
            => new OpId<T>(NumSystem, OpKind, NumKind, Generic, Fusion, OpTitle);
        
        public OpId<T> FlipGeneric()
            => new OpId<T>(NumSystem, OpKind, NumKind, Generic.Flip(), Fusion, OpTitle);
       
    }

}