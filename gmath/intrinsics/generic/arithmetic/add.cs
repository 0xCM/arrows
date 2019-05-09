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
        public static Vec128<T> add<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return generic<T>(dinx.add(int8(lhs), int8(rhs)));
                case PrimalKind.uint8:
                    return generic<T>(dinx.add(uint8(lhs), uint8(rhs)));
                case PrimalKind.int16:
                    return generic<T>(dinx.add(int16(lhs), int16(rhs)));
                case PrimalKind.uint16:
                    return generic<T>(dinx.add(uint16(lhs), uint16(rhs)));
                case PrimalKind.int32:
                    return generic<T>(dinx.add(int32(lhs), int32(rhs)));
                case PrimalKind.uint32:
                    return generic<T>(dinx.add(uint32(lhs), uint32(rhs)));
                case PrimalKind.int64:
                    return generic<T>(dinx.add(int64(lhs), int64(rhs)));
                case PrimalKind.uint64:
                    return generic<T>(dinx.add(uint64(lhs), uint64(rhs)));
                case PrimalKind.float32:
                    return generic<T>(dinx.add(float32(lhs), float32(rhs)));
                case PrimalKind.float64:
                    return generic<T>(dinx.add(float64(lhs), float64(rhs)));
                default:
                    throw unsupported(kind);
            }            
        }

        [MethodImpl(Inline)]
        public static unsafe Span128<T> add<T>(in Vec128<T> lhs, in Vec128<T> rhs, Span128<T> dst, int blockIndex)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            var dstBlock = dst.Block(blockIndex);
            switch(kind)
            {
                case PrimalKind.int8:
                     fixed(sbyte* pDst = &first(As.int8(dstBlock)))
                        dinx.add(int8(lhs), int8(rhs), pDst);
                    break;
                case PrimalKind.uint8:
                     fixed(byte* pDst = &first(As.uint8(dstBlock)))
                        dinx.add(uint8(lhs), uint8(rhs), pDst);
                    break;
                case PrimalKind.int16:
                     fixed(short* pDst = &first(As.int16(dstBlock)))
                        dinx.add(int16(lhs), int16(rhs), pDst);
                    break;
                case PrimalKind.uint16:
                     fixed(ushort* pDst = &first(As.uint16(dstBlock)))
                        dinx.add(uint16(lhs), uint16(rhs), pDst);
                    break;
                case PrimalKind.int32:
                     fixed(int* pDst = &first(As.int32(dstBlock)))
                        dinx.add(int32(lhs), int32(rhs), pDst);
                    break;
                case PrimalKind.uint32:
                    fixed(uint* pDst = &first(As.uint32(dstBlock)))
                        dinx.add(uint32(lhs), uint32(rhs), pDst);
                    break;
                case PrimalKind.int64:
                    fixed(long* pDst = &first(As.int64(dstBlock)))
                        dinx.add(int64(lhs), int64(rhs), pDst);
                    break;
                case PrimalKind.float32:
                    fixed(float* pDst = &first(As.float32(dstBlock)))
                        dinx.add(float32(lhs), float32(rhs), pDst);
                    break;
                case PrimalKind.float64:
                    fixed(double* pDst = &first(As.float64(dstBlock)))
                        dinx.add(float64(lhs), float64(rhs), pDst);
                break;                
                default:
                    throw unsupported(kind);                    
            }
            return dst;
        }



        [MethodImpl(Inline)]
        public static unsafe void add<T>(in Vec128<T> lhs, in Vec128<T> rhs, void* dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    dinx.add(int8(lhs), int8(rhs), int8(dst));
                    break;
                case PrimalKind.uint8:
                    dinx.add(uint8(lhs), uint8(rhs), uint8(dst));
                    break;
                case PrimalKind.int16:
                    dinx.add(int16(lhs), int16(rhs), int16(dst));
                    break;
                case PrimalKind.uint16:
                    dinx.add(uint16(lhs), uint16(rhs), uint16(dst));
                    break;
                case PrimalKind.int32:
                    dinx.add(int32(lhs), int32(rhs), int32(dst));
                    break;
                case PrimalKind.uint32:
                    dinx.add(uint32(lhs), uint32(rhs), uint32(dst));
                    break;
                case PrimalKind.int64:
                    dinx.add(int64(lhs), int64(rhs), int64(dst));
                    break;
                case PrimalKind.uint64:
                    dinx.add(uint64(lhs), uint64(rhs), uint64(dst));
                    break;
                case PrimalKind.float32:
                    dinx.add(float32(lhs), float32(rhs), float32(dst));
                    break;
                case PrimalKind.float64:
                    dinx.add(float64(lhs), float64(rhs), float64(dst));                
                break;                
                default:
                    throw unsupported(kind);
            }
        }
            


        [MethodImpl(Inline)]
        public static Vec256<T> add<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return generic<T>(dinx.add(int8(lhs), int8(rhs)));
                case PrimalKind.uint8:
                    return generic<T>(dinx.add(uint8(lhs), uint8(rhs)));
                case PrimalKind.int16:
                    return generic<T>(dinx.add(int16(lhs), int16(rhs)));
                case PrimalKind.uint16:
                    return generic<T>(dinx.add(uint16(lhs), uint16(rhs)));
                case PrimalKind.int32:
                    return generic<T>(dinx.add(int32(lhs), int32(rhs)));
                case PrimalKind.uint32:
                    return generic<T>(dinx.add(uint32(lhs), uint32(rhs)));
                case PrimalKind.int64:
                    return generic<T>(dinx.add(int64(lhs), int64(rhs)));
                case PrimalKind.uint64:
                    return generic<T>(dinx.add(uint64(lhs), uint64(rhs)));
                case PrimalKind.float32:
                    return generic<T>(dinx.add(float32(lhs), float32(rhs)));
                case PrimalKind.float64:
                    return generic<T>(dinx.add(float64(lhs), float64(rhs)));
                default:
                    throw unsupported(kind);
            }            
        }

        [MethodImpl(Inline)]
        public static unsafe Span256<T> add<T>(in Vec256<T> lhs, in Vec256<T> rhs, Span256<T> dst, int blockIndex)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            var dstBlock = dst.Block(blockIndex);
            switch(kind)
            {
                case PrimalKind.int8:
                     fixed(sbyte* pDst = &first(As.int8(dstBlock)))
                        dinx.add(int8(lhs), int8(rhs), pDst);
                    break;
                case PrimalKind.uint8:
                     fixed(byte* pDst = &first(As.uint8(dstBlock)))
                        dinx.add(uint8(lhs), uint8(rhs), pDst);
                    break;
                case PrimalKind.int16:
                     fixed(short* pDst = &first(As.int16(dstBlock)))
                        dinx.add(int16(lhs), int16(rhs), pDst);
                    break;
                case PrimalKind.uint16:
                     fixed(ushort* pDst = &first(As.uint16(dstBlock)))
                        dinx.add(uint16(lhs), uint16(rhs), pDst);
                    break;
                case PrimalKind.int32:
                     fixed(int* pDst = &first(As.int32(dstBlock)))
                        dinx.add(int32(lhs), int32(rhs), pDst);
                    break;
                case PrimalKind.uint32:
                    fixed(uint* pDst = &first(As.uint32(dstBlock)))
                        dinx.add(uint32(lhs), uint32(rhs), pDst);
                    break;
                case PrimalKind.int64:
                    fixed(long* pDst = &first(As.int64(dstBlock)))
                        dinx.add(int64(lhs), int64(rhs), pDst);
                    break;
                case PrimalKind.float32:
                    fixed(float* pDst = &first(As.float32(dstBlock)))
                        dinx.add(float32(lhs), float32(rhs), pDst);
                    break;
                case PrimalKind.float64:
                    fixed(double* pDst = &first(As.float64(dstBlock)))
                        dinx.add(float64(lhs), float64(rhs), pDst);
                break;                
                default:
                    throw unsupported(kind);                    
            }
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span128<T> add<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();        
            switch(kind)
            {
                case PrimalKind.int8:
                {
                    var xDst = int8(dst);
                    dinx.add(int8(lhs), int8(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.uint8:
                {
                    var xDst = uint8(dst);
                    dinx.add(uint8(lhs), uint8(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.int16:
                {
                    var xDst = int16(dst);
                    dinx.add(int16(lhs), int16(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.uint16:
                {
                    var xDst = uint16(dst);
                    dinx.add(uint16(lhs), uint16(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.int32:
                {
                    var xDst = int32(dst);
                    dinx.add(int32(lhs), int32(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.uint32:
                {
                    var xDst = uint32(dst);
                    dinx.add(uint32(lhs), uint32(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.int64:
                {
                    var xDst = int64(dst);
                    dinx.add(int64(lhs), int64(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.uint64:
                {
                    var xDst = uint64(dst);
                    dinx.add(uint64(lhs), uint64(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.float32:
                {
                    var xDst = float32(dst);
                    dinx.add(float32(lhs), float32(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.float64:
                {
                    var xDst = float64(dst);
                    dinx.add(float64(lhs), float64(rhs), ref  xDst);
                    return generic<T>(xDst);
                }
                
                default:
                    throw unsupported(kind);
            }                
        }

        [MethodImpl(Inline)]
        public static Span256<T> add<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();        
            switch(kind)
            {
                case PrimalKind.int8:
                {
                    var xDst = int8(dst);
                    dinx.add(int8(lhs), int8(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.uint8:
                {
                    var xDst = uint8(dst);
                    dinx.add(uint8(lhs), uint8(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.int16:
                {
                    var xDst = int16(dst);
                    dinx.add(int16(lhs), int16(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.uint16:
                {
                    var xDst = uint16(dst);
                    dinx.add(uint16(lhs), uint16(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.int32:
                {
                    var xDst = int32(dst);
                    dinx.add(int32(lhs), int32(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.uint32:
                {
                    var xDst = uint32(dst);
                    dinx.add(uint32(lhs), uint32(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.int64:
                {
                    var xDst = int64(dst);
                    dinx.add(int64(lhs), int64(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.uint64:
                {
                    var xDst = uint64(dst);
                    dinx.add(uint64(lhs), uint64(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.float32:
                {
                    var xDst = float32(dst);
                    dinx.add(float32(lhs), float32(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.float64:
                {
                    var xDst = float64(dst);
                    dinx.add(float64(lhs), float64(rhs), ref  xDst);
                    return generic<T>(xDst);
                }
                
                default:
                    throw unsupported(kind);
            }                
        }


   }
}