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

    public static class OpKinds
    {
        public static OpId OpId(this OpKind op, PrimalKind prim, bool generic = false, 
            bool intrinsic = false, OpFusion fusion = OpFusion.Atomic, ByteSize? operandSize = null)
                => Z0.OpId.Define(op, prim, generic, intrinsic, fusion, operandSize);

        public static OpId OpId<T>(this OpKind kind, bool generic = false, bool intrinsic = false, 
            OpFusion fusion = OpFusion.Atomic, ByteSize? operandSize = null)
                where T : struct, IEquatable<T>
                    => Z0.OpId.Define<T>(kind, generic, intrinsic, fusion, operandSize);
    
        /// <summary>
        /// Describes vectored intrinsic operators
        /// </summary>
        static OpId InXOpId<T>(this OpKind kind, ByteSize operandSize, bool generic = false)
            where T : struct, IEquatable<T>
                => kind.OpId<T>(generic, true, OpFusion.Fused, operandSize);

        /// <summary>
        /// Describes intrinsic scalar operators on Num128 values
        /// </summary>
        public static OpId Num128OpId<T>(this OpKind kind, bool generic = false)
            where T : struct, IEquatable<T>
                => kind.OpId<T>(generic, intrinsic: true, fusion: OpFusion.Atomic);

        /// <summary>
        /// Describes intrinsic scalar operators on Vec128 values
        /// </summary>
        public static OpId Vec128OpId<T>(this OpKind kind, bool generic = false)
            where T : struct, IEquatable<T>
                => kind.InXOpId<T>(DataSize.Size16, generic);

        /// <summary>
        /// Describes intrinsic scalar operators on Vec128 values
        /// </summary>
        public static OpId Vec256OpId<T>(this OpKind kind, bool generic = false)
            where T : struct, IEquatable<T>
                => kind.InXOpId<T>(DataSize.Size32, generic);

        /// <summary>
        /// Describes vectored/fused primal operations
        /// </summary>
        public static OpId PrimalFusedOpId<T>(this OpKind kind, bool generic = false)
            where T : struct, IEquatable<T>
                => kind.OpId<T>(generic, intrinsic: false, fusion: OpFusion.Fused);

        /// <summary>
        /// Describes atomal primal operations
        /// </summary>
        public static OpId PrimalAtomicOpId<T>(this OpKind kind, bool generic = false)
            where T : struct, IEquatable<T>
                => kind.OpId<T>(generic, intrinsic: false, fusion: OpFusion.Atomic);

    }

}