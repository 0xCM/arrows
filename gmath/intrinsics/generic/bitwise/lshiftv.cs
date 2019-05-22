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
        public static Vec128<S> lshiftv<S,T>(in Vec128<S> lhs, in Vec128<T> shifts)
            where S : struct
            where T : struct
        {
            var kind = PrimalKinds.kind<S>();
            switch(kind)
            {
                case PrimalKind.int32:
                    return generic<S>(dinx.lshiftv(int32(lhs), uint32(shifts)));
                case PrimalKind.uint32:
                    return generic<S>(dinx.lshiftv(uint32(lhs), uint32(shifts)));
                case PrimalKind.int64:
                    return generic<S>(dinx.lshiftv(int64(lhs), uint64(shifts)));
                case PrimalKind.uint64:
                    return generic<S>(dinx.lshiftv(uint64(lhs), uint64(shifts)));
                default:
                    throw unsupported(kind);
            }            
        }

        [MethodImpl(Inline)]
        public static Vec256<S> lshiftv<S,T>(in Vec256<S> lhs, in Vec256<T> shifts)
            where S : struct
            where T : struct
        {
            var kind = PrimalKinds.kind<S>();
            switch(kind)
            {
                case PrimalKind.int32:
                    return generic<S>(dinx.lshiftv(int32(lhs), uint32(shifts)));
                case PrimalKind.uint32:
                    return generic<S>(dinx.lshiftv(uint32(lhs), uint32(shifts)));
                case PrimalKind.int64:
                    return generic<S>(dinx.lshiftv(int64(lhs), uint64(shifts)));
                case PrimalKind.uint64:
                    return generic<S>(dinx.lshiftv(uint64(lhs), uint64(shifts)));
                default:
                    throw unsupported(kind);
            }            
        }

        public static Span128<S> lshiftv<S,T>(in ReadOnlySpan128<S> lhs, in ReadOnlySpan128<T> shifts, Span128<S> dst)
            where S : struct
            where T : struct
        {
            var kind = PrimalKinds.kind<S>();        
            switch(kind)
            {
                case PrimalKind.int32:
                {
                    var xDst = int32(dst);
                    dinx.lshiftv(int32(in lhs), uint32(in shifts), ref xDst);
                }
                break;
                case PrimalKind.uint32:
                {
                    var xDst = uint32(dst);
                    dinx.lshiftv(uint32(in lhs), uint32(in shifts), ref xDst);
                }
                break;
                case PrimalKind.int64:
                {
                    var xDst = int64(dst);
                    dinx.lshiftv(int64(lhs), uint64(shifts), ref xDst);
                }
                break;
                case PrimalKind.uint64:
                {
                    var xDst = uint64(dst);
                    dinx.or(uint64(lhs), uint64(shifts), ref xDst);
                }
                break;                
                default:
                    throw unsupported(kind);
            }                
            return dst;
        }


        public static Span256<T> lshiftv<S,T>(in ReadOnlySpan256<T> lhs, in ReadOnlySpan256<S> shifts, Span256<T> dst)
            where T : struct
            where S : struct
        {
            var kind = PrimalKinds.kind<T>();        
            switch(kind)
            {
                case PrimalKind.int32:
                {
                    var xDst = int32(dst);
                    dinx.lshiftv(int32(in lhs), uint32(in shifts), ref xDst);
                }
                break;
                case PrimalKind.uint32:
                {
                    var xDst = uint32(dst);
                    dinx.lshiftv(uint32(in lhs), uint32(in shifts), ref xDst);
                }
                break;
                case PrimalKind.int64:
                {
                    var xDst = int64(dst);
                    dinx.lshiftv(int64(lhs), uint64(shifts), ref xDst);
                }
                break;
                case PrimalKind.uint64:
                {
                    var xDst = uint64(dst);
                    dinx.or(uint64(lhs), uint64(shifts), ref xDst);
                }
                break;                
                default:
                    throw unsupported(kind);
            }                
            return dst;
        }


    }

}