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
            NumericKind numKind = NumericKind.Native, 
            bool generic = false, 
            bool intrinsic = false, 
            OpFusion fusion = OpFusion.Atomic, 
            ByteSize? operandSize = null, 
            OpVariance? mode = null,
            bool baseline = true)
                => new OpId(op, Primitive, numKind, generic, intrinsic, fusion,operandSize, mode,  baseline);

        public static OpId<T> OpId<T>(this OpKind op, 
            NumericKind numKind = NumericKind.Native, 
            bool generic = false, 
            NumericSystem numSystem = NumericSystem.Primal,             
            OpFusion fusion = OpFusion.Atomic, 
            ByteSize? operandSize = null, 
            OpVariance? mode = null)
                where T : struct
                    => new OpId<T>(op, numKind, generic, numSystem, fusion, operandSize ?? Unsafe.SizeOf<T>(), mode);        

        public static OpType WithType(this OpKind src, PrimalKind prim)
            => OpType.Define(src,prim);    
    }

}

