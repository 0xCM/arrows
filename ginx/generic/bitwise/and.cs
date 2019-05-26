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
    using static As;
    using static AsInX;

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
        static void andSmall<T>(PrimalKind kind, in Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
        {
            if (kind == PrimalKind.int8)
                dinx.and(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (kind == PrimalKind.uint8)
                dinx.and(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (kind == PrimalKind.int16)
                dinx.and(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (kind == PrimalKind.uint16)
                dinx.and(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else throw unsupported(kind);

        }

        [MethodImpl(Inline)]
        static void andLarge<T>(PrimalKind kind, in Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
        {
            if(kind == PrimalKind.int32)
                dinx.and(int32(lhs), int32(rhs), ref int32(ref dst));
            else if (kind == PrimalKind.uint32)
                dinx.and(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if (kind == PrimalKind.int64)
                dinx.and(int64(lhs), int64(rhs), ref int64(ref dst));
            else if (kind == PrimalKind.uint64)
                dinx.and(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        static void andFloat<T>(PrimalKind kind, in Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
        {
            if(kind == PrimalKind.float32)
                dinx.and(float32(lhs), float32(rhs), ref float32(ref dst));
            else if (kind == PrimalKind.float64)
                dinx.and(float64(lhs), float64(rhs), ref float64(ref dst));                
            else
                throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static void and<T>(in Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind.IsFloat())
                andFloat(kind, in lhs, in rhs, ref dst);
            else if(kind.IsSmallInt())
                andSmall(kind, in lhs, in rhs, ref dst);
            else
                andLarge(kind, in lhs, in rhs, ref dst);
        }
        
        [MethodImpl(Inline)]
        static void andSmall<T>(PrimalKind kind, in Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
        {
            if (kind == PrimalKind.int8)
                dinx.and(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (kind == PrimalKind.uint8)
                dinx.and(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (kind == PrimalKind.int16)
                dinx.and(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (kind == PrimalKind.uint16)
                dinx.and(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else throw unsupported(kind);

        }

        [MethodImpl(Inline)]
        static void andLarge<T>(PrimalKind kind, in Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
        {
            if(kind == PrimalKind.int32)
                dinx.and(int32(lhs), int32(rhs), ref int32(ref dst));
            else if (kind == PrimalKind.uint32)
                dinx.and(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if (kind == PrimalKind.int64)
                dinx.and(int64(lhs), int64(rhs), ref int64(ref dst));
            else if (kind == PrimalKind.uint64)
                dinx.and(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        static void andFloat<T>(PrimalKind kind, in Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
        {
            if(kind == PrimalKind.float32)
                dinx.and(float32(lhs), float32(rhs), ref float32(ref dst));
            else if (kind == PrimalKind.float64)
                dinx.and(float64(lhs), float64(rhs), ref float64(ref dst));                
            else
                throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static void and<T>(in Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind.IsFloat())
                andFloat(kind, in lhs, in rhs, ref dst);
            else if(kind.IsSmallInt())
                andSmall(kind, in lhs, in rhs, ref dst);
            else
                andLarge(kind, in lhs, in rhs, ref dst);
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