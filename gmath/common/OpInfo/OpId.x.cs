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
            OpMode? mode = null,
            bool baseline = true)
                => new OpId(op, Primitive, NumKind, generic, intrinsic, fusion,operandSize, mode,  baseline);

        public static OpId<T> OpId<T>(this OpKind op, 
            NumericKind NumKind = NumericKind.Native, 
            bool generic = false, 
            bool intrinsic = false,             
            OpFusion fusion = OpFusion.Atomic, 
            ByteSize? operandSize = null, 
            OpMode? mode = null,
            bool baseline = true)
                where T : struct
                    => new OpId<T>(op, NumKind, generic, intrinsic, fusion, operandSize ?? Unsafe.SizeOf<T>(), mode, baseline);
    
        /// <summary>
        /// Describes vectored intrinsic operators
        /// </summary>
        static OpId<T> InXOpId<T>(this OpKind kind, ByteSize operandSize)
            where T : struct
                => kind.OpId<T>(NumericKind.Derived, intrinsic: true, fusion: OpFusion.Fused, operandSize : operandSize);

        /// <summary>
        /// Describes intrinsic scalar operators on Num128 values
        /// </summary>
        public static OpId<T> Num128OpId<T>(this OpKind kind)
            where T : struct
                => kind.OpId<T>(NumericKind.Derived, intrinsic: true, fusion: OpFusion.Atomic);

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
                => kind.OpId<T>(NumericKind.Native, false, intrinsic: false, fusion: OpFusion.Fused, baseline: true);

        /// <summary>
        /// Describes atomic primal operations
        /// </summary>
        public static OpId<T> PrimalDirect<T>(this OpKind kind, NumericKind numKind = NumericKind.Native)
            where T : struct
                => kind.OpId<T>(numKind, intrinsic: false, baseline : true);

        /// <summary>
        /// Describes atomal primal operations
        /// </summary>
        public static OpId<T> PrimalAtomic<T>(this OpKind kind, NumericKind numKind = NumericKind.Native)
            where T : struct
                => kind.OpId<T>(numKind);

        /// <summary>
        /// Describes an operator on a generic number type
        /// </summary>
        public static OpId<T> NumG<T>(this OpKind kind, OpFusion fusion = OpFusion.Atomic)
            where T : struct
                => kind.OpId<T>(NumericKind.Derived, fusion: fusion);

        /// <summary>
        /// Describes an operator on a numbers type
        /// </summary>
        public static OpId<T> Numbers<T>(this OpKind kind)
            where T : struct
                => kind.OpId<T>(NumericKind.Derived, fusion: OpFusion.Fused);

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
                
                if(src.Fusion == OpFusion.Fused)
                    uri += "Vec";
                else
                    uri += "Num";
                
                uri += $"{src.OperandSize*8}[{src.OperandType}]/";
            }
            else
            {
                uri += "primal/";

                if(src.Generic)
                    uri += "generic/";
                else
                    uri += "direct/";

                if(src.Fusion == OpFusion.Fused)
                    uri += "fused/";
                else
                    uri += "atomic/";

                uri += $"{src.OperandType}/";

            }

            uri += $"{src.OpKind.ToString().ToLower()}/";

            if(src.Role)
                uri += "baseline ";
            else
                uri += "benchmark";

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

    }

}

