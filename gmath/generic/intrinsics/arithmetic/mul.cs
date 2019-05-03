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
        public static Num128<T> mul<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return generic<T>(Avx2.AddScalar(float32(lhs), float32(rhs)));

            if(kind == PrimalKind.float64)
                return generic<T>(Avx2.AddScalar(float64(lhs), float64(rhs)));

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Vec128<T> mul<T>(in Vec128<T> lhs, in Vec128<T> rhs)
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
        public static ref T[] mul<T>(T[] lhs, T[] rhs, ref T[] dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();        
            switch(kind)
            {
                case PrimalKind.int32:
                {
                    ref var xDst = ref int64(ref dst);
                    dinx.mul(int32(ref lhs), int32(ref rhs), ref xDst);
                    return ref generic<T>(ref xDst);
                }
                case PrimalKind.uint32:
                {
                    ref var xDst = ref uint64(ref dst);
                    dinx.mul(uint32(ref lhs), uint32(ref rhs), ref xDst);
                    return ref generic<T>(ref xDst);
                }
                case PrimalKind.float32:
                {
                    ref var xDst = ref float32(ref dst);
                    dinx.mul(float32(ref lhs), float32(ref rhs), ref xDst);
                    return ref generic<T>(ref xDst);
                }
                case PrimalKind.float64:
                {
                    ref var xDst = ref float64(ref dst);
                    dinx.mul(float64(ref lhs), float64(ref rhs), ref xDst);
                    return ref generic<T>(ref xDst);
                }
                
                default:
                    throw errors.unsupported(kind);
            }                
        }
    }
}