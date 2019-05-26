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

    
    using static zfunc;
    using static AsInX;

    public static partial class ginx
    {
        
        [MethodImpl(Inline)]
        public static Vec128<T> max<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind.IsFloat())
            {
                if(kind == PrimalKind.float32)
                    return generic<T>(dinx.max(in float32(in rhs), in float32(in rhs)));
                else if(kind == PrimalKind.float64)
                    return generic<T>(dinx.max(in float64(in rhs), in float64(in rhs)));
            }
            else if(kind.IsSmallInt())
            {
                if(kind == PrimalKind.int8)
                    return generic<T>(dinx.max(in int8(in rhs), in int8(in rhs)));
                else if(kind == PrimalKind.uint8)
                    return generic<T>(dinx.max(in uint8(in rhs), in uint8(in rhs)));
                else if(kind == PrimalKind.int16)
                    return generic<T>(dinx.max(in int16(in rhs), in int16(in rhs)));
                else if(kind == PrimalKind.uint16)
                    return generic<T>(dinx.max(in uint16(in rhs), in uint16(in rhs)));
            }
            else
            {
                if(kind == PrimalKind.int32)
                    return generic<T>(dinx.max(in int32(in rhs), in int32(in rhs)));
                else if(kind == PrimalKind.uint32)
                    return generic<T>(dinx.max(in uint32(in rhs), in uint32(in rhs)));
            }

            throw unsupported(kind);

        }

         
       [MethodImpl(Inline)]
       public static Vec256<T> max<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind.IsFloat())
            {
                if(kind == PrimalKind.float32)
                    return generic<T>(dinx.max(in float32(in rhs), in float32(in rhs)));
                else if(kind == PrimalKind.float64)
                    return generic<T>(dinx.max(in float64(in rhs), in float64(in rhs)));
            }
            else if(kind.IsSmallInt())
            {
                if(kind == PrimalKind.int8)
                    return generic<T>(dinx.max(in int8(in rhs), in int8(in rhs)));
                else if(kind == PrimalKind.uint8)
                    return generic<T>(dinx.max(in uint8(in rhs), in uint8(in rhs)));
                else if(kind == PrimalKind.int16)
                    return generic<T>(dinx.max(in int16(in rhs), in int16(in rhs)));
                else if(kind == PrimalKind.uint16)
                    return generic<T>(dinx.max(in uint16(in rhs), in uint16(in rhs)));
            }
            else
            {
                if(kind == PrimalKind.int32)
                    return generic<T>(dinx.max(in int32(in rhs), in int32(in rhs)));
                else if(kind == PrimalKind.uint32)
                    return generic<T>(dinx.max(in uint32(in rhs), in uint32(in rhs)));
            }

            throw unsupported(kind);
        }        
    }
}