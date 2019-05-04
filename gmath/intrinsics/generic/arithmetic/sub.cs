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
    using static As;

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static Vec128<T> sub<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return generic<T>(dinx.sub(int8(lhs), int8(rhs)));
                case PrimalKind.uint8:
                    return generic<T>(dinx.sub(uint8(lhs), uint8(rhs)));
                case PrimalKind.int16:
                    return generic<T>(dinx.sub(int16(lhs), int16(rhs)));
                case PrimalKind.uint16:
                    return generic<T>(dinx.sub(uint16(lhs), uint16(rhs)));
                case PrimalKind.int32:
                    return generic<T>(dinx.sub(int32(lhs), int32(rhs)));
                case PrimalKind.uint32:
                    return generic<T>(dinx.sub(uint32(lhs), uint32(rhs)));
                case PrimalKind.int64:
                    return generic<T>(dinx.sub(int64(lhs), int64(rhs)));
                case PrimalKind.uint64:
                    return generic<T>(dinx.sub(uint64(lhs), uint64(rhs)));
                case PrimalKind.float32:
                    return generic<T>(dinx.sub(float32(lhs), float32(rhs)));
                case PrimalKind.float64:
                    return generic<T>(dinx.sub(float64(lhs), float64(rhs)));
                default:
                    throw errors.unsupported(kind);
            }            
        }



        [MethodImpl(Inline)]
        public static unsafe void sub<T>(in Vec128<T> lhs, in Vec128<T> rhs, void* dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    dinx.sub(int8(lhs), int8(rhs), dst);
                    break;
                case PrimalKind.uint8:
                    dinx.sub(uint8(lhs), uint8(rhs), dst);
                    break;
                case PrimalKind.int16:
                    dinx.sub(int16(lhs), int16(rhs), dst);
                    break;
                case PrimalKind.uint16:
                    dinx.sub(uint16(lhs), uint16(rhs), dst);
                    break;
                case PrimalKind.int32:
                    dinx.sub(int32(lhs), int32(rhs), dst);
                    break;
                case PrimalKind.uint32:
                    dinx.sub(uint32(lhs), uint32(rhs), dst);
                    break;
                case PrimalKind.int64:
                    dinx.sub(int64(lhs), int64(rhs), dst);
                    break;
                case PrimalKind.uint64:
                    dinx.sub(uint64(lhs), uint64(rhs), dst);
                    break;
                case PrimalKind.float32:
                    dinx.sub(float32(lhs), float32(rhs), dst);
                    break;
                case PrimalKind.float64:
                    dinx.sub(float64(lhs), float64(rhs), dst);                
                break;                
                default:
                    throw errors.unsupported(kind);
            }
        }
            


        [MethodImpl(Inline)]
        public static Vec256<T> sub<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return generic<T>(dinx.sub(int8(lhs), int8(rhs)));
                case PrimalKind.uint8:
                    return generic<T>(dinx.sub(uint8(lhs), uint8(rhs)));
                case PrimalKind.int16:
                    return generic<T>(dinx.sub(int16(lhs), int16(rhs)));
                case PrimalKind.uint16:
                    return generic<T>(dinx.sub(uint16(lhs), uint16(rhs)));
                case PrimalKind.int32:
                    return generic<T>(dinx.sub(int32(lhs), int32(rhs)));
                case PrimalKind.uint32:
                    return generic<T>(dinx.sub(uint32(lhs), uint32(rhs)));
                case PrimalKind.int64:
                    return generic<T>(dinx.sub(int64(lhs), int64(rhs)));
                case PrimalKind.uint64:
                    return generic<T>(dinx.sub(uint64(lhs), uint64(rhs)));
                case PrimalKind.float32:
                    return generic<T>(dinx.sub(float32(lhs), float32(rhs)));
                case PrimalKind.float64:
                    return generic<T>(dinx.sub(float64(lhs), float64(rhs)));
                default:
                    throw errors.unsupported(kind);
            }            
        }

        [MethodImpl(Inline)]
        public static ref T[] sub<T>(T[] lhs, T[] rhs, ref T[] dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();        
            switch(kind)
            {
                case PrimalKind.int8:
                {
                    ref var xDst = ref int8(ref dst);
                    dinx.sub(int8(ref lhs), int8(ref rhs), ref xDst);
                    return ref generic<T>(ref xDst);
                }
                case PrimalKind.uint8:
                {
                    ref var xDst = ref uint8(ref dst);
                    dinx.sub(uint8(ref lhs), uint8(ref rhs), ref xDst);
                    return ref generic<T>(ref xDst);
                }
                case PrimalKind.int16:
                {
                    ref var xDst = ref int16(ref dst);
                    dinx.sub(int16(ref lhs), int16(ref rhs), ref xDst);
                    return ref generic<T>(ref xDst);
                }
                case PrimalKind.uint16:
                {
                    ref var xDst = ref uint16(ref dst);
                    dinx.sub(uint16(ref lhs), uint16(ref rhs), ref xDst);
                    return ref generic<T>(ref xDst);
                }
                case PrimalKind.int32:
                {
                    ref var xDst = ref int32(ref dst);
                    dinx.sub(int32(ref lhs), int32(ref rhs), ref xDst);
                    return ref generic<T>(ref xDst);
                }
                case PrimalKind.uint32:
                {
                    ref var xDst = ref uint32(ref dst);
                    dinx.sub(uint32(ref lhs), uint32(ref rhs), ref xDst);
                    return ref generic<T>(ref xDst);
                }
                case PrimalKind.int64:
                {
                    ref var xDst = ref int64(ref dst);
                    dinx.sub(int64(ref lhs), int64(ref rhs), ref xDst);
                    return ref generic<T>(ref xDst);
                }
                case PrimalKind.uint64:
                {
                    ref var xDst = ref uint64(ref dst);
                    dinx.sub(uint64(ref lhs), uint64(ref rhs), ref xDst);
                    return ref generic<T>(ref xDst);
                }
                case PrimalKind.float32:
                {
                    ref var xDst = ref float32(ref dst);
                    dinx.sub(float32(ref lhs), float32(ref rhs), ref xDst);
                    return ref generic<T>(ref xDst);
                }
                case PrimalKind.float64:
                {
                    ref var xDst = ref float64(ref dst);
                    dinx.sub(float64(ref lhs), float64(ref rhs), ref xDst);
                    return ref generic<T>(ref xDst);
                }
                
                default:
                    throw errors.unsupported(kind);
            }                
        }
    }
}