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

    public readonly struct OpId 
    {   
        public static IEnumerable<OpKind> OpKinds
            => typeof(OpKind).GetEnumValues().AsQueryable().Cast<OpKind>();

        public static IEnumerable<PrimalKind> Primitives
            => typeof(PrimalKind).GetEnumValues().AsQueryable().Cast<PrimalKind>();

        public static readonly OpId Zero = new OpId(OpKind.None, PrimalKind.none, false, false, OpFusion.Atomic, 0);     
        
        public static OpId Define(OpKind Kind, PrimalKind Primitive, bool Generic = false, bool Intrinsic = false, 
            OpFusion Fusion = OpFusion.Atomic, ByteSize? OperandSize = null)
                => new OpId(Kind, Primitive, Generic, Intrinsic, Fusion,OperandSize);

        public static OpId Define<T>(OpKind Kind,  bool Generic = false, bool Intrinsic = false, 
            OpFusion Fusion = OpFusion.Atomic, ByteSize? OperandSize = null)
            where T : struct, IEquatable<T>
                => new OpId(Kind, PrimalKinds.kind<T>(), Generic, Intrinsic, Fusion, OperandSize ?? Unsafe.SizeOf<T>());

        public static OpId operator ~(OpId src)
            => src.FlipGeneric();

        OpId(OpKind OpKind, PrimalKind OperandKind, bool Generic, bool Intrinsic, OpFusion Fusion, ByteSize? OperandSize)
        {
            this.OpKind = OpKind;
            this.OperandKind = OperandKind;
            this.Generic = Generic;
            this.Intrinsic = Intrinsic;
            this.Fusion = Fusion;
            this.OperandSize = OperandSize ?? 0;
        }
        
        public readonly OpKind OpKind;

        public readonly PrimalKind OperandKind;

        public readonly ByteSize OperandSize;

        public readonly bool Generic;

        public readonly bool Intrinsic;

        public readonly OpFusion Fusion;

        public bool Vectored =>
            Fusion == OpFusion.Fused;

        /// <summary>
        /// monomorphic (direct) vs parametric (generic)
        /// </summary>
        string Parametricity
            => Generic ? "generic" : "direct";

        string Prefix 
            => Intrinsic ?  (Generic ? "ginx" : "dinx") : (Generic ? "gmath" : "dmath");

        string OpInfo
            => Vectored ? $"{OpKind}/Vec{OperandSize}[{OperandKind}]" 
              : Intrinsic ? $"Num{OperandSize}[{OperandKind}]"            
              : $"{OpKind}/{OperandKind}";

        public override string ToString() 
            => $"{Prefix}/{OpInfo}".ToLower();
        
        public OpId FlipGeneric()
            => new OpId(OpKind,OperandKind, !Generic, Intrinsic, Fusion, OperandSize);
    
        public OpId ResizeOperand(int OperandSize)
            => new OpId(OpKind,OperandKind, Generic, Intrinsic, Fusion, OperandSize);
    }



}