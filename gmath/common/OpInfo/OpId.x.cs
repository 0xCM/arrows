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

    public static class OpKinds
    {
        public static OpId OpId(this OpKind op, 
            PrimalKind Primitive, 
            NumericKind NumKind = NumericKind.Native, 
            bool generic = false, 
            bool intrinsic = false, 
            OpFusion fusion = OpFusion.Atomic, 
            ByteSize? operandSize = null, 
            OpVariance? mode = null,
            bool baseline = true)
                => new OpId(op, Primitive, NumKind, generic, intrinsic, fusion,operandSize, mode,  baseline);

        public static OpId<T> OpId<T>(this OpKind op, 
            NumericKind NumKind = NumericKind.Native, 
            bool generic = false, 
            NumericSystem system = NumericSystem.Primal,             
            OpFusion fusion = OpFusion.Atomic, 
            ByteSize? operandSize = null, 
            OpVariance? mode = null)
                where T : struct
                    => new OpId<T>(op, NumKind, generic, system, fusion, operandSize ?? Unsafe.SizeOf<T>(), mode);
    
        static OpId<T> InXOpId<T>(this OpKind kind, ByteSize operandSize)
            where T : struct
                => kind.OpId<T>(NumericKind.Number, system: NumericSystem.Intrinsic, fusion: OpFusion.Fused, operandSize : operandSize);

        public static OpId<T> Num128OpId<N,T>(this OpKind kind)
            where N : ITypeNat, new()
            where T : struct            
                => kind.OpId<T>(NumericKind.Number, system: NumericSystem.Intrinsic, 
                        operandSize: new N().value/8);

        /// <summary>
        /// Describes intrinsic scalar operators on Vec128 values
        /// </summary>
        public static OpId<T> Vec128OpId<T>(this OpKind kind)
            where T : struct
                => kind.InXOpId<T>(DataSize.Size16);

        /// <summary>
        /// Describes intrinsic scalar operators on Vec128 values
        /// </summary>
        public static OpId<T> Vec256OpId<T>(this OpKind kind)
            where T : struct
                => kind.InXOpId<T>(DataSize.Size32);

        /// <summary>
        /// Describes vectored/fused primal operations
        /// </summary>
        public static OpId<T> NativeFused<T>(this OpKind kind)
            where T : struct
                => kind.OpId<T>(NumericKind.Native, generic:false, system: NumericSystem.Primal, fusion: OpFusion.Fused);

        /// <summary>
        /// Describes atomic primal operations
        /// </summary>
        public static OpId<T> PrimalDirect<T>(this OpKind kind, NumericKind numKind = NumericKind.Native)
            where T : struct
                => kind.OpId<T>(numKind, system: NumericSystem.Primal);
        
        public static OpId<T> IntrinsicDirect<N,T>(this OpKind kind,  bool scalar = false)
            where N : ITypeNat, new()
            where T : struct
                => kind.OpId<T>(NumKind : InferInXNumKind<N>(scalar), generic: false, system: NumericSystem.Intrinsic, operandSize : new N().value/8);

        public static OpId<T> IntrinsicGeneric<N,T>(this OpKind kind,  bool scalar = false)
            where N : ITypeNat, new()
            where T : struct
                => kind.OpId<T>(NumKind : InferInXNumKind<N>(scalar), generic : true, system: NumericSystem.Intrinsic, operandSize : new N().value/8);

        /// <summary>
        /// Describes atomal primal operations
        /// </summary>
        public static OpId<T> PrimalGeneric<T>(this OpKind kind, NumericKind numKind = NumericKind.Native)
            where T : struct
                => kind.OpId<T>(numKind, generic: true);

        /// <summary>
        /// Describes an operator on a generic number type
        /// </summary>
        public static OpId<T> NumG<T>(this OpKind kind)
            where T : struct
                => kind.OpId<T>(NumericKind.Number, generic: true);

        /// <summary>
        /// Describes an operator on a numbers type
        /// </summary>
        public static OpId<T> Numbers<T>(this OpKind kind)
            where T : struct
                => kind.OpId<T>(NumericKind.Number, fusion: OpFusion.Fused);

        public static string BuildUri(this IOpId src)
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

        public static OpId FlipBaseline(this IOpId src)
            => src.OpKind.OpId(src.OperandType, src.NumKind, src.Generic, 
                src.Intrinsic, src.Fusion, src.OperandSize, src.Mode, !src.Role);

        public static OpId<T> FlipBaseline<T>(this IOpId<T> src)
            where T : struct
                => cast<OpId<T>>((src as IOpId).FlipBaseline());
            
        public static OpId FlipGeneric(this IOpId src)
            => src.OpKind.OpId(src.OperandType, src.NumKind, !src.Generic, 
                src.Intrinsic, src.Fusion, src.OperandSize, src.Mode, !src.Role);

        public static OpId<T> FlipGeneric<T>(this IOpId<T> src)
            where T : struct
                => cast<OpId<T>>((src as IOpId).FlipGeneric());

        public static OpId ResizeOperand(this IOpId src, int OperandSize)
            => src.OpKind.OpId( src.OperandType, src.NumKind, src.Generic, 
                src.Intrinsic, src.Fusion, OperandSize, src.Mode, !src.Role);

        static NumericKind InferInXNumKind<N>(bool scalar)
            where N : ITypeNat, new()
        {
            var size = new N().value;
            if(scalar)
            {
                if(size == 128)
                    return NumericKind.Num128;
                else if(size == 256)
                    return NumericKind.Num256;                
            }
            else 
            {
                if(size == 128)
                    return NumericKind.Vec128;
                else if(size == 256)
                    return NumericKind.Vec256;                
            }
            var @class = scalar ? "Num" : "Vec";
            throw unsupported($"Intrinsic {@class}[{size}]");
        }

    }

}

