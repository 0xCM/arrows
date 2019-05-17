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

    public class OpId<T> : IOpId<T>
        where T : struct
    {
        public static readonly OpId<T> Zero = new OpId<T>(OpKind.None, NumericKind.Default, false, false, OpFusion.Default, 0, OpMode.Default, false);
        
        public static bool operator ==(OpId<T> lhs, OpId<T> rhs)
            => lhs.OpKind == rhs.OpKind
            && lhs.NumKind == rhs.NumKind
            && lhs.OperandType == rhs.OperandType
            && lhs.OperandSize == rhs.OperandSize
            && lhs.Generic == rhs.Generic
            && lhs.Intrinsic == rhs.Intrinsic
            && lhs.Fusion == rhs.Fusion
            && lhs.Mode == rhs.Mode
            && lhs.Role == rhs.Role;

        public static bool operator !=(OpId<T> lhs, OpId<T> rhs)
            => !(lhs == rhs);

        public static implicit operator OpId(OpId<T> src)
            =>  src.OpKind.OpId(src.OperandType, src.NumKind, src.Generic, src.Intrinsic, 
                    src.Fusion, src.OperandSize, src.Mode, src.Role);

        public static OpId<T> operator ~(OpId<T> src)
            => src.ToggleGeneric();

        public static OpId<T> operator !(OpId<T> src)
            => src.ToggleRole();

        public OpId(OpKind OpKind, NumericKind NumKind, bool Generic, bool Intrinsic, 
            OpFusion Fusion, ByteSize? OperandSize, OpMode? Mode, bool Role)
        {
            this.OpKind = OpKind;
            this.NumKind = NumKind;
            this.OperandType = PrimalKinds.kind<T>();
            this.Generic = Generic;
            this.Intrinsic = Intrinsic;
            this.Fusion = Fusion;
            this.OperandSize = OperandSize ?? 0;
            this.Role = Role;
            this.Mode = Mode ?? OpMode.ReadOnly;
        }
        
        public OpKind OpKind {get;}

        public NumericKind NumKind {get;}

        public PrimalKind OperandType {get;}

        public ByteSize OperandSize {get;}

        public bool Generic {get;}

        public bool Intrinsic {get;}

        public OpFusion Fusion {get;}

        public OpMode Mode {get;}

        public bool Role {get;}

        public bool NonZero
            => OpKind != OpKind.None;

        public override string ToString()
            => this.BuildUri();

        public override bool Equals(object obj)
            => obj is OpId<T> ? (OpId<T>)obj == this : false;

        public override int GetHashCode()
            => ToString().GetHashCode();

        public OpId<T> ToggleGeneric()
            => new OpId<T>(OpKind, NumKind, !Generic, Intrinsic, Fusion, OperandSize, Mode, Role);

        public OpId<T> ToggleRole()
            => new OpId<T>(OpKind, NumKind, Generic, Intrinsic, Fusion, OperandSize, Mode, !Role);
        
        public OpId<T> WithMode(OpMode Mode)
            => new OpId<T>(OpKind, NumKind, Generic, Intrinsic, Fusion, OperandSize, Mode, Role);
    }

    public class OpId : IOpId
    {   
        public static IEnumerable<OpKind> OpKinds
            => typeof(OpKind).GetEnumValues().AsQueryable().Cast<OpKind>();

        public static IEnumerable<PrimalKind> Primitives
            => typeof(PrimalKind).GetEnumValues().AsQueryable().Cast<PrimalKind>();

        public static readonly OpId Zero = new OpId(OpKind.None, PrimalKind.none, NumericKind.Native, 
            false, false, OpFusion.Atomic, 0, OpMode.ReadOnly, true);     

        public static OpId operator !(OpId src)
            => src.FlipBaseline();

        public static OpId operator ~(OpId src)
            => src.FlipGeneric();
        
        public OpId(OpKind OpKind, PrimalKind OperandKind, NumericKind NumericKind, bool Generic, bool Intrinsic, 
            OpFusion Fusion, ByteSize? OperandSize, OpMode? Mode, bool Baseline)
        {
            this.OpKind = OpKind;
            this.OperandType = OperandKind;
            this.NumKind = NumericKind;
            this.Generic = Generic;
            this.Intrinsic = Intrinsic;
            this.Fusion = Fusion;
            this.OperandSize = OperandSize ?? 0;
            this.Mode = Mode ?? OpMode.ReadOnly;
            this.Role = Baseline;
       }
        
        public OpKind OpKind {get;}

        public NumericKind NumKind {get;}

        public PrimalKind OperandType {get;}

        public ByteSize OperandSize {get;}

        public bool Generic {get;}

        public bool Intrinsic {get;}

        public OpFusion Fusion {get;}

        public bool Role {get;}

        public OpMode Mode {get;}

        public override string ToString() 
            => this.BuildUri();

        public OpId FlipBaseline()
            => new OpId(OpKind, OperandType, NumKind, Generic, Intrinsic, Fusion, OperandSize, Mode, !Role);

        public OpId FlipGeneric()
            => new OpId(OpKind, OperandType, NumKind, !Generic, Intrinsic, Fusion, OperandSize, Mode, Role);
    
        public OpId ResizeOperand(int OperandSize)
            => new OpId(OpKind, OperandType, NumKind, Generic, Intrinsic, Fusion, OperandSize, Mode, Role);

        public OpId WithMode(OpMode Mode)
            => new OpId(OpKind, OperandType, NumKind, Generic, Intrinsic, Fusion, OperandSize, Mode, Role);

    }
}