//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static zcore;

    static class shells
    {
        [MethodImpl(Inline)]
        public static unsafe void PerformOpAndStoreResultToPointer<T>(in Vec128<T> lhs, in Vec128<T> rhs, void* dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            var vLen = Vec128<T>.Length;

            if(kind == PrimalKind.int8)
            {
                var xLhs = As.int8(lhs);
                var xRhs = As.int8(rhs);
            }

            if(kind == PrimalKind.uint8)
            {
                var xLhs = As.uint8(lhs);
                var xRhs = As.uint8(rhs);                
            }

            if(kind == PrimalKind.int16)
            {
                var xLhs = As.int16(lhs);
                var xRhs = As.int16(rhs);                
            }

            if(kind == PrimalKind.uint16)
            {
                var xLhs = As.uint16(lhs);
                var xRhs = As.uint16(rhs);                            
            }

            if(kind == PrimalKind.int32)
            {
                var xLhs = As.int32(lhs);
                var xRhs = As.int32(rhs);                            
            }

            if(kind == PrimalKind.uint32)
            {
                var xLhs = As.uint32(lhs);
                var xRhs = As.uint32(rhs);                            
            }

            if(kind == PrimalKind.int64)
            {
                var xLhs = As.int64(lhs);
                var xRhs = As.int64(rhs);                            
                
            }

            if(kind == PrimalKind.uint64)
            {
                
            }

            if(kind == PrimalKind.float32)
            {
                
            }

            if(kind == PrimalKind.float64)
            {
                
            }

            throw errors.unsupported(kind);

        }
    }


}


