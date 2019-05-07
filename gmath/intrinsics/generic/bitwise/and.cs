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
    using static mfunc;
    using static As;

    partial class ginx
    {


        [MethodImpl(Inline)]
        public static Vec128<T> and<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return generic<T>(dinx.and(int8(lhs), int8(rhs)));
                case PrimalKind.uint8:
                    return generic<T>(dinx.and(uint8(lhs), uint8(rhs)));
                case PrimalKind.int16:
                    return generic<T>(dinx.and(int16(lhs), int16(rhs)));
                case PrimalKind.uint16:
                    return generic<T>(dinx.and(uint16(lhs), uint16(rhs)));
                case PrimalKind.int32:
                    return generic<T>(dinx.and(int32(lhs), int32(rhs)));
                case PrimalKind.uint32:
                    return generic<T>(dinx.and(uint32(lhs), uint32(rhs)));
                case PrimalKind.int64:
                    return generic<T>(dinx.and(int64(lhs), int64(rhs)));
                case PrimalKind.uint64:
                    return generic<T>(dinx.and(uint64(lhs), uint64(rhs)));
                case PrimalKind.float32:
                    return generic<T>(dinx.and(float32(lhs), float32(rhs)));
                case PrimalKind.float64:
                    return generic<T>(dinx.and(float64(lhs), float64(rhs)));
                default:
                    throw errors.unsupported(kind);
            }            
        }

        [MethodImpl(Inline)]
        public static unsafe void and<T>(in Vec128<T> lhs, in Vec128<T> rhs, void* dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    dinx.and(int8(lhs), int8(rhs), (sbyte*) dst);
                    break;
                case PrimalKind.uint8:
                    dinx.and(uint8(lhs), uint8(rhs), (byte*) dst);
                    break;
                case PrimalKind.int16:
                    dinx.and(int16(lhs), int16(rhs), (short*) dst);
                    break;
                case PrimalKind.uint16:
                    dinx.and(uint16(lhs), uint16(rhs), (ushort*) dst);
                    break;
                case PrimalKind.int32:
                    dinx.and(int32(lhs), int32(rhs), (int*) dst);
                    break;
                case PrimalKind.uint32:
                    dinx.and(uint32(lhs), uint32(rhs), (uint*) dst);
                    break;
                case PrimalKind.int64:
                    dinx.and(int64(lhs), int64(rhs), (long*) dst);
                    break;
                case PrimalKind.uint64:
                    dinx.and(uint64(lhs), uint64(rhs), (ulong*) dst);
                    break;
                case PrimalKind.float32:
                    dinx.and(float32(lhs), float32(rhs), (float*) dst);
                    break;
                case PrimalKind.float64:
                    dinx.and(float64(lhs), float64(rhs), (double*) dst);                
                break;                
                default:
                    throw errors.unsupported(kind);
            }
        }


    }

}