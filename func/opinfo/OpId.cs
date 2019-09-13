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

    public class OpId : IOpId
    {   
        public static IEnumerable<OpKind> OpKinds
            => typeof(OpKind).GetEnumValues().AsQueryable().Cast<OpKind>();

        public static IEnumerable<PrimalKind> Primitives
            => typeof(PrimalKind).GetEnumValues().AsQueryable().Cast<PrimalKind>();

        public static readonly OpId Zero 
            = new OpId(NumericSystem.Primal, OpKind.None, PrimalKind.int8, NumericKind.Native, Genericity.Direct, OpFusion.Atomic, string.Empty);     

        public static OpId operator ~(OpId src)
            => src.FlipGeneric();
        
        public OpId(NumericSystem NumSystem, OpKind OpKind, PrimalKind OperandKind, NumericKind NumKind, Genericity Generic, OpFusion Fusion, string OpTitle)
        {
            this.NumSystem = NumSystem;
            this.OpKind = OpKind;
            this.OperandType = OperandKind;
            this.NumKind = NumKind;
            this.Generic = Generic;
            this.Fusion = Fusion;
            this.OpTitle =  ifEmpty(OpTitle, OpId.DefineOpTitle(this));
            this.OpUri = BuildOpUri(this);
       }
        
        public NumericSystem NumSystem {get;}

        public OpKind OpKind {get;}

        public NumericKind NumKind {get;}

        public PrimalKind OperandType {get;}

        public Genericity Generic {get;}

        public OpFusion Fusion {get;}

        public string OpTitle {get;}

        public string OpUri {get;}

        public bool Intrinsic 
            => NumSystem == NumericSystem.Intrinsic;
        
        public bool NonZero
            => OpKind != OpKind.None;

        public override string ToString() 
            => OpUri;

        public OpId WithTitle(string OpTitle)
            => new OpId(NumSystem, OpKind, OperandType, NumKind, Generic.Flip(), Fusion, OpTitle);
        
        public OpId FlipGeneric()
            => new OpId(NumSystem, OpKind, OperandType, NumKind, Generic.Flip(), Fusion, OpTitle);
    
        public OpId ResizeOperand(int OperandSize)
            => new OpId(NumSystem, OpKind, OperandType, NumKind, Generic, Fusion,  OpTitle);

        public static string DefineOpTitle(IOpId src)
            => $"{src.OpKind.ToString().ToLower()}";

        public static string BuildOpUri(IOpId src)
        {
            var uri = string.Empty;            
            if(src.Intrinsic)
            {
                if(src.Generic.IsGeneric())
                    uri += "ginx/";
                else
                    uri += "dinx/";

                if(src.Fusion == OpFusion.Fused)
                    uri += "fused/";
                else
                    uri += "atomic/";

                uri += $"{src.OpTitle}/";

                if(src.NumKind == NumericKind.Vec128)
                    uri += "Vec128";
                else if(src.NumKind == NumericKind.Vec256)
                    uri += "Vec256";
                else if(src.NumKind == NumericKind.Num128)
                    uri += "Num128";
                else 
                    uri += "Vec???";
                
                uri += $"[{src.OperandType}]";
            }
            else
            {
                if(src.NumKind == NumericKind.NumG)
                    uri += "numg/";
                else if (src.NumKind == NumericKind.VecG)
                    uri += "vecg/";
                else
                {
                    if(src.Generic.IsGeneric())
                        uri += "primg/";
                    else
                        uri = "primd/";
                }

                if(src.Fusion == OpFusion.Fused)
                    uri += "fused/";
                else
                    uri += "atomic/";

                uri += $"{src.OpTitle}/";

                uri += $"{src.OperandType}";

            }



            return uri;
        }

    }
}