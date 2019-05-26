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


    public class OpId : IOpId
    {   
        public static IEnumerable<OpKind> OpKinds
            => typeof(OpKind).GetEnumValues().AsQueryable().Cast<OpKind>();

        public static IEnumerable<PrimalKind> Primitives
            => typeof(PrimalKind).GetEnumValues().AsQueryable().Cast<PrimalKind>();

        public static readonly OpId Zero = new OpId(OpKind.None, PrimalKind.int8, NumericKind.Native, 
            false, false, OpFusion.Atomic, 0, OpVariance.In, true);     


        public static OpId operator !(OpId src)
            => src.FlipBaseline();

        public static OpId operator ~(OpId src)
            => src.FlipGeneric();
        
        public OpId(OpKind OpKind, PrimalKind OperandKind, NumericKind NumericKind, bool Generic, bool Intrinsic, 
            OpFusion Fusion, ByteSize? OperandSize, OpVariance? Mode, bool Baseline)
        {
            this.OpKind = OpKind;
            this.OperandType = OperandKind;
            this.NumKind = NumericKind;
            this.Generic = Generic;
            this.Intrinsic = Intrinsic;
            this.Fusion = Fusion;
            this.OperandSize = OperandSize ?? 0;
            this.Mode = Mode ?? OpVariance.In;
            this.Role = Baseline;
            this.OpUri = BuildOpUri(this);
       }
        
        public OpKind OpKind {get;}

        public NumericKind NumKind {get;}

        public PrimalKind OperandType {get;}

        public ByteSize OperandSize {get;}

        public bool Generic {get;}

        public bool Intrinsic {get;}

        public OpFusion Fusion {get;}

        public bool Role {get;}

        public OpVariance Mode {get;}

        public string OpUri {get;}

        public override string ToString() 
            => OpUri;

        public OpId FlipBaseline()
            => new OpId(OpKind, OperandType, NumKind, Generic, Intrinsic, Fusion, OperandSize, Mode, !Role);

        public OpId FlipGeneric()
            => new OpId(OpKind, OperandType, NumKind, !Generic, Intrinsic, Fusion, OperandSize, Mode, Role);
    
        public OpId ResizeOperand(int OperandSize)
            => new OpId(OpKind, OperandType, NumKind, Generic, Intrinsic, Fusion, OperandSize, Mode, Role);

        public OpId WithMode(OpVariance Mode)
            => new OpId(OpKind, OperandType, NumKind, Generic, Intrinsic, Fusion, OperandSize, Mode, Role);

 
        public static string BuildOpUri(IOpId src)
        {
            var uri = string.Empty;            
            if(src.Intrinsic)
            {
                uri += "intrinsics/";                    

                if(src.Generic)
                    uri += "generic/";
                else 
                    uri += "direct/";
                
                if(src.NumKind == NumericKind.Vec128 || src.NumKind == NumericKind.Vec256)
                    uri += "Vec";
                else
                    uri += "Num";
                
                uri += $"{src.OperandSize*8}[{src.OperandType}]/";
            }
            else
            {
                if(src.NumKind == NumericKind.Number)
                    uri += $"number";
                else
                    uri += $"primal";

                uri += $"[{src.OperandType}]/";

                if(src.Generic)
                    uri += "generic/";
                else
                    uri += "direct/";

                if(src.Fusion == OpFusion.Fused)
                    uri += "fused/";
                else
                    uri += "atomic/";


            }

            uri += $"{src.OpKind.ToString().ToLower()}";

            return uri;
        }

    }
}