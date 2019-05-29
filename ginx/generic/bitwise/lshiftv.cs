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
        public static Vec128<S> lshift<S,T>(in Vec128<S> lhs, in Vec128<T> shifts)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                return generic<S>(dinx.lshift(in int32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(uint)) 
                return generic<S>(dinx.lshift(in uint32(in lhs), uint32(in shifts)));
            else if(typeof(S) == typeof(long))
                return generic<S>(dinx.lshift(in int64(lhs), uint64(in shifts)));
            else if(typeof(S) == typeof(ulong))
                return generic<S>(dinx.lshift(in uint64(lhs), in uint64(in shifts)));
            else
                throw unsupported(PrimalKinds.kind<S>());

        }

        [MethodImpl(Inline)]
        public static Vec256<S> lshift<S,T>(in Vec256<S> lhs, in Vec256<T> shifts)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                return generic<S>(dinx.lshift(in int32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(uint)) 
                return generic<S>(dinx.lshift(in uint32(in lhs), uint32(in shifts)));
            else if(typeof(S) == typeof(long))
                return generic<S>(dinx.lshift(in int64(lhs), uint64(in shifts)));
            else if(typeof(S) == typeof(ulong))
                return generic<S>(dinx.lshift(in uint64(lhs), in uint64(in shifts)));
            else
                throw unsupported(PrimalKinds.kind<S>());
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
                    dinx.lshift(int32(in lhs), uint32(in shifts), ref xDst);
                }
                break;
                case PrimalKind.uint32:
                {
                    var xDst = uint32(dst);
                    dinx.lshift(uint32(in lhs), uint32(in shifts), ref xDst);
                }
                break;
                case PrimalKind.int64:
                {
                    var xDst = int64(dst);
                    dinx.lshift(int64(lhs), uint64(shifts), ref xDst);
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
                    dinx.lshift(int32(in lhs), uint32(in shifts), ref xDst);
                }
                break;
                case PrimalKind.uint32:
                {
                    var xDst = uint32(dst);
                    dinx.lshift(uint32(in lhs), uint32(in shifts), ref xDst);
                }
                break;
                case PrimalKind.int64:
                {
                    var xDst = int64(dst);
                    dinx.lshift(int64(lhs), uint64(shifts), ref xDst);
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