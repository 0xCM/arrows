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
            bool intrinsic = false, OpFusion fusion = OpFusion.Atomic, ByteSize? operandSize = null, bool baseline = true)
                => Z0.OpId.Define(op, prim, generic, intrinsic, fusion, operandSize, baseline);

        public static OpId<T> OpId<T>(this OpKind kind, bool generic = false, bool intrinsic = false, 
            OpFusion fusion = OpFusion.Atomic, ByteSize? operandSize = null, bool baseline = true)
                where T : struct, IEquatable<T>
                    => Z0.OpId.Define<T>(kind, generic, intrinsic, fusion, operandSize, baseline);
    
        /// <summary>
        /// Describes vectored intrinsic operators
        /// </summary>
        static OpId<T> InXOpId<T>(this OpKind kind, ByteSize operandSize, bool generic = false, bool baseline = true)
            where T : struct, IEquatable<T>
                => kind.OpId<T>(generic, true, OpFusion.Fused, operandSize, baseline);

        /// <summary>
        /// Describes intrinsic scalar operators on Num128 values
        /// </summary>
        public static OpId<T> Num128OpId<T>(this OpKind kind, bool generic = false, bool baseline = true)
            where T : struct, IEquatable<T>
                => kind.OpId<T>(generic, intrinsic: true, fusion: OpFusion.Atomic, baseline: baseline);

        /// <summary>
        /// Describes intrinsic scalar operators on Vec128 values
        /// </summary>
        public static OpId<T> Vec128OpId<T>(this OpKind kind, bool generic = false, bool baseline = true)
            where T : struct, IEquatable<T>
                => kind.InXOpId<T>(DataSize.Size16, generic, baseline);

        /// <summary>
        /// Describes intrinsic scalar operators on Vec128 values
        /// </summary>
        public static OpId<T> Vec256OpId<T>(this OpKind kind, bool generic = false, bool baseline = true)
            where T : struct, IEquatable<T>
                => kind.InXOpId<T>(DataSize.Size32, generic, baseline);

        /// <summary>
        /// Describes vectored/fused primal operations
        /// </summary>
        public static OpId<T> PrimalFused<T>(this OpKind kind, bool generic = false, bool baseline = true)
            where T : struct, IEquatable<T>
                => kind.OpId<T>(generic, intrinsic: false, fusion: OpFusion.Fused, baseline: baseline);

        /// <summary>
        /// Describes atomal primal operations
        /// </summary>
        public static OpId<T> PrimalDirect<T>(this OpKind kind, OpFusion fusion = OpFusion.Atomic, bool baseline = true)
            where T : struct, IEquatable<T>
                => kind.OpId<T>(generic : false, intrinsic: false, fusion: fusion, baseline : baseline);

        /// <summary>
        /// Describes atomal primal operations
        /// </summary>
        public static OpId<T> PrimalAtomic<T>(this OpKind kind, bool generic = false, bool baseline = true)
            where T : struct, IEquatable<T>
                => kind.OpId<T>(generic, intrinsic: false, fusion: OpFusion.Atomic, baseline: baseline);

        /// <summary>
        /// Describes an operator on a generic number type
        /// </summary>
        public static OpId<T> NumGOpId<T>(this OpKind kind, bool baseline = true)
            where T : struct, IEquatable<T>
                => kind.OpId<T>(generic: true, intrinsic: false, fusion: OpFusion.Atomic, baseline : baseline);

        /// <summary>
        /// Describes an operator on a numbers type
        /// </summary>
        public static OpId<T> Numbers<T>(this OpKind kind, bool generic = false, bool baseline = true)
            where T : struct, IEquatable<T>
                => kind.OpId<T>(generic: generic, intrinsic: false, fusion: OpFusion.Fused, baseline: baseline);

    }

}