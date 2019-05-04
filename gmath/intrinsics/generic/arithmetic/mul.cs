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
    using static inxfunc;

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static Vec128<T> mul<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.float32:
                    return generic<T>(dinx.mul(float32(lhs), float32(rhs)));                    
                case PrimalKind.float64:
                    return generic<T>(dinx.mul(float64(lhs), float64(rhs)));
                default:
                    throw errors.unsupported(kind);
            }            
        }

        [MethodImpl(Inline)]
        public static Vec128<S> mul<S,T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where S : struct, IEquatable<S>
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int32:
                    return generic<S>(dinx.mul(int32(lhs), int32(rhs)));
                case PrimalKind.uint32:
                    return generic<S>(dinx.mul(uint32(lhs), uint32(rhs)));
                case PrimalKind.float32:
                    return generic<S>(dinx.mul(float32(lhs), float32(rhs)));
                    
                case PrimalKind.float64:
                    return generic<S>(dinx.mul(float64(lhs), float64(rhs)));
                default:
                    throw errors.unsupported(kind);
            }            
        }

        [MethodImpl(Inline)]
        public static ref Vec128<S> mul<S,T>(in Vec128<T> lhs, in Vec128<T> rhs, ref Vec128<S> dst)
            where S : struct, IEquatable<S>
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int32:
                    dst = generic<S>(dinx.mul(int32(lhs), int32(rhs)));
                    return ref dst;
                case PrimalKind.uint32:
                    dst = generic<S>(dinx.mul(uint32(lhs), uint32(rhs)));
                    return ref dst;
                case PrimalKind.float32:
                    dst = generic<S>(dinx.mul(float32(lhs), float32(rhs)));
                    return ref dst;                    
                case PrimalKind.float64:
                    dst = generic<S>(dinx.mul(float64(lhs), float64(rhs)));
                    return ref dst;
                default:
                    throw errors.unsupported(kind);
            }            
        }

        [MethodImpl(Inline)]
        public static unsafe Span<T> mul<S,T>(in Vec128<S> lhs, in Vec128<S> rhs, Span<T> dst)
            where S : struct, IEquatable<S>
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int32:
                     fixed(long* pDst = &first(As.int64(dst)))
                        dinx.mul(int32(lhs), int32(rhs), pDst);
                    break;
                case PrimalKind.uint32:
                    fixed(ulong* pDst = &first(As.uint64(dst)))
                        dinx.mul(uint32(lhs), uint32(rhs), pDst);
                    break;
                case PrimalKind.float32:
                    fixed(float* pDst = &first(As.float32(dst)))
                        dinx.mul(float32(lhs), float32(rhs), pDst);
                    break;
                case PrimalKind.float64:
                    fixed(double* pDst = &first(As.float64(dst)))
                        dinx.mul(float64(lhs), float64(rhs), pDst);
                break;                
                default:
                    throw errors.unsupported(kind);                    
            }
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void mul<T>(in Vec128<T> lhs, in Vec128<T> rhs, void* dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int32:
                    dinx.mul(int32(lhs), int32(rhs), dst);
                    break;
                case PrimalKind.uint32:
                    dinx.mul(uint32(lhs), uint32(rhs), dst);
                    break;
                case PrimalKind.float32:
                    dinx.mul(float32(lhs), float32(rhs), dst);
                    break;
                case PrimalKind.float64:
                    dinx.mul(float64(lhs), float64(rhs), dst);                
                break;                
                default:
                    throw errors.unsupported(kind);
            }
        }
            


        [MethodImpl(Inline)]
        public static Vec256<T> mul<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int32:
                    return generic<T>(dinx.mul(int32(lhs), int32(rhs)));
                case PrimalKind.uint32:
                    return generic<T>(dinx.mul(uint32(lhs), uint32(rhs)));
                case PrimalKind.float32:
                    return generic<T>(dinx.mul(float32(lhs), float32(rhs)));
                case PrimalKind.float64:
                    return generic<T>(dinx.mul(float64(lhs), float64(rhs)));
                default:
                    throw errors.unsupported(kind);
            }            
        }

        [MethodImpl(Inline)]
        public static Span<T> mul<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();        
            switch(kind)
            {
                case PrimalKind.int32:
                {
                    var xDst = int64(dst);
                    dinx.mul(int32(lhs), int32(rhs), xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.uint32:
                {
                    var xDst = uint64(dst);
                    dinx.mul(uint32(lhs), uint32(rhs), xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.float32:
                {
                    var xDst = float32(dst);
                    dinx.mul(float32(lhs), float32(rhs), xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.float64:
                {
                    var xDst = float64(dst);
                    dinx.mul(float64(rhs), float64(rhs), xDst);
                    return generic<T>(xDst);
                }
                
                default:
                    throw errors.unsupported(kind);
            }                
        }
    }
}