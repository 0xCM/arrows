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

    public readonly struct OpId<T>
        where T : struct
    {
        public static implicit operator OpId(OpId<T> src)
            => OpId.Define(src.OpKind, src.OperandKind, src.Generic, src.Intrinsic, src.Fusion, src.OperandSize, src.Baseline);

        public static OpId<T> operator ~(OpId<T> src)
            => src.FlipGeneric();

        public static OpId<T> operator !(OpId<T> src)
            => src.FlipBaseline();

        public OpId(OpKind OpKind, bool Generic, bool Intrinsic, OpFusion Fusion, ByteSize? OperandSize, bool Baseline)
        {
            this.OpKind = OpKind;
            this.OperandKind = PrimalKinds.kind<T>();
            this.Generic = Generic;
            this.Intrinsic = Intrinsic;
            this.Fusion = Fusion;
            this.OperandSize = OperandSize ?? 0;
            this.Baseline = Baseline;
        }
        
        public readonly OpKind OpKind;

        public readonly PrimalKind OperandKind;

        public readonly ByteSize OperandSize;

        public readonly bool Generic;

        public readonly bool Intrinsic;

        public readonly OpFusion Fusion;

        public readonly bool Baseline;

        public bool Vectored =>
            Fusion == OpFusion.Fused;

        string Describe(OpId src)
            => src.ToString();

        public override string ToString()
            => Describe(this);

        public OpId<T> FlipGeneric()
            => new OpId<T>(OpKind, !Generic, Intrinsic, Fusion, OperandSize, Baseline);

        public OpId<T> FlipBaseline()
            => new OpId<T>(OpKind, Generic, Intrinsic, Fusion, OperandSize, !Baseline);


    }

    public readonly struct OpId 
    {   
        public static IEnumerable<OpKind> OpKinds
            => typeof(OpKind).GetEnumValues().AsQueryable().Cast<OpKind>();

        public static IEnumerable<PrimalKind> Primitives
            => typeof(PrimalKind).GetEnumValues().AsQueryable().Cast<PrimalKind>();

        public static readonly OpId Zero = new OpId(OpKind.None, PrimalKind.none, false, false, OpFusion.Atomic, 0, true);     
        
        public static OpId Define(OpKind Kind, PrimalKind Primitive, bool Generic = false, bool Intrinsic = false, 
            OpFusion Fusion = OpFusion.Atomic, ByteSize? OperandSize = null, bool baseline = true)
                => new OpId(Kind, Primitive, Generic, Intrinsic, Fusion,OperandSize, baseline);

        public static OpId<T> Define<T>(OpKind Kind,  bool Generic = false, bool Intrinsic = false, 
            OpFusion Fusion = OpFusion.Atomic, ByteSize? OperandSize = null, bool baseline = true)
            where T : struct, IEquatable<T>
                => new OpId<T>(Kind, Generic, Intrinsic, Fusion, OperandSize ?? Unsafe.SizeOf<T>(), baseline);

        public static OpId operator !(OpId src)
            => src.FlipBaseline();

        public static OpId operator ~(OpId src)
            => src.FlipGeneric();
        
        OpId(OpKind OpKind, PrimalKind OperandKind, bool Generic, bool Intrinsic, OpFusion Fusion, ByteSize? OperandSize, bool Baseline)
        {
            this.OpKind = OpKind;
            this.OperandKind = OperandKind;
            this.Generic = Generic;
            this.Intrinsic = Intrinsic;
            this.Fusion = Fusion;
            this.OperandSize = OperandSize ?? 0;
            this.Baseline = Baseline;
       }
        
        public readonly OpKind OpKind;

        public readonly PrimalKind OperandKind;

        public readonly ByteSize OperandSize;

        public readonly bool Generic;

        public readonly bool Intrinsic;

        public readonly OpFusion Fusion;

        public readonly bool Baseline;

        public bool Vectored =>
            Fusion == OpFusion.Fused;

        string OpInfo
        {
            get            
            {   string info = string.Empty;            
                if(Intrinsic)
                {
                    info += "intrinsics/";                    

                    if(Generic)
                        info += "generic/";
                    else 
                        info += "direct/";
                    
                    if(Vectored)
                        info += "Vec";
                    else
                        info += "Num";
                    
                    info += $"{OperandSize*8}[{OperandKind}]/";
                }
                else
                {
                    info += "primal/";

                    if(Generic)
                        info += "generic/";
                    else
                        info += "direct/";

                    if(Vectored)
                        info += "fused/";
                    else
                        info += "atomic/";

                    info += $"{OperandKind}/";

                }

                info += $"{OpKind.ToString().ToLower()}/";

                if(Baseline)
                    info += "baseline ";
                else
                    info += "benchmark";

                return info;
            }
        }

        public override string ToString() 
            => OpInfo;

        public OpId FlipBaseline()
            => new OpId(OpKind,OperandKind, Generic, Intrinsic, Fusion, OperandSize, !Baseline);

        public OpId FlipGeneric()
            => new OpId(OpKind,OperandKind, !Generic, Intrinsic, Fusion, OperandSize, Baseline);
    
        public OpId ResizeOperand(int OperandSize)
            => new OpId(OpKind,OperandKind, Generic, Intrinsic, Fusion, OperandSize, Baseline);
    }
}