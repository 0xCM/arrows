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

    public readonly struct OpId<T> : IOpId<T>
        where T : struct
    {
        public static implicit operator OpId(OpId<T> src)
            =>  src.OpKind.OpId(src.OperandType, src.NumKind, src.Generic, src.Intrinsic, src.Fusion, src.OperandSize, src.Baseline);

        public static OpId<T> operator ~(OpId<T> src)
            => src.FlipGeneric();

        public static OpId<T> operator !(OpId<T> src)
            => src.FlipBaseline();

        public OpId(OpKind OpKind, NumericKind NumKind, bool Generic, bool Intrinsic, OpFusion Fusion, ByteSize? OperandSize, bool Baseline)
        {
            this.OpKind = OpKind;
            this.NumKind = NumKind;
            this.OperandType = PrimalKinds.kind<T>();
            this.Generic = Generic;
            this.Intrinsic = Intrinsic;
            this.Fusion = Fusion;
            this.OperandSize = OperandSize ?? 0;
            this.Baseline = Baseline;
        }
        
        public OpKind OpKind {get;}

        public NumericKind NumKind {get;}

        public PrimalKind OperandType {get;}

        public ByteSize OperandSize {get;}

        public bool Generic {get;}

        public bool Intrinsic {get;}

        public OpFusion Fusion {get;}

        public bool Baseline {get;}


        public override string ToString()
            => this.BuildUri();

        public OpId<T> FlipGeneric()
            => new OpId<T>(OpKind, NumKind, !Generic, Intrinsic, Fusion, OperandSize, Baseline);

        public OpId<T> FlipBaseline()
            => new OpId<T>(OpKind, NumKind, Generic, Intrinsic, Fusion, OperandSize, !Baseline);
    }

    public readonly struct OpId : IOpId
    {   
        public static IEnumerable<OpKind> OpKinds
            => typeof(OpKind).GetEnumValues().AsQueryable().Cast<OpKind>();

        public static IEnumerable<PrimalKind> Primitives
            => typeof(PrimalKind).GetEnumValues().AsQueryable().Cast<PrimalKind>();

        public static readonly OpId Zero = new OpId(OpKind.None, PrimalKind.none, NumericKind.Native, false, false, OpFusion.Atomic, 0, true);     
        
        // public static OpId Define(OpKind Kind, PrimalKind Primitive, NumericKind NumKind = NumericKind.Native, bool Generic = false, bool Intrinsic = false, 
        //     OpFusion Fusion = OpFusion.Atomic, ByteSize? OperandSize = null, bool baseline = true)
        //         => new OpId(Kind, Primitive, NumKind, Generic, Intrinsic, Fusion,OperandSize, baseline);

        // public static OpId<T> Define<T>(OpKind Kind, NumericKind NumKind = NumericKind.Native, bool Generic = false, bool Intrinsic = false, 
        //     OpFusion Fusion = OpFusion.Atomic, ByteSize? OperandSize = null, bool baseline = true)
        //     where T : struct, IEquatable<T>
        //         => new OpId<T>(Kind, NumKind, Generic, Intrinsic, Fusion, OperandSize ?? Unsafe.SizeOf<T>(), baseline);

        public static OpId operator !(OpId src)
            => src.FlipBaseline();

        public static OpId operator ~(OpId src)
            => src.FlipGeneric();
        
        public OpId(OpKind OpKind, PrimalKind OperandKind, NumericKind NumericKind, bool Generic, bool Intrinsic, OpFusion Fusion, ByteSize? OperandSize, bool Baseline)
        {
            this.OpKind = OpKind;
            this.OperandType = OperandKind;
            this.NumKind = NumericKind;
            this.Generic = Generic;
            this.Intrinsic = Intrinsic;
            this.Fusion = Fusion;
            this.OperandSize = OperandSize ?? 0;
            this.Baseline = Baseline;
       }
        
        public OpKind OpKind {get;}

        public NumericKind NumKind {get;}

        public PrimalKind OperandType {get;}

        public ByteSize OperandSize {get;}

        public bool Generic {get;}

        public bool Intrinsic {get;}

        public OpFusion Fusion {get;}

        public bool Baseline {get;}

        public override string ToString() 
            => this.BuildUri();

        public OpId FlipBaseline()
            => new OpId(OpKind, OperandType, NumKind, Generic, Intrinsic, Fusion, OperandSize, !Baseline);

        public OpId FlipGeneric()
            => new OpId(OpKind, OperandType, NumKind, !Generic, Intrinsic, Fusion, OperandSize, Baseline);
    
        public OpId ResizeOperand(int OperandSize)
            => new OpId(OpKind, OperandType, NumKind, Generic, Intrinsic, Fusion, OperandSize, Baseline);
    }
}