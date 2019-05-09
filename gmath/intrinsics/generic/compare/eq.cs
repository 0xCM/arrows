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

    
    using static mfunc;
    using static As;

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static bool eq<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return dinx.eq(int8(lhs), int8(rhs));
                case PrimalKind.uint8:
                    return dinx.eq(uint8(lhs), uint8(rhs));
                case PrimalKind.int16:
                    return dinx.eq(int16(lhs), int16(rhs));
                case PrimalKind.uint16:
                    return dinx.eq(uint16(lhs), uint16(rhs));
                case PrimalKind.int32:
                    return dinx.eq(int32(lhs), int32(rhs));
                case PrimalKind.uint32:
                    return dinx.eq(uint32(lhs), uint32(rhs));
                case PrimalKind.int64:
                    return dinx.eq(int64(lhs), int64(rhs));
                case PrimalKind.uint64:
                    return dinx.eq(uint64(lhs), uint64(rhs));
                case PrimalKind.float32:
                    return dinx.eq(float32(lhs), float32(rhs));
                case PrimalKind.float64:
                    return dinx.eq(float64(lhs), float64(rhs));
                default:
                    throw unsupported(kind);
            }            
        }
    }
}