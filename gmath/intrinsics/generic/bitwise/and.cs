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
    using static zfunc;    
    using static As;

    partial class ginx
    {


        [MethodImpl(Inline)]
        public static Vec128<T> and<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
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
                    throw unsupported(kind);
            }            
        }

        [MethodImpl(Inline)]
        public static unsafe void and<T>(in Vec128<T> lhs, in Vec128<T> rhs, void* dst)
            where T : struct
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
                    throw unsupported(kind);
            }
        }

        [MethodImpl(Inline)]
        public static Span128<T> and<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();        
            switch(kind)
            {
                case PrimalKind.int8:
                {
                    var xDst = int8(dst);
                    dinx.and(int8(lhs), int8(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.uint8:
                {
                    var xDst = uint8(dst);
                    dinx.and(uint8(lhs), uint8(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.int16:
                {
                    var xDst = int16(dst);
                    dinx.and(int16(lhs), int16(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.uint16:
                {
                    var xDst = uint16(dst);
                    dinx.and(uint16(lhs), uint16(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.int32:
                {
                    var xDst = int32(dst);
                    dinx.and(int32(lhs), int32(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.uint32:
                {
                    var xDst = uint32(dst);
                    dinx.and(uint32(lhs), uint32(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.int64:
                {
                    var xDst = int64(dst);
                    dinx.and(int64(lhs), int64(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.uint64:
                {
                    var xDst = uint64(dst);
                    dinx.and(uint64(lhs), uint64(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.float32:
                {
                    var xDst = float32(dst);
                    dinx.and(float32(lhs), float32(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.float64:
                {
                    var xDst = float64(dst);
                    dinx.and(float64(lhs), float64(rhs), ref  xDst);
                    return dst;
                }
                
                default:
                    throw unsupported(kind);
            }                
        }


        [MethodImpl(Inline)]
        public static Span256<T> and<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();        
            switch(kind)
            {
                case PrimalKind.int8:
                {
                    var xDst = int8(dst);
                    dinx.and(int8(lhs), int8(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.uint8:
                {
                    var xDst = uint8(dst);
                    dinx.and(uint8(lhs), uint8(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.int16:
                {
                    var xDst = int16(dst);
                    dinx.and(int16(lhs), int16(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.uint16:
                {
                    var xDst = uint16(dst);
                    dinx.and(uint16(lhs), uint16(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.int32:
                {
                    var xDst = int32(dst);
                    dinx.and(int32(lhs), int32(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.uint32:
                {
                    var xDst = uint32(dst);
                    dinx.and(uint32(lhs), uint32(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.int64:
                {
                    var xDst = int64(dst);
                    dinx.and(int64(lhs), int64(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.uint64:
                {
                    var xDst = uint64(dst);
                    dinx.and(uint64(lhs), uint64(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.float32:
                {
                    var xDst = float32(dst);
                    dinx.and(float32(lhs), float32(rhs), ref xDst);
                    return dst;
                }
                case PrimalKind.float64:
                {
                    var xDst = float64(dst);
                    dinx.and(float64(lhs), float64(rhs), ref  xDst);
                    return dst;
                }
                default:
                    throw unsupported(kind);
            }
        }
 

    }

}